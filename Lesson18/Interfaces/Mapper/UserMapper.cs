namespace Lesson18.Interfaces.Mapper
{
    public class UserDto
    {
        public string FullName { get; set; }
    }

    public class UserEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class UserMapper : IMapper<UserEntity, UserDto>
    {
        public UserDto Map (UserEntity source)
        {
            return new UserDto { FullName = $"{source.Name} {source.Surname}" };
        }
    }
}
