namespace CrossMacro.UI.Services.Desktop;

internal interface ITrayIconHandle : IDisposable
{
    public event EventHandler? Clicked;
    public bool IsVisible { get; set; }
    public bool HasNativeMenuExporter { get; }
    public string? GetToolTipText();
    public void SetToolTipText(string? value);
}
