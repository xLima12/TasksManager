using TasksManager.Communication.Responses;

namespace TasksManager.API.UseCase.Task.GetById;

public class GetTaskById
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Minha primeira Tarefa",
            Description = "Descrição da minha primeira tarefa",
            Priority = 0,
            Status = (Communication.Enums.TasksStatus)2,
        };
    }
}
