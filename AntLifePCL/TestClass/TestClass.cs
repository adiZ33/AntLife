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

        private int naszaKasa;

        public int NaszaKasa
        {
            get { return 20; }
        }

        //hermetyzacja

        private int _wiek;

        public int GetAge()
        {
            return _wiek;
        }

        public void SetAge(int wiek)
        {
            _wiek = wiek;
        }

        public int wiek { get; set; }
    }
}
