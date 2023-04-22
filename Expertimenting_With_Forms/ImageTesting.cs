using Microsoft.VisualBasic;

namespace Expertimenting_With_Forms
{
    public partial class ImageTesting : Form
    {
        // List to store the names of the images
        List<string> imageNames;

        // Dictionary to store the image name and its corresponding url
        Dictionary<string, string> images;

        public ImageTesting()
        {
            InitializeComponent();

            // Initialize the list and dictionary
            imageNames = new List<string>();
            images = new Dictionary<string, string>();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            // Open the file dialog to choose the image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (.jpg, .jpeg, .png)|*.jpg;*.jpeg;*.png";

            // If an image is chosen
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Prompt user to enter the picture name
                string pictureName = Interaction.InputBox("Please enter the picture name:", "Name Input", "").ToLower();
                string url = ofd.FileName;

                // Set the picture box to display the chosen image
                picbPicture.Image = new Bitmap(url);

                // Add the picture name and url to the dictionary
                images.Add(pictureName, url);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Prompt user to enter the picture name
            string pictureName = Interaction.InputBox("Please enter the picture name:", "Name Input", "").ToLower();

            bool found = false;

            // Iterate through the dictionary to find the image with the given picture name
            for (int i = 0; i < images.Count; i++)
            {
                if (images.ContainsKey(pictureName))
                {
                    found = true;
                }
            }

            if (found)
            {
                // Set the picture box to display the chosen image
                picbPicture.Image = new Bitmap(images[pictureName]);
            }
            else
            {
                MessageBox.Show("Picture does not exist.");
            }
        }

        private void btnCloseImage_Click(object sender, EventArgs e)
        {
            // Remove the image from the picture box
            picbPicture.Image = null;
        }
    }
}
