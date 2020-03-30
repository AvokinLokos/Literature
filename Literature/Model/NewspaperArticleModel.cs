using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature.Model
{
    public class NewspaperArticleModel
    {
        public string Author { get; set; }
        public string ArticleTitle { get; set; }
        public string NewspaperTitle { get; set; }
        public string EditionYear { get; set; }
        public string Release { get; set; }
        public string ArticleNumber { get; set; }
    }
}
