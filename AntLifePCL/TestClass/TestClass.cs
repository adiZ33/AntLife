using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifePCL
{
    public class TestClass
    {
        public int TestClassId { get; set; }
        public string TestClassName { get; set; }

        #region Bezpieczne pole

        private int testInt;

        public int TestInt
        {
            get { return testInt; }
            set
            {
                if (testInt < 10)
                    testInt = 10;
                else
                testInt = value;
            }
        }

        #endregion
    }
}
