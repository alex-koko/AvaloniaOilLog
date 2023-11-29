using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace AvaloniaCalc;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var input = $"{InputDate.Text} | {InputOil.Text} | {InputMoney.Text} | {InputMemo.Text} |";
        
        Result.Text = input;
        
    }
}