namespace WillowMaze.Wasm.Decompiled;


class AppCompatobject$1 : androidx.savedstate.SavedStateRegistry$SavedStateProvider {
    readonly androidx.appcompat.app.AppCompatobject this$0;

    AppCompatobject$1(androidx.appcompat.app.AppCompatobject appCompatobject) {
        this.this$0 = appCompatobject;
    }

    public static androidx.appcompat.app.AppCompatDelegate VZThlLsqBUaCOEMj(androidx.appcompat.app.AppCompatobject appCompatobject) {
        return appCompatobject.getDelegate();
    }

    public static void VZThlLsqBUaCOEMj(androidx.appcompat.app.AppCompatobject appCompatobject, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZThlLsqBUaCOEMj(androidx.appcompat.app.AppCompatobject appCompatobject, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZThlLsqBUaCOEMj(androidx.appcompat.app.AppCompatobject appCompatobject, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EDRUUEqGatNocYaA(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.os.Dictionary<string, object> bundle) {
        appCompatDelegate.onSaveInstanceState(bundle);
    }

    public static void EDRUUEqGatNocYaA(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EDRUUEqGatNocYaA(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.os.Dictionary<string, object> bundle, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EDRUUEqGatNocYaA(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.os.Dictionary<string, object> bundle, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override android.os.Dictionary<string, object> SaveState() {
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        eDRUUEqGatNocYaA(VZThlLsqBUaCOEMj(this.this$0), bundle);
        return bundle;
    }
}

