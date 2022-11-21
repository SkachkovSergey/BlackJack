namespace Common
{
    /// <summary>Интерфейс игры Блак Джек.</summary>
    public interface IBlackJack
    {
        /// <summary>Начало новой игры.</summary>
        void Restart();

        /// <summary>"Ещё" - игрок просит карту.</summary>
        void Hit();

        /// <summary>Метод <see cref="Hit"/> может выполняться.</summary>
        /// <returns><see langword="true"/>, если игрок не вызывал <see cref="Enough"/>, если у игрока нет перебора.</returns>
        bool CanHi();

        /// <summary>"Хватит" - игрок набрал себе достаточно карт. Дальше карты набирает дилер.</summary>
        void Enough();

        /// <summary>Происходит при любых изменениях в игре.</summary>

        event EventHandler<BlackJackMessageArgs> Message;
    }
}