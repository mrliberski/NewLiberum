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
            DateTime Expiration = new DateTime(2024, 11, 07);
            if (Expiration > DateTime.Today)
            {
                //MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. It comes with no warranties whatsoever. ", "Licence Expiry date: " + Expiration.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(@"Hola, 
New updates:

Warehouse section in Handover was renamed to Warehouse Locations Daily Checks on Cyrus' reqest.

Airbag Flaps & chutes pallet factor amended.

Some background logic was updated. 

                ", "New updates 06.11.2024", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
