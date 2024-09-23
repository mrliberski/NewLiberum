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
            DateTime Expiration = new DateTime(2024, 09, 25);
            if (Expiration > DateTime.Today)
            {
                //MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. It comes with no warranties whatsoever. ", "Licence Expiry date: " + Expiration.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. 
Updates since Monday:

1. Added Registration number to Packaging Tracker
2. Stating discrepancy between advised & received qty will trigger automatic email alert. 
3! Please please please start putting incoming Joyson packaging on the tracker as they also monitor packaging inventory. 

Upcoming:

1. Daily packagig count submitted via form will be inserted in database. 
This will allow close monitoring of balance.
2. Outbound packaging tracker. 
3. Tell me what features you need and we'll look into it. There won't be a better time to get it done. 
4. Handover - your input is needed.

                ", "New updates 23.09.2024", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
