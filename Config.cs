using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Organizer {
    public static class Config {

        public static Form1 form;
        public static Button btn;
        public static bool attente = false;

        public static List<Fenetre> fenetres = new List<Fenetre>();
        public static List<Fenetre> checks = new List<Fenetre>();

        public static List<Keys> raccourcis = new List<Keys>() { Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None };
        private static string fichierSave = Application.StartupPath + "/keys.json";

        public static void putBtn(Button newBtn) {
            if (newBtn == btn) {
                outBtn(btn);
            } else if (attente) {
                btn.Text = "Aucun raccourci";
                btn = newBtn;
                btn.Text = "Appuyez sur une touche";
            } else {
                attente = true;
                btn = newBtn;
                btn.Text = "Appuyez sur une touche";
            }
        }

        public static void outBtn(Button oldBtn) {
            if (oldBtn.Equals(btn)) {
                attente = false;
                btn.Text = "Aucun raccourci";
                btn = null;
            }
        }

        public static void sauvegarderRaccourcis() {
            var lignes = raccourcis.Select(k => k.ToString()).ToList();
            File.WriteAllLines(fichierSave, lignes);
        }

        public static void chargerRaccourcis() {
            if (File.Exists(fichierSave)) {
                var lignes = File.ReadAllLines(fichierSave);
                raccourcis = lignes.Select(l => (Keys)Enum.Parse(typeof(Keys), l)).ToList();
            }

            for (int i = 0; i < raccourcis.Count; i++) {
                string racTxt = raccourcis[i].ToString();
                if (racTxt == "None") racTxt = "Aucun raccourci";
                form.renBtn("btnfen" + (i + 1), racTxt);
            }
        }
    }
}
