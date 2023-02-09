namespace KillSmoke
{
    public partial class Form1 : Form
    {
        private int daysWithoutSmoke;
        private DateTime lastCheckDay;

        public int DaysWithoutSmoke { get => 0; set => daysWithoutSmoke = value; }
        public DateTime LastCheckDay { get => lastCheckDay; set => lastCheckDay = value; }

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonYes_Click(object sender, EventArgs e)
        {
            ClearingPage();
            //TODO обнулить количесмтво дней и сохранить
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            ClearingPage();
            labelTitle.Text = DaysWithoutSmoke.ToString();
            //TODO увеличить количесмтво дней и сохранить
        }

        /// <summary>
        /// Checking last day
        /// </summary>
        private void CheckingDay()
        {
            //TODO проверить был ли вход сегодня, если бы написать что вход уже был зайди завтра, если не был открыть окно
        }

        private void ClearingPage()
        {
            labelTitle.Text = string.Empty;
            //TODO убрать кнопки да/нет
        }
    }
}
 