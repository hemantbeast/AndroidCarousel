using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AndroidCarousel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		ObservableCollection<string> _listData;

		public event PropertyChangedEventHandler PropertyChanged;

		public MainViewModel()
		{
			ListData = new ObservableCollection<string> {
				"0", "1", "2", "3", "4", "5"
			};
		}

		public ObservableCollection<string> ListData {
			get => _listData;
			set {
				_listData = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ListData)));
			}
		}
	}
}
