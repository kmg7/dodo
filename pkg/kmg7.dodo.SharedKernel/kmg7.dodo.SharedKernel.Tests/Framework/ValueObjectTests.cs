using Shouldly;

namespace kmg7.dodo.SharedKernel.Tests.Framework;
public class ValueObjectTests
{
    [Fact]
    public void ValueObjects_with_same_values_should_be_equal()
    {
        var valueObject1 = new TestValueObject(1, ["a"]);
        var valueObject2 = new TestValueObject(1, ["a"]);

        valueObject1.ShouldBe(valueObject2);
    }

    [Theory]
    [InlineData(1, "a", "b", 2, "a", "b")]
    [InlineData(2, "a", "b", 2, "b", "a")]
    public void ValueObjects_with_different_values_should_not_be_equal(int numA, string textA1, string textA2, int numbB, string textB1, string textB2)
    {
        var valueObject1 = new TestValueObject(numA, [textA1, textA2]);
        var valueObject2 = new TestValueObject(numbB, [textB1, textB2]);

        valueObject1.ShouldNotBe(valueObject2);
    }

    [Fact]
    public void ValueObjects_with_same_values_should_have_equal_hash_codes()
    {
        var valueObject1 = new TestValueObject(1, ["a"]);
        var valueObject2 = new TestValueObject(1, ["a"]);

        var valueObject1HashCode = valueObject1.GetHashCode();
        var valueObject2HashCode = valueObject2.GetHashCode();

        valueObject1HashCode.ShouldBe(valueObject2HashCode);
    }

    [Theory]
    [InlineData(1, "a", "b", 2, "a", "b")]
    [InlineData(2, "a", "b", 2, "b", "a")]
    public void ValueObjects_with_different_values_should_not_have_equal_hash_codes(int numA, string textA1, string textA2, int numbB, string textB1, string textB2)
    {
        var valueObject1 = new TestValueObject(numA, [textA1, textA2]);
        var valueObject2 = new TestValueObject(numbB, [textB1, textB2]);

        var valueObject1HashCode = valueObject1.GetHashCode();
        var valueObject2HashCode = valueObject2.GetHashCode();

        valueObject1HashCode.ShouldNotBe(valueObject2HashCode);
    }
}
