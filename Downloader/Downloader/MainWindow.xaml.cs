using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Downloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayText.Text = WebsiteUrl.Text;

            var currentUrl = WebsiteUrl.Text;

            await Task.Run(async () =>
            {
                var webClient = new WebClient();

                var downloaderString = await webClient.DownloadStringTaskAsync(currentUrl);

            });


            var doSomeWorkTask =  DoSomeWork();

            doSomeWorkTask.Wait();

            var resultInt  = doSomeWorkTask.Result;

            await DoSomeWork();

        }

        /// <summary>
        /// mnmhmbn
        /// </summary>
        /// <returns>mnm,bnń</returns>
        private async Task<int> DoSomeWork()
        {
            var a = 2;

            await Task.Delay(1000);

            return 2;
        }






    }






}
