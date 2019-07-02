using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Однородность
{
	public partial class AddPage : ContentPage
	{
        //Добавление компонентов
        Label standard_deviation_label = new Label() { Text = "Стандартное отклонение :", FontSize = 20, TextColor = Color.Red };
        Label standard_deviation_entry = new Label() { FontSize = 20, TextColor = Color.Black };
        Button calculate_standard_deviation_button = new Button() { Text = "Вычислить", FontSize = 20 };
        Label reference_dose_value_label = new Label() { Text = "Эталонное значение дозы :", FontSize = 20, TextColor = Color.Red };
        Label reference_dose_value_entry = new Label() { FontSize = 20, TextColor = Color.Black };
        Button calculate_reference_dose_value_button = new Button() { Text = "Вычислить", FontSize = 20, IsEnabled = false };
        Label indicator_of_acceptability_label = new Label() { Text = "(AV) - Показатель приемлимости :", FontSize = 20, TextColor = Color.Red };
        Label indicator_of_acceptability_entry = new Label() { FontSize = 20,TextColor = Color.Black };
        Button calculate_indicator_of_acceptability_button = new Button() { Text = "Вычислить", FontSize = 20, IsEnabled = false };
        Button back_button = new Button() { Text = "Назад", FontSize = 20 };

        public AddPage()
		{
            //Размер и расположение компонентов
            AbsoluteLayout.SetLayoutBounds(standard_deviation_label, new Rectangle(6, 6, 200, 80));
            AbsoluteLayout.SetLayoutBounds(standard_deviation_entry, new Rectangle(226, 6, 200, 80));
            AbsoluteLayout.SetLayoutBounds(calculate_standard_deviation_button, new Rectangle(446, 6, 200, 70));
            AbsoluteLayout.SetLayoutBounds(reference_dose_value_label, new Rectangle(6, 86, 200, 80));
            AbsoluteLayout.SetLayoutBounds(reference_dose_value_entry, new Rectangle(226, 86, 200, 80));
            AbsoluteLayout.SetLayoutBounds(calculate_reference_dose_value_button, new Rectangle(446, 86, 200, 70));
            AbsoluteLayout.SetLayoutBounds(indicator_of_acceptability_label, new Rectangle(6, 166, 200, 80));
            AbsoluteLayout.SetLayoutBounds(indicator_of_acceptability_entry, new Rectangle(226, 166, 200, 80));
            AbsoluteLayout.SetLayoutBounds(calculate_indicator_of_acceptability_button, new Rectangle(446, 166, 200, 70));
            AbsoluteLayout.SetLayoutBounds(back_button, new Rectangle(666, 6, 230, 230));

            AbsoluteLayout absoluteLayout = new AbsoluteLayout()
            {
                Children =
                {
                    standard_deviation_label,
                    standard_deviation_entry,
                    calculate_standard_deviation_button,
                    reference_dose_value_label, 
                    reference_dose_value_entry,
                    calculate_reference_dose_value_button,
                    indicator_of_acceptability_label,
                    indicator_of_acceptability_entry,
                    calculate_indicator_of_acceptability_button,
                    back_button,
                }
            };

            calculate_standard_deviation_button.Clicked += calculate_standard_deviation_button_Click;
            calculate_reference_dose_value_button.Clicked += calculate_reference_dose_value_button_Click;
            calculate_indicator_of_acceptability_button.Clicked += calculate_indicator_of_acceptability_button_Click;
            back_button.Clicked += back_button_Click;
            ScrollView scrollView = new ScrollView();
            scrollView.Orientation = ScrollOrientation.Horizontal;
            scrollView.Content = absoluteLayout;
            Content = scrollView;
        }

        double standart_deviation;
        double reference_dose_value;
        //Нажатие на кнопку вычисления стандартного отклонения
        private void calculate_standard_deviation_button_Click(object sender, EventArgs e)
        {
            standart_deviation = Math.Round(Convert.ToDouble(Math.Sqrt(((Math.Pow((Add.psc1 - Add.average_content_of_substance), 2) + Math.Pow((Add.psc2 - Add.average_content_of_substance), 2) +
                Math.Pow((Add.psc3 - Add.average_content_of_substance), 2) + Math.Pow((Add.psc4 - Add.average_content_of_substance), 2) +
                Math.Pow((Add.psc5 - Add.average_content_of_substance), 2) + Math.Pow((Add.psc6 - Add.average_content_of_substance), 2) +
                Math.Pow((Add.psc7 - Add.average_content_of_substance), 2) + Math.Pow((Add.psc8 - Add.average_content_of_substance), 2) +
                Math.Pow((Add.psc9 - Add.average_content_of_substance), 2) + Math.Pow((Add.psc10 - Add.average_content_of_substance), 2))) / 9)), 1);
            standard_deviation_entry.Text = standart_deviation.ToString();
            calculate_reference_dose_value_button.IsEnabled = true;
        }

        //Нажатие на кнопку вычисления эталонного значения дозы
        private void calculate_reference_dose_value_button_Click(object sender, EventArgs e)
        {
            double average = Add.average_content_of_substance;
            reference_dose_value = 0;
            if (average < 98.5)
            {
                reference_dose_value = 98.5;
            }

            if ((average >= 98.5) && (average <= 101.5))
            {
                reference_dose_value = Math.Round(Convert.ToDouble(average), 1);
            }

            if (average > 101.5)
            {
                reference_dose_value = 101.5;
            }
            reference_dose_value_entry.Text = reference_dose_value.ToString();
            calculate_indicator_of_acceptability_button.IsEnabled = true;
        }

        //Нажатие на кнопку вычисления показателя приемлимости
        private void calculate_indicator_of_acceptability_button_Click(object sender, EventArgs e)
        {
            double average = Add.average_content_of_substance;
            double indicator_of_acceptability = Math.Sqrt(Math.Pow((reference_dose_value - average), 2)) + 2.4 * standart_deviation;
            indicator_of_acceptability_entry.Text = indicator_of_acceptability.ToString();
        }

        //Нажатие на кнопку возврата назад
        private async void back_button_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
	}
}