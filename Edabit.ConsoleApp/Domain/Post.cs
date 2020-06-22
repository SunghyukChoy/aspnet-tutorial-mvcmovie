using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit.ConsoleApp.Domain
{
    public class Post
    {
        
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }

    }
}
