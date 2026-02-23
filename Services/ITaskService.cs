using TaskManagerAPI.DTOs;

namespace TaskManagerAPI.Services;

public interface ITaskService
{
    /// <summary>Gets all tasks belonging to the specified user.</summary>
    Task<IEnumerable<TaskResponseDto>> GetAllTasksAsync(int userId);

    /// <summary>Gets a single task by ID, ensuring it belongs to the specified user.</summary>
    Task<TaskResponseDto?> GetTaskByIdAsync(int id, int userId);

    /// <summary>Creates a new task for the specified user.</summary>
    Task<TaskResponseDto> CreateTaskAsync(TaskCreateDto dto, int userId);

    /// <summary>Updates an existing task. Returns null if the task is not found or does not belong to the user.</summary>
    Task<TaskResponseDto?> UpdateTaskAsync(int id, TaskUpdateDto dto, int userId);

    /// <summary>Deletes a task. Returns false if the task is not found or does not belong to the user.</summary>
    Task<bool> DeleteTaskAsync(int id, int userId);
}
