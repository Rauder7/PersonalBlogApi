using Domain.ValueObject;
using Domain.ValueObjects;
using Shared.Errors;
using Shared.Result;

namespace Domain.Entities
{
    public class Post
    {
        Guid Id { get; set; }
        string Titulo { get; set; }
        string Descripcion { get; set; }
        Author author { get; set; }
        public IReadOnlyList<Tag> Tags => _tags;
        private List<Tag> _tags { get; set; }
        DateTime Creation_date { get; set; }
        TimeOnly Tiempo_lectura { get; set; }

        const int numberMaximoofTag = 4;

        public Post(Guid id, string titulo, string description, List<Tag> tags)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = description;
            _tags = tags;

        }
        private Post()
        {
            _tags = new List<Tag>();
        }
        public static Post Create(Guid id, string titulo, string description, List<Tag> tags)
        {
            return new(id, titulo, description, tags);
        }
        public Result AddTag(Tag tag)
        {
            if (_tags.Count() < numberMaximoofTag)
            {
                return Result.Failure(DomainErrors.TooManyTagsError);
            }
            else
            {
                _tags.Add(tag);
                return Result.Success();
            }
        }


    }
}