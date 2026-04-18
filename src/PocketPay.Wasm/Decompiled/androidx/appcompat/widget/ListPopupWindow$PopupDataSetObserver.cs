namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$PopupDataHashSetObserver : android.database.DataHashSetObserver {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$PopupDataHashSetObserver(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        this.this$0 = listPopupWindow;
    }

    public static void FborNoEVRxsYILMp(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.dismiss();
    }

    public static void NwwIKeNHsfhykTkl(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public static bool PDOJyewmiiLwrdLX(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public override void OnChanged() {
        if (pDOJyewmiiLwrdLX(this.this$0)) {
            NwwIKeNHsfhykTkl(this.this$0);
        }
    }

    public override void OnInvalidated() {
        FborNoEVRxsYILMp(this.this$0);
    }
}

