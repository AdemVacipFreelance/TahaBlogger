using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
    public interface ILikeService
    {
        int GetLikeCountByPostId(int postId);

        Like Insert(Like like);

        void Delete(int likeId);

        //ilk geri dönüş tipimiz, Daha sonra metot adı ve parametleri .
        Like GetLikeById(int likeId);

        
        

    }
}
