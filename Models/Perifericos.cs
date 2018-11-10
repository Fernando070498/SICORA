using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SICORA.Models
{
    public class Perifericos
    {
        public int ID { get; set;}
        public string Nom_perifericos {get; set;}
        public string Desc_perifericos {get; set;}
        public string Img_perifericos {get; set;}        
        public string pre_perifericos {get;set;}
    }
}

