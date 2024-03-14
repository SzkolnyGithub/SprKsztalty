namespace Sprawdzian14._03Badowski4c;

public partial class MainPage : ContentPage
{
	bool kwadrat = true;
	float x = 0;
	Color kolor;
	public MainPage()
	{
		InitializeComponent();
        List<string> wybor = new List<string>
        {
            "kwadrat",
			"kolo"
        };
		ksztalt.ItemsSource = wybor;
		ksztalt.SelectedItem = wybor[0];
		GraphView.Drawable = new GraphicsDrawable();
    }
	private void wybrany(object sender, SelectedItemChangedEventArgs e)
	{
		
		if(e.SelectedItem.ToString() == "kwadrat")
		{
			kwadrat = true;
			kolor = Colors.Blue;
		} else 
		{
			kwadrat = false;
			kolor = Colors.Red;
		}
		GraphView.Drawable = new GraphicsDrawable
		{
			KolorK = kolor,
            kwadratK = kwadrat,
            xK = x
        };
    }
	private void zmiana(object sender, ValueChangedEventArgs e)
	{
		x = (float)e.NewValue;
		GraphView.Drawable = new GraphicsDrawable
		{
			KolorK = kolor,
			kwadratK = kwadrat,
			xK = x
		};
	}
	private class GraphicsDrawable : IDrawable
	{
		public Color KolorK = Colors.Blue;
		public bool kwadratK = true;
		public float xK;
		public void Draw(ICanvas canvas, RectF rect)
		{
			canvas.FillColor = KolorK;
			canvas.StrokeSize = 2;
			if(kwadratK)
			{
				canvas.FillRectangle(10, 10, xK, xK);
			} else
			{
				canvas.FillEllipse(10, 10, xK, xK);
			}
		}
	}
}

