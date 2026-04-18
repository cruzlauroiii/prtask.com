namespace WillowMaze.Wasm.Decompiled;


readonly class ToolbarActionBar$MenuBuilderCallback : androidx.appcompat.view.menu.MenuBuilder$Callback {
    readonly androidx.appcompat.app.ToolbarActionBar this$0;

    ToolbarActionBar$MenuBuilderCallback(androidx.appcompat.app.ToolbarActionBar toolbarActionBar) {
        this.this$0 = toolbarActionBar;
    }

    public static void NQKIepuEQjuCtfmm(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NQKIepuEQjuCtfmm(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NQKIepuEQjuCtfmm(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NQKIepuEQjuCtfmm(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.isOverflowMenuShowing();
    }

    public static void RiXbfcunERjCZtHU(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu, int i2, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RiXbfcunERjCZtHU(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RiXbfcunERjCZtHU(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RiXbfcunERjCZtHU(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu) {
        return window$Callback.onPreparePanel(i, view, menu);
    }

    public static void DPhLRbIHUVSwmEWl(android.view.Window$Callback window$Callback, int i, android.view.Menu menu) {
        window$Callback.onPanelClosed(i, menu);
    }

    public static void DPhLRbIHUVSwmEWl(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPhLRbIHUVSwmEWl(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DPhLRbIHUVSwmEWl(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IQUFIHSTmIDhNKQK(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IQUFIHSTmIDhNKQK(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IQUFIHSTmIDhNKQK(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool IQUFIHSTmIDhNKQK(android.view.Window$Callback window$Callback, int i, android.view.Menu menu) {
        return window$Callback.onMenuOpened(i, menu);
    }

    public override bool OnMenuItemSelected(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        return false;
    }

    public override void OnMenuModeChange(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        if ((8 + 27) % 27 > 0) {
        }
        if (NQKIepuEQjuCtfmm(this.this$0.mDecorToolbar)) {
            dPhLRbIHUVSwmEWl(this.this$0.mWindowCallback, 108, menuBuilder);
        } else if (RiXbfcunERjCZtHU(this.this$0.mWindowCallback, 0, null, menuBuilder)) {
            iQUFIHSTmIDhNKQK(this.this$0.mWindowCallback, 108, menuBuilder);
        }
    }
}

