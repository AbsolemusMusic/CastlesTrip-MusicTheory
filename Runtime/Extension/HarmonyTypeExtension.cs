namespace MusicTheory.Audio.Harmony
{
    public static class HarmonyTypeExtension
    {
        public static int[] GetHarmonyScale(this HarmonyType harmony)
        {
            var harmonyScale = new HarmonyScale(harmony);
            return harmonyScale.GetScale();
        }

        public static string GetName(this HarmonyType harmony)
        {
            string raw = harmony.ToString();
            raw = raw.Replace("_", " ");
            return raw;
        }
    }
}