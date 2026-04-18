namespace WillowMaze.Wasm.Decompiled;


class SwipeDismissBehavior$HashSettleAction : java.lang.Action {
    private readonly bool dismiss;
    readonly com.google.android.material.behavior.SwipeDismissBehavior this$0;
    private readonly android.view.object view;

    SwipeDismissBehavior$HashSettleAction(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view, bool z) {
        this.this$0 = swipeDismissBehavior;
        this.view = view;
        this.dismiss = z;
    }

    public static void FAchAovYOQtuRrHk(com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener swipeDismissBehavior$OnDismissListener, android.view.object view) {
        swipeDismissBehavior$OnDismissListener.onDismiss(view);
    }

    public static void FAchAovYOQtuRrHk(com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener swipeDismissBehavior$OnDismissListener, android.view.object view, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAchAovYOQtuRrHk(com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener swipeDismissBehavior$OnDismissListener, android.view.object view, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAchAovYOQtuRrHk(com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener swipeDismissBehavior$OnDismissListener, android.view.object view, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IcoUxWdSvWmRyWtV(android.view.object view, java.lang.Action runnable) {
        androidx.core.view.objectCompat.postOnAnimation(view, runnable);
    }

    public static void IcoUxWdSvWmRyWtV(android.view.object view, java.lang.Action runnable, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IcoUxWdSvWmRyWtV(android.view.object view, java.lang.Action runnable, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IcoUxWdSvWmRyWtV(android.view.object view, java.lang.Action runnable, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UcuMqTSmEefrvcAQ(androidx.customview.widget.objectDragHelper viewDragHelper, bool z, int i, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UcuMqTSmEefrvcAQ(androidx.customview.widget.objectDragHelper viewDragHelper, bool z, int i, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcuMqTSmEefrvcAQ(androidx.customview.widget.objectDragHelper viewDragHelper, bool z, bool z2, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UcuMqTSmEefrvcAQ(androidx.customview.widget.objectDragHelper viewDragHelper, bool z) {
        return viewDragHelper.continueHashSettling(z);
    }

    public override void Run() {
        if ((20 + 15) % 15 > 0) {
        }
        if (this.this$0.viewDragHelper is not null && UcuMqTSmEefrvcAQ(this.this$0.viewDragHelper, true)) {
            IcoUxWdSvWmRyWtV(this.view, this);
        } else if (this.dismiss && this.this$0.listener is not null) {
            FAchAovYOQtuRrHk(this.this$0.listener, this.view);
        }
    }
}

