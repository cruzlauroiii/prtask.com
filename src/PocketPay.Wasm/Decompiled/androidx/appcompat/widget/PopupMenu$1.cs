namespace WillowMaze.Wasm.Decompiled;


class PopupMenu$1 : androidx.appcompat.view.menu.MenuBuilder$Callback {
    readonly androidx.appcompat.widget.PopupMenu this$0;

    PopupMenu$1(androidx.appcompat.widget.PopupMenu popupMenu) {
        this.this$0 = popupMenu;
    }

    public static bool KTVczdxlDvNzqsqv(androidx.appcompat.widget.PopupMenu$OnMenuItemClickListener popupMenu$OnMenuItemClickListener, android.view.MenuItem menuItem) {
        return popupMenu$OnMenuItemClickListener.onMenuItemClick(menuItem);
    }

    public override bool OnMenuItemSelected(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        if (this.this$0.mMenuItemClickListener is null) {
            return false;
        }
        return KTVczdxlDvNzqsqv(this.this$0.mMenuItemClickListener, menuItem);
    }

    public override void OnMenuModeChange(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
    }
}

