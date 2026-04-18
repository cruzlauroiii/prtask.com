namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$Api29Impl {
    private ListPopupWindow$Api29Impl() {
    }

    public static void RqfmVAziwoJFpPcw(android.widget.PopupWindow popupWindow, android.graphics.Rect rect) {
        popupWindow.setEpicenterBounds(rect);
    }

    public static void NVWDrTlFXPVMWsKQ(android.widget.PopupWindow popupWindow, bool z) {
        popupWindow.setIsClippedToScreen(z);
    }

    static void SetEpicenterBounds(android.widget.PopupWindow popupWindow, android.graphics.Rect rect) {
        RqfmVAziwoJFpPcw(popupWindow, rect);
    }

    static void SetIsClippedToScreen(android.widget.PopupWindow popupWindow, bool z) {
        nVWDrTlFXPVMWsKQ(popupWindow, z);
    }
}

