using Marshall.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Core.Interfaces
{
    public interface ICommandHandler<in T> where T : CommandBase
    {
        Result Handle(T command);
    }
}
