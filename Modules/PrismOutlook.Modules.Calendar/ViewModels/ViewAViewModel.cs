using Prism.Mvvm;

namespace PrismOutlook.Modules.Calendar.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public ViewAViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
