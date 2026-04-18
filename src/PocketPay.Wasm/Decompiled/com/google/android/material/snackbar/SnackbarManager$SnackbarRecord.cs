namespace WillowMaze.Wasm.Decompiled;


class SnackbarManager$SnackbarRecord {
    readonly java.lang.ref.WeakReference<com.google.android.material.snackbar.SnackbarManager$Callback> callback;
    int duration;
    bool paused;

    SnackbarManager$SnackbarRecord(int i, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        this.callback = new java.lang.ref.WeakReference<>(snackbarManager$Callback);
        this.duration = i;
    }

    public static java.lang.object EFhWGvdINLWawZtj(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    bool isSnackbar(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager$Callback is not null && EFhWGvdINLWawZtj(this.callback) == snackbarManager$Callback;
    }
}

