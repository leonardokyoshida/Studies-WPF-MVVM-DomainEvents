using Prism.Mvvm;
using StudiesWPF.WPF.Models;

namespace StudiesWPF.WPF.ViewModels
{
    public class TestViewModel : BindableBase
    {
        private Test _test;

        public Test Test
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }

        public TestViewModel()
        {
            _test = new Test();
            _test.Message = "This Prism Example";
        }

    }
}
