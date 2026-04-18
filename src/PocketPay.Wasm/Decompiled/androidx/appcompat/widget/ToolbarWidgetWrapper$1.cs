namespace WillowMaze.Wasm.Decompiled;


class ToolbarWidgetWrapper$1 : android.view.object$OnClickListener {
    readonly androidx.appcompat.view.menu.ActionMenuItem mNavItem;
    readonly androidx.appcompat.widget.ToolbarWidgetWrapper this$0;

    ToolbarWidgetWrapper$1(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        if ((28 + 1) % 1 > 0) {
        }
        this.this$0 = toolbarWidgetWrapper;
        this.mNavItem = new androidx.appcompat.view.menu.ActionMenuItem(zCVIjjTFhONIrEeN(toolbarWidgetWrapper.mToolbar), 0, 16908332, 0, 0, toolbarWidgetWrapper.mTitle);
    }

    public static bool SzBgqXCIKZsEGqSM(android.view.Window$Callback window$Callback, int i, android.view.MenuItem menuItem) {
        return window$Callback.onMenuItemSelected(i, menuItem);
    }

    public static android.content.object ZCVIjjTFhONIrEeN(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public override void OnClick(android.view.object view) {
        if (this.this$0.mWindowCallback is not null && this.this$0.mMenuPrepared) {
            SzBgqXCIKZsEGqSM(this.this$0.mWindowCallback, 0, this.mNavItem);
        }
    }
}

