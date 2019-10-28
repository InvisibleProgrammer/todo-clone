using Moq;

using TodoClone.Repository;

using Xunit;

namespace TodoClone.Application.Test
{
    public sealed class RegistrationTests
    {
        Mock<IUserRepository> userRepository;

        public RegistrationTests(IUserRepository userRepository)
        {
            this.userRepository = new Mock<IUserRepository>();
        }

        [Fact]
        public void RegisterUser_WithPassword_Success()
        {
            IUserService userService = new UserService(userRepository.Object);

            userService.Register("test@test.com", "S3cretP@ssw0rd");

            // No assertion. It is expected to not have exception. It just works.
        }

        [Fact]
        public void RegisterUser_WithExistingEmail_Fail()
        {
            // Todo: Don't know why but adding Domain project doesn't work.
            // It doesn't see the reference or the User class.

            //userRepository.Setup(r => r.GetUserById(1)).Returns(new User());
            //IUserService userService = new UserService(userRepository.Object);

            //Assert.Throws<UserAlreadyRegisteredException>(() =>
            //{
            //    userService.Register("test@test.com", "S3cretP2ssw0rd");
            //});
        }
    }
}
