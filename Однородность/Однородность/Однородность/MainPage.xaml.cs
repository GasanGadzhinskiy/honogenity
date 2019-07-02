using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Однородность
{
    public partial class MainPage : ContentPage
    {
        //Объявление переменных
        
        //Добавление компонентов
        //Первый столбец - номера
        Label number_main_label = new Label() { Text = "№", FontSize = 25, TextColor = Color.Red };
        Label number_label_1 = new Label() { Text = "1", FontSize = 20, TextColor = Color.Black };
        Label number_label_2 = new Label() { Text = "2", FontSize = 20, TextColor = Color.Black };
        Label number_label_3 = new Label() { Text = "3", FontSize = 20, TextColor = Color.Black };
        Label number_label_4 = new Label() { Text = "4", FontSize = 20, TextColor = Color.Black };
        Label number_label_5 = new Label() { Text = "5", FontSize = 20, TextColor = Color.Black };
        Label number_label_6 = new Label() { Text = "6", FontSize = 20, TextColor = Color.Black };
        Label number_label_7 = new Label() { Text = "7", FontSize = 20, TextColor = Color.Black };
        Label number_label_8 = new Label() { Text = "8", FontSize = 20, TextColor = Color.Black };
        Label number_label_9 = new Label() { Text = "9", FontSize = 20, TextColor = Color.Black };
        Label number_label_10 = new Label() { Text = "10", FontSize = 20, TextColor = Color.Black };

        //Второй столбец - масса
        Label weight_main_label = new Label() { Text = "    Масса", FontSize = 25, TextColor = Color.Red };
        Entry weight_entry_1 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_2 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_3 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_4 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_5 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_6 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_7 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_8 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_9 = new Entry() { Keyboard = Keyboard.Numeric };
        Entry weight_entry_10 = new Entry() { Keyboard = Keyboard.Numeric };

        //Третий столбец - содержание вещества в 1-й таблетке
        Label substance_content_label = new Label() { Text = "  Содержание", FontSize = 25, TextColor = Color.Red };
        Label substance_content_label_2 = new Label() { Text = "в 1-й таблетке", FontSize = 25, TextColor = Color.Red };
        Label substance_content_entry_1 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_2 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_3 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_4 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_5 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_6 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_7 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_8 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_9 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label substance_content_entry_10 = new Label() { FontSize = 20, TextColor = Color.Black };

        //Четвертый стобец - содержание вещества в 1-й таблетке, в процентах от номинала
        Label prosent_substance_content_label = new Label() { Text = "           %", FontSize = 25, TextColor = Color.Red };
        Label prosent_substance_content_label_2 = new Label() { Text = "от номинала", FontSize = 25, TextColor = Color.Red };
        Label prosent_substance_content_entry_1 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_2 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_3 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_4 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_5 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_6 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_7 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_8 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_9 = new Label() { FontSize = 20, TextColor = Color.Black };
        Label prosent_substance_content_entry_10 = new Label() { FontSize = 20, TextColor = Color.Black };

        //Дополнительные значения
        Button calculate_average_weight_of_the_tablet_button = new Button() { Text = "Вычислить", FontSize = 20 };
        Button calculate_substance_content_button = new Button() { Text = "Вычислить", FontSize = 20, IsEnabled = false };
        Button calculate_content_of_substance_button = new Button() { Text = "Вычислить", FontSize = 20, IsEnabled = false };
        Button calculate_average_content_of_substance_button = new Button() { Text = "Вычислить", FontSize = 20, IsEnabled = false };
        Button receive_additional_data_button = new Button() { Text = "Получить дополнительные значения", FontSize = 20, IsEnabled = false };
        Label average_substance_content_label = new Label() { Text = "Введите среднее", FontSize = 20, TextColor = Color.Red };
        Label average_substance_content_label_2 = new Label() { Text = "содержание вещества", FontSize = 20, TextColor = Color.Red };
        Label nominal_label = new Label() { Text = "Введите", FontSize = 20, TextColor = Color.Red };
        Label nominal_label_2 = new Label() { Text = "номинал", FontSize = 20, TextColor = Color.Red };
        Label average_weight_of_the_tablet_entry = new Label() { FontSize = 20, TextColor = Color.Black };
        Entry average_substance_content_entry = new Entry() { Keyboard = Keyboard.Numeric, IsEnabled = false };
        Entry nominal_entry = new Entry() { Keyboard = Keyboard.Numeric, IsEnabled = false };
        Label average_content_of_substance_entry = new Label() { FontSize = 20, TextColor = Color.Black };

        public MainPage()
        {
            //Размер и расположение компонентов
            //Первый столбец
            AbsoluteLayout.SetLayoutBounds(number_main_label, new Rectangle(6, 40, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_1, new Rectangle(6, 160, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_2, new Rectangle(6, 220, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_3, new Rectangle(6, 280, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_4, new Rectangle(6, 340, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_5, new Rectangle(6, 400, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_6, new Rectangle(6, 460, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_7, new Rectangle(6, 520, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_8, new Rectangle(6, 580, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_9, new Rectangle(6, 640, 40, 60));
            AbsoluteLayout.SetLayoutBounds(number_label_10, new Rectangle(6, 700, 40, 60));

            //Второй столбец
            AbsoluteLayout.SetLayoutBounds(weight_main_label, new Rectangle(86, 40, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_1, new Rectangle(86, 160, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_2, new Rectangle(86, 220, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_3, new Rectangle(86, 280, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_4, new Rectangle(86, 340, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_5, new Rectangle(86, 400, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_6, new Rectangle(86, 460, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_7, new Rectangle(86, 520, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_8, new Rectangle(86, 580, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_9, new Rectangle(86, 640, 150, 60));
            AbsoluteLayout.SetLayoutBounds(weight_entry_10, new Rectangle(86, 700, 150, 60));

            //Третий столбец
            AbsoluteLayout.SetLayoutBounds(substance_content_label, new Rectangle(350, 40, 600, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_label_2, new Rectangle(350, 100, 600, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_1, new Rectangle(375, 160, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_2, new Rectangle(375, 220, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_3, new Rectangle(375, 280, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_4, new Rectangle(375, 340, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_5, new Rectangle(375, 400, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_6, new Rectangle(375, 460, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_7, new Rectangle(375, 520, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_8, new Rectangle(375, 580, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_9, new Rectangle(375, 640, 150, 60));
            AbsoluteLayout.SetLayoutBounds(substance_content_entry_10, new Rectangle(375, 700, 150, 60));

            //Четвертый столбец
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_label, new Rectangle(650, 40, 964, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_label_2, new Rectangle(650, 100, 964, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_1, new Rectangle(664, 160, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_2, new Rectangle(664, 220, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_3, new Rectangle(664, 280, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_4, new Rectangle(664, 340, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_5, new Rectangle(664, 400, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_6, new Rectangle(664, 460, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_7, new Rectangle(664, 520, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_8, new Rectangle(664, 580, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_9, new Rectangle(664, 640, 150, 60));
            AbsoluteLayout.SetLayoutBounds(prosent_substance_content_entry_10, new Rectangle(664, 700, 150, 60));

            //Дополнительные значения
            AbsoluteLayout.SetLayoutBounds(calculate_average_weight_of_the_tablet_button, new Rectangle(80, 800, 162, 60));
            AbsoluteLayout.SetLayoutBounds(average_weight_of_the_tablet_entry, new Rectangle(86, 865, 150, 60));
            AbsoluteLayout.SetLayoutBounds(average_substance_content_label, new Rectangle(86, 960, 300, 60));
            AbsoluteLayout.SetLayoutBounds(average_substance_content_label_2, new Rectangle(86, 990, 300, 60));
            AbsoluteLayout.SetLayoutBounds(average_substance_content_entry, new Rectangle(86, 1040, 150, 60));
            AbsoluteLayout.SetLayoutBounds(calculate_substance_content_button, new Rectangle(369, 800, 162, 60));
            AbsoluteLayout.SetLayoutBounds(nominal_label, new Rectangle(375, 960, 150, 60));
            AbsoluteLayout.SetLayoutBounds(nominal_label_2, new Rectangle(375, 990, 150, 60));
            AbsoluteLayout.SetLayoutBounds(nominal_entry, new Rectangle(375, 1040, 150, 60));
            AbsoluteLayout.SetLayoutBounds(calculate_content_of_substance_button, new Rectangle(369, 1140, 162, 60));
            AbsoluteLayout.SetLayoutBounds(calculate_average_content_of_substance_button, new Rectangle(658, 800, 162, 60));
            AbsoluteLayout.SetLayoutBounds(average_content_of_substance_entry, new Rectangle(664, 865, 150, 60));
            AbsoluteLayout.SetLayoutBounds(receive_additional_data_button, new Rectangle(664, 950, 250, 250));

            AbsoluteLayout absoluteLayout = new AbsoluteLayout()
            {
                Children =
                {
                    number_main_label,
                    number_label_1,
                    number_label_2,
                    number_label_3,
                    number_label_4,
                    number_label_5,
                    number_label_6,
                    number_label_7,
                    number_label_8,
                    number_label_9,
                    number_label_10,
                    weight_main_label,
                    weight_entry_1,
                    weight_entry_2,
                    weight_entry_3,
                    weight_entry_4,
                    weight_entry_5,
                    weight_entry_6,
                    weight_entry_7,
                    weight_entry_8,
                    weight_entry_9,
                    weight_entry_10,
                    substance_content_label,
                    substance_content_label_2,
                    substance_content_entry_1,
                    substance_content_entry_2,
                    substance_content_entry_3,
                    substance_content_entry_4,
                    substance_content_entry_5,
                    substance_content_entry_6,
                    substance_content_entry_7,
                    substance_content_entry_8,
                    substance_content_entry_9,
                    substance_content_entry_10,
                    prosent_substance_content_label,
                    prosent_substance_content_label_2,
                    prosent_substance_content_entry_1,
                    prosent_substance_content_entry_2,
                    prosent_substance_content_entry_3,
                    prosent_substance_content_entry_4,
                    prosent_substance_content_entry_5,
                    prosent_substance_content_entry_6,
                    prosent_substance_content_entry_7,
                    prosent_substance_content_entry_8,
                    prosent_substance_content_entry_9,
                    prosent_substance_content_entry_10,
                    calculate_average_weight_of_the_tablet_button,                    
                    calculate_substance_content_button,
                    calculate_content_of_substance_button,
                    calculate_average_content_of_substance_button,
                    receive_additional_data_button,
                    average_substance_content_label,
                    average_substance_content_label_2,
                    nominal_label,
                    nominal_label_2,
                    average_weight_of_the_tablet_entry,
                    average_content_of_substance_entry,
                    nominal_entry,
                    average_substance_content_entry,
                }
            };

            //Прокрутка
            absoluteLayout.WidthRequest = 920;
            absoluteLayout.HeightRequest = 1200;
            ScrollView scrollView = new ScrollView();
            scrollView.Orientation = ScrollOrientation.Both;
            scrollView.HorizontalScrollBarVisibility = ScrollBarVisibility.Never;
            scrollView.VerticalScrollBarVisibility = ScrollBarVisibility.Never;
            scrollView.Content = absoluteLayout;

            //Обработка событий
            weight_entry_1.TextChanged += weight_entry_1_textChange;
            weight_entry_2.TextChanged += weight_entry_2_textChange;
            weight_entry_3.TextChanged += weight_entry_3_textChange;
            weight_entry_4.TextChanged += weight_entry_4_textChange;
            weight_entry_5.TextChanged += weight_entry_5_textChange;
            weight_entry_6.TextChanged += weight_entry_6_textChange;
            weight_entry_7.TextChanged += weight_entry_7_textChange;
            weight_entry_8.TextChanged += weight_entry_8_textChange;
            weight_entry_9.TextChanged += weight_entry_9_textChange;
            weight_entry_10.TextChanged += weight_entry_10_textChange;
            calculate_average_weight_of_the_tablet_button.Clicked += calculate_average_weight_of_the_tablet_button_Click;
            calculate_substance_content_button.Clicked += calculate_substance_content_button_Click;
            calculate_content_of_substance_button.Clicked += calculate_content_of_substance_button_Click;
            calculate_average_content_of_substance_button.Clicked += calculate_average_content_of_substance_button_Click;
            receive_additional_data_button.Clicked += receive_additional_data_button_Click;
            Content = scrollView;
        }

        //События
        //Нажатие на кнопку вычисления среднего веса таблетки
        public bool isChanged = false;
        public void calculate_average_weight_of_the_tablet_button_Click(object sender, EventArgs e)
        {
            Add.countOfX = 0;
            if (Add.isNull1 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull2 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull3 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull4 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull5 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull6 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull7 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull8 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull9 == false)
            {
                Add.countOfX++;
            }

            if (Add.isNull10 == false)
            {
                Add.countOfX++;
            }

            if (Add.countOfX > 0)
            {
                double average_weight_of_the_tablet = Math.Round((Add.we1 + Add.we2 + Add.we3 + Add.we4 + Add.we5 + Add.we6 + Add.we7 + Add.we8 + Add.we9 + Add.we10) / Add.countOfX, 1);
                average_weight_of_the_tablet_entry.Text = average_weight_of_the_tablet.ToString();
                calculate_substance_content_button.IsEnabled = true;
                average_weight_of_the_tablet_entry.IsEnabled = true;
                average_substance_content_entry.IsEnabled = true;
            }

            if (Add.countOfX == 0)
            {
                average_weight_of_the_tablet_entry.Text = "не число";
            }
        }

        //Нажатие на кнопку вычисления среднего содержания вещества в одной таблетке
        private void calculate_substance_content_button_Click(object sender, EventArgs e)
        {
            if (average_substance_content_entry.Text.Length > 0)
            {
                double average_weight_of_the_tablet = Convert.ToDouble(average_weight_of_the_tablet_entry.Text);
                double average_substance_content = Convert.ToDouble(average_substance_content_entry.Text);
                substance_content_entry_1.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we1).ToString()), 1).ToString();
                substance_content_entry_2.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we2).ToString()), 1).ToString();
                substance_content_entry_3.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we3).ToString()), 1).ToString();
                substance_content_entry_4.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we4).ToString()), 1).ToString();
                substance_content_entry_5.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we5).ToString()), 1).ToString();
                substance_content_entry_6.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we6).ToString()), 1).ToString();
                substance_content_entry_7.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we7).ToString()), 1).ToString();
                substance_content_entry_8.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we8).ToString()), 1).ToString();
                substance_content_entry_9.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we9).ToString()), 1).ToString();
                substance_content_entry_10.Text = Math.Round(Convert.ToDouble((average_substance_content / average_weight_of_the_tablet * Add.we10).ToString()), 1).ToString();
                Add.sc1 = Convert.ToDouble(substance_content_entry_1.Text);
                Add.sc2 = Convert.ToDouble(substance_content_entry_2.Text);
                Add.sc3 = Convert.ToDouble(substance_content_entry_3.Text);
                Add.sc4 = Convert.ToDouble(substance_content_entry_4.Text);
                Add.sc5 = Convert.ToDouble(substance_content_entry_5.Text);
                Add.sc6 = Convert.ToDouble(substance_content_entry_6.Text);
                Add.sc7 = Convert.ToDouble(substance_content_entry_7.Text);
                Add.sc8 = Convert.ToDouble(substance_content_entry_8.Text);
                Add.sc9 = Convert.ToDouble(substance_content_entry_9.Text);
                Add.sc10 = Convert.ToDouble(substance_content_entry_10.Text);
                nominal_entry.IsEnabled = true;
                calculate_content_of_substance_button.IsEnabled = true;
            }
        }

        //Нажатие на кнопку вычисления содержания вещества в каждой таблетки, в процентах от номинала
        private void calculate_content_of_substance_button_Click(object sender, EventArgs e)
        {
            double nominal = Convert.ToDouble(nominal_entry.Text);
            prosent_substance_content_entry_1.Text = Math.Round(Convert.ToDouble((Add.sc1 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_2.Text = Math.Round(Convert.ToDouble((Add.sc2 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_3.Text = Math.Round(Convert.ToDouble((Add.sc3 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_4.Text = Math.Round(Convert.ToDouble((Add.sc4 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_5.Text = Math.Round(Convert.ToDouble((Add.sc5 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_6.Text = Math.Round(Convert.ToDouble((Add.sc6 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_7.Text = Math.Round(Convert.ToDouble((Add.sc7 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_8.Text = Math.Round(Convert.ToDouble((Add.sc8 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_9.Text = Math.Round(Convert.ToDouble((Add.sc9 / nominal * 100).ToString()), 1).ToString();
            prosent_substance_content_entry_10.Text = Math.Round(Convert.ToDouble((Add.sc10 / nominal * 100).ToString()), 1).ToString();
            Add.psc1 = Convert.ToDouble(prosent_substance_content_entry_1.Text);
            Add.psc2 = Convert.ToDouble(prosent_substance_content_entry_2.Text);
            Add.psc3 = Convert.ToDouble(prosent_substance_content_entry_3.Text);
            Add.psc4 = Convert.ToDouble(prosent_substance_content_entry_4.Text);
            Add.psc5 = Convert.ToDouble(prosent_substance_content_entry_5.Text);
            Add.psc6 = Convert.ToDouble(prosent_substance_content_entry_6.Text);
            Add.psc7 = Convert.ToDouble(prosent_substance_content_entry_7.Text);
            Add.psc8 = Convert.ToDouble(prosent_substance_content_entry_8.Text);
            Add.psc9 = Convert.ToDouble(prosent_substance_content_entry_9.Text);
            Add.psc10 = Convert.ToDouble(prosent_substance_content_entry_10.Text);
            calculate_average_content_of_substance_button.IsEnabled = true;
        }

        //Нажатие на кнопку вычисления среднего содержания вещества в одной таблетки, в процентах от номинала
        private void calculate_average_content_of_substance_button_Click(object sender, EventArgs e)
        {
            Add.average_content_of_substance = (Add.psc1 + Add.psc2 + Add.psc3 + Add.psc4 + Add.psc5 + Add.psc6 + Add.psc7 + Add.psc8 + Add.psc9 + Add.psc10) / 10;
            average_content_of_substance_entry.Text = Add.average_content_of_substance.ToString();
            average_content_of_substance_entry.IsEnabled = true;
            receive_additional_data_button.IsEnabled = true;
        }

        //Нажатие на кнопку показа дополнительных сведений
        private async void receive_additional_data_button_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }

        //Изменение текста
        private void weight_entry_1_textChange(object sender, EventArgs e)
        {                       
            if ((weight_entry_1.Text.Length > 0))
            {
                Add.we1 = Convert.ToDouble(weight_entry_1.Text);
                Add.isNull1 = false;
            }

            else
            {
                Add.we1 = 0;
                Add.isNull1 = true;
            }
        }

        private void weight_entry_2_textChange(object sender, EventArgs e)
        {
            if (weight_entry_2.Text.Length > 0)
            {
                Add.we2 = Convert.ToDouble(weight_entry_2.Text);
                Add.isNull2 = false;
            }

            else
            {
                Add.we2 = 0;
                Add.isNull2 = true;
            }
        }

        private void weight_entry_3_textChange(object sender, EventArgs e)
        {
            if (weight_entry_3.Text.Length > 0)
            {
                Add.we3 = Convert.ToDouble(weight_entry_3.Text);
                Add.isNull3 = false;
            }

            if (weight_entry_3.Text.Length == 0)
            {
                Add.we3 = 0;
                Add.isNull3 = true;
            }
        }

        private void weight_entry_4_textChange(object sender, EventArgs e)
        {
            if (weight_entry_4.Text.Length > 0)
            {
                Add.we4 = Convert.ToDouble(weight_entry_4.Text);
                Add.isNull4 = false;
            }

            else
            {
                Add.we4 = 0;
                Add.isNull4 = true;
            }
        }

        private void weight_entry_5_textChange(object sender, EventArgs e)
        {
            if (weight_entry_5.Text.Length > 0)
            {
                Add.we5 = Convert.ToDouble(weight_entry_5.Text);
                Add.isNull5 = false;
            }

            else
            {
                Add.we5 = 0;
                Add.isNull5 = true;
            }
        }

        private void weight_entry_6_textChange(object sender, EventArgs e)
        {
            if (weight_entry_6.Text.Length > 0)
            {
                Add.we6 = Convert.ToDouble(weight_entry_6.Text);
                Add.isNull6 = false;
            }

            else
            {
                Add.we6 = 0;
                Add.isNull6 = true;
            }

        }

        private void weight_entry_7_textChange(object sender, EventArgs e)
        {
            if (weight_entry_7.Text.Length > 0)
            {
                Add.we7 = Convert.ToDouble(weight_entry_7.Text);
                Add.isNull7 = false;
            }

            else
            {
                Add.we7 = 0;
                Add.isNull7 = true;
            }
        }

        private void weight_entry_8_textChange(object sender, EventArgs e)
        {
            if (weight_entry_8.Text.Length > 0)
            {
                Add.we8 = Convert.ToDouble(weight_entry_8.Text);
                Add.isNull8 = false;
            }

            else
            {
                Add.we8 = 0;
                Add.isNull8 = true;
            }
        }

        private void weight_entry_9_textChange(object sender, EventArgs e)
        {
            if (weight_entry_9.Text.Length > 0)
            {
                Add.we9 = Convert.ToDouble(weight_entry_9.Text);
                Add.isNull9 = false;
            }

            else
            {
                Add.we9 = 0;
                Add.isNull9 = true;
            }
        }

        private void weight_entry_10_textChange(object sender, EventArgs e)
        {
            if (weight_entry_10.Text.Length > 0)
            {
                Add.we10 = Convert.ToDouble(weight_entry_10.Text);
                Add.isNull10 = false;
            }

            else
            {
                Add.we10 = 0;
                Add.isNull10 = true;
            }
        }

        //Метод определяет, является ли символ недопустимым
        public bool isSymbol(char s)
        {
            if (("+*-/()#-;.").IndexOf(s) == -1)
            {
                return false;
            }

            return true;
        }
    }
}
