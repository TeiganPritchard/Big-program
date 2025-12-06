using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    
    public partial class Battle : Form
    {
        private BindingList<Character> party;
        private Character boss;

        private int playerMoves = 0; // Counts total player moves
        private int turn = 0; // Tracks whose turn it is



        public Battle(BindingList<Character> party, Character boss)
        {
            InitializeComponent();
            this.boss = boss;
            this.party = party;
            SetupFight();
        }



       
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

            UpdateMoves(party[turn]);
            label1.Text = $"{party[turn].CharacterName}'s turn";

        }

        // Changes the buttons
        public void UpdateMoves(Character character)
        {
            for(int i = 0; i < character.moves.Count; i++)
            {
                buttons.Controls[i].Text = character.moves[i].name;
            }
        }



        public void BossTurn()
        {
            if(boss.CharacterName == "Dragon")
            {
                if (new Random().Next(2) == 0)
                {
                    BossMove.DragonBreath(party);
                }
                else
                {
                    BossMove.DragonClaw(party);
                }
            }
            else if(boss.CharacterName == "Knight")
            {
                if(new Random().Next(2) == 0)
                {
                    BossMove.KnightCleave(party);
                }
                else
                {
                    BossMove.KnightShieldBash(party);
                }
            }
            else if(boss.CharacterName == "Ogre")
            {
                if (new Random().Next(2) == 0)
                {
                    BossMove.OgreSmash(party);
                }
                else
                {
                    BossMove.OgreStomp(party);
                }
            }
        }

        private void PressAnyButton(object sender, EventArgs e)
        {
            // 1. Figure out what button and move was used
            Button pressedButton = (Button)sender;

            // 2. Figure out which character's turn it is
            Character currentCharacter = party[turn];
            label1.Text = $"{currentCharacter.CharacterName}'s turn";

            // 3. Find the move the player clicked
            GameMove selectedMove = currentCharacter.moves.FirstOrDefault(m => m.name == pressedButton.Text);
            if (selectedMove != null)
            {
                // 4. Apply the move to the boss
                selectedMove.effect(currentCharacter, boss);
                if (boss.HP < 0) boss.HP = 0;

                // 5. Increment player move counter and trigger boss every 4 moves
                playerMoves++;
                if (playerMoves % 4 == 0)
                {
                    BossTurn();
                }

                // 6. Check for win/lose
                if (boss.HP <= 0)
                {
                    MessageBox.Show("You defeated the boss!");
                    this.Close();
                    return;
                }
                if (party.All(p => p.HP <= 0))
                {
                    MessageBox.Show("Your party was defeated!");
                    this.Close();
                    return;
                }

                // 7. Move to next alive player
                turn = (turn + 1) % party.Count;
                while (party[turn].HP <= 0)
                {
                    turn = (turn + 1) % party.Count;
                }

                // 8. Update buttons for the next player
                UpdateMoves(party[turn]);
            }
        }


    }
}
