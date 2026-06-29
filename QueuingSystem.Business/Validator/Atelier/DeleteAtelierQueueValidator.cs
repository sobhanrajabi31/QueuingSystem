using QueuingSystem.Business.Validator.Atelier.Base;
using QueuingSystem.Shared.DTOs.Atelier;

namespace QueuingSystem.Business.Validator.Atelier
{
    public sealed class DeleteAtelierQueueValidator : AtelierValidatorBase<DeleteAtelierQueueDto>
    {
        public DeleteAtelierQueueValidator()
        {
            IdRules(x => x.QueueId);
            IdRules(x => x.EmployeeId);
        }
    }
}
