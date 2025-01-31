﻿using System.Collections.Generic;
using System;
using System.Linq;

namespace VotingApp.Shared.RepositoryInterfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetSingle(int id);
        void AddSingle(T param);

        T UpdateSingle( T param);

        void SaveChanges();

        //IEnumerable<T> GetOverview(Func<T, bool> predicate = null);
        //T GetDetail(Func<T, bool> predicate);
        //void Add(T entity);
    }
}
