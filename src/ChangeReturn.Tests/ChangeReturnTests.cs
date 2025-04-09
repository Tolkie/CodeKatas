using FluentAssertions;
using Xunit;

namespace ChangeReturn.Tests;

public class ChangeReturnTests
{
    private readonly ChangeReturn changeReturn = new();

    [Fact]
    public void ChangeReturn_returns_empty_array_when_no_change_should_be_returned()
    {
        var result = changeReturn.GetChange(0, 0);
        result.Length.Should().Be(0);
    }

    [Fact]
    public void ChangeReturn_returns_three_dollars_and_a_nickel()
    {
        var expected = new List<Change>
        {
            new() {Denomination = Denomination.OneDollar, Number = 3},
            new() {Denomination = Denomination.Nickel, Number = 1}
        };

        var result = changeReturn.GetChange((decimal) 1.95, (decimal) 5.00);

        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ChangeReturn_returns_one_of_each_denomination()
    {
        var expected = new List<Change>
        {
            new() {Denomination = Denomination.HundredDollar, Number = 1},
            new() {Denomination = Denomination.FiftyDollar, Number = 1},
            new() {Denomination = Denomination.TwentyDollar, Number = 1},
            new() {Denomination = Denomination.TenDollar, Number = 1},
            new() {Denomination = Denomination.FiveDollar, Number = 1},
            new() {Denomination = Denomination.OneDollar, Number = 1},
            new() {Denomination = Denomination.HalfDollar, Number = 1},
            new() {Denomination = Denomination.Quarter, Number = 1},
            new() {Denomination = Denomination.Dime, Number = 1},
            new() {Denomination = Denomination.Nickel, Number = 1},
            new() {Denomination = Denomination.Cent, Number = 1}
        };

        var result = changeReturn.GetChange((decimal)13.09, (decimal)200.00);

        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ChangeReturn_returns_one_dime_and_one_nickel()
    {
        var expected = new List<Change>
        {
            new() {Denomination = Denomination.Dime, Number = 1},
            new() {Denomination = Denomination.Nickel, Number = 1}
        };

        var result = changeReturn.GetChange((decimal)0.85, (decimal)1.00);

        result.Should().BeEquivalentTo(expected);          
    }
}