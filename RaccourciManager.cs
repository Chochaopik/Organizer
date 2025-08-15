using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer {
    public class RaccourciManager {

        private int indexActuel = 0;

        private IKeyboardMouseEvents globalHook;

        public RaccourciManager() {
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalHook_KeyDown;
        }

        private void GlobalHook_KeyDown(object sender, KeyEventArgs e) {
            if (Config.checks.Count == 0) return;

            if (Config.raccourcis.Contains(e.KeyCode)) {
                int getIndex = Config.raccourcis.IndexOf(e.KeyCode);
                if (getIndex == 16) {
                    indexActuel--;
                    if (indexActuel < 0) indexActuel = Config.checks.Count - 1;
                } else  if (getIndex == 17) {
                    indexActuel++;
                    if (indexActuel > Config.checks.Count-1) indexActuel = 0;
                } else if (getIndex < 16) {
                    if (getIndex > Config.checks.Count - 1) return;
                    indexActuel = getIndex;
                } else {
                    return;
                }
                Config.form.BringToFront(Config.checks[indexActuel].hWnd);
            }
        }

        public void Stop() {
            globalHook.KeyDown -= GlobalHook_KeyDown;
            globalHook.Dispose();
        }
    }
}
