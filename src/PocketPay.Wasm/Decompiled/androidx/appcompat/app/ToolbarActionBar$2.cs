namespace WillowMaze.Wasm.Decompiled;


class ToolbarActionBar$2 : androidx.appcompat.widget.Toolbar$OnMenuItemClickListener {
    readonly androidx.appcompat.app.ToolbarActionBar this$0;

    ToolbarActionBar$2(androidx.appcompat.app.ToolbarActionBar toolbarActionBar) {
        this.this$0 = toolbarActionBar;
    }

    public static void SXGVzwUPLEORcSLe(android.view.Window$Callback window$Callback, int i, android.view.MenuItem menuItem, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SXGVzwUPLEORcSLe(android.view.Window$Callback window$Callback, int i, android.view.MenuItem menuItem, java.lang.string str, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SXGVzwUPLEORcSLe(android.view.Window$Callback window$Callback, int i, android.view.MenuItem menuItem, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SXGVzwUPLEORcSLe(android.view.Window$Callback window$Callback, int i, android.view.MenuItem menuItem) {
        return window$Callback.onMenuItemSelected(i, menuItem);
    }

    public override bool OnMenuItemClick(android.view.MenuItem menuItem) {
        return SXGVzwUPLEORcSLe(this.this$0.mWindowCallback, 0, menuItem);
    }
}

