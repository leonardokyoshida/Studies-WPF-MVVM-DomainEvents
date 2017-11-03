using Prism.Mvvm;

namespace StudiesWPF.WPF.Models
{
    public class Test : BindableBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message,value); }
        }

    }
}
