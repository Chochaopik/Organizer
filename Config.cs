using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Organizer {
    public static class Config {

        public static bool pause = false;

        public static Form1 form;
        public static Button btn;
        public static bool attente = false;
        public static int attenteId = 0;

        public static List<Fenetre> fenetres = new List<Fenetre>();
        public static List<Fenetre> checks = new List<Fenetre>();

        public static List<Keys> raccourcis = new List<Keys>() { Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None, Keys.None };
        private static string fichierSave = Application.StartupPath + "/keys.json";

        public static void putBtn(Button newBtn) {
            attenteId = int.Parse(newBtn.Name.Replace("btnfen", ""))-1;
            if (newBtn == btn) {
                outBtn(btn);
            } else if (attente) {
                btn.Text = "Aucun raccourci";
                btn = newBtn;
                raccourcis[attenteId] = Keys.None;
                Config.sauvegarderRaccourcis();
                btn.Text = "Appuyez sur une touche";
            } else if (raccourcis[attenteId] != Keys.None) {
                attente = true;
                raccourcis[attenteId] = Keys.None;
                Config.sauvegarderRaccourcis();
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
                raccourcis[attenteId] = Keys.None;
                Config.sauvegarderRaccourcis();
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
