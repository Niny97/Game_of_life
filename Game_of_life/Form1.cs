using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;



namespace Game_of_life
{
    
    enum E_CELL_STATE
    {
        DEAD,
        ALIVE
    }


    public partial class Form1 : Form
    {

        // Static variables:

        static Graphics canvas;
        static Color clear_color = Color.White;

        static SolidBrush alive_brush1 = new SolidBrush(Color.FromArgb(255, 204, 102));
        static SolidBrush alive_brush2 = new SolidBrush(Color.IndianRed);
        static SolidBrush dead_brush = new SolidBrush(Color.White);

        static List<List<E_CELL_STATE>> grid = new List<List<E_CELL_STATE>>();
        // Used to write the result between frames (next state frame, then rewrite to 'grid' to display):
        static List<List<E_CELL_STATE>> calculation_grid = new List<List<E_CELL_STATE>>();
        static List<List<E_CELL_STATE>> save_grid = new List<List<E_CELL_STATE>>();

        static float width;
        static float height;

        static int custom_width = 30;
        static int custom_height = 22;

        static float cell_width;
        static float cell_height;

        static bool is_grid_set = false;
        static bool is_it_new = false;
        static bool is_it_playing = false;


        public Form1()
        {
            InitializeComponent();
            
            canvas = pictureBox1.CreateGraphics();

            RectangleF bounds = canvas.VisibleClipBounds;
            width = (float)Math.Floor(bounds.Width);
            height = (float)Math.Floor(bounds.Height);

            cell_width = width / custom_width;
            cell_height = height / custom_height;

            // Configure timer:
            timer1.Tick += new System.EventHandler(this.simulation_loop);
            timer1.Enabled = false;

        }

        
        static void initialize_grid()
        {
            // Create a new grid based on 'width' and 'height'.

            grid.Clear();
            calculation_grid.Clear();
            save_grid.Clear();

            for (int i = 0; i < custom_height; i++)
            {
                List<E_CELL_STATE> row = new List<E_CELL_STATE>();
                List<E_CELL_STATE> row_2 = new List<E_CELL_STATE>();
                List<E_CELL_STATE> row_3 = new List<E_CELL_STATE>();

                for (int j = 0; j < custom_width; j++)
                {
                    row.Add(E_CELL_STATE.DEAD);
                    row_2.Add(E_CELL_STATE.DEAD);
                    row_3.Add(E_CELL_STATE.DEAD);
                }

                grid.Add(row);
                calculation_grid.Add(row_2);
                save_grid.Add(row_3);

            }
        }
        
        
        static void draw_lines(float width, float height, int x_cells, int y_cells)
        {
            Pen lines = new Pen(Color.Gray, 1);

            int x = 1;
            int y = 1;

            for (int i = 0; i < x_cells; i++)
            {
                canvas.DrawLine(lines, x * (width / x_cells), 0, x * (width / x_cells), height);
                x++;
            }
            for (int i = 0; i < y_cells; i++)
            {
                canvas.DrawLine(lines, 0, y * (height / y_cells), width, y * (height / y_cells));
                y++;
            }
        }


        static void randomize_grid()
        {
            Random r = new Random();
            int rand;

            for (int i = 0; i < custom_height; i++)
            {
                for (int j = 0; j<custom_width; j++)
                {
                    rand = r.Next(2);

                    if (rand == 0)
                    {
                        grid[i][j] = E_CELL_STATE.ALIVE;
                        canvas.FillRectangle(alive_brush1, j * cell_width, i * cell_height, cell_width, cell_height);

                    }
                    else
                    {
                        grid[i][j] = E_CELL_STATE.DEAD;
                        canvas.FillRectangle(dead_brush, j * cell_width, i * cell_height, cell_width, cell_height);
                    }
                }
            }
        }


        // ----------------------------------

