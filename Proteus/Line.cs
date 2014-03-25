
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Line : Curve    
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Line); }
        }
    }
}
