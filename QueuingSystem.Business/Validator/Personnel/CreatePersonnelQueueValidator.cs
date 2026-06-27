using QueuingSystem.Business.Validator.Personnel.Base;
using QueuingSystem.Shared.DTOs.Personnel;

namespace QueuingSystem.Business.Validator.Personnel
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
