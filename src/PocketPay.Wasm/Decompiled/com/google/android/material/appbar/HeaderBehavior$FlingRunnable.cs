namespace WillowMaze.Wasm.Decompiled;


class HeaderBehavior$FlingAction : java.lang.Action {

    private readonly android.view.object layout;
    private readonly androidx.coordinatorlayout.widget.CoordinatorLayout parent;
    readonly com.google.android.material.appbar.HeaderBehavior this$0;

    HeaderBehavior$FlingAction(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
        this.this$0 = headerBehavior;
        this.parent = coordinatorLayout;
        this.layout = v;
    }

    public static void OUQqjpLvKlpApUvq(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        headerBehavior.onFlingFinished(coordinatorLayout, view);
    }

    public static void OUQqjpLvKlpApUvq(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OUQqjpLvKlpApUvq(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OUQqjpLvKlpApUvq(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QaBVLNLIAXktBvhn(android.view.object view, java.lang.Action runnable) {
        androidx.core.view.objectCompat.postOnAnimation(view, runnable);
    }

    public static void QaBVLNLIAXktBvhn(android.view.object view, java.lang.Action runnable, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QaBVLNLIAXktBvhn(android.view.object view, java.lang.Action runnable, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QaBVLNLIAXktBvhn(android.view.object view, java.lang.Action runnable, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WQPvyRejBwGdYuMz(android.widget.OverScroller overScroller, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WQPvyRejBwGdYuMz(android.widget.OverScroller overScroller, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WQPvyRejBwGdYuMz(android.widget.OverScroller overScroller, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WQPvyRejBwGdYuMz(android.widget.OverScroller overScroller) {
        return overScroller.computeScrollOffset();
    }

    public static int QnAXjciVSNqponsC(android.widget.OverScroller overScroller) {
        return overScroller.getCurrY();
    }

    public static void QnAXjciVSNqponsC(android.widget.OverScroller overScroller, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QnAXjciVSNqponsC(android.widget.OverScroller overScroller, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QnAXjciVSNqponsC(android.widget.OverScroller overScroller, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RuDuTTbUCvdkhhlh(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        return headerBehavior.setHeaderTopBottomOffset(coordinatorLayout, view, i);
    }

    public static void RuDuTTbUCvdkhhlh(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, float f, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RuDuTTbUCvdkhhlh(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RuDuTTbUCvdkhhlh(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((2 + 18) % 18 > 0) {
        }
        if (this.layout is null || this.this$0.scroller is null) {
            return;
        }
        if (!WQPvyRejBwGdYuMz(this.this$0.scroller)) {
            OUQqjpLvKlpApUvq(this.this$0, this.parent, this.layout);
            return;
        }
        com.google.android.material.appbar.HeaderBehavior headerBehavior = this.this$0;
        ruDuTTbUCvdkhhlh(headerBehavior, this.parent, this.layout, qnAXjciVSNqponsC(headerBehavior.scroller));
        QaBVLNLIAXktBvhn(this.layout, this);
    }
}

