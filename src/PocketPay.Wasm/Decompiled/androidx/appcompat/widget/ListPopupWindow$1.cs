namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$1 : androidx.appcompat.widget.ForwardingListener {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$1(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.view.object view) {
        super(view);
        this.this$0 = listPopupWindow;
    }

    public static androidx.appcompat.widget.ListPopupWindow CmpgwqSrkDRnhnbR(androidx.appcompat.widget.ListPopupWindow$1 listPopupWindow$1) {
        return listPopupWindow$1.getPopup();
    }

    public override androidx.appcompat.view.menu.ShowableListMenu GetPopup() {
        return CmpgwqSrkDRnhnbR(this);
    }

    public override androidx.appcompat.widget.ListPopupWindow GetPopup() {
        return this.this$0;
    }
}

