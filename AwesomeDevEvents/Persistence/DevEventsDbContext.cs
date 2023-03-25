using AwesomeDevEvents.Entities;

namespace AwesomeDevEvents.Persistence
{
    public class DevEventsDbContext
    {
        public DevEventsDbContext()
        {
            DevEvents = new List<DevEvent>();
        }

        public List<DevEvent> DevEvents { get; set; }
    }
}
