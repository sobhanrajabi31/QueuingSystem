using QueuingSystem.Business.Validator.Atelier.Base;
using QueuingSystem.Shared.DTOs.Atelier;

namespace QueuingSystem.Business.Validator.Atelier
{
    public sealed class UpdateAtelierQueueStatusValidator : AtelierValidatorBase<UpdateAtelierQueueDto>
    {
        public UpdateAtelierQueueStatusValidator()
        {
            IdRules(x => x.QueueId);
            EmployeeIdRules(x => x.EmployeeId);
            QueueStatusRules(x => x.QueueStatus);
        }
    }
}
