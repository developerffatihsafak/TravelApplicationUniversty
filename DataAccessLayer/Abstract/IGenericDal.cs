﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
        List<T> GetListBYFilter(Expression<Func<T, bool>> filter);
    }
}
