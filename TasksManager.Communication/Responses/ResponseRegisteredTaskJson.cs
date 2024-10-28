using TasksManager.Communication.Enums;

namespace TasksManager.Communication.Responses;

public class ResponseRegisteredTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime Deadline
    {
        get
        {
            if (Priority == TaskPriority.ALTA)
            {
                return DateTime.Now.AddHours(4);
            }
            else if (Priority == TaskPriority.MEDIA)
            {
                return DateTime.Now.AddDays(2);
            }
            return DateTime.Now.AddDays(4);
        }
    }
    public  TasksStatus Status { get; set; }
}
