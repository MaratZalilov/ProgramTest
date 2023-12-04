using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramTest
{
    public partial class GameForm : Form
    {
        private System.Windows.Forms.Button[] buttons;
        private GameForm gameForm;
        

        private string[] NameButton = {"Buttons0", "Buttons1", "Buttons2"};

        private bool _isButton= false;
        public GameForm()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Remove(MainButton);
            
            ButtonGeneration();

        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            
            

            QuestionAndAnswerGeneration(sender,e);


        }
        //private void Buttons_MouseClick(object sender, MouseEventArgs e)
        //{

        //    if (e.Button == MouseButtons.Left)
        //    {
        //        _isButton = e.Equals(sender) ;
        //        QuestionAndAnswerGeneration(sender, e);
        //    }

                


        //}
        public void ButtonGeneration()
        {
            
            buttons = new System.Windows.Forms.Button[3];
            int W = 330, H = 200;
            for (int j = 0; j < 3; j++)
            {
                buttons[j] = new System.Windows.Forms.Button
                {
                    BackColor = Color.Orange,
                    Size = new Size(200, 50),
                    Location = new Point(W, H += 50),
                    Text = $"{j+1} "+ $"Ответ"
                };
                buttons[j].Name = NameButton[j];
                buttons[j].Click += new EventHandler(this.Buttons_Click);
                buttons[j].Tag = new Point(j);
                MainPanel.Controls.Add(buttons[j]);
                

            }
        }
        public void QuestionAndAnswerGeneration(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Zalilov Marat\source\repos\ProgramTest\ProgramTest\QuestionAndAnswer\QuestionAndAnswer.txt");
                string line = sr.ReadLine();

                //while (line != null)
                //{
                    MainLabelText.Text = line;
                    line = sr.ReadLine();
                    for(int j = 0;j < 3; j++)
                    {
                        if ( NameButton[j] == "Buttons0")
                        {
                            MessageBox.Show("Работает 1 кнопка");
                            MainLabelText.Text = line;
                            line = sr.ReadLine();
                            
                        }
                        else if (NameButton[j] == "Buttons1")
                        {
                            MessageBox.Show("Работает 2 кнопка");
                            MainLabelText.Text = line;
                            line = sr.ReadLine();
                            
                        }
                        else if (NameButton[j] == "Buttons2")
                        {
                            MessageBox.Show("Работает 3 кнопка");
                            MainLabelText.Text = line;
                            line = sr.ReadLine();
                            
                        }
                    }
                    
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
