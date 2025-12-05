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
    public partial class Battle : Form
    {
        private BindingList<Character> party;
        private Character boss;


        public Battle(BindingList<Character> party, Character boss)
        { 
            InitializeComponent();
            this.boss = boss;
            this.party = party;
        }

        public void SetupFight()
        {
            foreach(Character character in this.party)
            {

            }
        }


    }
}
