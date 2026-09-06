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
            if (float.TryParse(timeInput.Text, out float days))
            {
                float hours = days * 24;
                float minutes = hours * 60;

                resultLabel.Text = $"{hours:N0} hours - that's {minutes:N0} minutes";
            }
            else
            {
                resultLabel.Text = "Please enter a valid number.";
            }

            SemanticScreenReader.Announce(resultLabel.Text);
        }
    }
}