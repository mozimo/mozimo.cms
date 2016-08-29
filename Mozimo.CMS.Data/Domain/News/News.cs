using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mozimo.CMS.Data.Domain.News
{
    public class News
    {
        [Key]
        public long Id { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
    }
}
