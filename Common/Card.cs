using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Common
{
    [DebuggerDisplay($"{{{nameof(GetDisplay)}(),nq}}")]
    public class Card
    {
        public CardSuit Suit { get; }
        public CardRank Rank { get; }

        private Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public static ReadOnlyCollection<Card> FullDeckOfCards { get; }
        public static ReadOnlyCollection<Card> CardsWithoutSuits { get; }

        static Card()
        {
            List<Card> fullDeckOfCards = new List<Card>(56);
            List<Card> cardsWithoutSuits = new List<Card>(14);

            foreach (var suit in Enum.GetValues<CardSuit>())
            {
                foreach (var rank in Enum.GetValues<CardRank>())
                {
                    if (rank == CardRank.None)
                        continue;

                    var list = suit == CardSuit.None ? cardsWithoutSuits : fullDeckOfCards;

                    list.Add(new Card(suit, rank));
                }
            }

            CardsWithoutSuits = Array.AsReadOnly(cardsWithoutSuits.ToArray());
            FullDeckOfCards = Array.AsReadOnly(fullDeckOfCards.ToArray());
        }

        public override string ToString() => $"{Rank} {Suit}";

        public string GetDisplay() => $"{nameof(Rank)}: {Rank}; {nameof(Suit)}: {Suit}";

        private static readonly Random random = new Random();

        public static IEnumerable<Card> GetRandomFullDeck() =>
            FullDeckOfCards
            .OrderBy(_ => random.Next());

        public static IEnumerable<Card> GetRandomFullDeckWithoutJoker() =>
            GetRandomFullDeck()
            .Where(card => card.Rank != CardRank.Joker);

        public static IEnumerable<Card> GetRandomShortDeck() =>
            GetRandomFullDeckWithoutJoker()
            .Where(card => (int)card.Rank >= (int)CardRank.Six);

    }
}