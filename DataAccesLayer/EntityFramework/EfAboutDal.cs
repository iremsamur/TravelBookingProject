using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfAboutDal :GenericRepository<About>,IAboutDal
    {
        //her entitynin ortak metodları kullanabilmesi için
        //GenericRepository'den kendi entity değerine göre
        //miras alarak çalışmasını sağlar. kendi Dal sınıfından 
        //IAboutDal'dan miras alarak ise kendine özel özelleştirilmiş metodlar varsa
        //onların kullanılmasını sağlar.
        

    }
}
