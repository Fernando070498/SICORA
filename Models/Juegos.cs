using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SICORA.Models
{
    public class Juegos
    {
        public int ID { get; set;}
        public string Nom_juego {get; set;}
        public string Desc_juego {get; set;}
        public string Img_juego {get; set;}
        public string trailer_juego {get; set;}
        public string pre_juego {get;set;}
    }
}

