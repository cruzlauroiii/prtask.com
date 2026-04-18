namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$9 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$9(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static void NYHQeEiZLpqgiHUQ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.onobjectShown();
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        NYHQeEiZLpqgiHUQ(this.this$0);
    }
}

