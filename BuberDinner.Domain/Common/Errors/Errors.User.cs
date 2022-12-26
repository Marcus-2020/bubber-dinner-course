using ErrorOr;

namespace BuberDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class User
    {
        private static Error _duplicateEmail = Error.Conflict(
            code: "User.DuplicateEmail",
            description: "The email already exists.");
        
        public static Error DuplicateEmail => _duplicateEmail;
    }
}