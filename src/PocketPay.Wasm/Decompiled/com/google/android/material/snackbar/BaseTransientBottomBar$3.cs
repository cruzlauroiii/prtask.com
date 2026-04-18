namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$3 : androidx.core.view.OnApplyWindowInsetsListener {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$3(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static int ALYAJqCAHmGcUCvH(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$602(baseTransientBottomBar, i);
    }

    public static int AXgvfQdSDjLScqEN(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetBottom();
    }

    public static void AYvRaWIxuzTgPwSn(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        com.google.android.material.snackbar.BaseTransientBottomBar.access$900(baseTransientBottomBar);
    }

    public static int HuIsYZxWCVikixYq(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$802(baseTransientBottomBar, i);
    }

    public static int DarTTEzsmkTzdRnY(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static int LsnnXSDnbQImUfil(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    public static int OrjqiBWBfEtPXsIZ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$702(baseTransientBottomBar, i);
    }

    public override androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        ALYAJqCAHmGcUCvH(this.this$0, AXgvfQdSDjLScqEN(windowInsetsCompat));
        orjqiBWBfEtPXsIZ(this.this$0, darTTEzsmkTzdRnY(windowInsetsCompat));
        HuIsYZxWCVikixYq(this.this$0, lsnnXSDnbQImUfil(windowInsetsCompat));
        AYvRaWIxuzTgPwSn(this.this$0);
        return windowInsetsCompat;
    }
}

