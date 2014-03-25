
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spline : Curve
    {
        public virtual Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Spline); }
        }
    }
}
