using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro.Contrib.WPF.Demo.ViewModels;

namespace Caliburn.Micro.Contrib.WPF.Demo
{
    public interface IDemo { }

    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {

        public IObservableCollection<string> LogItems { get; private set; }
        public IObservableCollection<IDemo> Demos { get; set; }

        public CoreDemoViewModel CoreDemo { get; set; }
        public DialogsDemoViewModel DialogsDemo { get; set; }
        public DynamicDemoViewModel DynamicDemo { get; set; }

        public void Log(string message)
        {
            LogItems.Insert(0, message);
        }

        public ShellViewModel()
        {
            Demos = new BindableCollection<IDemo>(IoC.GetAllInstances(typeof(IDemo)).Cast<IDemo>());

            LogItems = new BindableCollection<string>();
        }
    }
}