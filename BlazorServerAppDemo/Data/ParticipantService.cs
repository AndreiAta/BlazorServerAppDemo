namespace BlazorServerAppDemo.Data
{
    public class ParticipantService
    {
        public Task<Participant[]> GetAllParticipants()
        {
            return Task.FromResult(new[] {new Participant()} );
        }
    }
}
