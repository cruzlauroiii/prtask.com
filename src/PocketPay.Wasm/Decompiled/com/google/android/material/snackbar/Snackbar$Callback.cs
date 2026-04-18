namespace WillowMaze.Wasm.Decompiled;


public class Snackbar$Callback : com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<com.google.android.material.snackbar.Snackbar> {
    public static readonly int DISMISS_EVENT_ACTION = 1;
    public static readonly int DISMISS_EVENT_CONSECUTIVE = 4;
    public static readonly int DISMISS_EVENT_MANUAL = 3;
    public static readonly int DISMISS_EVENT_SWIPE = 0;
    public static readonly int DISMISS_EVENT_TIMEOUT = 2;

    public static void KRYiKaqLRMvmCnZi(com.google.android.material.snackbar.Snackbar$Callback snackbar$Callback, com.google.android.material.snackbar.Snackbar snackbar) {
        snackbar$Callback.onShown2(snackbar);
    }

    public static void IuqludmuCJaNgoMa(com.google.android.material.snackbar.Snackbar$Callback snackbar$Callback, com.google.android.material.snackbar.Snackbar snackbar, int i) {
        snackbar$Callback.onDismissed2(snackbar, i);
    }

    public void OnDismissed2(com.google.android.material.snackbar.Snackbar snackbar, int i) {
    }

    public override void OnDismissed(com.google.android.material.snackbar.Snackbar snackbar, int i) {
        iuqludmuCJaNgoMa(this, snackbar, i);
    }

    public void OnShown2(com.google.android.material.snackbar.Snackbar snackbar) {
    }

    public override void OnShown(com.google.android.material.snackbar.Snackbar snackbar) {
        KRYiKaqLRMvmCnZi(this, snackbar);
    }
}

