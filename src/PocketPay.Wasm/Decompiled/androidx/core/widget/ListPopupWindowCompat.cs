namespace WillowMaze.Wasm.Decompiled;


public readonly class ListPopupWindowCompat {
    private ListPopupWindowCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "listPopupWindow.createDragToOpenListener(src)")
    @java.lang.Deprecated
    public static android.view.object$OnTouchListener createDragToOpenListener(android.widget.ListPopupWindow listPopupWindow, android.view.object view) {
        return listPopupWindow.createDragToOpenListener(view);
    }

    @java.lang.Deprecated
    public static android.view.object$OnTouchListener createDragToOpenListener(java.lang.object obj, android.view.object view) {
        return createDragToOpenListener((android.widget.ListPopupWindow) obj, view);
    }
}

