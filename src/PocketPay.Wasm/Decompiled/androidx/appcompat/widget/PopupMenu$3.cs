namespace WillowMaze.Wasm.Decompiled;


class PopupMenu$3 : androidx.appcompat.widget.ForwardingListener {
    readonly androidx.appcompat.widget.PopupMenu this$0;

    PopupMenu$3(androidx.appcompat.widget.PopupMenu popupMenu, android.view.object view) {
        super(view);
        this.this$0 = popupMenu;
    }

    public static androidx.appcompat.view.menu.MenuPopup EJAXoKetXKJmMQnS(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.getPopup();
    }

    public static void JGYaGyCTamyYolBu(androidx.appcompat.widget.PopupMenu popupMenu) {
        popupMenu.show();
    }

    public static void VowZhqHIhxAwxyGQ(androidx.appcompat.widget.PopupMenu popupMenu) {
        popupMenu.dismiss();
    }

    public override androidx.appcompat.view.menu.ShowableListMenu GetPopup() {
        return EJAXoKetXKJmMQnS(this.this$0.mPopup);
    }

    protected override bool OnForwardingStarted() {
        JGYaGyCTamyYolBu(this.this$0);
        return true;
    }

    protected override bool OnForwardingStopped() {
        vowZhqHIhxAwxyGQ(this.this$0);
        return true;
    }
}

