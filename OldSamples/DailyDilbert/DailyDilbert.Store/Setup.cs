using Cirrious.MvvmCross.ViewModels;
using Windows.UI.Xaml.Controls;

namespace DailyDilbert.Store
{
    public class Setup : MvxStoreSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new DailyDilbert.Core.App();
        }
    }
}