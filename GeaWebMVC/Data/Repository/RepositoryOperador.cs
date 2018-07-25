﻿using Data;
using Data.Repository;
using GeaWebMVC.Models;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
  public class RepositoryOperador : RepositoryBase<Operador>, IRepositoryOperador
    {
        public RepositoryOperador(GeaContext context)
            : base(context)
        {

        }
    }
}
