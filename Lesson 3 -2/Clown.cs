using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3__2
{
    class Clown
    {
        public string Name;
        public int Height;


        public void TalkAboutYourself()
        {
            MessageBox.Show("My Name is" + Name + " and I'm " + Height);
        }
    }

   


    
}
