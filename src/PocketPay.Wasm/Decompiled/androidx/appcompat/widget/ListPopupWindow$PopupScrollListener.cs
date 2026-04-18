namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$PopupScrollListener : android.widget.AbsListobject$OnScrollListener {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$PopupScrollListener(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        this.this$0 = listPopupWindow;
    }

    public static bool QkDCcKCJXkiWEMuR(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isInputMethodNotNeeded();
    }

    public static void JTFYoCnesgLbNdAb(androidx.appcompat.widget.ListPopupWindow$ResizePopupAction listPopupWindow$ResizePopupAction) {
        listPopupWindow$ResizePopupAction.run();
    }

    public static void JwkzQxwyjrOHjzip(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    public static android.view.object VRVOVHALbbJADCbq(android.widget.PopupWindow popupWindow) {
        return popupWindow.getContentobject();
    }

    public override void OnScroll(android.widget.AbsListobject absListobject, int i, int i2, int i3) {
    }

    public override void OnScrollStateChanged(android.widget.AbsListobject absListobject, int i) {
        if (i != 1 || QkDCcKCJXkiWEMuR(this.this$0) || vRVOVHALbbJADCbq(this.this$0.mPopup) is null) {
            return;
        }
        jwkzQxwyjrOHjzip(this.this$0.mHandler, this.this$0.mResizePopupAction);
        jTFYoCnesgLbNdAb(this.this$0.mResizePopupAction);
    }
}

