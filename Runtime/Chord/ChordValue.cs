namespace MusicTheory.Audio.Harmony
{
    public static class ChordValue
    {
        public static int[] IDs(this ChordType type)
        {
            switch (type)
            {
                case ChordType.Augmented: return new[] { 0, 4, 8 };
                case ChordType.Diminished: return new[] { 0, 3, 6 };
                case ChordType.Fifth: return new[] { 0, 7 };
                case ChordType.Fifth9: return new[] { 0, 7, 14 };
                case ChordType.FifthOctave: return new[] { 0, 7, 12 };
                case ChordType.Major: return new[] { 0, 4, 7 };
                case ChordType.Major7th: return new[] { 0, 4, 7, 11 };
                case ChordType.Minor: return new[] { 0, 3, 7 };
                case ChordType.Minor7th: return new[] { 0, 3, 7, 10 };
                case ChordType.Minor9th: return new[] { 0, 3, 7, 10, 14 };
                case ChordType.Octave: return new[] { 0, 12 };
                case ChordType.Suspended2: return new[] { 0, 2, 7 };
                case ChordType.Suspended4: return new[] { 0, 5, 7 };
                default: return new int[0];
            }
        }

        public static string Title(this ChordType type)
        {
            switch (type)
            {
                case ChordType.Augmented: return "Augmented";
                case ChordType.Diminished: return "Diminished";
                case ChordType.Fifth: return "Fifth";
                case ChordType.Fifth9: return "Fifth9";
                case ChordType.FifthOctave: return "FifthOctave";
                case ChordType.Major: return "Major";
                case ChordType.Major7th: return "Major7th";
                case ChordType.Minor: return "Minor";
                case ChordType.Minor7th: return "Minor7th";
                case ChordType.Minor9th: return "Minor9th";
                case ChordType.Octave: return "Octave";
                case ChordType.Suspended2: return "Suspended2";
                case ChordType.Suspended4: return "Suspended4";
                default: return "";
            }
        }
    }
}