        public static bool is_in_bounds(int x, int y)
        {
            if (x < custom_width && x >= 0 && y < custom_height && y >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        void simulation_loop(object sender, System.EventArgs e)
        {

            // Calculate new state according to the rules of Game Of Life.
            // Read from 'grid' and write new state into 'calculation_grid' (to not mess with the data as you calculate).

            for (int i = 0; i < custom_height; i++)
            {
                for (int j = 0; j < custom_width; j++)
                {
                    int neighbors = 0;

                    if (is_in_bounds(j - 1, i - 1) == true)
                    {
                        if (grid[i - 1][j - 1] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }
                    if (is_in_bounds(j, i - 1) == true)
                    {
                        if (grid[i - 1][j] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }
                    if (is_in_bounds(j + 1, i - 1) == true)
                    {
                        if (grid[i - 1][j + 1] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }
                    if (is_in_bounds(j - 1, i) == true)
                    {
                        if (grid[i][j - 1] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }
                    if (is_in_bounds(j + 1, i) == true)
                    {
                        if (grid[i][j + 1] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }
                    if (is_in_bounds(j - 1, i + 1) == true)
                    {
                        if (grid[i + 1][j - 1] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }
                    if (is_in_bounds(j, i + 1) == true)
                    {
                        if (grid[i + 1][j] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }
                    if (is_in_bounds(j + 1, i + 1) == true)
                    {
                        if (grid[i + 1][j + 1] == E_CELL_STATE.ALIVE)
                        {
                            neighbors++;
                        }
                    }

                    
                    //If cell is alive:

                    if (grid[i][j] == E_CELL_STATE.ALIVE)
                    { 
                        if (neighbors <= 1)                            //    -- 0 or 1 neighbor -> dies of underpopulation
                        {
                            calculation_grid[i][j] = E_CELL_STATE.DEAD;
                            canvas.FillRectangle(dead_brush, j * cell_width, i * cell_height, cell_width, cell_height);
                        }
                        else if (neighbors > 3)                        //    -- more than 3 neighbors -> dies of overpopulation
                        {
                            calculation_grid[i][j] = E_CELL_STATE.DEAD;
                            canvas.FillRectangle(dead_brush, j * cell_width, i * cell_height, cell_width, cell_height);
                        }
                        else                                           //    -- else -> nothing changes
                        {
                            calculation_grid[i][j] = E_CELL_STATE.ALIVE;
                            canvas.FillRectangle(alive_brush1, j * cell_width, i * cell_height, cell_width, cell_height);
                        }

                    }
                    else    // If cell is dead:
                    {
                        if (neighbors == 3)
                        {
                            calculation_grid[i][j] = E_CELL_STATE.ALIVE;           //    -- 3 neigbors -> becomes alive.
                            canvas.FillRectangle(alive_brush2, j * cell_width, i * cell_height, cell_width, cell_height);
                        }
                        else
                        {
                            calculation_grid[i][j] = E_CELL_STATE.DEAD;            //    -- else -> nothing changes
                            canvas.FillRectangle(dead_brush, j * cell_width, i * cell_height, cell_width, cell_height);
                        }
                    }

                }
            }

            // Rewrite from 'calculation_grid' to 'grid'.

            for (int i = 0; i < custom_height; i++)
            {
                for (int j = 0; j < custom_width; j++)
                {
                    grid[i][j] = calculation_grid[i][j];
                }

            }

        }


        // ----------------------------------

        // ---- GUI EVENTS ----


        public static void pix_to_grid(int pixx, int pixy, out int grid_x, out int grid_y,
            out float cell_width, out float cell_height)
        {
            cell_width = width / custom_width;
            cell_height = height / custom_height;

            grid_x = (int)Math.Floor(pixx / cell_width);
            grid_y = (int)Math.Floor(pixy / cell_height);

        }


        // MOUSE click

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int mouse_x = e.X;
            int mouse_y = e.Y;

            int grid_x;
            int grid_y;

            pix_to_grid(mouse_x, mouse_y, out grid_x, out grid_y, out cell_width, out cell_height);

            is_it_new = true;

            if (is_grid_set == true)
            {
                if (grid[grid_y][grid_x] == E_CELL_STATE.DEAD)
                {
                    grid[grid_y][grid_x] = E_CELL_STATE.ALIVE;
                    canvas.FillRectangle(alive_brush1, grid_x * cell_width, grid_y * cell_height, cell_width, cell_height);
                }
                else
                {
                    grid[grid_y][grid_x] = E_CELL_STATE.DEAD;
                    canvas.FillRectangle(dead_brush, grid_x * cell_width, grid_y * cell_height, cell_width, cell_height);
                }
            }
        }


        // NEW button click

        private void new_button_Click(object sender, EventArgs e)
        {
            is_grid_set = true;
            is_it_new = true;

            initialize_grid();
            
            canvas.FillRectangle(new SolidBrush(clear_color), 0, 0, width, height);
            draw_lines(width, height, custom_width, custom_height);
        }

        // RANDOM button click

        private void randomize_Click(object sender, EventArgs e)
        {
            is_grid_set = true;
            is_it_new = false;

            initialize_grid();

            canvas.FillRectangle(new SolidBrush(clear_color), 0, 0, width, height);

            randomize_grid();

            for (int i = 0; i < custom_height; i++)
            {
                for (int j = 0; j < custom_width; j++)
                {
                    save_grid[i][j] = grid[i][j];
                }

            }

        }


        // START/STOP button click

        private void start_Click(object sender, EventArgs e)
        {
            if (is_grid_set == true)
            {
                if (is_it_playing == false)
                {
                    if (is_it_new == true)
                    {
                        for (int i = 0; i < custom_height; i++)
                        {
                            for (int j = 0; j < custom_width; j++)
                            {
                                save_grid[i][j] = grid[i][j];
                            }

                        }
                    }

                    timer1.Interval = int.Parse(textBox3.Text);      // In milliseconds
                    timer1.Enabled = true;
                    is_it_playing = true;
                    is_it_new = false;

                    button4.BackgroundImage = Properties.Resources.pause1;
                    button4.BackgroundImageLayout = ImageLayout.Zoom;

                }
                else
                {
                    is_it_new = false;
                    timer1.Stop();
                    is_it_playing = false;

                    button4.BackgroundImage = Properties.Resources.play1;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
            

        // BARS
            
            // WIDTH

        private void width_bar_Scroll(object sender, EventArgs e)
        {
            label6.Text = width_bar.Value.ToString();
            custom_width = width_bar.Value;
            cell_width = width / custom_width;

            is_grid_set = true;

            initialize_grid();
            canvas.FillRectangle(new SolidBrush(clear_color), 0, 0, width, height);
            draw_lines(width, height, custom_width, custom_height);
            
        }

            // HEIGHT

        private void height_bar_Scroll(object sender, EventArgs e)
        {
            label7.Text = height_bar.Value.ToString();
            custom_height = height_bar.Value;
            cell_height = height / custom_height;

            is_grid_set = true;

            initialize_grid();
            canvas.FillRectangle(new SolidBrush(clear_color), 0, 0, width, height);
            draw_lines(width, height, custom_width, custom_height);
            
        }
        
        // SAVE button

        private void save_button_Click(object sender, EventArgs e)
        {
            if (is_grid_set == true)
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save file";
                save.Filter = "Text files (*.txt)|*.txt";

                if (is_it_new == true)
                {
                    for (int i = 0; i < custom_height; i++)
                    {
                        for (int j = 0; j < custom_width; j++)
                        {
                            save_grid[i][j] = grid[i][j];
                        }

                    }
                }

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter write = new StreamWriter(File.Create(save.FileName));

                    write.Write(custom_width.ToString() + custom_height.ToString());

                    for (int i = 0; i < custom_height; i++)
                    {
                        for (int j = 0; j < custom_width; j++)
                        {
                            if (save_grid[i][j] == E_CELL_STATE.ALIVE)
                            {
                                write.Write(1);
                            }
                            else
                            {
                                write.Write(0);
                            }
                        }
                    }

                    write.Dispose();
                }

                is_it_new = false;
            }
        }

        // LOAD button

        public void open_button_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open file";
            open.Filter = "Text files (*.txt)|*.txt| All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                char[] file = new char[2];

                int ch;
                string str;

                read.Read(file, 0, 2);
                string wh = file[0].ToString() + file[1].ToString();
                custom_width = Convert.ToInt32(wh);

                read.Read(file, 0, 2);
                wh = file[0].ToString() + file[1].ToString();
                custom_height = Convert.ToInt32(wh);

                cell_width = width / custom_width;
                cell_height = height / custom_height;

                width_bar.Value = custom_width;
                height_bar.Value = custom_height;
                label6.Text = custom_width.ToString();
                label7.Text = wh;

                initialize_grid();

                for (int i = 0; i < custom_height; i++)
                {
                    for (int j = 0; j < custom_width; j++)
                    {
                        read.Read(file, 0, 1);
                        str = file[0].ToString();

                        ch = Convert.ToInt32(str);

                        if (ch == 1)
                        {
                            grid[i][j] = E_CELL_STATE.ALIVE;
                            canvas.FillRectangle(alive_brush1, j * cell_width, i * cell_height, cell_width, cell_height);

                        }
                        else
                        {
                            grid[i][j] = E_CELL_STATE.DEAD;
                            canvas.FillRectangle(dead_brush, j * cell_width, i * cell_height, cell_width, cell_height);

                        }
                    }
                }

                read.Dispose();
            }
        }

       
    }
}
