namespace myapp.Controls;

public partial class TheatrePanel : BindableObject, IDrawable
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(TheatrePanel));

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FontColor = Colors.Black;
        canvas.FontSize = 14;
        canvas.Font = Microsoft.Maui.Graphics.Font.Default;

        canvas.DrawString($"Bound Item Value >> {Name}", 0, 0, 400, 38, HorizontalAlignment.Left, VerticalAlignment.Top);
    }
}
