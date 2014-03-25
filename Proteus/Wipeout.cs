
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wipeout : RasterImage
    {
        public override Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Wipeout); }
        }
    }
}
