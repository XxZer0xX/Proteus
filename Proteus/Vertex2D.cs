
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vertex2D : Vertex
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Vertex2d); }
        }
    }
}
