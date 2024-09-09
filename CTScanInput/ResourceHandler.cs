namespace CTScanInput
{
    internal static class ResourceHandler
    {
        public static List<string> GetMaterials()
        {
            var materials = File.ReadAllLines(getMaterialFile());
            return materials.ToList();
        }

        public static void SaveMaterials(List<string> materials)
        {
            File.WriteAllText(getMaterialFile(), string.Join(Environment.NewLine, materials));
        }

        private static string getMaterialFile()
        {
            var resourcePath = Path.GetDirectoryName(Application.ExecutablePath);
            if (resourcePath is null)
            {
                return string.Empty;
            }
            var materialsFile = Path.Combine(resourcePath, "Materials.txt");
            if (!File.Exists(materialsFile))
            {
                return string.Empty;
            }
            return materialsFile;
        }
    }
}
