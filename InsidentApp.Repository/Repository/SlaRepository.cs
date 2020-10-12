using AppNominas.Repository;
using IncidentApp.Model;
using IncidentApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Repository.Repository
{
    public class SlaRepository : Repository<Sla>, ISlaRepository
    {
        public SlaRepository(IncidentAppContext context) : base(context)
        {

        }
    }
}


