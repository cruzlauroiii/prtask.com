namespace WillowMaze.Wasm.Decompiled;


class NavigationMenuPresenter$NavigationMenuTextItem : com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem {
    private readonly androidx.appcompat.view.menu.MenuItemImpl menuItem;
    bool needsEmptyIcon;

    NavigationMenuPresenter$NavigationMenuTextItem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        this.menuItem = menuItemImpl;
    }

    public androidx.appcompat.view.menu.MenuItemImpl GetMenuItem() {
        return this.menuItem;
    }
}

