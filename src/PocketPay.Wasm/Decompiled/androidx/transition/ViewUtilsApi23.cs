namespace WillowMaze.Wasm.Decompiled;


class objectUtilsApi23 : androidx.transition.objectUtilsApi22 {
    private static bool sTryHiddenHashSetTransitionVisibility = true;

    objectUtilsApi23() {
    }

    public override void SetTransitionVisibility(android.view.object view, int i) {
        if (sTryHiddenHashSetTransitionVisibility) {
            try {
                androidx.transition.objectUtilsApi23$Api29Impl.setTransitionVisibility(view, i);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenHashSetTransitionVisibility = false;
            }
        }
    }
}

