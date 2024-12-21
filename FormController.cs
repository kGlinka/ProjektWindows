using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtManagement
{
    public static class FormController
    {
        // Domyślne ustawienia wyglądu
        public static Color DefaultBackColor = Color.LightBlue;
        public static Color DefaultForeColor = Color.Black;
        public static Font DefaultFont = new Font("Arial", 10);
        public static FormBorderStyle DefaultFormBorderStyle = FormBorderStyle.None;

        // Metoda do zastosowania domyślnych ustawień do formularza
        public static void ApplyDefaultStyles(Form form)
        {
            form.BackColor = DefaultBackColor;
            form.ForeColor = DefaultForeColor;
            form.Font = DefaultFont;
            form.FormBorderStyle = DefaultFormBorderStyle;
        }
    }
}
