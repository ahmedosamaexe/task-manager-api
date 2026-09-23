using TaskManagerAPI.DTOs;

namespace TaskManagerAPI.Services;

public interface ITaskService
{
    Task<PagedResult<TaskResponseDto>> GetAllTasksAsync(int userId, int page, int pageSize);
    Task<TaskResponseDto?> GetTaskByIdAsync(int id, int userId);
    Task<TaskResponseDto> CreateTaskAsync(TaskCreateDto dto, int userId);
    Task<TaskResponseDto?> UpdateTaskAsync(int id, TaskUpdateDto dto, int userId);
    Task<bool> DeleteTaskAsync(int id, int userId);
}

public sealed record PagedResult<T>(
    IReadOnlyList<T> Items,
    int Page,
    int PageSize,
    int TotalCount,
    int TotalPages);
