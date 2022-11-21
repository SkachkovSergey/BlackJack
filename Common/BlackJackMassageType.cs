namespace Common
{
    /// <summary>Различные типы сообщений.</summary>
    public enum BlackJackMassageType
    {
        /// <summary>Незадан тип.</summary>
        None,
        /// <summary>Новая игра.</summary>
        Restart,
        /// <summary>Карта игроку.</summary>
        PlayerСard,
        /// <summary>Карта дилеру.</summary>
        DilerCard,
        /// <summary>Игрок выиграл.</summary>
        PlayerWin,
        /// <summary>Игрок проиграл.</summary>
        LosingPlayer
    }
}