using Microsoft.Extensions.Logging;
using S08B_DependencyInjection_Services.Interfaces;

namespace S08B_DependencyInjection_Services
{
    public class LoggingMessageWriter : IMessageWriter
    {
        private readonly ILogger<LoggingMessageWriter> _logger;

        public LoggingMessageWriter(ILogger<LoggingMessageWriter> logger)
        {
            _logger = logger;
        }

        public void Write(string message)
        {
            _logger.LogInformation("LoggingMessageWriter dit: " + message);
        }
    }
}
