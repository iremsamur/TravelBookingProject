using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public Destination GetDestinationDetails(int DestinationID)
        {
            using (var context = new Context())
            {
                var value = context.Destinations.Include(x => x.DestinationDetails).FirstOrDefault();
               
                return value;
            }
        }
    }
}
