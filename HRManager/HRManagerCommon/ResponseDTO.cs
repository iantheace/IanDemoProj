using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagerCommon
{
    public class ResponseDTO<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; }

    }
}
