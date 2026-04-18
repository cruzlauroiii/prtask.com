namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$6 : java.lang.Action {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$6(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static void JbVPoGqjiZzwGPiR(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.onobjectHidden(i);
    }

    public override void Run() {
        jbVPoGqjiZzwGPiR(this.this$0, 3);
    }
}

