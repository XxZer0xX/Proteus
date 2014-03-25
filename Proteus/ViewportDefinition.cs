using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwgX
{
    public class ViewportDefinition : AbstractView
    {
        public Type MappedType
        {
            get { return typeof(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord); }
        }
    }
}
