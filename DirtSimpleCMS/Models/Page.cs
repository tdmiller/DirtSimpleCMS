using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtSimpleCMS.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UrlPath { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
