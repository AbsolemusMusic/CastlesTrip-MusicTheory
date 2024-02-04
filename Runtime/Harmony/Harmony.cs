namespace MusicTheory.Audio.Harmony
{
    public class Harmony
    {
        private HarmonyType harmonyType;

        public Harmony(HarmonyType harmonyType)
        {
            this.harmonyType = harmonyType;
        }

        public int GetOctaveID(int itemID)
        {
            int[] scale = harmonyType.GetHarmonyScale();
            return itemID / scale.Length;
        }

        public int GetNoteID(int itemID)
        {
            int[] scale = harmonyType.GetHarmonyScale();
            itemID = itemID % scale.Length;
            return scale[itemID];
        }
    }
}