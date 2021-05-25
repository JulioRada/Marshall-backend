using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Core.Entity
{
    public class Entity: IEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        /*public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }


        public static bool operator !=(Entity a, Entity b) => !(a == b);*/
    }
}
