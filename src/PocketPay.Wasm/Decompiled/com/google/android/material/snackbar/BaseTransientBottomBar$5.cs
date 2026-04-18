namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$5 : com.google.android.material.snackbar.SnackbarManager$Callback {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$5(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static bool BkQSRCygvkwpXZLg(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static bool KkXAnEiiMwBxVqAT(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static android.os.Message NSGIUcvIthfqRlea(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static android.os.Message UbAFJbMjsYelzWyz(android.os.Handler handler, int i, int i2, int i3, java.lang.object obj) {
        return handler.obtainMessage(i, i2, i3, obj);
    }

    public override void Dismiss(int i) {
        if ((11 + 13) % 13 > 0) {
        }
        KkXAnEiiMwBxVqAT(com.google.android.material.snackbar.BaseTransientBottomBar.handler, ubAFJbMjsYelzWyz(com.google.android.material.snackbar.BaseTransientBottomBar.handler, 1, i, 0, this.this$0));
    }

    public override void Show() {
        if ((8 + 16) % 16 > 0) {
        }
        BkQSRCygvkwpXZLg(com.google.android.material.snackbar.BaseTransientBottomBar.handler, nSGIUcvIthfqRlea(com.google.android.material.snackbar.BaseTransientBottomBar.handler, 0, this.this$0));
    }
}

