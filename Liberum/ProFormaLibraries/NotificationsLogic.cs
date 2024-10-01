using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class NotificationsLogic
    {
        // MAIN FUNCTION - all notifiction would have to be inserted here
        public static void DisplayNotificationsAsRequired()
        {
            FirstNote();
        }

        // UPDATE NOTE
        public static void FirstNote()
        {
            DateTime Expiration = new DateTime(2024, 10, 01);
            if (Expiration > DateTime.Today)
            {
                //MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. It comes with no warranties whatsoever. ", "Licence Expiry date: " + Expiration.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(@"Hola, 
New updates:

1. Handover form is all wired up and should work as expected. Let me know if it misbehaves. 

Upcoming:

1. Daily packagig count submitted via form will be inserted in database. 
2. Outbound packaging tracker. 
3. Links and what not

                ", "New updates 30.09.2024", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
