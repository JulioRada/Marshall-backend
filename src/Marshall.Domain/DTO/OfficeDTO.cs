using Marshall.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Domain.DTO
{
    public class OfficeDTO: CommandBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
