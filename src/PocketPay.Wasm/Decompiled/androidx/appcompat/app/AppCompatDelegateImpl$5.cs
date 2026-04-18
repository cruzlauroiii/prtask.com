namespace WillowMaze.Wasm.Decompiled;


class AppCompatDelegateImpl$5 : androidx.appcompat.widget.ContentFrameLayout$OnAttachListener {
    readonly androidx.appcompat.app.AppCompatDelegateImpl this$0;

    AppCompatDelegateImpl$5(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        this.this$0 = appCompatDelegateImpl;
    }

    public static void OPXpmrQvODKeloGT(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        appCompatDelegateImpl.dismissPopups();
    }

    public static void OPXpmrQvODKeloGT(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPXpmrQvODKeloGT(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OPXpmrQvODKeloGT(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnAttachedFromWindow() {
    }

    public override void OnDetachedFromWindow() {
        OPXpmrQvODKeloGT(this.this$0);
    }
}

