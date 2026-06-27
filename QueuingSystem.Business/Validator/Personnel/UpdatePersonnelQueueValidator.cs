using QueuingSystem.Business.Validator.Personnel.Base;
using QueuingSystem.Shared.DTOs.Personnel;

namespace QueuingSystem.Business.Validator.Personnel
{
    public sealed class UpdatePersonnelQueueValidator : PersonnelValidatorBase<UpdatePersonnelQueueDto>
    {
        public UpdatePersonnelQueueValidator()
        {
            IdRules(x => x.Id);
            QueueEndedAtRules(x => x.QueueEndedAt);
        }
    }
}
