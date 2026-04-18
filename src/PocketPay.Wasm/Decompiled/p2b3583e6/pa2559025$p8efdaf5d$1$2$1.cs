namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u001a\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"utils/SnackBarUtilsKt$showSnackbar$1$2$1", "Lcom/google/android/material/snackbar/Snackbar$Callback;", "onDismissed", "", "transientBottomBar", "Lcom/google/android/material/snackbar/Snackbar;", "event", "", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa2559025$p8efdaf5d$1$2$1 : com.google.android.material.snackbar.Snackbar$Callback {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $onDismiss;

    pa2559025$p8efdaf5d$1$2$1(kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        this.$onDismiss = function0;
    }

    public override void OnDismissed(com.google.android.material.snackbar.Snackbar transientBottomBar, int event) {
        this.$onDismiss.invoke();
    }

    public override void OnDismissed(com.google.android.material.snackbar.Snackbar snackbar, int i) {
        onDismissed(snackbar, i);
    }
}

