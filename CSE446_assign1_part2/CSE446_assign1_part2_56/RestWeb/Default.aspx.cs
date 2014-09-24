using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Runtime.Serialization;

public partial class _Default : System.Web.UI.Page
{
    static string secret;  //golbal variable
    static int attempt;    //golable variable
    protected void Page_Load(object sender, EventArgs e){ }
    protected void Btn1_Click(object sender, EventArgs e)
    {
        //Creat the base address to the secretNum service
        Uri baseUri = new Uri("http://localhost:1192/WcfService/Service.svc");
        // create the path from tree root to child node
        UriTemplate myTemplate = new UriTemplate("secret/{lower}/{upper}");
        // Assign values to variable to complete URI
        Uri completeUri = myTemplate.BindByPosition(baseUri,
        lowerTxt.Text,UpperTxt.Text);
        WebClient proxy = new WebClient();  //create proxy
        byte[] abc = proxy.DownloadData(completeUri);  //receive in byte
        Stream strm = new MemoryStream(abc);  //convert to memo stream
        DataContractSerializer obj = new DataContractSerializer(typeof(string));
        secret = obj.ReadObject(strm).ToString();
        attempt = 0;
        lbl1.Text =  Convert.ToString(attempt);
        lblgenerate.Text = "Secret Num has been generated";
      
    }
    protected void Btn2_Click(object sender, EventArgs e)
    {
        attempt++;
        lbl1.Text = Convert.ToString(attempt);
        //Creat the base address to the secretNum service
        Uri baseUri = new Uri("http://localhost:1192/WcfService/Service.svc");
        // create the path from tree root to child node
        UriTemplate myTemplate = new UriTemplate("check/{userNum}/{SecretNum}");
        // Assign values to variable to complete URI
        Uri completeUri = myTemplate.BindByPosition(baseUri,
        lowtxt0.Text,secret);
        WebClient prox = new WebClient();  //create proxy
        byte[] abc = prox.DownloadData(completeUri);  //receive in byte
        Stream strm = new MemoryStream(abc);  //convert to memo stream
        DataContractSerializer obj = new DataContractSerializer(typeof(string));
        lbl2.Text = obj.ReadObject(strm).ToString();
    }
}
