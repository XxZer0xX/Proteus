
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    
    public partial class FaceRecord : Vertex
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.FaceRecord); }
        }  
        
    }
}
