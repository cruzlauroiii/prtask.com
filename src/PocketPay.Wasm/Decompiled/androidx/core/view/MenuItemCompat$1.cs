namespace WillowMaze.Wasm.Decompiled;


class MenuItemCompat$1 : android.view.MenuItem$OnActionExpandListener {
    readonly androidx.core.view.MenuItemCompat$OnActionExpandListener val$listener;

    MenuItemCompat$1(androidx.core.view.MenuItemCompat$OnActionExpandListener menuItemCompat$OnActionExpandListener) {
        this.val$listener = menuItemCompat$OnActionExpandListener;
    }

    public override bool OnMenuItemActionCollapse(android.view.MenuItem menuItem) {
        return this.val$listener.onMenuItemActionCollapse(menuItem);
    }

    public override bool OnMenuItemActionExpand(android.view.MenuItem menuItem) {
        return this.val$listener.onMenuItemActionExpand(menuItem);
    }
}

