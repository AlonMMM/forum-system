using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    public class SubForum
    {

        public SubForum(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }



    }
}
