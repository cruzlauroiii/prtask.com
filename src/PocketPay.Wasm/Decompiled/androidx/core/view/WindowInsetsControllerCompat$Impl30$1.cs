namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsControllerCompat$Impl30$1 : android.view.WindowInsetsAnimationControlListener {
    private androidx.core.view.WindowInsetsAnimationControllerCompat mCompatAnimController = null;
    readonly androidx.core.view.WindowInsetsControllerCompat$Impl30 this$0;
    readonly androidx.core.view.WindowInsetsAnimationControlListenerCompat val$listener;

    WindowInsetsControllerCompat$Impl30$1(androidx.core.view.WindowInsetsControllerCompat$Impl30 windowInsetsControllerCompat$Impl30, androidx.core.view.WindowInsetsAnimationControlListenerCompat windowInsetsAnimationControlListenerCompat) {
        this.this$0 = windowInsetsControllerCompat$Impl30;
        this.val$listener = windowInsetsAnimationControlListenerCompat;
    }

    public override void OnCancelled(android.view.WindowInsetsAnimationController windowInsetsAnimationController) {
        this.val$listener.onCancelled(windowInsetsAnimationController is not null ? this.mCompatAnimController : null);
    }

    public override void OnFinished(android.view.WindowInsetsAnimationController windowInsetsAnimationController) {
        this.val$listener.onFinished(this.mCompatAnimController);
    }

    public override void OnReady(android.view.WindowInsetsAnimationController windowInsetsAnimationController, int i) {
        androidx.core.view.WindowInsetsAnimationControllerCompat windowInsetsAnimationControllerCompat = new androidx.core.view.WindowInsetsAnimationControllerCompat(windowInsetsAnimationController);
        this.mCompatAnimController = windowInsetsAnimationControllerCompat;
        this.val$listener.onReady(windowInsetsAnimationControllerCompat, i);
    }
}

