using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;

namespace PracticalWork12.Helpers
{
    internal class Helpers
    {
        public static BoardGamesEntities DB = new BoardGamesEntities();
        public static Label label;
        public static Frame frame;
        public static Users CurrentUser;
    }
}
