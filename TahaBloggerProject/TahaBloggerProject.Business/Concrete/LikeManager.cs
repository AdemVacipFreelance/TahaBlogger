using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Concrete
{
    public class LikeManager : ILikeService
    {
        private readonly ILikeDal _likeDal;
        public LikeManager(ILikeDal likeDal)
        {
            _likeDal = likeDal;
        }
        public void Delete(int likeId)
        {
            var entity = GetLikeById(likeId);

            _likeDal.Delete(entity);
        }

        public Like GetLikeById(int likeId)
        {
            return _likeDal.Get(x => x.LikeId == likeId);
        }

        public int GetLikeCountByPostId(int postId)
        {
            return _likeDal.GetList(x => x.PostId == postId).Count;
        }

        public Like Insert(Like like)
        {
            return _likeDal.Add(like);
        }
    }
}