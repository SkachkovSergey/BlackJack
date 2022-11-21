namespace Common
{
    /// <summary>Аргумент события <see cref="IBlackJack.Message"/>.</summary>
    public class BlackJackMessageArgs : EventArgs
    {
        /// <summary>Что произошло.</summary>
        public BlackJackMassageType MessageType { get; }

        /// <summary>Карта, если выдаётся карта.</summary>
        public Card? Card { get; }

        /// <summary>Сумма, включая выданную карту.</summary>
        public int? Sum { get; }


        private BlackJackMessageArgs(BlackJackMassageType mode, Card? card, int? sum)
        {
            MessageType = mode;
            Card = card;
            Sum = sum;
        }

        /// <summary>Аргумент для сообщения о новой игре.</summary>
        public static BlackJackMessageArgs Restart { get; } = new BlackJackMessageArgs(BlackJackMassageType.Restart, null, null);

        /// <summary>Аргумент для сообщения о выиграше игрока.</summary>
        public static BlackJackMessageArgs PlayerWin { get; } = new BlackJackMessageArgs(BlackJackMassageType.PlayerWin, null, null);

        /// <summary>Аргумент для сообщения о проигрыше игрока.</summary>
        public static BlackJackMessageArgs LosingPlayer { get; } = new BlackJackMessageArgs(BlackJackMassageType.LosingPlayer, null, null);

        /// <summary>Аргумент для сообщения о выдачи карты игроку.</summary>
        /// <param name="card">Выдаваемая карта.</param>
        /// <param name="sum">Сумма очков у игрока, включая выдаваемую карту.</param>
        /// <returns>Аргумент с заданными свойствами.</returns>
        public static BlackJackMessageArgs PlayerСard(Card card, int sum) => new BlackJackMessageArgs(
            BlackJackMassageType.PlayerСard,
            card ?? throw new ArgumentNullException(nameof(card)),
            sum > 0 ? sum : throw new ArgumentOutOfRangeException(nameof(sum), "Должна быть больше нуля."));

        /// <summary>Аргумент для сообщения о выдачи карты дилеру.</summary>
        /// <param name="card">Выдаваемая карта.</param>
        /// <param name="sum">Сумма очков у дилера, включая выдаваемую карту.</param>
        /// <returns>Аргумент с заданными свойствами.</returns>
        public static BlackJackMessageArgs DilerCard(Card card, int sum) => new BlackJackMessageArgs(BlackJackMassageType.DilerCard, card, sum);
    }
}