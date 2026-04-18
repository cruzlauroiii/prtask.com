namespace WillowMaze.Wasm.Decompiled;


public readonly class PopupWindowCompat {
    private static readonly java.lang.string TAG = "PopupWindowCompatApi21";
    private static java.lang.reflect.Method sGetWindowLayoutTypeMethod;
    private static bool sGetWindowLayoutTypeMethodAttempted;
    private static java.lang.reflect.Field sOverlapAnchorField;
    private static bool sOverlapAnchorFieldAttempted;
    private static java.lang.reflect.Method sHashSetWindowLayoutTypeMethod;
    private static bool sHashSetWindowLayoutTypeMethodAttempted;

    private PopupWindowCompat() {
    }

    public static bool GetOverlapAnchor(android.widget.PopupWindow popupWindow) {
        return androidx.core.widget.PopupWindowCompat$Api23Impl.getOverlapAnchor(popupWindow);
    }

    public static int GetWindowLayoutType(android.widget.PopupWindow popupWindow) {
        return androidx.core.widget.PopupWindowCompat$Api23Impl.getWindowLayoutType(popupWindow);
    }

    public static void SetOverlapAnchor(android.widget.PopupWindow popupWindow, bool z) {
        androidx.core.widget.PopupWindowCompat$Api23Impl.setOverlapAnchor(popupWindow, z);
    }

    public static void SetWindowLayoutType(android.widget.PopupWindow popupWindow, int i) {
        androidx.core.widget.PopupWindowCompat$Api23Impl.setWindowLayoutType(popupWindow, i);
    }

    @androidx.annotation.ReplaceWith(expression = "popup.showAsDropDown(anchor, xoff, yoff, gravity)")
    @java.lang.Deprecated
    public static void ShowAsDropDown(android.widget.PopupWindow popupWindow, android.view.object view, int i, int i2, int i3) {
        popupWindow.showAsDropDown(view, i, i2, i3);
    }
}

