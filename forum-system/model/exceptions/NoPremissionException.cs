using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.exceptions
{
    class NoPremissionException : Exception
    {
        public NoPremissionException() { }

        public NoPremissionException(string message) : base(message) { }
    }
}
