namespace BlazorServerAppDemo.Data
{
    public class EventService
    {
        private static readonly string[] EventNames = new[]
        {
            "Annual Party", "Intro course to React.js", "Learning in databases"
        };

        public Task<CompanyEvent[]> GetAllEventsAsync()
        {
            return Task.FromResult(Enumerable.Range(0, 3).Select(index => new CompanyEvent
            {
                Id = index,
                Name = EventNames[index],
                Description = "Description",
                DateAndTime = DateTime.UtcNow,
            }).ToArray());
        }

        public Task AddParticipantToEvent(string? companyEventName, Participant participant)
        {
            // Add participant to event
            return Task.CompletedTask;
        }

        public Task<Participant[]> GetAllParticipantsForEvent(string companyEventName)
        {
            return Task.FromResult(new Participant[] { });
        }
    }
}
