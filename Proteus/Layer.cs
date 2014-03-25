
namespace DwgX
{
    using System;
    using System.Collections.Generic;

    public partial class Layer : Symbol
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.LayerTableRecord); }
        }  
    }
}
