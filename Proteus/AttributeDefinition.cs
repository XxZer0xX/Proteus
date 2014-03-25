
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttributeDefinition : DbText
    {
        public override Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.AttributeDefinition); }
        } 
    }
}
