using System.Collections.Generic;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
    public interface IPostImageService
    {
        PostImage Insert(PostImage postImage);

        void Remove(int postImageId);

        PostImage GetPostImage(int postImageId);

        List<PostImage> GetPostImages(int postId);
    }
}