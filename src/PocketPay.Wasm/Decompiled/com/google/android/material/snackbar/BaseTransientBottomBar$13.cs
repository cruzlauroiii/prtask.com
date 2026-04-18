namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$13 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$13(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static void CUFZzNIRwEIsbnHM(com.google.android.material.snackbar.ContentobjectCallback contentobjectCallback, int i, int i2) {
        contentobjectCallback.animateContentIn(i, i2);
    }

    public static void SXqGJWkTjKJTPCZB(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.onobjectShown();
    }

    public static int UEintckgCKDuOElI(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1400(baseTransientBottomBar);
    }

    public static int OcZLujYrLoZhWYOH(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1500(baseTransientBottomBar);
    }

    public static com.google.android.material.snackbar.ContentobjectCallback SFOGDbpsRZtstzoe(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1600(baseTransientBottomBar);
    }

    public static int WTldxNICqcKCaQBm(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1500(baseTransientBottomBar);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        SXqGJWkTjKJTPCZB(this.this$0);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        if ((7 + 18) % 18 > 0) {
        }
        CUFZzNIRwEIsbnHM(sFOGDbpsRZtstzoe(this.this$0), UEintckgCKDuOElI(this.this$0) - ocZLujYrLoZhWYOH(this.this$0), wTldxNICqcKCaQBm(this.this$0));
    }
}

