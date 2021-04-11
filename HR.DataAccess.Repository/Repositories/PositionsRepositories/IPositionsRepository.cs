﻿using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DataAccess.Repository.Repositories.PositionsRepositories
{
    public interface IPositionsRepository
    {
        Positions Get(int id);
        IEnumerable<Positions> GetAll();
        void Add(Positions position);
        void Delete(int positionId);
        void Update(int positionId, Positions position);
    }
}
