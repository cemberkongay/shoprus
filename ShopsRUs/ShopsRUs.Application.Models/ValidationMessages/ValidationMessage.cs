using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Application.Models.ValidationMessages
{
    public class ValidationMessage
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
    public enum MessageCode
    {
        Error = 1,
        Info = 2,
        Warning = 3,
        Success = 4
    }
}
