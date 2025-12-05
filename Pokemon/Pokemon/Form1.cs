using Pokemon.Properties;
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
        Random random = new Random();
        public BindingList<Character> characterList = new BindingList<Character>();
        public BindingList<Character> party = new BindingList<Character>();
        public Character[] bosses = new Character[2];
        public Form1()
        {
            InitializeComponent();
            Character mage = new Character("Mage", 40, 2, 50, Properties.Resources.Mage);
            Character warrior = new Character("Warrior", 15, 20, 100, Properties.Resources.Warrior);


            Character ogre = new Character("Ogre", 15, 15, 6000, Properties.Resources.Ogre);

            characterList.Add(mage);
            characterList.Add(warrior);

            CharacterListing.DataSource = characterList;
            currentParty.DataSource = party;

        }

        // when the button is clicked do this
        private void ClickAddToParty(object sender, EventArgs e)
        {
            // check how many characters are in the current party
            if(party.Count < 4)
            {
                // iterate through the list of selectable characters one by one
                foreach (Character singleCharacter in characterList)
                {
                    // compare the name of the character to the current selected dude
                    if (singleCharacter.CharacterName == CharacterListing.CurrentCell.OwningRow.Cells["CharacterName"].Value.ToString())
                    {
                        party.Add(singleCharacter);
                    }
                }
            }
        }

        // we want to remove a character from the sheet, when clicked
        private void ClickRemoveButton(object sender, EventArgs e)
        {
            //Identify the selected row
            if (currentParty.SelectedRows.Count == 0)
            {
                // if there is, return
                MessageBox.Show("There's nothing selected to be removed");
                return;
            }

            // and then update the labels and expense list
            party.RemoveAt(currentParty.SelectedRows[0].Index);
        }

        private void FightClick(object sender, EventArgs e)
        {
            if(party.Count != 4)
            {
                MessageBox.Show("You must select four party members!");
                return;
            }

            Battle fight = new Battle(party, bosses[random.Next(2)]);
            fight.ShowDialog();


        }
    }
}
