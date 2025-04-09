using Xunit;
using FluentAssertions;

namespace PokerHandRanking.Tests;

public class PokerHandRankingTests
{
    private readonly PokerHandRanking pokerHandRanking = new();

    [Fact]
    public void PokerHandRanking_returns_royal_flush()
    {
        var hand = new List<Card>
        {
            new() { Rank = Rank.Ace, Suit = Suit.Club },
            new() { Rank = Rank.King, Suit = Suit.Club },
            new() { Rank = Rank.Queen, Suit = Suit.Club },
            new() { Rank = Rank.Jack, Suit = Suit.Club },
            new() { Rank = Rank.Ten, Suit = Suit.Club }
        };

        var result = pokerHandRanking.RankHand(hand);

        result.Should().Be("Royal Flush");
    }
}