using AppNominas.Repository;
using IncidentApp.Model;
using IncidentApp.Model.Model;
using IncidentApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Repository.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IncidentAppContext context) : base(context)
        {

        }
    }
}