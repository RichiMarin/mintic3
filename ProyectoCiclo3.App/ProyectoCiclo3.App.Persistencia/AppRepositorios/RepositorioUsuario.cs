using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuario()
        {
            usuarios = new List<Usuario>()
            {
                new Usuario{id=1,nombre="Ricardo",apellidos= "Marin",direccion= "Calle 52",telefono= "88888888"},
                new Usuario{id=2,nombre="Sebas",apellidos= "sanches",direccion= "calle 51",telefono= "999999"},
                new Usuario{id=3,nombre="Magno",apellidos= "herrera",direccion= "calle50",telefono= "777777"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id);
        }
        public Usuario Update(Usuario newUsuario){

            var usuario= usuarios.SingleOrDefault(b => b.id == newUsuario.id);

            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
                
            }
        return usuario;
        }
    }
}
