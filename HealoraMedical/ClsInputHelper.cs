using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    internal class ClsInputHelper
    {

        public static void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyChar == 22)
            {
                return; // Ctrl+V'ye izin ver
            }

            // Geri silme (Backspace) ve diğer kontrol karakterlerine izin ver
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Sadece rakamlara izin ver
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Engelle
            }
        }
        public static void OnlyNumeric_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Yapıştırılan metin yalnızca sayı mı kontrol et
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt.Text, @"^\d*$"))
            {
                txt.Text = ""; 
            }
        }

        public static void OnlyAlphabetic(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyChar == 22)
                return;

            // Backspace vb. kontrol tuşlarına izin
            if (char.IsControl(e.KeyChar))
                return;

            // Harf (Unicode uyumlu) değilse, engelle
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) // boşluklara da izin
                e.Handled = true;
        }
        public static void OnlyText_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Eğer yapıştırılan veri yalnızca harf ve boşluklardan oluşmuyorsa uyar
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt.Text, @"^[a-zA-ZçÇğĞıİöÖşŞüÜ\s]*$"))
            {
                MessageBox.Show("Sadece harf ve boşluk karakteri girilebilir.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Text = "";
            }
        }

    }
}
