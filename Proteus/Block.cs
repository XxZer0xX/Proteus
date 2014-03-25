
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Block : Entity
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.BlockReference); }
        } 
    }
}
