using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifePCL.Poli
{
    public class MilitaryBase : BaseBody
    {
        public int WallResistance { get; set; }

        public override void CreateBase(string Name, float Longitude, float Latitude)
        {
            //base.CreateBase(Name, Longitude, Latitude);
            Debug.WriteLine("MilitaryBase Wall resistance: 0");
            Debug.WriteLine("MilitaryBase Name: " + Name);
            Debug.WriteLine("MilitaryBase Localization: " + Longitude + " | " + Latitude);
        }

        public virtual void CreateBase(string Name, float Longitude, float Latitude, int WallResistance)
        {
            base.CreateBase(Name, Longitude, Latitude);
            //CreateBase(Name, Longitude, Latitude);
            Debug.WriteLine("MilitaryBase Wall resistance: " + WallResistance);
        }

        public override void CreateDefense(int Val)
        {
            Debug.WriteLine("MilitaryBase Defense value is set to: " + Val);
        }
    }
}
