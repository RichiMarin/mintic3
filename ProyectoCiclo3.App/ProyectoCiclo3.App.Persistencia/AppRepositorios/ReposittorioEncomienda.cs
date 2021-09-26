using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> encomiendas;
 
    public RepositorioEncomienda()
        {
            encomiendas = new List<Encomienda>()
            {
                new Encomienda{id=1,descripcion="Tablet Samsung 10",peso= 2,tipo= "Tecnologia",presentacion= "Caja 14cm x 20 cm"},
                new Encomienda{id=2,descripcion="Televisor LG 65 4K",peso= 15,tipo= "Tecnologia",presentacion= "Caja de 2mts x 25cm"},
                new Encomienda{id=3,descripcion="Carro a control remoto amarillo",peso= 3,tipo= "Jugueteria",presentacion= "Caja 50cm x 30cm"}
 
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return encomiendas;
        }
 
        public Encomienda GetEncomiendaWithId(int id){
            return encomiendas.SingleOrDefault(b => b.id == id);
        }
    }
}