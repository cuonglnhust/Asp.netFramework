﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedushop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TedushopDbContext dbContext;

        public TedushopDbContext Init()
        {
            return dbContext ?? (dbContext = new TedushopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
