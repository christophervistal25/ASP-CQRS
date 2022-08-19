using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Core.Student.Transports
{
    public class StudentTransport:BaseTransport
    {
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public string? Suffix { get; set; }

        public string? Fullname { get; set; }

    }
}
