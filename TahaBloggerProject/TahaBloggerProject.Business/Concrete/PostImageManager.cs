using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Concrete
{
    public class PostImageManager : IPostImageService
    {
        IPostImageDal _postImageDal;
        public PostImageManager(IPostImageDal postImageDal)
        {
            _postImageDal = postImageDal;
        }
        public PostImage GetPostImage(int postImageId)
        {
            var data = _postImageDal.Get(x => x.PostImageId == postImageId);
            return data;
        }

        public List<PostImage> GetPostImages(int postId)
        {
            //Standartlaştır. Geri dönüş tipi olan her metotta değişkene ata. Mapping için lazım olabilir.
            var data = _postImageDal.GetList(x => x.PostId == postId);
            return data;
        }

        public PostImage Insert(PostImage postImage)
        {
            var data = _postImageDal.Add(postImage);
            return data;
        }

        public void Remove(int postImageId)
        {
            var removedEntity = GetPostImage(postImageId);

            _postImageDal.Delete(removedEntity);
        }
    }
}
