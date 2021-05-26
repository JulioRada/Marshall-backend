using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Core.Commands
{
    public class Result
    {
        public readonly IEnumerable<string> Errors;
        public readonly bool Success;

        public Result(bool success, IEnumerable<string> errors)
        {
            Success = success;
            Errors = errors;
        }
    }
}
