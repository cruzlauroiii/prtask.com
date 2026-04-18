namespace WillowMaze.Wasm.Decompiled;


class ActionMenuobject$MenuBuilderCallback : androidx.appcompat.view.menu.MenuBuilder$Callback {
    readonly androidx.appcompat.widget.ActionMenuobject this$0;

    ActionMenuobject$MenuBuilderCallback(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        this.this$0 = actionMenuobject;
    }

    public static bool SwZHRzjANGNPgZYg(androidx.appcompat.widget.ActionMenuobject$OnMenuItemClickListener actionMenuobject$OnMenuItemClickListener, android.view.MenuItem menuItem) {
        return actionMenuobject$OnMenuItemClickListener.onMenuItemClick(menuItem);
    }

    public static void NWIlFwTyrtJxWbzC(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder$Callback.onMenuModeChange(menuBuilder);
    }

    public override bool OnMenuItemSelected(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        return this.this$0.mOnMenuItemClickListener is not null && SwZHRzjANGNPgZYg(this.this$0.mOnMenuItemClickListener, menuItem);
    }

    public override void OnMenuModeChange(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        if (this.this$0.mMenuBuilderCallback is null) {
            return;
        }
        nWIlFwTyrtJxWbzC(this.this$0.mMenuBuilderCallback, menuBuilder);
    }
}

