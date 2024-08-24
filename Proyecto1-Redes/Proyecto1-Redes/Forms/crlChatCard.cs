using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Redes.Forms
{
    public partial class crlChatCard : UserControl
    {
        public string UserName { get; set; }

        private string _chatShow;
        private string _lastMessage;
        private string _status;

        public string chatShow
        {
            get => _chatShow;
            set
            {
                _chatShow = value;
                switch (value)
                {
                    case "Chat":
                        panel1.BackColor = Color.Green;
                        break;
                    case "DoNotDisturb":
                        panel1.BackColor = Color.Red;
                        break;
                    case "ExtendedAway":
                        panel1.BackColor = Color.Orange;
                        break;
                    case "Away":
                        panel1.BackColor = Color.Yellow;
                        break;
                    case "Unavailable":
                        panel1.BackColor = Color.Gray;
                        break;
                    case "Unknown":
                        panel1.BackColor = Color.Gray;
                        break;
                    default:
                        panel1.BackColor = Color.Gray;
                        break;
                }
            }
        }
        public string LastMessage
        {
            get => _lastMessage;
            set
            {
                _lastMessage = value;
                lblLastMessage.Text = value;
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                if (lbStatus.InvokeRequired)
                {
                    lbStatus.Invoke(new Action(() => lbStatus.Text = value));
                }
                else
                {
                    lbStatus.Text = value;
                }
            }
        }

        public crlChatCard(String UserName, string LastMessage, string Status = "Unknown", string chatShow = "Unknown")
        {
            InitializeComponent();
            this.UserName = UserName;
            this.LastMessage = LastMessage;
            this.Status = Status;
            this.chatShow = chatShow;
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            lblLastMessage.Text = LastMessage;
            lblUserName.Text = UserName;
            lbStatus.Text = Status;

        }

        private void lbInitial_Paint(object sender, PaintEventArgs e)
        {
            lbInitial.Text = UserName.Substring(0, 1).ToUpper();
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lbInitial.Width, lbInitial.Height);

            this.lbInitial.Region = new Region(path);
        }

        private void crlChatCard_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color de fondo a HEX: 817f7f y borde cuando el mouse entra
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#817f7f");

            // Opcional: puedes animar una transición
            var animationTimer = new Timer();
            animationTimer.Interval = 10; // Tiempo entre cada frame de la animación
            int steps = 10;
            int currentStep = 0;

            animationTimer.Tick += (s, args) =>
            {
                currentStep++;
                //this.Height += 2;

                if (currentStep >= steps)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };
            animationTimer.Start();
        }

        private void crlChatCard_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo a HEX #505050 y borde cuando el mouse sale
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#505050");

            // Restaurar tamaño si cambió
            var animationTimer = new Timer();
            animationTimer.Interval = 10; // Tiempo entre cada frame de la animación
            int steps = 10;
            int currentStep = 0;

            animationTimer.Tick += (s, args) =>
            {
                currentStep++;
                //this.Height -= 2;

                if (currentStep >= steps)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };
            animationTimer.Start();
        }

    }
}
