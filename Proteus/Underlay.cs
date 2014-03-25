
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Underlay : DbObject
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.UnderlayReference); }
        }
    }
}
