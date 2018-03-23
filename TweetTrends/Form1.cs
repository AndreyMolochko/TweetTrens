﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweetTrends
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data data = new Data("my_life.txt");
            // = data.tweetsWithData[0];
            Sentiments sentiments = new Sentiments("sentiments.csv");
            List<Coordinates> test = new List<Coordinates>();
            //label1.Text=sentiments.getAverageSentiment(data.tweets[0].context).ToString();
            label1.Text = data.parsing.state.coordinatesState.ElementAt(0).Value.ElementAt(1).latitude.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String jsonn = "";
            State state = new State();
            Newtonsoft.Json.JsonConvert.PopulateObject(textBox1.Text, state);
            //MessageBox.Show(state.allStates.ContainsKey("WA").ToString());
            //MessageBox.Show(state.WA.Count.ToString());
        }
    }
}
