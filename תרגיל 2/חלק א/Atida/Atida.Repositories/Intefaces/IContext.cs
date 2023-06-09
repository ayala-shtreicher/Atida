﻿using Atida.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Repositories.Intefaces
{
    public interface IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<SicknessDetails> SicknessDetails { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
