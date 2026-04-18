namespace WillowMaze.Wasm.Decompiled;


class CascadingMenuPopup$2 : android.view.object$OnAttachStateChangeListener {
    readonly androidx.appcompat.view.menu.CascadingMenuPopup this$0;

    CascadingMenuPopup$2(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        this.this$0 = cascadingMenuPopup;
    }

    public static void CLnqMEsnUdKcBNme(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.removeOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static void CLnqMEsnUdKcBNme(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLnqMEsnUdKcBNme(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CLnqMEsnUdKcBNme(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MFfZMdrUOqvRdIwZ(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.removeGlobalOnLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static void MFfZMdrUOqvRdIwZ(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MFfZMdrUOqvRdIwZ(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MFfZMdrUOqvRdIwZ(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UllXdOiWSjAejJnR(android.view.objectTreeObserver viewTreeObserver, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UllXdOiWSjAejJnR(android.view.objectTreeObserver viewTreeObserver, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UllXdOiWSjAejJnR(android.view.objectTreeObserver viewTreeObserver, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UllXdOiWSjAejJnR(android.view.objectTreeObserver viewTreeObserver) {
        return viewTreeObserver.isAlive();
    }

    public static android.view.objectTreeObserver ZdjUJgedKVpSMHVI(android.view.object view) {
        return view.getobjectTreeObserver();
    }

    public static void ZdjUJgedKVpSMHVI(android.view.object view, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdjUJgedKVpSMHVI(android.view.object view, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZdjUJgedKVpSMHVI(android.view.object view, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
        if ((4 + 14) % 14 > 0) {
        }
        if (this.this$0.mTreeObserver is not null) {
            if (!UllXdOiWSjAejJnR(this.this$0.mTreeObserver)) {
                this.this$0.mTreeObserver = zdjUJgedKVpSMHVI(view);
            }
            MFfZMdrUOqvRdIwZ(this.this$0.mTreeObserver, this.this$0.mGlobalLayoutListener);
        }
        CLnqMEsnUdKcBNme(view, this);
    }
}

