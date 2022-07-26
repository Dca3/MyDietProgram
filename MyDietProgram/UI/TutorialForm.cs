﻿using MaterialSkin.Controls;
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
        Bitmap[] gallery = new Bitmap[]{
                Properties.Resources.Main1,
                Properties.Resources.Main1,
                Properties.Resources.Main1,
                Properties.Resources.Main2,
                Properties.Resources.MealEdit,
                Properties.Resources.NewFood,
                Properties.Resources.DailyReport,
                Properties.Resources.Overview,
                Properties.Resources.FoodStats
            };

        string[] descArr = new string[] {
            "",
            "",
            "Sağ üst kısımda, kayıt olurken girdiğiniz bilgilere göre hesaplanan günlük olarak tüketmeniz gereken kalori miktarını görebilirsiniz.",//Main1
            "Anasayfa'da gerekli alanları doldurarak yediğiniz yiyeceklerin kaydını oluşturun. Eklediğiniz bilgiler öğünler bölümüne eklenir.", // Main2
            "Öğünün yanında yer alan düzenle butonuna basarak öğününüzün içeriğini düzenleyebilirsiniz.", //MealEdit
            "Yiyecekler listesinin yanındaki \"+\" butonuna tıklayarak yeni bir yiyecek oluşturabilirsiniz", //NewFood
            "Günlük Rapor'da geçerli tarihe ait kayıtlarınızı görebilirsiniz.", //DailyReport
            "Kıyas Raporu, diğer kullanınıcılar ile sizin kayıtlarınızı karşılaştırır.", // Comparision
            "Yemek İstatistikleri, yiyeceklerin hangi öğünlerde ne kadar tüketildiğini gösterir." //FoodStats
        };
        public TutorialForm()
        {
            InitializeComponent();
            pbxSlide.Visible = false;
            pbxSlide.Image = gallery[slideIndex];
            lblDescription.Text = descArr[slideIndex];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            slideIndex--;
            btnNext.Enabled = true;

            if (slideIndex == 0)
                lblWelcome.Text = "Hoşgeldiniz";

            if (slideIndex == 1)
            {
                pbxSlide.Visible = false;
                lblWelcome.Visible = true;
            }

            if (slideIndex != 0)
            {
                pbxSlide.Image = gallery[slideIndex];
                lblDescription.Text = descArr[slideIndex];
            }

            if (slideIndex == 0)
            {
                pbxSlide.Visible = false;
                btnPrev.Enabled = false;
                lblWelcome.Visible = true;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            slideIndex++;
            btnPrev.Enabled = true;
            pbxSlide.Visible = true;

            if (slideIndex == 1)
                lblWelcome.Text = "Bilgileriniz ile günlük kalori ihtiyacınızı hesaplayabilir, tükettiğiniz yiyeceklerin kaydını tutabilirsiniz.";

            if (slideIndex == 2)
            {
                pbxSlide.Visible = true;
                lblWelcome.Visible = false;
            }
            if (slideIndex != gallery.Length)
            {
                pbxSlide.Image = gallery[slideIndex];
                lblDescription.Text = descArr[slideIndex];
            }

            if (slideIndex == gallery.Length - 1)
            {
                btnNext.Enabled = false;
            }

        }
    }
}
