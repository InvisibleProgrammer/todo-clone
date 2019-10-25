using Xunit;

namespace TodoClone.Application.Test
{
    public sealed class RegistrationTests
    {
        [Fact]
        public void RegisterUser_WithPassword_Success()
        {
            IUserService userService = new UserService();

            userService.Register("test@test.com", "S3cretP@ssw0rd");

            // No assertion. It is expected to not have exception. It just works.
        }
    }
}
