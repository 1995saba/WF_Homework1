using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV
{
    public partial class FormCV : Form
    {
        public FormCV()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string fullName = "Орунбаева Сабина Сериковна";
            string dateOfBirth = "06.05.1995";
            string placeOfBirth = "Казахстан, Костанайская обл., г.Рудный";
            string education = "2015 год - окончила ЕНУ им. Л.Н.Гумилева, специальность \"Туризм\".";
            string languages = "русский - свободно, английский - Intermediate, французский - базовый";
            string secondJob = "Сентябрь 2014 — наст.время  -  Ресепшионист в отеле Jelsomino ТОО \"Paritet-Food-Market\".";
            string firstJob = "Ноябрь 2012 — июнь 2014  -  Реализатор продукции в малые торговые точки ИП \"Омарова\".";

            MessageBox.Show(fullName +"\nДата рождения: "+ dateOfBirth + "\nМесто рождения: " + placeOfBirth);
            MessageBox.Show(education + "\nЗнание языков: " + languages, "Образование");
            MessageBox.Show(secondJob +"\n" + firstJob, "Опыт работы:");
        }
    }
}
