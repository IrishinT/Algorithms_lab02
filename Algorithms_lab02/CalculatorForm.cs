namespace Algorithms_lab02
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcGCDLCM_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(num1TextBox.Text, out int a) ||
                !int.TryParse(num2TextBox.Text, out int b) ||
                a == 0 || b == 0)
            {
                MessageBox.Show("Введите корректные ненулевые числа");
                return;
            }

            int gcd = GCD(a, b);
            int lcm = LCM(a, b, gcd);

            resultGCD.Text = gcd.ToString();
            resultLCM.Text = lcm.ToString();

            ShowSteps(a, b);
            PrepareVisualization(a, b);
        }

        private int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        private int LCM(int a, int b, int gcd)
        {
            return Math.Abs(a * b) / gcd;
        }

        private void ShowSteps(int a, int b)
        {
            stepsListBox.Items.Clear();

            int x = Math.Abs(a);
            int y = Math.Abs(b);

            while (y != 0)
            {
                int q = x / y;
                int r = x % y;

                stepsListBox.Items.Add($"{x} = {y} * {q} + {r}");

                x = y;
                y = r;
            }

            stepsListBox.Items.Add($"НОД = {x}");
        }

        private int visA;
        private int visB;

        private void PrepareVisualization(int a, int b)
        {
            visA = Math.Abs(a);
            visB = Math.Abs(b);
            visualPictureBox.Invalidate(); // перерисовка
        }

        private void visualPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (visA == 0 || visB == 0) return;

            int x = visA;
            int y = visB;

            int startX = 10;
            int startY = 10;
            int height = 30;
            int spacing = 5;

            int maxValue = Math.Max(visA, visB);

            float scale = Math.Min(
                (visualPictureBox.Width - 20) / (float)maxValue,
                1f);

            Brush brushA = Brushes.LightBlue;
            Brush brushB = Brushes.LightGreen;

            while (x != y)
            {
                if (x > y)
                {
                    g.FillRectangle(
                        brushA,
                        startX,
                        startY,
                        x * scale,
                        height);

                    startY += height + spacing;
                    x -= y;
                }
                else
                {
                    g.FillRectangle(
                        brushB,
                        startX,
                        startY,
                        y * scale,
                        height);

                    startY += height + spacing;
                    y -= x;
                }

                // защита от выхода вниз
                if (startY > visualPictureBox.Height - height - 20)
                    break;
            }

            g.FillRectangle(
                Brushes.Orange,
                startX,
                startY,
                x * scale,
                height);

            g.DrawString(
                $"НОД = {x}",
                Font,
                Brushes.Black,
                startX,
                startY + height + 5);
        }
    }
}
