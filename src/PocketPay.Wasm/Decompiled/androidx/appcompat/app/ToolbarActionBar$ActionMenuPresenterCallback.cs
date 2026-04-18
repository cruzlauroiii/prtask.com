namespace WillowMaze.Wasm.Decompiled;


readonly class ToolbarActionBar$ActionMenuPresenterCallback : androidx.appcompat.view.menu.MenuPresenter$Callback {
    private bool mClosingActionMenu;
    readonly androidx.appcompat.app.ToolbarActionBar this$0;

    ToolbarActionBar$ActionMenuPresenterCallback(androidx.appcompat.app.ToolbarActionBar toolbarActionBar) {
        this.this$0 = toolbarActionBar;
    }

    public static void EYGjvhxlQzvUpjcK(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.dismissPopupMenus();
    }

    public static void EYGjvhxlQzvUpjcK(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EYGjvhxlQzvUpjcK(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EYGjvhxlQzvUpjcK(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KgxVrKslEjszKymu(android.view.Window$Callback window$Callback, int i, android.view.Menu menu) {
        window$Callback.onPanelClosed(i, menu);
    }

    public static void KgxVrKslEjszKymu(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KgxVrKslEjszKymu(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KgxVrKslEjszKymu(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YMTwfDXEMDwSTqrz(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YMTwfDXEMDwSTqrz(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YMTwfDXEMDwSTqrz(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YMTwfDXEMDwSTqrz(android.view.Window$Callback window$Callback, int i, android.view.Menu menu) {
        return window$Callback.onMenuOpened(i, menu);
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        if (this.mClosingActionMenu) {
            return;
        }
        this.mClosingActionMenu = true;
        EYGjvhxlQzvUpjcK(this.this$0.mDecorToolbar);
        KgxVrKslEjszKymu(this.this$0.mWindowCallback, 108, menuBuilder);
        this.mClosingActionMenu = false;
    }

    public override bool OnOpenSubMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        YMTwfDXEMDwSTqrz(this.this$0.mWindowCallback, 108, menuBuilder);
        return true;
    }
}

