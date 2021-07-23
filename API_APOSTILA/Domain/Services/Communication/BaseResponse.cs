using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_APOSTILA.Domain.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Succcess { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponse(bool success, string message)
        {
            Succcess = success;
            Message = message;
        }
    }
}
