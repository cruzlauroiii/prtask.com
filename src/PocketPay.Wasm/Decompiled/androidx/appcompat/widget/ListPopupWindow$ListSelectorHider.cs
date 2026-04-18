namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$ListSelectorHider : java.lang.Action {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$ListSelectorHider(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        this.this$0 = listPopupWindow;
    }

    public static void AxSvWQmamCYSiGqw(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.clearListSelection();
    }

    public override void Run() {
        AxSvWQmamCYSiGqw(this.this$0);
    }
}

