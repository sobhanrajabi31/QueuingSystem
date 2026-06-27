using QueuingSystem.Business.Validator.Atelier.Base;
using QueuingSystem.Shared.DTOs.Atelier;

namespace QueuingSystem.Business.Validator.Atelier
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
