using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    public class Repository <T>
    {
        public List<T> Getir()
        {

            // veritabanında ilgili tabloya git ordan kayıtları getir


            return null;
        }

        public string Ekle(T data)
        {
            // veritabanına git ilgili tabloya şu T tipindeki datayı ekle.

            return "Data başarılı bir şekilde eklenmiştir";
        }

    }
}
