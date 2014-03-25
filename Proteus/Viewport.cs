
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Viewport : Entity
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Viewport); }
        }
    }
}
