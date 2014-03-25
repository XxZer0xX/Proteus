
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class ProxyObject : DbObject
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.ProxyObject); }
        }
    }
}
