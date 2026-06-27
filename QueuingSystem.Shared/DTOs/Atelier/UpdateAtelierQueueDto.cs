using QueuingSystem.Shared.DTOs.Atelier.Base;
using QueuingSystem.Shared.Entities;

namespace QueuingSystem.Shared.DTOs.Atelier
{
    public sealed class UpdateAtelierQueueDto : AtelierDtoBase
    {
        public QueueStatus QueueStatus { get; set; }
    }
}
