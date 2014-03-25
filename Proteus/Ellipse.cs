
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ellipse : Curve
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Ellipse); }
        }  
    }
}
