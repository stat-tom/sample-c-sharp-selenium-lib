using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationLibrary.Exceptions
{
    public class ControlNotFoundException : ApplicationException
    {
        public ControlNotFoundException(string message) : base(message)
        {

        }
    }
}
