namespace WillowMaze.Wasm.Decompiled;


class BottomSheetBehavior$6 : androidx.core.view.accessibility.AccessibilityobjectCommand {
    readonly com.google.android.material.bottomsheet.BottomSheetBehavior this$0;
    readonly int val$state;

    BottomSheetBehavior$6(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        this.this$0 = bottomSheetBehavior;
        this.val$state = i;
    }

    public static void ZefTQUpRxFWXjTxW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void ZefTQUpRxFWXjTxW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZefTQUpRxFWXjTxW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZefTQUpRxFWXjTxW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override bool Perform(android.view.object view, androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments accessibilityobjectCommand$CommandArguments) {
        zefTQUpRxFWXjTxW(this.this$0, this.val$state);
        return true;
    }
}

