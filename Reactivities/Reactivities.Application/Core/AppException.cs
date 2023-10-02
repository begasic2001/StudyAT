using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Core
{
    public class AppException
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

        public AppException(int StatusCode, string Message, string Details = null)
        {
            this.StatusCode = StatusCode;
            this.Message = Message;
            this.Details = Details;
        }
    }
}
