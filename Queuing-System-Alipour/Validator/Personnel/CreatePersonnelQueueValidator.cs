using Queuing_System_Alipour.DTOs.Personnel;
using Queuing_System_Alipour.Validator.Personnel.Base;

namespace Queuing_System_Alipour.Validator.Personnel
{
    public class CreatePersonnelQueueValidator : PersonnelValidatorBase<CreatePersonnelQueueDto>
    {
        public CreatePersonnelQueueValidator()
        {
            LastNameRules(x => x.LastName);
            QueueCreatedAtRules(x => x.QueueCreatedAt);
        }
    }
}
