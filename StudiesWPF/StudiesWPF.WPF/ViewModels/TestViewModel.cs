using Prism.Mvvm;
using Prism.Regions;
using StudiesWPF.WPF.Models;

namespace StudiesWPF.WPF.ViewModels
{
    public class TestViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private Test _test;
        public Test Test
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }

        public TestViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _test = new Test();
            _test.Message = "This Prism Example";
        }

    }
}
