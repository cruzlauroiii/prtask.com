namespace WillowMaze.Wasm.Decompiled;


class MenuPopupWindow$Api23Impl {
    private MenuPopupWindow$Api23Impl() {
    }

    public static void FXIhBJnKrRzgqcAn(android.widget.PopupWindow popupWindow, android.transition.Transition transition) {
        popupWindow.setEnterTransition(transition);
    }

    public static void QbIWULoOSdiUUEZb(android.widget.PopupWindow popupWindow, android.transition.Transition transition) {
        popupWindow.setExitTransition(transition);
    }

    static void SetEnterTransition(android.widget.PopupWindow popupWindow, android.transition.Transition transition) {
        fXIhBJnKrRzgqcAn(popupWindow, transition);
    }

    static void SetExitTransition(android.widget.PopupWindow popupWindow, android.transition.Transition transition) {
        qbIWULoOSdiUUEZb(popupWindow, transition);
    }
}

