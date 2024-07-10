using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public class ErrorOnValidationException : JourneyException
    {
        private readonly IList<string> _messages;

        public ErrorOnValidationException(IList<string> messages) : base(string.Empty)
        {
            _messages = messages;
        }

        public override IList<string> GetErrorMessages()
        {
            return _messages;
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.BadRequest;
        }
    }
}
