using Queuing_System_Alipour.DTOs.Atelier.Base;

namespace Queuing_System_Alipour.DTOs.Atelier
{
    public sealed class UpdateAtelierQueueDto : AtelierDtoBase
    {
        public int QueueStatus { get; set; }
    }
}
