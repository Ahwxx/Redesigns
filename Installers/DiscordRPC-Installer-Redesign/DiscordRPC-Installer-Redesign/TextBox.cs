using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

[DefaultEvent("TextChanged")]
public class GhostTextBox : Control
{

    #region  Variables

    Button InputButton = new Button();
    public TextBox TextInput = new TextBox();

    HorizontalAlignment textAlignment;

    bool isPasswordMasked = false;
    bool isEnabled = true;
    bool showOpenButton;

    Timer AnimationTimer = new Timer { Interval = 1 };
    
    string filter = @"All Files (*.*)|*.*";

    bool isFocussed = false;

    float SizeAnimation = 0;
    float SizeInc_Dec;

    float PointAnimation;
    float PointInc_Dec;

    Color fontColor = Color.White;
    Color focusColor = Color.FromArgb(88, 101, 242);
    Open typeToOpen;

    Color EnabledFocusedColor;
    Color EnabledStringColor;

    Color BGColor = Color.FromArgb(54, 57, 63);

    Color EnabledUnFocusedColor = ColorTranslator.FromHtml("#dbdbdb");

    Color EnabledInPutColor = Color.White;
    Color DisabledInputColor = Color.White;
    Color DisabledUnFocusedColor = ColorTranslator.FromHtml("#e9ecee");
    Color DisabledStringColor = ColorTranslator.FromHtml("#babbbd");

    #endregion
    #region  Properties

    public HorizontalAlignment TextAlignment
    {
        get
        {
            return textAlignment;
        }
        set
        {
            textAlignment = value;
            Invalidate();
        }
    }

    [Category("Behavior")]
    public bool UseSystemPasswordChar
    {
        get
        {
            return isPasswordMasked;
        }
        set
        {
            TextInput.UseSystemPasswordChar = UseSystemPasswordChar;
            isPasswordMasked = value;
            Invalidate();
        }
    }

    public Color bgcolor
    {
        get
        {
            return BGColor;
        }
        set
        {
            BGColor = value;
            Invalidate();
        }
    }

    [Category("Behavior")]
    public bool ShowOpenButton
    {
        get { return showOpenButton; }
        set
        {
            showOpenButton = value;
            AddButton();
            AddTextBox();
            Controls.Add(TextInput);
            if (showOpenButton)
            {
                Controls.Add(InputButton);
            }
            Invalidate();
        }
    }

    public enum Open
    {
        OpenFolder,
        OpenFile
    }

    [Category("Behavior")]
    public Open TypeToOpen 
    {
        get
        {
            return typeToOpen;
        }
        set
        {
            typeToOpen = value;
        }
    }

    [Category("Behavior")]
    public bool IsEnabled
    {
        get { return isEnabled; }
        set
        {
            isEnabled = value;

            if (IsEnabled)
            {
                TextInput.ForeColor = EnabledStringColor;
                InputButton.Enabled = true;
            }
            else
            {
                TextInput.ForeColor = DisabledStringColor;
                InputButton.Enabled = false;
            }

            Invalidate();
        }
    }

