using System.Drawing;
using System;
using System.Windows.Forms;

public class PlaceHolderTextBox : TextBox
{

    bool isPlaceHolder = true;
    string _placeHolderText;
    public string PlaceHolderText
    {
        get { return _placeHolderText; }
        set
        {
            _placeHolderText = value;
            setPlaceholder();
        }
    }

    public new string Text
    {
        get => isPlaceHolder ? string.Empty : base.Text;
        set => base.Text = value;
    }

    //when the control loses focus, the placeholder is shown
    private void setPlaceholder()
    {
        if (string.IsNullOrEmpty(base.Text))
        {
            base.Text = PlaceHolderText;
            this.ForeColor = Color.Gray;
            this.Font = new Font(this.Font, FontStyle.Italic);
            isPlaceHolder = true;
        }
    }

    //when the control is focused, the placeholder is removed
    private void removePlaceHolder()
    {

        if (isPlaceHolder)
        {
            base.Text = "";
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Font = new Font(this.Font, FontStyle.Regular);
            isPlaceHolder = false;
        }
    }
    public PlaceHolderTextBox()
    {
        GotFocus += removePlaceHolder;
        LostFocus += setPlaceholder;
    }

    private void setPlaceholder(object sender, EventArgs e)
    {
        setPlaceholder();
    }

    private void removePlaceHolder(object sender, EventArgs e)
    {
        removePlaceHolder();
    }
    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // X-coordinate of upper-left corner or padding at start
        int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
        int nRightRect, // X-coordinate of lower-right corner or Width of the object
        int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                        //RADIUS, how round do you want it to be?
        int nheightRect, //height of ellipse 
        int nweightRect //width of ellipse
    );
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
    }
}
