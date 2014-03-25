
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hatch : Entity
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Hatch); }
        }
        
    }
}
