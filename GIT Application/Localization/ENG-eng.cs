using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_Application.Localization
{
    internal class ENG_eng : Lang
    {
        public ENG_eng() 
        {
            Greeting = "Welcome to GitHub \nSibSUTIS Desktop";
            GreetingSecond = "Clone a repository or create a new one";
            CloneRepo = "Clone a repository";
            CreateRepo = "Create a repository";
            NameRepo = "Name:";
            DescriptionRepo = "Description:";
            LocalPath = "Local Path:";
            GitIgnore = "GIT Ignore:";
        }
    }
}
