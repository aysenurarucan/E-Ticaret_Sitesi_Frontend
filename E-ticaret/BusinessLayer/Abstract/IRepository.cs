using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IRepository<T> where T:class,new()
    {
        List<T> List();
        void Insert(T p); //parametre belirtildi
        void Delete(T p);
        void UpDate(T p);
         T GetById(int Id);
    }
}
