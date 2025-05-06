namespace Lesson18.Interfaces.Mapper
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map (TSource source);
    }
}
