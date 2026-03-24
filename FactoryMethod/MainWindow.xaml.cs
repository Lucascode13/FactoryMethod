using System.Windows;
using FactoryMethod.ViewModels;

namespace FactoryMethod
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); // ESSENCIAL
        }
    }
}