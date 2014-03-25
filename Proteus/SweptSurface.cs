
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class SweptSurface : Surface
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.SweptSurface); }
        }
    }
}
