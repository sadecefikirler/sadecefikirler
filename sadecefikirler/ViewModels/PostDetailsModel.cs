using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sadecefikirler.Models;

namespace sadecefikirler.ViewModels
{
    public class PostDetailsModel
    {
        public Post DetailofPost { get; set; }
        public Category _Category { get; set; }
        public List<Post> SimilarPost { get; set; }
    }
}