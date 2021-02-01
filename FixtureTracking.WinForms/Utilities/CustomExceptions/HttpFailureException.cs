using FixtureTracking.Core.Utilities.Middlewares.Exception;
using System;
using System.Net;

namespace FixtureTracking.WinForms.Utilities.CustomExceptions
{
    public class HttpFailureException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; private set; }
        public HttpFailureException(string message, HttpStatusCode httpStatusCode) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }

        public HttpFailureException(ErrorDetail errorDetail) : base(errorDetail.Message.Replace("~", "\r\n"))
        {
            HttpStatusCode = (HttpStatusCode)errorDetail.StatusCode;
        }

    }
}
