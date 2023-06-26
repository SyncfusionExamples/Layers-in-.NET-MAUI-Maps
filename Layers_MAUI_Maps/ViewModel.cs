using System.Collections.ObjectModel;

namespace Layers_MAUI_Maps
{
	public class ViewModel
	{
		public ObservableCollection<Model> Data { get; set; }
		public ViewModel()
		{
			Data = new ObservableCollection<Model>();
			Data.Add(new Model(117, "Albania", 3195000, 111, "High", Colors.AliceBlue));
			Data.Add(new Model(15, "Argentina", 40091359, 14, "Low", Colors.Red));
			Data.Add(new Model(102, "Austria", 8372930, 100, "High", Colors.Green));
			Data.Add(new Model(359, "Belgium", 10827519, 355, "High", Colors.Blue));
			Data.Add(new Model(23, "Brazil", 206598985, 24, "Low", Colors.Violet));
			Data.Add(new Model(80, "Cambodia", 14805000, 82, "Low", Colors.Yellow));
			Data.Add(new Model(4, "Canada", 35151728, 3.4, "Low", Colors.Orange));
			Data.Add(new Model(143, "China", 1389750000, 144, "High", Colors.Brown));
			Data.Add(new Model(394, "India", 1198003000, 364, "High", Colors.BlueViolet));
			Data.Add(new Model(504, "Korea", 48456369, 487, "High", Colors.LightGreen));
		}
	}
}
