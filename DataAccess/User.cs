using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public ICollection<Upload> Uploads { get; set; }
    }
}
