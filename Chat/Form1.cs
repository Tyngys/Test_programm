﻿using Chat.FormClient;
using Chat.FormServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CreateServer_Click(object sender, EventArgs e)
        {
            Server formServer = new Server();
            formServer.Show();
            
        }

        private void button_CreateClient_Click(object sender, EventArgs e)
        {
            Client formClient = new Client();
            formClient.Show();
        }
    }
}
