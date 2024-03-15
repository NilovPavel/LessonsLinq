using LessonsLinq;

internal class EmplEqualityComparer : IEqualityComparer<Employee>
{
    bool IEqualityComparer<Employee>.Equals(Employee? x, Employee? y)
    {
        return x.Name.Equals(y.Name);
    }

    int IEqualityComparer<Employee>.GetHashCode(Employee obj)
    {
        return 0;
    }
}