namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        float x1=0;

        float y1=0;

        static int count = 0;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
         x1 = e.X;
          y1 = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.X<10|| e.Y < 10)
            {
                MessageBox.Show("Wrooong");
            }

            else
            {
               
                AddLabelDynamic();

            }

        }

        void AddLabelDynamic()
        {
            Label label = new Label
            {
                AutoSize = false,

            Location = new Point(((int)x1), ((int)y1)),

            Size = new Size(60, 70),

            Font = new Font("Hello", 20),

            Text = count.ToString()

        };

            label.Click += Label_Click;

            label.DoubleClick += Label_DoubleClick;

            count += 1;

            this.Controls.Add(label);
            

        }

        private void Label_DoubleClick(object? sender, EventArgs e)
        {
            Label label = sender as Label;

            count -= 1;

            label.BringToFront();

            label.Dispose();
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            Label label = sender as Label;

            Text = $"{label.Location.X},{label.Location.Y}";
        }
    }
}