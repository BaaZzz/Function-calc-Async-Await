using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Tasks_LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double F(double x)
        {
            return Math.Sin(x) * Math.Exp(-x / 5);
        }
        private double OnetaskMediumRectangles(double a, double b, int N)
        {
            double result = 0;
            double h = (b - a) / N;
            for (int i = 0; i < N; i++)
            {
                result += F(a + h / 2 + i * h);
            }
            result *= h;
            return result;
        }

        private double MultitaskMediumRectangles(double a, double b, int N)
        {
            int maxParallelTasks = Int32.Parse(textBoxThreadNumber.Text);
            double result = 0;
            object lockObj = new object();
            double h = (b - a) / N;
            var intervals = new ConcurrentQueue<(double left, double right)>();
            Task[] workers = new Task[maxParallelTasks];
            for (int i = 0; i < N; i++)
            {
                double left = a + i * h;
                double right = left + h;
                intervals.Enqueue((left, right));
            }
            for (int i = 0; i < maxParallelTasks; i++)
            {
                workers[i] = Task.Run(() =>
                {
                    while (intervals.TryDequeue(out var interval))
                    {
                        double mid = (interval.left + interval.right) / 2.0;
                        double height = F(mid);
                        double area = height * (interval.right - interval.left);
                        lock (lockObj)
                        {
                            result += area;
                        }
                    }
                });
            }
            Task.WaitAll(workers);
            return result;
        }

        private double MultitaskTrapezoida(double a, double b, int N)
        {
            int maxParallelTasks = Int32.Parse(textBoxThreadNumber.Text);
            double h = (b - a) / N;
            double result = 0;
            object lockObj = new object();
            var intervals = new ConcurrentQueue<(double left, double right)>();
            Task[] workers = new Task[maxParallelTasks];
            for (int i = 0; i < N; i++)
            {
                double left = a + i * h;
                double right = left + h;
                intervals.Enqueue((left, right));
            }
            for (int i = 0; i < maxParallelTasks; i++)
            {
                workers[i] = Task.Run(() =>
                {
                    while (intervals.TryDequeue(out var interval))
                    {
                        double heightA = F(interval.left);
                        double heightB = F(interval.right);
                        double area = (heightA + heightB) * h / 2;
                        lock (lockObj)
                        {
                            result += area;
                        }
                    }
                });
            }
            Task.WaitAll(workers);
            return result;
        }
 
        private double OnetaskTrapezoida(double a, double b, int N)
        {
            double h = (b - a) / N;
            double result = 0.5 * (F(a) + F(b));
            for (int i = 1; (i < N); i++)
            {
                double x = a + i * h;
                result += F(x);
            }
            return h * result;
        }

        private double OnetaskMonteCarlo(double a, double b, int N)
        {
            Random rnd = new Random();
            double result = 0;
            for (int i = 0; i < N; i++)
            {
                double x = a + rnd.NextDouble() * (b - a);
                result += F(x);
            }
            return (b - a) * result / N;
        }

        private double MultitaskMonteCarlo(double a, double b, int N)
        {
            int maxParallelTasks = Int32.Parse(textBoxThreadNumber.Text);
            Random rnd = new Random();
            object lockObj = new object();
            double result = 0;
            ConcurrentQueue<double> args = new ConcurrentQueue<double>();
            Task[] workers = new Task[maxParallelTasks];
            for (int i = 0; i < N; i++)
            {
                double x = a + rnd.NextDouble() * (b - a);
                args.Enqueue(x);
            }
            for (int i = 0; i < maxParallelTasks; i++)
            {
                workers[i] = Task.Run(() =>
                {
                    while (args.TryDequeue(out double x))
                    {
                        double y = F(x);
                        lock (lockObj)
                        {
                            result += y;
                        }
                    }
                });
            }
            Task.WaitAll(workers);
            return (b - a) * result / N;
        }

        private void buttonOnetask_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                textBoxThreadNumber.Text = "1";
                string s = comboBox1.Text;
                double a = Double.Parse(textBoxA.Text);
                double b = Double.Parse(textBoxB.Text);
                int N = Int32.Parse(textBoxN.Text);
                switch (s)
                {
                    case "Метод прямоугольников":
                        {
                            stopWatch.Start();
                            double result = Math.Round(OnetaskMediumRectangles(a, b, N), 5);
                            labelResult.Text = Convert.ToString(result);
                            stopWatch.Stop();
                            break;
                        }
                    case "Метод трапеций":
                        {
                            stopWatch.Start();
                            double result = Math.Round(OnetaskTrapezoida(a, b, N), 5);
                            labelResult.Text = Convert.ToString(result);
                            stopWatch.Stop();
                            break;
                        }
                    case "Метод Монте-Карло":
                        {
                            stopWatch.Start();
                            double result = Math.Round(OnetaskMonteCarlo(a, b, N), 5);
                            labelResult.Text = Convert.ToString(result);
                            stopWatch.Stop();
                            break;
                        }
                    default:
                        MessageBox.Show("Выберите один из методов");
                        break;
                }
                TimeSpan ts = stopWatch.Elapsed;
                String time = String.Format("{0:00} мс", ts.Ticks);
                dataGridView1.Rows.Add(textBoxA.Text, textBoxB.Text, textBoxN.Text, textBoxThreadNumber.Text, s, time);
                stopWatch.Reset();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        private void buttonMultitask_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                string s = comboBox1.Text;
                double a = Double.Parse(textBoxA.Text);
                double b = Double.Parse(textBoxB.Text);
                int N = Int32.Parse(textBoxN.Text);
                switch (s)
                {
                    case "Метод прямоугольников":
                        {
                            stopWatch.Start();
                            double result = Math.Round(MultitaskMediumRectangles(a, b, N), 5);
                            labelResult.Text = Convert.ToString(result);
                            stopWatch.Stop();
                            break;
                        }
                    case "Метод трапеций":
                        {
                            stopWatch.Start();
                            double result = Math.Round(MultitaskTrapezoida(a, b, N), 5);
                            labelResult.Text = Convert.ToString(result);
                            stopWatch.Stop();
                            break;
                        }
                    case "Метод Монте-Карло":
                        {
                            stopWatch.Start();
                            double result = Math.Round(MultitaskMonteCarlo(a, b, N), 5);
                            labelResult.Text = Convert.ToString(result);
                            stopWatch.Stop();
                            break;
                        }
                    default:
                        MessageBox.Show("Выберите один из методов");
                        break;
                }
                TimeSpan ts = stopWatch.Elapsed;
                String time = String.Format("{0:00} мс", ts.Ticks);
                dataGridView1.Rows.Add(textBoxA.Text, textBoxB.Text, textBoxN.Text, textBoxThreadNumber.Text, s, time);
                stopWatch.Reset();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("A", "a");
            dataGridView1.Columns.Add("B", "b");
            dataGridView1.Columns.Add("N", "N");
            dataGridView1.Columns.Add("КОЛ-ВО ПОТОКОВ", "Кол-во потоков");
            dataGridView1.Columns.Add("МЕТОД ИНТЕГРИРОВАНИЯ", "Метод интегрирования");
            dataGridView1.Columns.Add("ЗАТРАЧЕННОЕ ВРЕМЯ", "Затраченное время");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Form1_Load(sender, e); 
        }
    }
}

