using Shared.Result;

namespace Shared.Errors;
public static class DomainErrors
{
    public static readonly Error TooManyTagsError = new Error(
        "Post.TooManyTagsError",
        "No se puede sobrepasar el maximo de tags por Post");

    public static readonly Error ObjectEmpty = new Error(
        "ObjectEmpty",
        "El object no puede estar vacio");

    public static readonly Error MaximunLenghtExceeded = new Error(
        "MaximunLenghtExceeded",
        "La longitud maxima del objecto ha sido sobrepasado");
}
