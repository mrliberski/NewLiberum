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
            DateTime Expiration = new DateTime(2024, 10, 17);
            if (Expiration > DateTime.Today)
            {
                //MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. It comes with no warranties whatsoever. ", "Licence Expiry date: " + Expiration.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(@"Hola, 
New updates:

1. Handover form will close after 5 mins of inactivity
2. To prevent total overwrite of handover you will only be able to save latest version. If your version is not the latest, it won't get saved so it might be beneficial to keep the form closed in between. 

Upcoming:

1. Handover will be split into 3 individual forms to improve readibility:
    -   Logistic
    -   Direct Supply
    -   Transports
2. Bits and bobs in the meantime

                ", "New updates 16.10.2024", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
