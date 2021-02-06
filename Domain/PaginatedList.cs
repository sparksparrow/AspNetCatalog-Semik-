﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Models
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> productItems, int pageIndex, int count, int pageSize)
        {
            PageIndex = pageIndex;            
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(productItems);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 0);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages-1);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {            
            var count = await source.CountAsync();
            pageIndex = pageIndex > (int)Math.Ceiling(count / (double)pageSize) - 1 || pageIndex < 0 ? 0 : pageIndex;
            var items = await source.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, pageIndex, count, pageSize);
        }

    }
}
