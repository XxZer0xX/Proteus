
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attribute : DbText
    {
        public override Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.AttributeReference); }
        } 
    }
}
