namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$7 : com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$7(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static com.google.android.material.snackbar.SnackbarManager ARgWkNutcMlGkLpa() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static com.google.android.material.snackbar.SnackbarManager GCaoXSWWvDLllbuG() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static android.view.objectParent TqqHxGRGfojGHUcd(android.view.object view) {
        return view.getParent();
    }

    public static void UIiEtPTvhbIjZGnc(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager.restoreTimeoutIfPaused(snackbarManager$Callback);
    }

    public static void WDubQfmUJOhtjHdL(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void ECRxkuTcWLraxVUm(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.dispatchDismiss(i);
    }

    public static void EjHwlVdPSpIqyzJz(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager.pauseTimeout(snackbarManager$Callback);
    }

    public override void OnDismiss(android.view.object view) {
        if (TqqHxGRGfojGHUcd(view) is not null) {
            WDubQfmUJOhtjHdL(view, 8);
        }
        eCRxkuTcWLraxVUm(this.this$0, 0);
    }

    public override void OnDragStateChanged(int i) {
        if (i == 0) {
            UIiEtPTvhbIjZGnc(GCaoXSWWvDLllbuG(), this.this$0.managerCallback);
        } else if (i == 1 || i == 2) {
            ejHwlVdPSpIqyzJz(ARgWkNutcMlGkLpa(), this.this$0.managerCallback);
        }
    }
}

