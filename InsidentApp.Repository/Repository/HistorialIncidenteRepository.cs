using AppNominas.Repository;
using IncidentApp.Model;
using IncidentApp.Model.Model;
using IncidentApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Repository.Repository
{
    public class HistorialIncidenteRepository : Repository<HistorialIncidente>, IHistorialIncidenteRepository
    {
        public HistorialIncidenteRepository(IncidentAppContext context) : base(context)
        {

        }
    }
}
