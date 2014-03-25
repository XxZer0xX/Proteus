
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class DbText : Entity
    {
        public virtual Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.DBText); }
        }   
    }
}
