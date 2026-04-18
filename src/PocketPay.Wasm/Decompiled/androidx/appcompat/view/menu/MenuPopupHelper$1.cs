namespace WillowMaze.Wasm.Decompiled;


class MenuPopupHelper$1 : android.widget.PopupWindow$OnDismissListener {
    readonly androidx.appcompat.view.menu.MenuPopupHelper this$0;

    MenuPopupHelper$1(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        this.this$0 = menuPopupHelper;
    }

    public static void BjaNiiHMEKbkeLGx(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        menuPopupHelper.onDismiss();
    }

    public override void OnDismiss() {
        bjaNiiHMEKbkeLGx(this.this$0);
    }
}

