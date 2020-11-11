using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace QueueProcessor
{
    public class Functions
    {
        public static void ProcessQueueMessage([QueueTrigger("webjobqueue")] string message,
            ILogger logger)
        {
            logger.LogInformation(message);
        }
    }
}
