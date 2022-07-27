using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDietProgram.UI
{

    public partial class TutorialForm : MaterialForm
    {
        byte slideIndex = 0;
        List<Bitmap> gallery = new List<Bitmap>(){
                Properties.Resources.Main1,
                Properties.Resources.Main2,
                Properties.Resources.MealEdit1,
                Properties.Resources.NewFood,
                Properties.Resources.DailyReport,
                Properties.Resources.Comparision,
                Properties.Resources.FoodStats
            };

        string[] descArr = new string[] {
            "Anasayfa'da gerekli alanları doldurarak yediğini yiyecek için bir kayıt oluşturun.\nSağ üst kısımda kayıt olurken girdiğiniz bilgilere göre hesaplanan günlük olarak tüketmeniz gereken kalori miktarını görebilirsiniz.", // Main1
            "Eklediğiniz bilgiler öğünler bölümüne eklecektir.", //Main2
            "Öğünün yanında yer alan düzenle butonuna basarak öğününüzün içeriğini düzenleyebilirsiniz.", //MealEdit
            "Yiyecekler listesinin yanındaki \"+\" butonuna tıklayarak yeni bir yiyecek oluşturabilirsiniz", //NewFood
            "Günlük Rapor ekranında geçerli tarihe ait kayıtlarınızı gösterir.", //DailyReport
            "Kıyas Raporu diğer kullanınıcılar ile sizin kayıtlarınızı karşılaştırır", // Comparision
            "Yemek İstatistikleri Raporu yiyeceklerin hangi öğünlerde ne kadar tüketildiğini gösterir." //FoodStats
        };
        public TutorialForm()
        {
            InitializeComponent();
            pbxSlide.Image = gallery[slideIndex];
            label1.Text = slideIndex.ToString();
            lblDescription.Text = descArr[slideIndex];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;

            if (slideIndex != 0)
            {
                slideIndex--;
                pbxSlide.Image = gallery[slideIndex];
                lblDescription.Text = descArr[slideIndex];
            }
            
            if(slideIndex == 0)
                btnPrev.Enabled = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = true;

            if (slideIndex != gallery.Count - 1)
            {
                slideIndex++;
                pbxSlide.Image = gallery[slideIndex];
                lblDescription.Text = descArr[slideIndex];
            }

            if (slideIndex == gallery.Count -1)
                btnNext.Enabled = false;

        }
    }
}
