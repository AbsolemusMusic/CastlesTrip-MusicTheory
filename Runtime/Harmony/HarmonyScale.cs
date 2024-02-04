namespace MusicTheory.Audio.Harmony
{
    public class HarmonyScale
    {
        private HarmonyType harmonyType;

        private int[] Major = { 0, 2, 4, 5, 7, 9, 11 };
        private int[] MajorPentatonic = { 0, 2, 4, 7, 9 };
        private int[] MinorHarmonic = { 0, 2, 3, 5, 7, 8, 11 };
        private int[] MinorHungarian = { 0, 2, 3, 6, 7, 8, 11 };
        private int[] MinorMelodic = { 0, 2, 3, 5, 7, 9, 11 };
        private int[] MinorAeolian = { 0, 2, 3, 5, 7, 8, 10 };
        private int[] MinorNeapolitan = { 0, 1, 3, 5, 7, 8, 11 };
        private int[] MinorPentatonic = { 0, 3, 5, 7, 10 };
        private int[] Arabic = { 0, 1, 4, 5, 7, 8, 11 };
        private int[] Blues = { 0, 3, 5, 6, 7, 10 };
        private int[] Dominished = { 0, 2, 3, 5, 6, 8, 9, 11 };
        private int[] DominantBebop = { 0, 2, 4, 5, 7, 9, 10, 11 };
        private int[] Dorian = { 0, 2, 3, 5, 7, 9, 10 };
        private int[] Enigmatic = { 0, 1, 4, 6, 8, 10, 11 };
        private int[] JapaneseInsen = { 0, 1, 5, 7, 10 };
        private int[] Locrian = { 0, 1, 3, 5, 6, 8, 10 };
        private int[] Lydian = { 0, 2, 4, 6, 7, 9, 11 };
        private int[] Mixolydian = { 0, 2, 4, 5, 7, 9, 10 };
        private int[] Neapolitan = { 0, 1, 3, 5, 7, 9, 11 };
        private int[] Phrygian = { 0, 1, 3, 5, 7, 8, 10 };
        private int[] MajorChord = { 0, 4, 7 };
        private int[] Major7thChord = { 0, 4, 7, 11 };
        private int[] MinorChord = { 0, 3, 7 };
        private int[] Minor7thChord = { 0, 3, 7, 10 };

        public HarmonyScale(HarmonyType harmonyType)
        {
            this.harmonyType = harmonyType;
        }

        public int[] GetScale(HarmonyType harmonyType)
        {
            this.harmonyType = harmonyType;
            return GetScale();
        }

        public int[] GetScale()
        {
            switch (harmonyType)
            {
                case HarmonyType.Major: return Major;
                case HarmonyType.Major_Pentatonic: return MajorPentatonic;
                case HarmonyType.Minor_Harmonic: return MinorHarmonic;
                case HarmonyType.Minor_Hungarian: return MinorHungarian;
                case HarmonyType.Minor_Melodic: return MinorMelodic;
                case HarmonyType.Minor_Aeolian: return MinorAeolian;
                case HarmonyType.Minor_Neapolitan: return MinorNeapolitan;
                case HarmonyType.Minor_Pentatonic: return MinorPentatonic;
                case HarmonyType.Arabic: return Arabic;
                case HarmonyType.Blues: return Blues;
                case HarmonyType.Dominished: return Dominished;
                case HarmonyType.Dominant_Bebop: return DominantBebop;
                case HarmonyType.Dorian: return Dorian;
                case HarmonyType.Enigmatic: return Enigmatic;
                case HarmonyType.Japanese_Insen: return JapaneseInsen;
                case HarmonyType.Locrian: return Locrian;
                case HarmonyType.Lydian: return Lydian;
                case HarmonyType.Mixolydian: return Mixolydian;
                case HarmonyType.Neapolitan: return Neapolitan;
                case HarmonyType.Phrygian: return Phrygian;
                case HarmonyType.Major_Chord: return MajorChord;
                case HarmonyType.Major_7th_Chord: return Major7thChord;
                case HarmonyType.Minor_Chord: return MinorChord;
                case HarmonyType.Minor_7th_Chord: return Minor7thChord;
                default: return Major;
            }
        }
    }
}