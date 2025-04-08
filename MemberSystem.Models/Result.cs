using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSystem.Models
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static Result Ok() => new Result { Success = true };
        public static Result Fail(string message) => new Result { Success = false, Message = message };
    }
}
