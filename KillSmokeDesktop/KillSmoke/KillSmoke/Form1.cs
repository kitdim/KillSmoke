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
            //TODO �������� ����������� ���� � ���������
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            ClearingPage();
            labelTitle.Text = DaysWithoutSmoke.ToString();
            //TODO ��������� ����������� ���� � ���������
        }

        /// <summary>
        /// Checking last day
        /// </summary>
        private void CheckingDay()
        {
            //TODO ��������� ��� �� ���� �������, ���� �� �������� ��� ���� ��� ��� ����� ������, ���� �� ��� ������� ����
        }

        private void ClearingPage()
        {
            labelTitle.Text = string.Empty;
            //TODO ������ ������ ��/���
        }
    }
}
 