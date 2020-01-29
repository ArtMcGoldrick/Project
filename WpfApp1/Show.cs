using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Show
    {
        //Properties
        public string ShowName { get; set; }

        //Display with string
        public override string ToString()
        {
            return $"{ShowName}";
        }
    }
}
