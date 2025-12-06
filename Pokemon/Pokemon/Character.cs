using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Character
    {
        private string characterName;
        private int atk;
        private int hP;
        private int def;
        public Image image;
        public List<GameMove> moves = new List<GameMove>();


        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }
        public int Atk
        {
            get { return atk; }
            set { atk = value; }
        }
        public int HP
        {
            get { return hP; }
            set { hP = value; }
        }
        public int Def
        {
            get { return def; }
            set { def = value; }
        }
        //public Image Image
        //{
        //    get { return image; }
        //    set { image = value; }
        //}

        public Character(string name, int atk, int def, int hP, Image image)
        {

            this.CharacterName = name;
            this.Atk = atk;
            this.HP = hP;
            this.Def = def;
            this.image = image;

        }
        public Character(string name, int hP, Image image)
        {
            this.CharacterName = name;
            this.HP = hP;
            this.image = image;
        }
    }
}