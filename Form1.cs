using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadAssincrono
{
    public partial class Form1 : Form
    {
        string site;

        public Form1()
        {
            InitializeComponent();

            this.btnLer.Click += async (o, e) =>
            {
                await btnLer_Click(o, e);
            };

            site = "";
        }

        private async Task btnLer_Click(object sender, EventArgs e)
        {
            try
            {
                lstStatus.Items.Add("Lendo site...");
                lstStatus.Refresh();

                var web = new HttpClient();

                site = await web.GetStringAsync(new Uri(txtURL.Text));

                if (site != "" && txtPalavra.Text != "")
                {
                    lstStatus.Items.Add("Site Lido");
                    btnContar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnContar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "")
            {
                int total = await ContarPalavras(txtPalavra.Text);
                //int total = Regex.Matches(site, txtPalavra.Text).Count;
                lstStatus.Items.Add($"Total de ocorrencias da palavra {txtPalavra.Text} = {total}");
            }
            else
            {
                lstStatus.Items.Add("Palavra não encontrada");
            }
        }

        private async Task<int> ContarPalavras(string palavra)
        {
            return await Task.Run(() => Regex.Matches(site, palavra).Count);
        }
    }
}