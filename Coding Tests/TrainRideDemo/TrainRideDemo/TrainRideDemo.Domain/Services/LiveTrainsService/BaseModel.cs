

namespace TrainRideDemo.Domain.Service
{
    public class ResponseObject
    {
        public bool Success { get; set; }

        public string Code { get; set; }

        public string Message { get; set; }

        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
