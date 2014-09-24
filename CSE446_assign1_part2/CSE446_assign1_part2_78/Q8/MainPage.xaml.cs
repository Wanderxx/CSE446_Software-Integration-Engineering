using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Windows;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Collections.Generic;

namespace Q8
{
    public partial class MainPage : PhoneApplicationPage
    {
        static string secret;
        static int attempt;
        static string result;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
           // headStoryboard.Begin();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            headStoryboard.Pause();
            string Number1 = Lowtxt.Text;
            string Number2 = Uptxt.Text;
            string ServiceUri = "http://localhost:1192/WcfService/Service.svc/secret/"
                                 + Number1 + "/"+ Number2;   //build URL
            WebClient proxy = new WebClient();  //create proxy
            proxy.DownloadStringCompleted +=
new DownloadStringCompletedEventHandler(proxy_DownloadStringCompleted);
            proxy.DownloadStringAsync(new Uri(ServiceUri));   //get the secret
            attempt=0;
            atmptTxt.Text = "Atemptes  " + attempt ;
        }

        void proxy_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Stream stream = new MemoryStream(Encoding.Unicode.GetBytes(e.Result));
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(string));
            secret  = obj.ReadObject(stream).ToString();
            numtxt.Text = "The num is: ";
            MessageBox.Show("Number has been generated!");
        }

        private void guessBtn_Click(object sender, RoutedEventArgs e)
        {
            attempt++;           
            string Number1 = guesstxt.Text;
            string Number2 = secret;
            string ServiceUri = "http://localhost:1192/WcfService/Service.svc/check/"
                                 + Number1 + "/" + Number2;    //build url
            WebClient prox = new WebClient();  //create proxy
            prox.DownloadStringCompleted +=
new DownloadStringCompletedEventHandler(prox_DownloadStringCompleted);   // stream to string 
            prox.DownloadStringAsync(new Uri(ServiceUri));
            
            atmptTxt.Text = "Atemptes  " + attempt;

        }
        void prox_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Stream stream = new MemoryStream(Encoding.Unicode.GetBytes(e.Result));
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(string));
            result = obj.ReadObject(stream).ToString();
            numtxt.Text = "The num is: " + result;
            if (result.Equals("correct"))     //animation
                headStoryboard.Begin();
            else
                headStoryboard.Pause();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        
    }
   
}