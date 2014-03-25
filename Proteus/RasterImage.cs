
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class RasterImage : Image
    {
        public override Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.RasterImage); }
        }

    }
}
