using intro.DataAccess.Abstracts;
using intro.DataAccess.Concretes;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business
{
    //constructor  yapıcı blok
    public class CourseManager   // operasyon tutucu  örnk olarak müşterisi listesi , ürün listesi gibi veri tek bir class tanımlama ile her bir sayfa genelinde  class çağırma temiz kod kullanılır.
    {

        //dependency injection
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            //business rules

            return _courseDal.GetAll();
        }
    }
}
