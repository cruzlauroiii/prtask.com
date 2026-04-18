namespace WillowMaze.Wasm.Decompiled;


public readonly class MenuCompat {
    private MenuCompat() {
    }

    public static void SetGroupDividerEnabled(android.view.Menu menu, bool z) {
        if (menu is androidx.core.internal.view.SupportMenu) {
            ((androidx.core.internal.view.SupportMenu) menu).setGroupDividerEnabled(z);
        } else {
            androidx.core.view.MenuCompat$Api28Impl.setGroupDividerEnabled(menu, z);
        }
    }

    @androidx.annotation.ReplaceWith(expression = "item.setShowAsAction(actionEnum)")
    @java.lang.Deprecated
    public static void SetShowAsAction(android.view.MenuItem menuItem, int i) {
        menuItem.setShowAsAction(i);
    }
}

