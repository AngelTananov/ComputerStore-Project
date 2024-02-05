using FluentValidation;

namespace BookstoreApp.Validators
{
    public class TestRequestValidation : AbstractValidator<GetAllBookByAuthorRequest>
    {

        public TestRequestValidation()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty().NotNull();

            RuleFor(x => x.AfterDate)
                .NotEmpty().NotNull();
        }
    }
}