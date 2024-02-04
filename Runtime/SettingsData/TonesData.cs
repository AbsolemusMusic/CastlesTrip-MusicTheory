namespace MusicTheory.Audio.Harmony
{
    public enum Tones { C, CSharp, D, DSharp, E, F, FSharp, G, GSharp, A, ASharp, B }

    static class TonesExtensions
    {
        public static string Name(this Tones tone)
        {
            switch (tone)
            {
                case Tones.C: return "C";
                case Tones.CSharp: return "C#";
                case Tones.D: return "D";
                case Tones.DSharp: return "D#";
                case Tones.E: return "E";
                case Tones.F: return "F";
                case Tones.FSharp: return "F#";
                case Tones.G: return "G";
                case Tones.GSharp: return "G#";
                case Tones.A: return "A";
                case Tones.ASharp: return "A#";
                case Tones.B: return "B";
                default: return "C";
            }
        }

        public static Tones GetToneByID(int keyNum)
        {
            int clamp = keyNum % 12;
            switch (clamp)
            {
                case 0: return Tones.C;
                case 1: return Tones.CSharp;
                case 2: return Tones.D;
                case 3: return Tones.DSharp;
                case 4: return Tones.E;
                case 5: return Tones.F;
                case 6: return Tones.FSharp;
                case 7: return Tones.G;
                case 8: return Tones.GSharp;
                case 9: return Tones.A;
                case 10: return Tones.ASharp;
                case 11: return Tones.B;
                default: return 0;
            }
        }
    }
}
