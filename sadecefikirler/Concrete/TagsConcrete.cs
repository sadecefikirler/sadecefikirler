using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sadecefikirler.Models;
using sadecefikirler.Absatract;

namespace sadecefikirler.Concrete
{
    public class TagsConcrete : IDataBusiness<Tag>
    {
        public void InsertData(Tag model)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Tag model)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Tag model)
        {
            throw new NotImplementedException();
        }

        public Tag SelectData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tag> ListData()
        {
            using (sadecefikirlerEntities db = new sadecefikirlerEntities())
            {
                return db.Tags.ToList();
            }
        }
    }
}