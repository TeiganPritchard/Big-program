using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Character mage = new Character("Mage", 20, 2, 50, Properties.Resources.Mage);
            BindingList<Character> characterList = new BindingList<Character>{mage};
            CharacterListing.DataSource = characterList;
        }

        private void StartBattleButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
