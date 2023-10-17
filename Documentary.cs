using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Documentary : Content
    {
        private String tvProducer;
        private bool voiceOver;

        public Documentary(int id, string title, string category) :
               this(id, title, category, String.Empty, true)
        { }

        public Documentary(int id, string title, string category, string tvProducer, bool voiceOver) : base(id, title, category)
        {
            this.tvProducer = tvProducer;
            this.voiceOver = voiceOver;
        }

        public string TvProducer { get => tvProducer; set => tvProducer = value; }
        public bool VoiceOver { get => voiceOver; set => voiceOver = value; }



    }
}
