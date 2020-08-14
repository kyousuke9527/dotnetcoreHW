﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dotnetcoreHW.Models
{
    public partial class ContosouniversityContext
    {
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            this.ChangeTracker.Entries()
                .Where(e => e.State == Microsoft.EntityFrameworkCore.EntityState.Deleted && e.Entity is IDelete)
                .ToList()
                .ForEach(entry =>
                {
                    entry.State = EntityState.Modified;
                    ((IDelete)entry.Entity).IsDeleted = true;
                });

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
