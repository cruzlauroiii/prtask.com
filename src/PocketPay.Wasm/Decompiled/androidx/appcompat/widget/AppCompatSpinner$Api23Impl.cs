namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatSpinner$Api23Impl {
    private AppCompatSpinner$Api23Impl() {
    }

    public static void DMLMLCVqqMeoXHgT(android.widget.ThemedSpinnerAdapter themedSpinnerAdapter, android.content.res.Resources$Theme resources$Theme) {
        themedSpinnerAdapter.setDropDownobjectTheme(resources$Theme);
    }

    public static bool HmKqQeOSfUsVJAxx(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.objectsCompat.Equals(obj, obj2);
    }

    public static android.content.res.Resources$Theme bErVLTeQdbeukefB(android.widget.ThemedSpinnerAdapter themedSpinnerAdapter) {
        return themedSpinnerAdapter.getDropDownobjectTheme();
    }

    static void SetDropDownobjectTheme(android.widget.ThemedSpinnerAdapter themedSpinnerAdapter, android.content.res.Resources$Theme resources$Theme) {
        if (HmKqQeOSfUsVJAxx(bErVLTeQdbeukefB(themedSpinnerAdapter), resources$Theme)) {
            return;
        }
        DMLMLCVqqMeoXHgT(themedSpinnerAdapter, resources$Theme);
    }
}

