using System;
using System.Collections.Generic;
using System.Linq;

namespace Dotnet_Framework_Linq_Extensions
{
    public static class WhereExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> iqQueryable,bool condition,Func<T,bool> predicate)
        {
            if(!condition)
                return iqQueryable;

            return iqQueryable.Where(predicate).AsQueryable();
        }
        
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> iEnumerable,bool condition,Func<T,bool> predicate)
        {
            if(!condition)
                return iEnumerable;

            return iEnumerable.Where(predicate);
        }
        
       
        
    }
}