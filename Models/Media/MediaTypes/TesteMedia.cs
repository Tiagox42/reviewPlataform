using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace reviewPlataform.Models.Media.MediaTypes
{
    public class TesteMedia : Media
    {
        public MediaType type { get; set; } = MediaType.Teste;
        public string Developer { get; set; }

        public TesteMedia(string developer, int negativePoints, int positivePoints, List<Comment> comments, string title) : base(negativePoints, positivePoints, comments, title)
        {
            Developer = developer;
        }

        
    }

}
