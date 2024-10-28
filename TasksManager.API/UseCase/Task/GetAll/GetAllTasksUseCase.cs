using TasksManager.Communication.Responses;

namespace TasksManager.API.UseCase.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson()
        {
            Tasks = new List<ReponseShortTaskJson>
            {
                new() {
                    Id = 1,
                    Name = "Minha primeira tarefa",
                    Priority = (Communication.Enums.TaskPriority)2,
                    Status = (Communication.Enums.TasksStatus)2
                },
                new() {
                    Id = 2,
                    Name = "Minha primeira tarefa",
                    Priority = (Communication.Enums.TaskPriority)1,
                    Status = (Communication.Enums.TasksStatus)2
                },
                new() {
                    Id = 3,
                    Name = "Minha primeira tarefa",
                    Priority = 0,
                    Status = (Communication.Enums.TasksStatus)2
                }
            }
        };
    }
}
