using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS02; Initial Catalog=DbYTAKutuphane; Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1");
            }
            catch (Exception)
            {
                MessageBox.Show("Baðlantý Hatasý!");
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
