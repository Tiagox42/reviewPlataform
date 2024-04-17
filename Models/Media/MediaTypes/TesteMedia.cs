using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace reviewPlataform.Models.Media.MediaTypes
{
    public class TesteMedia : Media
    {
        public string Developer { get; set; }

        public TesteMedia()
        {
        }

        public TesteMedia(string developer, int negativePoints, int positivePoints, string title, MediaType type) : base(negativePoints, positivePoints, title, type)
        {
            Developer = developer;
        }
    }

}
