using kmg7.dodo.SharedKernel.Framework;

namespace kmg7.dodo.SharedKernel.Tests.Framework;
public class TestValueObject : ValueObject
{
    public int IntegerValue { get; }
    public List<string> Strings { get; }

    public TestValueObject(int integerValue, List<string> strings)
    {
        IntegerValue = integerValue;
        Strings = strings;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return IntegerValue;
        foreach (var item in Strings)
        {
            yield return item;
        }
    }
}
