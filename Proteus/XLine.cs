
using System.Reflection;
using Acad = Autodesk.AutoCAD.DatabaseServices;

namespace DwgX
{
    public partial class XLine : Curve
    {
        public System.Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.Xline); }
        }

        
    }
}
