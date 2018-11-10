using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SICORA.Models
{
    public class Prueba_bd
    {
        public int ID { get; set;}
        public string Nom_juego {get; set;}
        public string Desc_juego {get; set;}
        public string Trailer_juego {get; set;}
        public string Imagen_juego {get; set;}
        public string Pre_juego {get;set;}
    }
}