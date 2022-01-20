using System;

namespace Aplikacja_GOT_PTTK.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //commit test
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
