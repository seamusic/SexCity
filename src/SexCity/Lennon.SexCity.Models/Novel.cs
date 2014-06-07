using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lennon.SexCity.Models
{
    public class Novel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string KeyWords { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Intro { get; set; }
        public string Content { get; set; }
        public string Remark { get; set; }
        public bool IsDeleted { get; set; }
    }
}
