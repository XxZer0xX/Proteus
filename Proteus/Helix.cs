
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Helix : Spline
    {
        public override Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Helix); }
        }
    }
}
