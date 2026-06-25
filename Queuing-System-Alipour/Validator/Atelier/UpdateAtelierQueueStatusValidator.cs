using Queuing_System_Alipour.DTOs.Atelier;
using Queuing_System_Alipour.Validator.Atelier.Base;

namespace Queuing_System_Alipour.Validator.Atelier
{
    public sealed class UpdateAtelierQueueStatusValidator 
        : AtelierValidatorBase<UpdateAtelierQueueDto>
    {
        public UpdateAtelierQueueStatusValidator()
        {
            IdRules(x => x.QueueId);
            EmployeeIdRules(x => x.EmployeeId);
            QueueStatusRules(x => x.QueueStatus);
        }
    }
}
