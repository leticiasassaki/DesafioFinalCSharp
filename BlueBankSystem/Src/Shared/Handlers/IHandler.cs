namespace BlueBank.System.Domain.Shared.Handlers
{
    public interface IHandler <TRequest, TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
