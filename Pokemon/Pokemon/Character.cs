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
        private string name;
        private int atk;
        private int hP;
        private int def;
        private Image image;
        public string Name
        {
            get { return name; }
            set { name = value; }
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
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public Character(string name, int atk, int def, int hP, Image image)
        {

            this.Name = name;
            this.atk = atk;
            this.HP = hP;
            this.Def = def;
            this.Image = image;

        }
    }
}