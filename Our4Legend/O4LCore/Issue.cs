using System;
using System . Collections . Generic;
using System . Text;

namespace Our4Legend
{
    public class Issue
    {

        public DateTime PublishTime { get; set; }

        public long Number { get; set; }

        public IEnumerable<Article> ListOfArticle { get; set; }

        public decimal Price { get; set; }
    }

}
