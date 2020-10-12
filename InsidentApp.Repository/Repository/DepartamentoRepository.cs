using AppNominas.Repository;
using IncidentApp.Model;
using IncidentApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace IncidentApp.Repository.Repository
{
    public   class DepartamentoRepository:Repository<Departamento>,IDepartamentoRepository
    {
        public DepartamentoRepository(IncidentAppContext context): base(context)
        {

        }
    }
}
