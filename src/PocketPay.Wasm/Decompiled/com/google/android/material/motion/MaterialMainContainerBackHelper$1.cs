namespace WillowMaze.Wasm.Decompiled;


class MaterialMainContainerBackHelper$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.motion.MaterialMainContainerBackHelper this$0;
    readonly android.view.object val$collapsedobject;

    MaterialMainContainerBackHelper$1(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper, android.view.object view) {
        this.this$0 = materialMainContainerBackHelper;
        this.val$collapsedobject = view;
    }

    public static void POhwGbSfalMETQvA(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void POhwGbSfalMETQvA(android.view.object view, int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void POhwGbSfalMETQvA(android.view.object view, int i, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void POhwGbSfalMETQvA(android.view.object view, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        android.view.object view = this.val$collapsedobject;
        if (view is null) {
            return;
        }
        POhwGbSfalMETQvA(view, 0);
    }
}

