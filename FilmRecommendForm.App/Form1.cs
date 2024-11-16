using FilmRecommend.Data;
using FilmRecommend.Entities;
using System.Data;
using System.Text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Mail;
using System.Net;



namespace FilmRecommendForm.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomizeComponents(); // Özelleştirmek için bileşenleri ayarlıyoruz.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void CustomizeComponents() // Bileşenleri özelleştiren metot.
        {
            // Formun arka plan rengini ayarlıyoruz.

            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // Form kenar stilini ayarlıyoruz.

            

            // Film kategorileri ComboBox'ını özelleştiriyoruz.
            comboBoxMovieCategories.DropDownStyle = ComboBoxStyle.DropDownList; // Sadece liste öğelerinden seçim yapmasını sağlıyoruz.
            comboBoxMovieCategories.ForeColor = System.Drawing.Color.Black; // Yazı rengini siyah yapıyoruz.

            // Film alt kategorileri ComboBox'ını özelleştiriyoruz.
            comboBoxSubCategories.DropDownStyle = ComboBoxStyle.DropDownList; // Sadece liste öğelerinden seçim yapmasını sağlıyoruz.
            comboBoxSubCategories.ForeColor = System.Drawing.Color.Black; // Yazı rengini siyah yapıyoruz.

            // DataGridView bileşenini özelleştiriyoruz.
            dataGridViewMovies.BackgroundColor = System.Drawing.Color.White; // Arka plan rengini beyaz yapıyoruz.
            dataGridViewMovies.BorderStyle = BorderStyle.None; // Kenarlık stilini kaldırıyoruz.
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue; // Başlık arka plan rengini mavi yapıyoruz.
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black; // Başlık yazı rengini siyah yapıyoruz.
            dataGridViewMovies.EnableHeadersVisualStyles = false; // Başlık stilini özelleştirmeyi etkinleştiriyoruz.
        }

        private void LoadCategories() // Film kategorilerini yükleyen metot.
        {
            using (var context = new FilmMoodDBContext())
            {
                var categories = context.MovieCategories.ToList(); // Veritabanından film kategorilerini alıyoruz.

                comboBoxMovieCategories.DataSource = categories; // Kategorileri ComboBox'a veri kaynağı olarak bağlıyoruz.
                comboBoxMovieCategories.DisplayMember = "CategoryName"; // Görüntülenecek alanı belirliyoruz.
                comboBoxMovieCategories.ValueMember = "MovieCategoryID"; // Değerini belirliyoruz.
            }
        }

        private void comboBoxMovieCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxMovieCategories.SelectedItem != null) // Seçili bir öğe var mı kontrol et
            {
                // Seçilen öğeyi MovieCategory nesnesi olarak al
                var selectedCategory = (MovieCategory)comboBoxMovieCategories.SelectedItem;

                // MovieCategoryID'yi al
                int selectedCategoryId = selectedCategory.MovieCategoryID;

                // Alt kategorileri yükle
                LoadSubCategories(selectedCategoryId);
            }
        }

        private void LoadSubCategories(int categoryId) // Alt kategorileri yükleyen metot.
        {
            using (var context = new FilmMoodDBContext()) // Veritabanı bağlamını kullanarak açıyoruz.
            {
                var subCategories = context.MovieSubCategories // Seçilen kategoriye ait alt kategorileri alıyoruz.
                    .Where(sc => sc.MovieCategoryID == categoryId)
                    .ToList(); // Alt kategorileri listeye dönüştürüyoruz.

                comboBoxSubCategories.DataSource = subCategories; // Alt kategorileri ComboBox'a veri kaynağı olarak bağlıyoruz.
                comboBoxSubCategories.DisplayMember = "SubCategoryName"; // Görüntülenecek alanı belirliyoruz.
                comboBoxSubCategories.ValueMember = "MovieSubCategoryID"; // Değerini belirliyoruz.
            }
        }

        private void comboBoxSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kullanıcı bir alt kategori seçtiğinde bu metot tetiklenir
            if (comboBoxSubCategories.SelectedItem != null) // Seçili bir öğe var mı kontrol et
            {
                // Seçilen öğeyi MovieSubCategory nesnesi olarak al
                var selectedSubCategory = (MovieSubCategory)comboBoxSubCategories.SelectedItem;

                // MovieSubCategoryID'yi al
                int selectedSubCategoryId = selectedSubCategory.MovieSubCategoryID;

                // Filmleri yükle
                LoadMovies(selectedSubCategoryId);
            }
        }

        private void LoadMovies(int subCategoryId) // Filmleri yükleyen metot.
        {
            using (var context = new FilmMoodDBContext()) // Veritabanı bağlamını kullanarak açıyoruz.
            {
                var movies = context.Movies // Seçilen alt kategoriye ait filmleri alıyoruz.
                    .Where(m => m.MovieSubCategoryID == subCategoryId)
                    .ToList(); // Filmleri listeye dönüştürüyoruz.

                dataGridViewMovies.DataSource = movies; // Filmleri DataGridView'a veri kaynağı olarak bağlıyoruz.
            }
        }

        private void dataGridViewMovies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) // DataGridView'da hücreye çift tıklandığında çağrılan metot.
        {
            if (e.RowIndex >= 0) // Eğer geçerli bir satır seçildiyse
            {
                var selectedRow = dataGridViewMovies.Rows[e.RowIndex]; // Seçilen satırı alıyoruz.
                string movieName = selectedRow.Cells["MovieName"].Value.ToString(); // Film adını alıyoruz.
                ShowMovieDetails(movieName); // Film detaylarını gösteren metodu çağırıyoruz.
            }
        }

        private void ShowMovieDetails(string movieName) // Film detaylarını gösteren metot.
        {
            using (var context = new FilmMoodDBContext()) // Veritabanı bağlamını kullanarak açıyoruz.
            {
                var movie = context.Movies.FirstOrDefault(m => m.MovieName == movieName); // Filmi adını kullanarak buluyoruz.

                if (movie != null) // Eğer film bulunursa
                {
                    // Film detaylarını bir mesaj kutusunda gösteriyoruz.
                    MessageBox.Show($"Film Adı: {movie.MovieName}\nYönetmen: {movie.Director}\nÇıkış Yılı: {movie.ReleaseYear}\nBaşrol: {movie.LeadingActor}\nIMDB Puanı: {movie.Rating}", "Film Detayları");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            // itex7  ardıdan itex7.bouncy-castle-adapter eklentilerini ekleyerek bu kod yazıldı ve işlem tamammlandı
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // PDF yazıcısını oluştur
                    using (var writer = new PdfWriter(saveFileDialog.FileName)) // Burada dosya adını geçiriyoruz
                    using (var pdf = new PdfDocument(writer)) // PdfDocument'ı oluşturuyoruz
                    {
                        var document = new Document(pdf);
                        document.Add(new Paragraph("Film Bilgileri").SetTextAlignment(TextAlignment.CENTER)); // Başlık ekle

                        // DataGridView'deki verileri PDF'ye ekle
                        foreach (DataGridViewRow row in dataGridViewMovies.Rows)
                        {
                            if (row.IsNewRow) continue; // Yeni satırı atla
                            string movieDetails = $"Film Adı: {row.Cells["MovieName"].Value}, " +
                                                  $"Yönetmen: {row.Cells["Director"].Value}, " +
                                                  $"Çıkış Yılı: {row.Cells["ReleaseYear"].Value}, " +
                                                  $"Başrol: {row.Cells["LeadingActor"].Value}, " +
                                                  $"IMDB Puanı: {row.Cells["Rating"].Value}";
                            document.Add(new Paragraph(movieDetails)); // Film detaylarını ekle
                        }

                        document.Close(); // PDF dökümanını kapat
                    }
                }
            }
        }  //PDF

        private void btnChart_Click(object sender, EventArgs e)
        {
            var chart = new Chart();
            chart.Left = 80;
            chart.Top = 60;
            
            chart.ChartAreas.Add(new ChartArea("MainArea"));

            // Örnek veri
            foreach (DataGridViewRow row in dataGridViewMovies.Rows)
            {
                if (row.IsNewRow) continue;
                string movieName = row.Cells["MovieName"].Value.ToString();
                double rating = Convert.ToDouble(row.Cells["Rating"].Value);
                chart.Series.Add(new Series(movieName) { Points = { new DataPoint(1, rating) } });
            }

            chart.Dock = DockStyle.Fill; // Grafik alanını forma yay
            var chartForm = new Form { Text = "Film Puanları Grafiği" };
            chartForm.Controls.Add(chart);
            chartForm.ShowDialog(); // Grafiği göster
        } //Grafik

        private void btn_sendEmail_Click(object sender, EventArgs e)
        {

            try
            {
                var usermail = txtEmail.Text;
                // DataGridView'dan film bilgilerini toplama
                StringBuilder filmDetailsBuilder = new StringBuilder();
                filmDetailsBuilder.AppendLine("Film Bilgileri:\n");

                // DataGridView'daki her satırı dolaşma
                foreach (DataGridViewRow row in dataGridViewMovies.Rows)
                {
                    if (row.Cells["MovieName"].Value != null && row.Cells["Director"].Value != null)
                    {
                        // Film bilgilerini al
                        string filmTitle = row.Cells["MovieName"].Value.ToString();
                        string filmDirector = row.Cells["Director"].Value.ToString();
                        int releaseYear = Convert.ToInt32(row.Cells["ReleaseYear"].Value); // Yıl hücresinin ismi "Yıl" olarak varsayılmıştır.

                        // Bilgileri ekle
                        filmDetailsBuilder.AppendLine($"Film Adı: {filmTitle}");
                        filmDetailsBuilder.AppendLine($"Yönetmen: {filmDirector}");
                        filmDetailsBuilder.AppendLine($"Yıl: {releaseYear}");
                        filmDetailsBuilder.AppendLine(); // Boş bir satır ekle
                    }
                }

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("nurii6345@gmail.com", "vkew qukv lgev dabl"), // Uygulama şifresini buraya ekleyin
                    EnableSsl = true,
                };

                // E-posta gönderim işlemi
                smtpClient.Send("nurii6345@gmail.com", usermail, "Film Bilgileri", filmDetailsBuilder.ToString());
                MessageBox.Show("E-posta başarıyla gönderildi!");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"SMTP Hatası: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        } //Email
    }
    
}
