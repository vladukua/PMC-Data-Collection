using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmcDataCollection.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var containers = new Containers<int>(3, 3);
            containers.AddContainer();
            containers[0].Create1DMatrix();
            containers[0].Create3DMatrix();
            containers[0].Create3DMatrix();
            containers[0].GetMatrix3D(0).CreatePosition();
            containers[0].GetMatrix3D(0).CreatePosition(50);
            containers[0].GetMatrix3D(1).CreatePosition(70);
            containers[0].GetMatrix3D(1).CreatePosition(50);
            containers.AddContainer();
            containers[1].Create3DMatrix();
            containers[1].GetMatrix3D(0).CreatePosition(20);
            containers[0].GetMatrix3D(0)[0].AddPoint(new Point3D<int>(5, 5, 5));
        }
    }
}
