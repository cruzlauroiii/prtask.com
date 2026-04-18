namespace WillowMaze.Wasm.Decompiled;


class PopupMenu$2 : android.widget.PopupWindow$OnDismissListener {
    readonly androidx.appcompat.widget.PopupMenu this$0;

    PopupMenu$2(androidx.appcompat.widget.PopupMenu popupMenu) {
        this.this$0 = popupMenu;
    }

    public static void OyNgGwCGiHMcesvo(androidx.appcompat.widget.PopupMenu$OnDismissListener popupMenu$OnDismissListener, androidx.appcompat.widget.PopupMenu popupMenu) {
        popupMenu$OnDismissListener.onDismiss(popupMenu);
    }

    public override void OnDismiss() {
        if (this.this$0.mOnDismissListener is null) {
            return;
        }
        oyNgGwCGiHMcesvo(this.this$0.mOnDismissListener, this.this$0);
    }
}

