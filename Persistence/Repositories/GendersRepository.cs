﻿using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class GenderRepository : Repository<GenderMaster>, IGendersRepository
    {
        public GenderRepository(fantasyfaceContext context) : base(context)
        {
        }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
    
}