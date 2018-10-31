using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SICORA.Models
{
    public class Prueba_bd
    {
        public string ID { get; set;}
        public string Nom_juego {get; set;}
        public string Desc_juego {get; set;}
        public string trailer_juego {get; set;}
        public string pre_juego {get;set;}
    }
}