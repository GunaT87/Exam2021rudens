﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ChromeOptions options;
        private object element;

        public Form1()
        {
            InitializeComponent();
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\37125\Documents\Programmaturas izstrades tehnologijas\Chrom\chromedriver_win32", options);
            driver.FindElement(By.Id("gh-ac")).SendKeys("ebay.com");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\37125\Documents\Programmaturas izstrades tehnologijas\Chrom\chromedriver_win32", options);
            driver.Url = "https://www.ebay.com/";
            driver.FindElement(By.Id("gh-btn")).Click();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\37125\Documents\Programmaturas izstrades tehnologijas\Chrom\chromedriver_win32", options);
            driver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\37125\Documents\Programmaturas izstrades tehnologijas\Chrom\chromedriver_win32", options);
            driver.Navigate().Back();


        }
    }
}
