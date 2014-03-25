
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class Field : DbObject
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Field); }
        }  
    }
}
