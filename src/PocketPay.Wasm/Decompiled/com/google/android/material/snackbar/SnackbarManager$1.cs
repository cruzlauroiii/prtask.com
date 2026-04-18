namespace WillowMaze.Wasm.Decompiled;


class SnackbarManager$1 : android.os.Handler$Callback {
    readonly com.google.android.material.snackbar.SnackbarManager this$0;

    SnackbarManager$1(com.google.android.material.snackbar.SnackbarManager snackbarManager) {
        this.this$0 = snackbarManager;
    }

    public static void WoiijkKVXpvDutPR(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord) {
        snackbarManager.handleTimeout(snackbarManager$SnackbarRecord);
    }

    public override bool HandleMessage(android.os.Message message) {
        if (message.what != 0) {
            return false;
        }
        woiijkKVXpvDutPR(this.this$0, (com.google.android.material.snackbar.SnackbarManager$SnackbarRecord) message.obj);
        return true;
    }
}

