namespace WillowMaze.Wasm.Decompiled;


class NavItemSelectedListener : android.widget.Adapterobject$OnItemSelectedListener {
    private readonly androidx.appcompat.app.ActionBar$OnNavigationListener mListener;

    public NavItemSelectedListener(androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener) {
        this.mListener = actionBar$OnNavigationListener;
    }

    public static void WtTEAbDKSJrzBsmB(androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener, int i, long j, char c, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtTEAbDKSJrzBsmB(androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener, int i, long j, char c, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WtTEAbDKSJrzBsmB(androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener, int i, long j, int i2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WtTEAbDKSJrzBsmB(androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener, int i, long j) {
        return actionBar$OnNavigationListener.onNavigationItemSelected(i, j);
    }

    public override void OnItemSelected(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener = this.mListener;
        if (actionBar$OnNavigationListener is null) {
            return;
        }
        wtTEAbDKSJrzBsmB(actionBar$OnNavigationListener, i, j);
    }

    public override void OnNothingSelected(android.widget.Adapterobject<object> adapterobject) {
    }
}

