using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Platform.Storage;
using MFAAvalonia.Helper;
using System.Linq;
using System;

namespace MFAAvalonia.Views.UserControls.Settings;

public partial class GameSettingsUserControl : UserControl
{
    public GameSettingsUserControl()
    {
        DataContext = Instances.GameSettingsUserControlModel;
        InitializeComponent();
        Loaded += OnLoaded;
    }
    
    private void OnLoaded(object? sender, EventArgs e)
    {
        if (OperatingSystem.IsAndroid())
        {
            TaskFocusModeCard.IsVisible = false;
        }
    }
}