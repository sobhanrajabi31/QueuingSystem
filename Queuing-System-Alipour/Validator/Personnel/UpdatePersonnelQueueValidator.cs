using Queuing_System_Alipour.DTOs.Personnel;
using Queuing_System_Alipour.Validator.Personnel.Base;

namespace Queuing_System_Alipour.Validator.Personnel
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
