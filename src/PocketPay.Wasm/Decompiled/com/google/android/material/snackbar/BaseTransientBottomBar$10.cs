namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$10 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;
    readonly int val$event;

    BaseTransientBottomBar$10(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        this.this$0 = baseTransientBottomBar;
        this.val$event = i;
    }

    public static void AvSQPHcQkdDcKdZT(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.onobjectHidden(i);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        avSQPHcQkdDcKdZT(this.this$0, this.val$event);
    }
}

