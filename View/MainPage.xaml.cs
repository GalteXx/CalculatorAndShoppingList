namespace MauiApp1.View;

public partial class MainPage : ContentPage
{
    private char _action;
    private double? _prevNumber;
    public MainPage()
    {
        InitializeComponent();
    }

    private void DigitClicked(object sender, EventArgs e)
    {
        DisplayLabel.Text += (sender as Button).Text;
    }

    private void ActionClicked(object sender, EventArgs e)
    {
        _prevNumber = Convert.ToDouble(DisplayLabel.Text);
        _action = Convert.ToChar((sender as Button).Text);
        DisplayLabel.Text += '\n';
    }
    private void EqClicked(object sender, EventArgs e)
    {
        if (DisplayLabel.Text.Split('\n').Last() == "" || _prevNumber is null)
            return;

        DisplayLabel.Text = _action switch
        {
            '+' => (_prevNumber + Convert.ToDouble(DisplayLabel.Text.Split('\n').Last())).ToString(),
            '÷' => (_prevNumber / Convert.ToDouble(DisplayLabel.Text.Split('\n').Last())).ToString(),
            '×' => (_prevNumber * Convert.ToDouble(DisplayLabel.Text.Split('\n').Last())).ToString(),
            '-' => (_prevNumber - Convert.ToDouble(DisplayLabel.Text.Split('\n').Last())).ToString(),
            _ => throw new NotImplementedException("This action was not implemented")
        };
    }
    private void ResetClicked(object sender, EventArgs e)
    {
        DisplayLabel.Text = "";
    }
}
