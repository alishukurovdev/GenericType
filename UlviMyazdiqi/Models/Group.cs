using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlviMyazdiqi.Models
{
     class Group
    {
        static int _count = 1;
        public int Id { get; set; } 
        public string Name { get; set; }
        public Group(string name)
        {
            Id = _count++;
            Name = name;
        }

    }
}
