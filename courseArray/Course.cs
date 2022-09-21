using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseArray
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int fees { get; set; }

        public override string ToString()
        {
            return $" Course detail: {Id} {Name} {fees}";
        }
    }
}
