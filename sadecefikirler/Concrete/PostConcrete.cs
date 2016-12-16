using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sadecefikirler.Models;
using sadecefikirler.Absatract;
using sadecefikirler.ViewModels;

namespace sadecefikirler.Concrete
{
    public class PostConcrete : IDataBusiness<Post>
    {
        public void InsertData(Post model)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Post model)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Post model)
        {
            throw new NotImplementedException();
        }

        public Post SelectData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> ListData()
        {
            using (sadecefikirlerEntities db = new sadecefikirlerEntities())
            {
                return db.Posts.ToList();
            }
        }
        public List<Post> GetCategoriePosts(int id)
        {
            using (sadecefikirlerEntities db = new sadecefikirlerEntities())
            {
                var posts = new List<Post>();
                var result = db.Posts.ToList();
                foreach (var item in result)
                {
                    foreach (var a in item.Categories)
                    {
                        if (a.Id==id)
                        {
                            posts.Add(item);
                        }
                    }
                }
                return posts;
                
            }
        }
    }
}