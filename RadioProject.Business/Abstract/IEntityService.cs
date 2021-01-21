﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RadioProject.Business.Abstract
{
    public interface IEntityService <T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter);
    }
}
