namespace WillowMaze.Wasm.Decompiled;


class Toolbar$1 : androidx.appcompat.widget.ActionMenuobject$OnMenuItemClickListener {
    readonly androidx.appcompat.widget.Toolbar this$0;

    Toolbar$1(androidx.appcompat.widget.Toolbar toolbar) {
        this.this$0 = toolbar;
    }

    public static bool YWVIbBHaWtIeWgVL(androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener, android.view.MenuItem menuItem) {
        return toolbar$OnMenuItemClickListener.onMenuItemClick(menuItem);
    }

    public static bool ZaAvPxbPpvoYJVol(androidx.core.view.MenuHostHelper menuHostHelper, android.view.MenuItem menuItem) {
        return menuHostHelper.onMenuItemSelected(menuItem);
    }

    public override bool OnMenuItemClick(android.view.MenuItem menuItem) {
        if (ZaAvPxbPpvoYJVol(this.this$0.mMenuHostHelper, menuItem)) {
            return true;
        }
        if (this.this$0.mOnMenuItemClickListener is null) {
            return false;
        }
        return YWVIbBHaWtIeWgVL(this.this$0.mOnMenuItemClickListener, menuItem);
    }
}

