using Prism.Mvvm;
using Prism.Regions;

namespace PrismOutlook.Modules.Contacts.ViewModels
{
    public class ViewAViewModel : BindableBase, IRegionMemberLifetime
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public bool KeepAlive => false;

        public ViewAViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
