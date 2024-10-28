using TasksManager.Communication.Requests;
using TasksManager.Communication.Responses;

namespace TasksManager.API.UseCase.Task.CreateTask;

public class CreateTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        var response = new ResponseRegisteredTaskJson()
        {
            Id = request.Id,
            Name = request.Name,
        };

        return response;
    }
}
