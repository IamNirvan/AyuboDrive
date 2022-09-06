using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Forms
{
    class CustomTitleBar
    {
        private readonly Form _parentForm;
        private readonly Panel _titleBar;
        private Button _exitButton;
        private Button _minimizeButton;
        private readonly int _titleBarHeight;
        private bool _drag = false;
        private Point _startPoint = new Point(0, 0);
        private readonly Color _titleBarColor;

        public CustomTitleBar(Form form, int titleBarHeight, Color titleBarColor)
        {
            _parentForm = form;
            _titleBarHeight = titleBarHeight;
            _titleBar = new Panel();
            _titleBarColor = titleBarColor;
            CreateTitleBar();
        }

        public CustomTitleBar(Form form)
        {
            _parentForm = form;
            _titleBarHeight = 40;
            _titleBarColor = Properties.Settings.Default.DARK_GRAY;
            _titleBar = new Panel();
            CreateTitleBar();
        }

        private void CreateTitleBar()
        {
            _titleBar.Location = _parentForm.Location;
            _titleBar.Width = _parentForm.Width;
            _titleBar.Height = _titleBarHeight;
            _titleBar.BackColor = _titleBarColor;
            _titleBar.BringToFront();
            
            _titleBar.MouseUp += new MouseEventHandler(TitleBar_MouseUp);
            _titleBar.MouseDown += new MouseEventHandler(TitleBar_MouseDown);
            _titleBar.MouseMove += new MouseEventHandler(TitleBar_MouseMove);
        }

        public void CreateMinimizeButton(Color backgroundColor, Color foregroundColor)
        {
            _minimizeButton = new Button()
            {
                BackgroundImage = Properties.Resources.minimizeIcon,
                BackgroundImageLayout = ImageLayout.Center,
                FlatStyle = FlatStyle.Flat,
                TabStop = false,
                Cursor = Cursors.Hand,
                BackColor = backgroundColor,
                ForeColor = foregroundColor,
                Size = new Size(_titleBarHeight, _titleBarHeight),
                Location = new Point(_titleBar.Width - (_titleBarHeight*2), 0)
            };

            _minimizeButton.MouseEnter += new EventHandler(MinimizeBtn_MouseEnter);
            _minimizeButton.MouseLeave += new EventHandler(MinimizeBtn_MouseLeave);
            _minimizeButton.FlatAppearance.BorderSize = 0;
            _titleBar.Controls.Add(_minimizeButton);
        }

        public void CreateExitButton(Color backgroundColor, Color foregroundColor)
        {
            _exitButton = new Button()
            {
                BackgroundImage = Properties.Resources.closeIcon,
                BackgroundImageLayout = ImageLayout.Center,
                FlatStyle = FlatStyle.Flat,
                TabStop = false,
                Cursor = Cursors.Hand,
                BackColor = backgroundColor,
                ForeColor = foregroundColor,
                Size = new Size(_titleBarHeight, _titleBarHeight),
                Location = new Point(_titleBar.Width - _titleBarHeight, 0)
            };

            _exitButton.MouseEnter += new EventHandler(ExitBtn_MouseEnter);
            _exitButton.MouseLeave += new EventHandler(ExitBtn_MouseLeave);
            _exitButton.FlatAppearance.BorderSize = 0;
            _titleBar.Controls.Add(_exitButton);
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = e.Location;
            _drag = true;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drag)
            {
                Point point1 = new Point(e.X, e.Y);
                Point point2 = _parentForm.PointToScreen(point1);
                Point point3 = new Point(point2.X - _startPoint.X, point2.Y - _startPoint.Y);
                _parentForm.Location = point3;
            }
        }

        public Panel GetTitleBar()
        {
            return _titleBar;
        }

        public Button GetExitButton()
        {
            return _exitButton;
        }

        public Button GetMinimizeButton()
        {
            return _minimizeButton;
        }


        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            _exitButton.BackColor = Properties.Settings.Default.RED;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            _exitButton.BackColor = Properties.Settings.Default.TRANSPARENT;
        }

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            _minimizeButton.BackColor = Properties.Settings.Default.DARK_GRAY;
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            _minimizeButton.BackColor = _titleBarColor;
        }
    }
}
