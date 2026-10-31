using Avalonia.Controls;
using Avalonia.Platform;

namespace CrossMacro.UI.Services.Desktop;

internal interface ITrayIconBackend
{
    public ITrayIconHandle Create(WindowIcon icon, NativeMenu menu, string toolTipText);
}

