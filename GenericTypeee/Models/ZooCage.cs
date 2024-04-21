using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeee.Models
{
    public class ZooCage<T,U>where T : Animal where U : Food
    {
        public T Animal { get; set; }
        public U Food { get; set; }
    }
}
