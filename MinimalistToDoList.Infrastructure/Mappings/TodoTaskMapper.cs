using System.Diagnostics.CodeAnalysis;
using MinimalistToDoList.Core.Entities;
using MinimalistToDoList_Shared.DTOs;

namespace MinimalistToDoList.Infrastructure.Mappings
{
    public class TodoTaskMapper
    {
        [return: NotNullIfNotNull("entity")]
        public static TodoTaskDto? ToDto(TodoTask? entity)
        {
            if (entity is null) return null;

            return new TodoTaskDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                IsCompleted = entity.IsCompleted,
                DueDate = entity.DueDate,
                Priority = entity.Priority switch
                {
                    Core.Enums.Priority.Low => Shared.Enums.PriorityDto.Low,
                    Core.Enums.Priority.Medium => Shared.Enums.PriorityDto.Medium,
                    Core.Enums.Priority.High => Shared.Enums.PriorityDto.High,
                    _ => throw new ArgumentOutOfRangeException(nameof(entity.Priority), entity.Priority, null)
                }
            };
        }

        [return:NotNullIfNotNull("dto")]
        public static TodoTask? ToEntity(TodoTaskDto? dto)
        {
            if (dto == null) return null;

            return new TodoTask
            {
                Id = dto.Id,
                Title = dto.Title,
                Description = dto.Description,
                IsCompleted = dto.IsCompleted,
                DueDate = dto.DueDate,
                Priority = dto.Priority switch
                {
                    Shared.Enums.PriorityDto.Low => Core.Enums.Priority.Low,
                    Shared.Enums.PriorityDto.Medium => Core.Enums.Priority.Medium,
                    Shared.Enums.PriorityDto.High => Core.Enums.Priority.High,
                    _ => throw new ArgumentOutOfRangeException(nameof(dto.Priority), dto.Priority, null)
                }
            };
        }
    }
}
