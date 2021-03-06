﻿using System.Collections.Immutable;
using NadekoBot.Common;

namespace NadekoBot.Modules.Gambling.Common.WheelOfFortune
{
    public class WheelOfFortune
    {
        private static readonly NadekoRandom _rng = new NadekoRandom();

        private static readonly ImmutableArray<string> _emojis = new string[] {
            "⬆",
            "↖",
            "⬅",
            "↙",
            "⬇",
            "↘",
            "➡",
            "↗" }.ToImmutableArray();

        public static readonly ImmutableArray<float> Multipliers = new float[] {
            1.5f,
            1f,
            0.1f,
            0f,
            0.2f,
            0.5f,
            2.5f,
            2f,

        }.ToImmutableArray();

        public int Result { get; }
        public string Emoji => _emojis[Result];
        public float Multiplier => Multipliers[Result];

        public WheelOfFortune()
        {
            this.Result = _rng.Next(0, 8);
        }
    }
}
