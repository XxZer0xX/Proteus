
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class Circle : Curve
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Circle); }
        } 
    }
}
