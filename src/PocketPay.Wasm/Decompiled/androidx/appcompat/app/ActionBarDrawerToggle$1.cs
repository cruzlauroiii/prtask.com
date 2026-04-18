namespace WillowMaze.Wasm.Decompiled;


class ActionBarDrawerToggle$1 : android.view.object$OnClickListener {
    readonly androidx.appcompat.app.ActionBarDrawerToggle this$0;

    ActionBarDrawerToggle$1(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        this.this$0 = actionBarDrawerToggle;
    }

    public static void OBmxcLWqxVsGXnhC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        actionBarDrawerToggle.toggle();
    }

    public static void OBmxcLWqxVsGXnhC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OBmxcLWqxVsGXnhC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBmxcLWqxVsGXnhC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TvgPLcuHvQFrRkNB(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public static void TvgPLcuHvQFrRkNB(android.view.object$OnClickListener view$OnClickListener, android.view.object view, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TvgPLcuHvQFrRkNB(android.view.object$OnClickListener view$OnClickListener, android.view.object view, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TvgPLcuHvQFrRkNB(android.view.object$OnClickListener view$OnClickListener, android.view.object view, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnClick(android.view.object view) {
        if (this.this$0.mDrawerIndicatorEnabled) {
            OBmxcLWqxVsGXnhC(this.this$0);
        } else {
            if (this.this$0.mToolbarNavigationClickListener is null) {
                return;
            }
            tvgPLcuHvQFrRkNB(this.this$0.mToolbarNavigationClickListener, view);
        }
    }
}

