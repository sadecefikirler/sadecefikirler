using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sadecefikirler.Models;
using sadecefikirler.Absatract;

namespace sadecefikirler.Concrete
{
    public class CategoryConcrete : IDataBusiness<Category>
    {
        public void InsertData(Category model)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Category model)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Category model)
        {
            throw new NotImplementedException();
        }

        public Category SelectData(int id)
        {
            using (sadecefikirlerEntities db = new sadecefikirlerEntities())
            {
                return db.Categories.Find(id);
            }
        }

        public List<Category> ListData()
        {
            using (sadecefikirlerEntities db = new sadecefikirlerEntities())
            {
                return db.Categories.ToList();
            }
        }
    }
}