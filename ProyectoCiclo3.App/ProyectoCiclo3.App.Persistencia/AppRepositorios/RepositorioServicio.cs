using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        List<Servicio> servicios;
 
    private readonly AppContext _appContext = new AppContext();  
 
       public IEnumerable<Servicio> GetAll()
        {
           return _appContext.Servicios.Include(u => u.origen)
                       .Include(u => u.destino).
                       Include(e => e.encomienda);
        }
        public Servicio GetServicioWithId(int id){
            return _appContext.Servicios.Find(id);
        }

        public Servicio Update(Servicio newServicio){

            var servicio= _appContext.Servicios.Find(newServicio.id);

            if(servicio != null){
                servicio.origen.nombre = newServicio.origen.nombre;
                servicio.destino.nombre = newServicio.destino.nombre;
                servicio.fecha = newServicio.fecha;
                servicio.hora = newServicio.hora;
                servicio.encomienda.descripcion = newServicio.encomienda.descripcion;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return servicio;
        
        }
        public Servicio Create(int origen, int destino, string fecha, string hora, int encomienda)
            {
            var newServicio = new Servicio();
            newServicio.origen = _appContext.Usuarios.Find(origen);
            newServicio.destino = _appContext.Usuarios.Find(destino);
            newServicio.encomienda = _appContext.Encomiendas.Find(encomienda);         
            newServicio.fecha = DateTime.Parse(fecha);
            newServicio.hora = hora;

            var addServicio = _appContext.Servicios.Add(newServicio);
            _appContext.SaveChanges();
            return addServicio.Entity;
        }

           public void Delete(int id)
        {
        var servic= _appContext.Servicios.Find(id);
        if (servic == null)
            return;
        _appContext.Servicios.Remove(servic);
        _appContext.SaveChanges();
        }

    }
}