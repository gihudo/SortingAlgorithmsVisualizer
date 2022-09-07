using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Random random = new Random();
        int[] arr;

        public Form1()
        {
            InitializeComponent();
        }

        float Map(float n, float start1, float stop1, float start2, float stop2)
        {
            return ((n- start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }

        void Display(int selected = -1, int selected2 = -1)
        {
            float pillarWidth = (pictureBox1.Width / (float)arr.Length);
            int pillarHeight;

            graphics.Clear(Color.White);
            graphics = Graphics.FromImage(pictureBox1.Image);

            for (int i = 0; i < arr.Length; i++)
            {
                pillarHeight = (int)Map(arr[arr.Length / arr.Length * i], 0, arr.Length, pictureBox1.Height / arr.Length, pictureBox1.Height);
                graphics.FillRectangle(Brushes.Blue, i * pillarWidth, pictureBox1.Height - pillarHeight, pillarWidth - 1, pillarHeight);
                if ((i + 1) % 10 == 0)
                    graphics.FillRectangle(Brushes.DarkBlue, i * pillarWidth, pictureBox1.Height - pillarHeight, pillarWidth - 1, pillarHeight);
                if(selected == i)
                    graphics.FillRectangle(Brushes.Red, i * pillarWidth, pictureBox1.Height - pillarHeight, pillarWidth - 1, pillarHeight);
                if(selected2 == i)
                    graphics.FillRectangle(Brushes.Green, i * pillarWidth, pictureBox1.Height - pillarHeight, pillarWidth - 1, pillarHeight);
            }
            pictureBox1.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(1920, 1080);
            graphics = Graphics.FromImage(pictureBox1.Image);
            arr = Enumerable.Range(0, (int)numericUpDown1.Value).ToArray();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    arr[i] = random.Next(0, arr.Length);
                }
                while (arr.Count(x => x == arr[i]) != 1);
            }
            Display();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            arr = Enumerable.Range(0, (int)numericUpDown1.Value).ToArray();
            Display();
        }

        async private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            listBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            timer1.Enabled = true;

            switch (listBox1.Text)
            {
                case "QuickSort":
                    await Task.Run(() => QuickSort.Sort(arr, 0, arr.Length - 1));
                    break;

                case "CocktailShaker_BubbleSort":
                    await Task.Run(() => CocktailShaker_BubbleSort.Sort(arr));
                    break;

                case "BubbleSort": 
                    await Task.Run(() => BubbleSort.Sort(arr));
                    break;

                case "SelectionSort":
                    await Task.Run(() => SelectionSort.Sort(arr));
                    break;

                case "MergeSort":
                    await Task.Run(() => MergeSort.Sort(arr, 0, arr.Length - 1));
                    break;

                case "InsertionSort":
                    await Task.Run(() => InsertionSort.Sort(arr));
                    break;

                default:
                    break;
            }


            button1.Enabled = true;
            button2.Enabled = true;
            numericUpDown1.Enabled = true;
            listBox1.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(listBox1.SelectedItem.ToString())
            {
                case "QuickSort":
                    Display(QuickSort.index, QuickSort.index2);
                    break;

                case "CocktailShaker_BubbleSort":
                    Display(CocktailShaker_BubbleSort.index);
                    break;

                case "BubbleSort":
                    Display(BubbleSort.index);
                    break;

                case "SelectionSort":
                    Display(SelectionSort.index, SelectionSort.index2);
                    break;

                case "MergeSort":
                    Display(MergeSort.index);
                    break;

                case "InsertionSort":
                    Display(InsertionSort.index, InsertionSort.index2);
                    break;

                default:
                    break;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
