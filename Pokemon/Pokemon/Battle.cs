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
            SetupFight();
        }



        // this is where i stopped
        public void SetupFight()
        {

            // hard coding these because i dont feel like making multiple arrays of variables to work with
            character1.Image = party[0].image;
            character2.Image = party[1].image;
            character3.Image = party[2].image;
            character4.Image = party[3].image;
               

            // this really feels like a jxswing setup lol
            character1HP.Maximum = party[0].HP;
            character1HP.Value = party[0].HP;
            character2HP.Maximum = party[1].HP;
            character2HP.Value = party[1].HP;
            character3HP.Maximum = party[2].HP;
            character3HP.Value = party[2].HP;
            character4HP.Maximum = party[3].HP;
            character4HP.Value = party[3].HP;

            bossPicture.Image = boss.image;
            
        }


    }
}
