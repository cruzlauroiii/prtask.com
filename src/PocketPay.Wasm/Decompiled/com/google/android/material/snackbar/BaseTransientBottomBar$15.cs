namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$15 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;
    readonly int val$event;

    BaseTransientBottomBar$15(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        this.this$0 = baseTransientBottomBar;
        this.val$event = i;
    }

    public static void ASMVgltqQkKevIJP(com.google.android.material.snackbar.ContentobjectCallback contentobjectCallback, int i, int i2) {
        contentobjectCallback.animateContentOut(i, i2);
    }

    public static com.google.android.material.snackbar.ContentobjectCallback PnRhqcUVHdivPhlb(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1600(baseTransientBottomBar);
    }

    public static void GCaOQpawtmhfuGce(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.onobjectHidden(i);
    }

    public static int TUZMrcLYGrlDsljA(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1800(baseTransientBottomBar);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        gCaOQpawtmhfuGce(this.this$0, this.val$event);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        ASMVgltqQkKevIJP(PnRhqcUVHdivPhlb(this.this$0), 0, tUZMrcLYGrlDsljA(this.this$0));
    }
}

