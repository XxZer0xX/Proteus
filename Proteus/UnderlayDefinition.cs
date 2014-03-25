
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class UnderlayDefinition : DbObject
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.UnderlayDefinition); }
        }
    }
}
