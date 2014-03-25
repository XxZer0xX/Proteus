
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class Body : Entity
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Body); }
        } 
    }
}
