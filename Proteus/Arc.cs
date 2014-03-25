
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class Arc : Curve
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Arc); }
        }
    }
}
