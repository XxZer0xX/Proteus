
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class Polyline : Curve
    {

        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Polyline); }
        }
    }
}
