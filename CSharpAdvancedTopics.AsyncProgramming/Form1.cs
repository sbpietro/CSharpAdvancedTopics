using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAdvancedTopics.AsyncProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //DownloadHtmlAsync("https://globoesporte.globo.com/");
            //var html = GetHtml("https://globoesporte.globo.com/");
            //var html = await GetHtmlAsync("https://globoesporte.globo.com/");
            
            var htmlTask = GetHtmlAsync("https://globoesporte.globo.com/");
            MessageBox.Show("Waiting for the task to complete");
            var html = await htmlTask;
            MessageBox.Show(html.Substring(0, 300));
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\stefa\Desktop\Projetos\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\stefa\Desktop\Projetos\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
