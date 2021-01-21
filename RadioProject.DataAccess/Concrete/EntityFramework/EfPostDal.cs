using RadioProject.DataAccess.Abstract;
using RadioProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioProject.DataAccess.Concrete.EntityFramework
{
    public class EfPostDal : EfBaseRepository<Post, RadioContext>,IPostDal
    {
    }
}
