namespace vogCodeChallenge.Common.Exceptions
{
    using System.Net;
    using Newtonsoft.Json;

    public class ActionResponse
    {
        [JsonProperty("statusCode")]
        public HttpStatusCode StatusCode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
