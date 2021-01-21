using RadioProject.Business.Abstract;
using RadioProject.DataAccess.Abstract;
using RadioProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RadioProject.Business.Concrete
{
    public class PostManager : IPostService
    {
        IPostDal postDal;

        public PostManager(IPostDal postDal)
        {
            this.postDal = postDal;
        }

        public void Add(Post entity)
        {
            postDal.Add(entity);
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public Post Get(Expression<Func<Post, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            return postDal.GetAll(filter);
        }

        public void Update(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
