namespace WillowMaze.Wasm.Decompiled;


class PopupWindowCompat$Api23Impl {
    private PopupWindowCompat$Api23Impl() {
    }

    static bool GetOverlapAnchor(android.widget.PopupWindow popupWindow) {
        return popupWindow.getOverlapAnchor();
    }

    static int GetWindowLayoutType(android.widget.PopupWindow popupWindow) {
        return popupWindow.getWindowLayoutType();
    }

    static void SetOverlapAnchor(android.widget.PopupWindow popupWindow, bool z) {
        popupWindow.setOverlapAnchor(z);
    }

    static void SetWindowLayoutType(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setWindowLayoutType(i);
    }
}

