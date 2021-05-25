using Marshall.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Domain.Entities
{
    public class Position : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
