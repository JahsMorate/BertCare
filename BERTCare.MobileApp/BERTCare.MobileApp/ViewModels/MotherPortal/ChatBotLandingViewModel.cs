/* [grial-metadata] id: Grial#NewsMembershipViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;

namespace BERTCare.MobileApp
{
	public class ChatBotLandingViewModel : ObservableObject
	{
        private NewsMembershipPlan _selectedPlan;

		public ChatBotLandingViewModel()
		{
			LoadData();
		}

		public ObservableCollection<NewsMembershipPlan> Plans { get; } = new ObservableCollection<NewsMembershipPlan>();
        
		public NewsMembershipPlan SelectedPlan
		{
			get => _selectedPlan;
			set => SetProperty(ref _selectedPlan, value);
		}

		private void LoadData()
 		{
            Plans.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "News.json", pageName: "NewsMembershipPage.xaml");

			SelectedPlan = Plans?.FirstOrDefault();
        }
    }
}

