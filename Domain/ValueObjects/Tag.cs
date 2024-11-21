using Shared.Errors;
using Shared.Result;

namespace Domain.ValueObject
{
    public class Tag
    {
        string Name { get; set; }
        string? Description { get; set; }
        const int MaximunNumberOfNameTag = 15;

        public Tag(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Result<Tag> Create(string name, string description)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Result.Failure<Tag>(DomainErrors.ObjectEmpty);
            }
            else if (name.Length < MaximunNumberOfNameTag)
            {
                return Result.Failure<Tag>(DomainErrors.MaximunLenghtExceeded);
            }
            Name = name;

            return new Tag(name, description);

        }

        public Result SetTagName(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
            {
                return Result.Failure(DomainErrors.ObjectEmpty);
            }
            else if (tagName.Length < MaximunNumberOfNameTag)
            {
                return Result.Failure(DomainErrors.MaximunLenghtExceeded);
            }
            Name = tagName;
            return Result.Success();
        }



    }
}