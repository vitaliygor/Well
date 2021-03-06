﻿namespace Well.Objects
{
    public class MiddleChestDeck : Deck
    {
        public const string Prefix = "M";

        public MiddleChestDeck() : this(0)
        {
        }

        public MiddleChestDeck(int name)
            : base(Prefix + name, DeckType.Middle)
        {
        }
    }
}