using Lesson18.Interfaces.Devices;
using Lesson18.Interfaces.Mapper;
using Lesson18.Interfaces.Repository;

namespace Lesson18.Interfaces
{
    public static class InterfacesDemo
    {
        public static void Show ()
        {
            Console.WriteLine("Обычный интерфейс:");
            IDevice.ShowDeviceType();
            IDevice lamp = new Lamp { Name = "Настольная лампа" };
            lamp.TurnOn();
            lamp.TurnOff();
            Console.WriteLine();

            Console.WriteLine("Дженерик интерфейс с ограничением:");
            IRepository<UserEntity> repo = new Repository<UserEntity>();

            var jane = new UserEntity { Name = "Jane", Surname = "Doe" };
            repo.Add(jane);

            var newUser = repo.CreateNew();
            newUser.Name = "Новый пользователь";
            repo.Add(newUser);
            Console.WriteLine();

            Console.WriteLine("Дженерик интерфейс с двумя типами:");
            IMapper<UserEntity, UserDto> mapper = new UserMapper();
            var dto = mapper.Map(jane);
            Console.WriteLine($"Преобразован в DTO: {dto.FullName}");
        }
    }
}
