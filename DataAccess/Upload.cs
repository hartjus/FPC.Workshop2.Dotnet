using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Upload
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string Payload { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
