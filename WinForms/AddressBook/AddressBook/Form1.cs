using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        string filePath = "AddressBookDB.txt";
        List<Person> AddressBook = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            ReadDataFromFile(filePath);
            ShowDataOnScreen();
        }

        private void ReadDataFromFile(string filePath)
        {
            Person p;

            string[] people = File.ReadAllLines(filePath);

            foreach (var person in people)
            {
                string[] personParameters = person.Split(';');
                p = new Person();
                p.firstName = personParameters[0];
                p.lastName = personParameters[1];
                p.phoneNumber = personParameters[2];
                p.email = personParameters[3];

                AddressBook.Add(p);
            }
        }

        private void ShowDataOnScreen()
        {
            Panel pnl;

            foreach (var item in AddressBook)
            {
                pnl = new Panel();
                pnl.Size = new Size(200, 150);
                pnl.BorderStyle = BorderStyle.FixedSingle;

                flowLayoutPanelContainer.Controls.Add(pnl);
            }
        }
    }
}
