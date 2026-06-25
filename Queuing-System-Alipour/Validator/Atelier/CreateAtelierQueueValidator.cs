using Queuing_System_Alipour.DTOs.Atelier;
using Queuing_System_Alipour.Validator.Atelier.Base;

namespace Queuing_System_Alipour.Validator.Atelier
{
    public sealed class CreateAtelierQueueValidator : AtelierValidatorBase<CreateAtelierQueueDto>
    {
        public CreateAtelierQueueValidator()
        {
            FullNameRules(x => x.FullName);
            PhoneNumberRules(x => x.PhoneNumber);
            QueueCreatedAtRules(x => x.QueueCreatedAt);
            QueueDurationRules(x => x.QueueDuration);
            NoteRules(x => x.Note);
        }
    }
}
