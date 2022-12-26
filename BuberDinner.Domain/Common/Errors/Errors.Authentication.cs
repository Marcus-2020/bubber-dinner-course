using ErrorOr;

namespace BuberDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        
        private static Error _invalidCredentials = Error.Validation(
            code: "User.InvalidLogin",
            description: "E-mail or password is incorrect.");

        public static Error InvalidCredentials => _invalidCredentials;
    }
}