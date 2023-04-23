using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestSystem.Data;
using TestSystem.Models;
using TestSystem.Services;

namespace TestSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestSystemService service = new TestSystemService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnYes.IsEnabled = false;
            btnNo.IsEnabled = false;
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            var questions = DataAccessLayer.GetQuestions();
            service.SetQuestions(questions);
            btnYes.IsEnabled = true;
            btnNo.IsEnabled = true;
            txtQuestion.Text = service.CurrentQuestionContent;
        }

        private void ButtonAnswer_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if (service.CheckAnswer(button.Content.ToString()))
            {

            }
            else
            {
                btnYes.IsEnabled = false;
                btnNo.IsEnabled = false;
                MessageBox.Show("END");
            }
            lblInfo.Content = service.Score.ToString();
            txtQuestion.Text = service.CurrentQuestionContent.ToString();
        }
    }
}
