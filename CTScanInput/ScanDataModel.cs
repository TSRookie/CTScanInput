namespace CTScanInput;

internal class ScanDataModel
{
    public string FileName { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;

    public string GetTimestampString() => Timestamp.ToString("yyyy-MM-dd HH:mm");

    public string CellID { get; set; }
    public string DeviceName { get; set; }

    public string ProjectName { get; set; }
    public string CellName { get; set; }

    public string Material { get; set; }

    public string OptionalText { get; set; }

    public string SecurityLevel { get; set; }

}