using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace YoutubeCrawler
{
  public partial class Form1 : Form
  {
    ChromeDriverService service;
    ChromeOptions options;
    IWebDriver driver;
    public Form1()
    {
      InitializeComponent();
      service = ChromeDriverService.CreateDefaultService();
      service.HideCommandPromptWindow = true;
      options = new ChromeOptions();
      options.AddArguments("headless");
      driver = new ChromeDriver(service, options);
    }

    ArrayList array = new ArrayList();
    private void Recommand_Btn_Click(object sender, EventArgs e)
    {
      array.Clear();
      listBox1.Items.Clear();
      PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6};
      Button[] buttons = { button1,button2,button3,button4,button5,button6 };
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      driver.Url = "https://www.youtube.com/";

      int k = 0;
      List<IWebElement> elements1 = driver.FindElements(By.TagName("ytd-rich-item-renderer")).ToList();
      foreach(IWebElement x in elements1)
      {
        if (x.Text == "") continue;
        listBox1.Items.Add(x.Text);
        array.Add(x.FindElement(By.Id("thumbnail")).GetAttribute("href"));
        try
        {
          if (k < 6)
          {
            buttons[k].Text = x.Text;
            pictureBoxes[k].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxes[k].ImageLocation = x.FindElement(By.Id("img")).GetAttribute("src").Split('?')[0];
            k++;
          }
        }
        catch { }
      }
    }

    private void YoutubeSearch_Btn_Click(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      browser = new ChromiumWebBrowser(@"https://www.youtube.com/results?search_query=" + textBox1.Text);
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }
    private void ProcessKill_Btn_Click(object sender, EventArgs e)
    {
      try
      {
        Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
        foreach(Process x in process) x.Kill();
        panel1.Controls.Remove(browser);
      }
      catch { }
    }


    public ChromiumWebBrowser browser;
    private void button1_Click(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      browser = new ChromiumWebBrowser(array[0].ToString());
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      IWebDriver driver = new ChromeDriver(service, options);
      browser = new ChromiumWebBrowser(array[1].ToString());
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }
    private void button3_Click(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      IWebDriver driver = new ChromeDriver(service, options);
      browser = new ChromiumWebBrowser(array[2].ToString());
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }
    private void button4_Click(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      IWebDriver driver = new ChromeDriver(service, options);
      browser = new ChromiumWebBrowser(array[3].ToString());
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }
    private void button5_Click(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      IWebDriver driver = new ChromeDriver(service, options);
      browser = new ChromiumWebBrowser(array[4].ToString());
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }
    private void button6_Click(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      IWebDriver driver = new ChromeDriver(service, options);
      browser = new ChromiumWebBrowser(array[5].ToString());
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Process[] process = Process.GetProcessesByName("CefSharp.BrowserSubprocess");
      foreach (Process x in process)
      {
        x.Kill();
      }
      panel1.Controls.Remove(browser);
      if (Cef.IsInitialized.Equals(false)) Cef.Initialize(new CefSettings());
      browser = new ChromiumWebBrowser(array[listBox1.SelectedIndex].ToString());
      browser.Dock = DockStyle.Fill;
      panel1.Controls.Add(browser);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Process[] process = Process.GetProcessesByName("chrome");
      foreach (Process x in process) x.Kill();
      process = Process.GetProcessesByName("chromedriver");
      foreach (Process x in process) x.Kill();
    }
  }
}
