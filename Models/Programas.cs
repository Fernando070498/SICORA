using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SICORA.Models
{
    public class Programas
    {
        public int ID { get; set;}
        public string Nom_programa {get; set;}
        public string Desc_programa {get; set;}
        public string Img_programa {get; set;}
        public string pre_programa {get;set;}
    }
}
