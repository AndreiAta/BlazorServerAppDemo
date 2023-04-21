namespace BlazorServerAppDemo.Data
{
    public interface IEventService
    {
        Task AddParticipantToEvent(string? companyEventName, Participant participant);

        Task<CompanyEvent[]> GetAllEventsAsync();

        Task<Participant[]> GetAllParticipantsForEvent(string companyEventName);
    }
}