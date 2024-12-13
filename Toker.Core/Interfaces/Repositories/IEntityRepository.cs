﻿using Commons.Repository.Interfaces;
using Commons.RequestFilter;
using Commons.Response;
using Toker.Core.DTOs.Response;
using Toker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toker.Core.Interfaces.Repositories
{
    public interface IEntityRepository : IGenericRepository<Entity>
    {
        Task<Entity> GetByName(string email);
        Task<RecordsResponse<EntityResponseDTO>> Get(QueryFilter filter);
    }
}
