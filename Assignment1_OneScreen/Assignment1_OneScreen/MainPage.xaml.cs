namespace Assignment1_OneScreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertClicked(object? sender, EventArgs e)
        {
            float days = float.Parse(timeInput.Text);

            float hours = days * 24;
            float minutes = hours * 60;

            resultLabel.TextColor = Colors.White;
            resultLabel.FontAttributes = FontAttributes.None;
            resultLabel.Text = $"{hours:N0} hours - that's {minutes:N0} minutes";

            SemanticScreenReader.Announce(resultLabel.Text);
        }
    }
}