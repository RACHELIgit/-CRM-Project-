using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeption
{
    public class exeptionclass
    {
        public class Exceptionfilednull : Exception
        {
            public Dictionary<string, List<int>> toString()
            {
                return null;
            }
                  }

        public class exeptionfileNoFound : Exception
        {
           public string toString()
            {
                return " הקובץ לא נמצא";
            }
        }

    }
}
