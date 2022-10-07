using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMOveAp.Formss
{
    public partial class FormMain : Form
    {

        const string apiKey = " b18e2da9";
        
        const string API_KEY = $"http://www.omdbapi.com/?apikey={apiKey}&";
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using HttpClient httpClient = new HttpClient();

            
            httpClient.GetStringAsync(API_KEY);

        }
    }
}
