using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_s_Birthday
{
    class IceCakes:Cake
    {
        public override void addPeople()
        {
            Cake.totalPerson += 6;
        }
    }
}
