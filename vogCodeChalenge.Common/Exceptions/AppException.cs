namespace vogCodeChallenge.Common.Exceptions
{
    using System;
    using System.Net;

    public class AppException : Exception
    {
        public ActionResponse ActionResponse { get; set; }

        public AppException(string message) : base(message)
        {
            ActionResponse = new ActionResponse
            {
                StatusCode = HttpStatusCode.BadRequest,
                Title = message
            };
        }
    }
}
