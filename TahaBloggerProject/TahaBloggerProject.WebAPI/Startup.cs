using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Business.Concrete;
using TahaBloggerProject.Business.Helper.MailOperation;
using TahaBloggerProject.Business.Helper.MailOperation.Gmail;
using TahaBloggerProject.Core.Utilities.Security.Jwt;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.DataAccess.Conctrete.EntityFramework;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            //Swagger.

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "CoreSwaggerWebAPI-Swagger",
                new OpenApiInfo
                {
                    Version = Configuration.GetSection("Swagger:SwaggerDoc:Version").Value,
                    Title = Configuration.GetSection("Swagger:SwaggerDoc:Title").Value,
                    Description = Configuration.GetSection("Swagger:SwaggerDoc:Description").Value,
                    TermsOfService = new Uri(Configuration.GetSection("Swagger:SwaggerDoc:TermsOfService").Value),
                    Contact = new OpenApiContact
                    {
                        Name = Configuration.GetSection("Swagger:SwaggerDoc:Contact:Name").Value,
                        Email = string.Empty,
                        Url = new Uri(Configuration.GetSection("Swagger:SwaggerDoc:Contact:Url").Value),
                    },
                    License = new OpenApiLicense
                    {
                        Name = Configuration.GetSection("Swagger:SwaggerDoc:License:Name").Value,
                        Url = new Uri(Configuration.GetSection("Swagger:SwaggerDoc:License:Url").Value),
                    }
                });
                //Commentleri Swagger için etkinleştirmek.
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //System.IO.FileNotFoundException: 'Could not find filec.IncludeXmlComments(xmlPath);
            });

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));

            services.AddTransient<ICategoryService, CategoryManager>();
            services.AddTransient<ICategoryDal, CategoryDal>();

            services.AddTransient<ICommentService, CommentManager>();
            services.AddTransient<ICommentDal, CommentDal>();

            services.AddTransient<ILikeService, LikeManager>();
            services.AddTransient<ILikeDal, LikeDal>();

            services.AddTransient<IPostService, PostManager>();
            services.AddTransient<IPostDal, PostDal>();

            services.AddTransient<IPostImageService, PostImageManager>();
            services.AddTransient<IPostImageDal, PostImageDal>();
        
            services.AddTransient<IAuthService, AuthManager>();
            services.AddTransient<ITokenHelper, JwtHelper>();

            services.AddTransient<IUserDal, UserDal>();
            services.AddTransient<IUserService, UserManager>();
           ;
            services.AddTransient<IAuthService, AuthManager>();
            services.AddTransient<ITokenHelper, JwtHelper>();



            services.AddTransient<IMailOperation, GMailOperation>();

            services.AddDbContext<TahaBlogDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:TahaBlogDb"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //Burayı appsettings jsondan okumadım. ancak şu şekilde okunabilir
                // c.SwaggerEndpoint(
                //String.Format(Configuration.GetSection("Swagger:UseSwaggerUI:SwaggerEndpoint").Value, Configuration.GetSection("Swagger:SwaggerName").Value),
                //Configuration.GetSection("Swagger:UseSwaggerUI:Name").Value);
                // c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint(url: "/swagger/CoreSwaggerWebAPI-Swagger/swagger.json", name: "My API Swagger V1");
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}