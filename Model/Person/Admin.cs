using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MendezPablo_Proyecto.Modelo.Person
{
    class Admin : Person
    {
        private int accessLevel;
        private bool godMode;

        public Admin(int id, string name, string password) :
               this(id, name, password, 0, true)
        { }

        public Admin(int id, string name, string password, int accessLevel, bool godMode) : base(id, name, password)
        {
            this.accessLevel = accessLevel;
            this.godMode = godMode;

        }

        public int AccessLevel { get => accessLevel; set => accessLevel = value; }
        public bool GodMode { get => godMode; set => godMode = value; }
    }
}
