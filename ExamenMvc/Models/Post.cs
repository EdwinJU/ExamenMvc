using System;

namespace ExamenMvc.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Detalle {get; set;}
        public DateTime Fecha { get; set; }
        public int UsuarioId{ get; set; }
        public virtual Usuario usuario {get; set;}


    }
}