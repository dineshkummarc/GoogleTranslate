// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Stetic {
    
    
    internal class Gui {
        
        private static bool initialized;
        
        internal static void Initialize(Gtk.Widget iconRenderer) {
            if ((Stetic.Gui.initialized == false)) {
                Stetic.Gui.initialized = true;
                Gtk.IconFactory w1 = new Gtk.IconFactory();
                Gtk.IconSet w2 = new Gtk.IconSet();
                Gtk.IconSource w3 = new Gtk.IconSource();
                w3.Pixbuf = new Gdk.Pixbuf(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "./res/swap.png"));
                w2.AddSource(w3);
                Gtk.IconSource w4 = new Gtk.IconSource();
                w4.Pixbuf = new Gdk.Pixbuf(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "./res/flags/ar.png"));
                w2.AddSource(w4);
                Gtk.IconSource w5 = new Gtk.IconSource();
                w5.Pixbuf = new Gdk.Pixbuf(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "./res/flags/bg.png"));
                w2.AddSource(w5);
                w1.Add("swap", w2);
                w1.AddDefault();
            }
        }
    }
    
    internal class ActionGroups {
        
        public static Gtk.ActionGroup GetActionGroup(System.Type type) {
            return Stetic.ActionGroups.GetActionGroup(type.FullName);
        }
        
        public static Gtk.ActionGroup GetActionGroup(string name) {
            return null;
        }
    }
}
