
namespace DwgX
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Acad = Autodesk.AutoCAD.DatabaseServices;

    public partial class Entity : DbObject
    {
        public virtual Type MappedType
        {
            get 
            { 
                return Assembly.GetAssembly(typeof(Acad.Entity))
                    .GetTypes()
                    .First(type => type.Name.Equals(GetType().Name, StringComparison.CurrentCultureIgnoreCase)); 
            }
        }

        public virtual Acad.Entity Transform()
        {
            var ctr = MappedType.GetConstructors().First();
            var ctrParmas = ctr.GetParameters();

        }
    }
}
