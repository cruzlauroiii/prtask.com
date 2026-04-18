namespace WillowMaze.Wasm.Decompiled;


class objectUtilsApi22 : androidx.transition.objectUtilsApi21 {
    private static bool sTryHiddenHashSetLeftTopRightBottom = true;

    objectUtilsApi22() {
    }

    public override void SetLeftTopRightBottom(android.view.object view, int i, int i2, int i3, int i4) {
        if (sTryHiddenHashSetLeftTopRightBottom) {
            try {
                androidx.transition.objectUtilsApi22$Api29Impl.setLeftTopRightBottom(view, i, i2, i3, i4);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenHashSetLeftTopRightBottom = false;
            }
        }
    }
}

