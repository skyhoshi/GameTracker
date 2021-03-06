﻿using DevChatter.GameTracker.Core.Model;
using System;
using System.Linq.Expressions;

namespace DevChatter.GameTracker.Core.Data.Specifications
{
    /// <summary>
    /// Used for filtering BaseEntity objects based on specified criteria
    /// </summary>
    public class BaseEntityPolicy<T> : ISpecification<T> where T : BaseEntity
    {
        protected BaseEntityPolicy(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public static BaseEntityPolicy<T> All()
        {
            return new BaseEntityPolicy<T>(x => true);
        }

        public static BaseEntityPolicy<T> ById(int id)
        {
            return new BaseEntityPolicy<T>(x => x.Id == id);
        }

        public Expression<Func<T, bool>> Criteria { get; }
    }
}