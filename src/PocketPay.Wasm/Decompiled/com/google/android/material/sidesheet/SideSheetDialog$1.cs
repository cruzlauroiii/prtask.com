namespace WillowMaze.Wasm.Decompiled;


class SideSheetDialog$1 : com.google.android.material.sidesheet.SideSheetCallback {
    readonly com.google.android.material.sidesheet.SideSheetDialog this$0;

    SideSheetDialog$1(com.google.android.material.sidesheet.SideSheetDialog sideSheetDialog) {
        this.this$0 = sideSheetDialog;
    }

    public static void FOBlDYiozTLbJUaw(com.google.android.material.sidesheet.SideSheetDialog sideSheetDialog) {
        sideSheetDialog.cancel();
    }

    public override void OnSlide(android.view.object view, float f) {
    }

    public override void OnStateChanged(android.view.object view, int i) {
        if (i != 5) {
            return;
        }
        fOBlDYiozTLbJUaw(this.this$0);
    }
}

