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
        public Character[] bosses = new Character[3];
        public Form1()
        {
            InitializeComponent();
            CreateCharacters();
            CharacterListing.DataSource = characterList;
            currentParty.DataSource = party;

        }

        // when the button is clicked do this
        private void ClickAddToParty(object sender, EventArgs e)
        {
            // check how many characters are in the current party
            if (party.Count < 4)
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

        // to begin the battle, press the fight button
        private void FightClick(object sender, EventArgs e)
        {
            // first we check if the party has four members
            if (party.Count != 4)
            {
                // if it doesnt, we alert the user
                MessageBox.Show("You must select four party members!");
                // and then return
                return;
            }

            // create a new battle instance with a random boss
            Battle fight = new Battle(party, bosses[random.Next(3)]);
            // show the battle form
            fight.ShowDialog();


        }
        public void CreateCharacters()
        {
            // create some characters to choose from
            Character mage = new Character("Mage", 40, 2, 100, Properties.Resources.Mage);
            Character warrior = new Character("Warrior", 15, 20, 200, Properties.Resources.Warrior);
            Character priest = new Character("Priest", 5, 8, 100, Properties.Resources.Priest);
            Character rogue = new Character("Rogue", 30, 10, 150, Properties.Resources.Rogue);


            // create the bossses, which are use a different constructor
            Character knight = new Character("Knight",750,Properties.Resources.Knight);
            Character ogre = new Character("Ogre",1000,Properties.Resources.Ogre);
            Character dragon = new Character("Dragon",1250, Properties.Resources.Dragon);

            // create the mage
            characterList.Add(mage);
            characterList.Add(warrior);
            characterList.Add(priest);
            characterList.Add(rogue);


            mage.moves.Add(new GameMove("FireBall", GameMove.FireBall));
            mage.moves.Add(new GameMove("PyroBlast", GameMove.PyroBlast));
            mage.moves.Add(new GameMove("Mage Shield", GameMove.MageShield));
            mage.moves.Add(new GameMove("Mage Melee", GameMove.MageMelee));

            warrior.moves.Add(new GameMove("Slam", GameMove.WarriorSlam));
            warrior.moves.Add(new GameMove("Defend", GameMove.WarriorDefend));
            warrior.moves.Add(new GameMove("Strike", GameMove.WarriorStrike));
            warrior.moves.Add(new GameMove("Rage", GameMove.WarriorRage));

            rogue.moves.Add(new GameMove("Backstab", GameMove.RogueBackstab));
            rogue.moves.Add(new GameMove("Evade", GameMove.RogueEvade));
            rogue.moves.Add(new GameMove("Slice", GameMove.RogueSlice));
            rogue.moves.Add(new GameMove("Instant Poison", GameMove.RoguePoison));

            priest.moves.Add(new GameMove("Heal", GameMove.PriestSmallHeal));
            priest.moves.Add(new GameMove("Greater Heal", GameMove.PriestLargeHeal));
            priest.moves.Add(new GameMove("Smite", GameMove.PriestSmite));
            priest.moves.Add(new GameMove("Revive", GameMove.PriestRevive));


            bosses[0] = knight;
            bosses[1] = ogre;
            bosses[2] = dragon;
        }
    }
}
