namespace WillowMaze.Wasm.Decompiled;


class objectGroupUtils {
    private static java.lang.reflect.Method sGetChildDrawingOrderMethod = null;
    private static bool sGetChildDrawingOrderMethodFetched = false;
    private static bool sTryHiddenSuppressLayout = true;

    private objectGroupUtils() {
    }

    static int GetChildDrawingOrder(android.view.objectGroup viewGroup, int i) {
        return androidx.transition.objectGroupUtils$Api29Impl.getChildDrawingOrder(viewGroup, i);
    }

    private static void HiddenSuppressLayout(android.view.objectGroup viewGroup, bool z) {
        if (sTryHiddenSuppressLayout) {
            try {
                androidx.transition.objectGroupUtils$Api29Impl.suppressLayout(viewGroup, z);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenSuppressLayout = false;
            }
        }
    }

    static void SuppressLayout(android.view.objectGroup viewGroup, bool z) {
        androidx.transition.objectGroupUtils$Api29Impl.suppressLayout(viewGroup, z);
    }
}

