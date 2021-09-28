using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        List<Servicio> servicios;
 
    public RepositorioServicio()
        {
            servicios = new List<Servicio>()
            {
                new Servicio{id=1,origen=1,destino=2,fecha="2021-18-07",hora= "12:34",encomienda=2},
                new Servicio{id=2,origen=2,destino=3,fecha="2021-18-07",hora= "09:54",encomienda=1},
                new Servicio{id=3,origen=3,destino=1,fecha="2021-18-07",hora= "21:14",encomienda=3},
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetServicioWithId(int id){
            return servicios.SingleOrDefault(b => b.id == id);
        }
    }
}