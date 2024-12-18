/* [grial-metadata] id: Grial#NewsData.cs version: 1.0.1 */
namespace BERTCare.MobileApp
{

    public class NewsSourcesData : ObservableObject
    {
        private bool _isFollowing;

        public string Icon { get; set; }
        public string Name { get; set; }
        public bool IsFollowing
        {
            get { return _isFollowing; }
            set { SetProperty(ref _isFollowing, value); }
        }
    }

    public class NewsMembershipPlan
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public bool IsRecommended { get; set; }
    }

}
