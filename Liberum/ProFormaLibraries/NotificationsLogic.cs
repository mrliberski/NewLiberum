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
            DateTime Expiration = new DateTime(2024, 10, 15);
            if (Expiration > DateTime.Today)
            {
                //MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. It comes with no warranties whatsoever. ", "Licence Expiry date: " + Expiration.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(@"Hola, 
New updates:

1. Internal Packaging count form has been wired up and is ready to use
2. Additional form was added to report bugs or submit ideas

Upcoming:

1. Handover will be split into 3 individual form to improve readibility:
    -   Logistic
    -   Direct Supply
    -   Transports

3. Links and control page - I need list form yourselves

                ", "New updates 14.10.2024", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
