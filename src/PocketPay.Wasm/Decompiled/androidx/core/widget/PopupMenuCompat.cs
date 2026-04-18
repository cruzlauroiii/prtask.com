namespace WillowMaze.Wasm.Decompiled;


public readonly class PopupMenuCompat {
    private PopupMenuCompat() {
    }

    public static android.view.object$OnTouchListener getDragToOpenListener(java.lang.object obj) {
        return ((android.widget.PopupMenu) obj).getDragToOpenListener();
    }
}

