namespace Api.UnitOfWork.commands
{
    public interface ICommandLine
    {
        string GetCommunity { get; }
        string GetCommunityById { get; }
        string AddCommunity { get; }
        string UpdateCommunity { get; }
        string RemoveCommunity { get; }
    }
}