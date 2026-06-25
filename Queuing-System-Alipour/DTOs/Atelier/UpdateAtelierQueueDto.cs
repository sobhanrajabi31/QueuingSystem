using Queuing_System_Alipour.DTOs.Atelier.Base;
using Queuing_System_Alipour.Entities;

namespace Queuing_System_Alipour.DTOs.Atelier
{
    public sealed class UpdateAtelierQueueDto : AtelierDtoBase
    {
        public QueueStatus QueueStatus { get; set; }
    }
}
