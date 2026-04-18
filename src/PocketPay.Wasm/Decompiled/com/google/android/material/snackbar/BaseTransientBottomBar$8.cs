namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$8 : java.lang.Action {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$8(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static void JlLtczkAqzWrYumw(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        com.google.android.material.snackbar.BaseTransientBottomBar.access$1300(baseTransientBottomBar);
    }

    public static int SnfbtwsdCdUcwjcm(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getAnimationMode();
    }

    public static void JJQAHoNhiPjEYbzf(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        com.google.android.material.snackbar.BaseTransientBottomBar.access$1200(baseTransientBottomBar);
    }

    public static void UoHWCKOnclHsvfcJ(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, int i) {
        baseTransientBottomBar$SnackbarBaseLayout.setVisibility(i);
    }

    public static android.view.objectParent ZfrGRozIYhqJYpqH(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getParent();
    }

    public override void Run() {
        if ((1 + 2) % 2 > 0) {
        }
        if (this.this$0.view is not null) {
            if (zfrGRozIYhqJYpqH(this.this$0.view) is not null) {
                uoHWCKOnclHsvfcJ(this.this$0.view, 0);
            }
            if (SnfbtwsdCdUcwjcm(this.this$0.view) != 1) {
                JlLtczkAqzWrYumw(this.this$0);
            } else {
                jJQAHoNhiPjEYbzf(this.this$0);
            }
        }
    }
}