    [Category("Behavior")]
    public string Filter
    {
        get { return filter; }
        set
        {
            filter = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color FocusedColor
    {
        get { return focusColor; }
        set
        {
            focusColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color FontColor
    {
        get { return fontColor; }
        set
        {
            fontColor = value;
            Invalidate();
        }
    }

    [Browsable(false)]
    public override Color ForeColor
    {
        get { return base.ForeColor; }
        set { base.ForeColor = value; }
    }

    #endregion
    #region  Events

    protected void OnKeyDown(object Obj, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.A)
        {
            TextInput.SelectAll();
            e.SuppressKeyPress = true;
        }
        if (e.Control && e.KeyCode == Keys.C)
        {
            TextInput.Copy();
            e.SuppressKeyPress = true;
        }
        if (e.Control && e.KeyCode == Keys.X)
        {
            TextInput.Cut();
            e.SuppressKeyPress = true;
        }
    }
    private void BrowseDown(object Obj, EventArgs e)
    {
        if (typeToOpen.ToString() == "OpenFile")
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK && ofd.SafeFileName != null)
            {
                Text = ofd.FileName;
            }
            Focus();
        }
        else if (typeToOpen.ToString() == "OpenFolder")
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Text = fbd.SelectedPath;
            }
        }     
    }
    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }

    protected override void OnGotFocus(System.EventArgs e)
    {
        base.OnGotFocus(e);
        TextInput.Focus();
        TextInput.SelectionLength = 0;
    }

    protected override void OnResize(System.EventArgs e)
    {
        base.OnResize(e);

        Height = 24;
        
        PointAnimation = Width / 2;
        SizeInc_Dec = Width / 15;
        PointInc_Dec = Width / 36;

        TextInput.Width = Width - 21;
        InputButton.Location = new Point(Width - 21, 1);
        InputButton.Size = new Size(21, 20);
    }

    #endregion
    public void AddButton()
    {
        InputButton.Location = new Point(Width - 21, 1);
        InputButton.Size = new Size(21, 20);

        InputButton.ForeColor = Color.White;
        InputButton.TextAlign = ContentAlignment.MiddleCenter;
        InputButton.BackColor = Color.Transparent;
        
        InputButton.TabStop = false;
        InputButton.FlatStyle = FlatStyle.Flat;
        InputButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        InputButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
        InputButton.FlatAppearance.BorderSize = 0;
        
        InputButton.MouseDown += BrowseDown;
        InputButton.MouseEnter += (sender, args) => EnabledInPutColor = EnabledFocusedColor;
        InputButton.MouseLeave += (sender, args) => EnabledInPutColor = Color.White;
    }
    public void AddTextBox()
    {
        TextInput.Text = Text;
        TextInput.Location = new Point(0, 1);
        TextInput.Size = new Size(Width - 21, 20);

        TextInput.Multiline = false;
        TextInput.Font = new Font("Segoe UI", 10);
        TextInput.ScrollBars = ScrollBars.None;
        TextInput.BorderStyle = BorderStyle.None;
        TextInput.TextAlign = HorizontalAlignment.Left;
        TextInput.BackColor = BGColor;
        TextInput.UseSystemPasswordChar = UseSystemPasswordChar;       
        
        TextInput.KeyDown += OnKeyDown;

        TextInput.GotFocus += (sender, args) => isFocussed = true; AnimationTimer.Start();
        TextInput.LostFocus += (sender, args) => isFocussed = false; AnimationTimer.Start();
    }

    public GhostTextBox()
    {
        Width = 300;
        DoubleBuffered = true;

        TextInput.TextChanged += (sender, args) => Text = TextInput.Text;
        TextChanged += (sender, args) => TextInput.Text = Text;

        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Bitmap B = new Bitmap(Width, Height);
        Graphics G = Graphics.FromImage(B);
        G.Clear(Color.Transparent);

        EnabledStringColor = fontColor;
        EnabledFocusedColor = focusColor;

        TextInput.TextAlign = TextAlignment;
        TextInput.ForeColor = IsEnabled ? EnabledStringColor : DisabledStringColor;
        TextInput.UseSystemPasswordChar = UseSystemPasswordChar;

        G.DrawLine(new Pen(new SolidBrush(IsEnabled ? EnabledUnFocusedColor : DisabledUnFocusedColor)), new Point(0, Height - 2), new Point(Width, Height - 2));
        if (IsEnabled)
        { G.FillRectangle(new SolidBrush(Color.FromArgb(88, 101, 242)), 0, (float)Height - 3, SizeAnimation, 2); }

        G.SmoothingMode = SmoothingMode.AntiAlias;
        if (showOpenButton)
        {
            G.FillEllipse(new SolidBrush(IsEnabled ? EnabledInPutColor : DisabledInputColor), Width - 5, 9, 4, 4);
            G.FillEllipse(new SolidBrush(IsEnabled ? EnabledInPutColor : DisabledInputColor), Width - 11, 9, 4, 4);
            G.FillEllipse(new SolidBrush(IsEnabled ? EnabledInPutColor : DisabledInputColor), Width - 17, 9, 4, 4);
        }

        e.Graphics.DrawImage((Image)(B.Clone()), 0, 0);
        G.Dispose();
        B.Dispose();
    }

    protected void AnimationTick(object sender, EventArgs e)
    {
        if (isFocussed)
        {
            if (SizeAnimation < Width + 250)
            {
                SizeAnimation += SizeInc_Dec;
                Invalidate();
            }

            if (PointAnimation > 0)
            {
                PointAnimation -= PointInc_Dec;
                Invalidate();
            }
        }
        else
        {
            if (SizeAnimation > 0)
            {
                SizeAnimation -= SizeInc_Dec;
                Invalidate();
            }

            if (PointAnimation < Width / 2)
            {
                PointAnimation += PointInc_Dec;
                Invalidate();
            }
        }
    }

}


