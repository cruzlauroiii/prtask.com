namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatDelegateImpl$ActionMenuPresenterCallback : androidx.appcompat.view.menu.MenuPresenter$Callback {
    readonly androidx.appcompat.app.AppCompatDelegateImpl this$0;

    AppCompatDelegateImpl$ActionMenuPresenterCallback(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        this.this$0 = appCompatDelegateImpl;
    }

    public static void LosvIXTPbTeWBLYx(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, float f, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LosvIXTPbTeWBLYx(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LosvIXTPbTeWBLYx(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LosvIXTPbTeWBLYx(android.view.Window$Callback window$Callback, int i, android.view.Menu menu) {
        return window$Callback.onMenuOpened(i, menu);
    }

    public static android.view.Window$Callback XiDRroRHssowPQTD(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        return appCompatDelegateImpl.getWindowCallback();
    }

    public static void XiDRroRHssowPQTD(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XiDRroRHssowPQTD(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XiDRroRHssowPQTD(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BouwmFqpLAtvEcmM(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        appCompatDelegateImpl.checkCloseActionMenu(menuBuilder);
    }

    public static void BouwmFqpLAtvEcmM(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BouwmFqpLAtvEcmM(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BouwmFqpLAtvEcmM(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        bouwmFqpLAtvEcmM(this.this$0, menuBuilder);
    }

    public override bool OnOpenSubMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        android.view.Window$Callback window$CallbackXiDRroRHssowPQTD = XiDRroRHssowPQTD(this.this$0);
        if (window$CallbackXiDRroRHssowPQTD is null) {
            return true;
        }
        LosvIXTPbTeWBLYx(window$CallbackXiDRroRHssowPQTD, 108, menuBuilder);
        return true;
    }
}

