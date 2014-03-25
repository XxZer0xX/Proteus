
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class Polyline3D : Curve
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Polyline3d); }
        } 
    }
}
