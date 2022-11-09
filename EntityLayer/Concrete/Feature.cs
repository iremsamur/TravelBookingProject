using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature : IEntity
    {
        //ana post dışında kalan diğer küçük post'lar için
        [Key]
        public int SubFeatureID { get; set; }
        public string Title{ get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

    }
}
