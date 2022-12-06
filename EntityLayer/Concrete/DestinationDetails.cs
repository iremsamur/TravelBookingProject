using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DestinationDetails : IEntity
    {
        [Key]
        public int DestinationDetailID { get; set; }
        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }


        public List<Destination> Destinations { get; set; }
      
    }
}
