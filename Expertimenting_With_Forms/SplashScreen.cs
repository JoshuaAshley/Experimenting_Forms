using Timer = System.Windows.Forms.Timer;

namespace Expertimenting_With_Forms
{
    public partial class SplashScreen : Form
    {
        // Initialize variables

        // Counter variable for progress bar
        private int k = 0;

        // Timer object to update progress bar
        private Timer timer;

        public SplashScreen()
        {
            InitializeComponent();

            // Create a new Timer instance and start it

            // Initialize the Timer object
            this.timer = new Timer();

            // Set the timer interval to 100ms
            this.timer.Interval = 100;

            // Register the timer_Tick event handler
            this.timer.Tick += new EventHandler(timer_Tick);

            // Start the timer
            this.timer.Start();
        }

        // Event handler for timer tick
        public async void timer_Tick(object sender, EventArgs e)
        {
            // Increment the progress counter
            k++;
            // Check if progress is less than 100%
            if (k < 101)
            {
                // Update the progress bar value
                pbPercent.Value = k;
            }
            // Progress has reached 100%
            else
            {
                // Stop the timer
                this.timer.Stop();

                // Wait for 500ms before closing the form
                await Task.Delay(500);

                // Close the form
                this.Close();
            }
        }
    }
}

