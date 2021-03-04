using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.CustomException
{
    public class NoSuitableDriverFound:Exception
    {
        public NoSuitableDriverFound(string Message) : base(Message)
        { 
        
        }
    }
}
