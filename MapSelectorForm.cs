using System;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Required for ComVisible

namespace EShiftApp
{
    // Make the class visible to COM, which allows JavaScript to call its methods via window.external
    [ComVisible(true)]
    public partial class MapSelectorForm : Form
    {
        private string selectedAddress = "";
        public string SelectedAddress => selectedAddress; // Public property to get the selected address

        public MapSelectorForm()
        {
            InitializeComponent();
            // Crucial: Expose this form object to the JavaScript environment
            // The JavaScript code can then call window.external.SetAddress(...)
            webBrowser1.ObjectForScripting = this;
        }

        private void MapSelectorForm_Load(object sender, EventArgs e)
        {
            // Construct the path to your map.html file
            // It assumes map.html is in the same directory as your executable
            string mapHtmlPath = System.IO.Path.Combine(Application.StartupPath, "map.html");
            // Navigate the WebBrowser control to your HTML file
            webBrowser1.Navigate(mapHtmlPath);
        }

        /// <summary>
        /// This method is called from JavaScript (window.external.SetAddress).
        /// It receives the geocoded address, sets it, and closes the form with DialogResult.OK.
        /// </summary>
        /// <param name="address">The formatted address string from Google Maps Geocoding.</param>
        public void SetAddress(string address)
        {
            selectedAddress = address; // Store the address
            DialogResult = DialogResult.OK; // Set dialog result
            this.Close(); // Close the form
        }

        // You can add more event handlers for webBrowser1 if needed,
        // for example, to handle navigation errors or when the document is fully loaded.
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Optional: You can add logic here if you need to do something once the HTML document is fully loaded.
            // For instance, you could inject JavaScript or check for errors.
        }
    }
}