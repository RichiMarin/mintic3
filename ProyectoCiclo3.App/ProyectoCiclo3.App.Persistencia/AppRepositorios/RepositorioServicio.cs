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

        public Servicio Update(Servicio newServicio){

            var servicio= servicios.SingleOrDefault(b => b.id == newServicio.id);

            if(servicio != null){
                servicio.origen = newServicio.origen;
                servicio.destino = newServicio.destino;
                servicio.fecha = newServicio.fecha;
                servicio.hora = newServicio.hora;
                servicio.encomienda = newServicio.encomienda;
                
            }
        return servicio;
        }
        public Servicio Create(Servicio newServicio)
        {
           if(servicios.Count > 0){
           newServicio.id=servicios.Max(r => r.id) +1; 
            }else{
               newServicio.id = 1; 
            }
           servicios.Add(newServicio);
           return newServicio;
        }

           public void Delete(int id)
        {
        var servic= servicios.SingleOrDefault(b => b.id == id);
        servicios.Remove(servic);
        return;
        }

    }
}