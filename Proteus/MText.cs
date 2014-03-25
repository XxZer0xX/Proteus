
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class MText : Entity
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.MText); }
        }
    }
}
