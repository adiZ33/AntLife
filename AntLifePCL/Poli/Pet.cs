using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifePCL.Poli
{
    public class Pet : Animal
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public virtual void GiveName() { }
    }
}
