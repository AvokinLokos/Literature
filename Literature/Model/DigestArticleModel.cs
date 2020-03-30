using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature.Model
{
    public class DigestArticleModel
    {
        public string Author { get; set; }
        public string ArticleTitle { get; set; }
        public string DigestTitle { get; set; }
        public string Town { get; set; }
        public string EditionTitle { get; set; }
        public string EditionYear { get; set; }
    }
}
