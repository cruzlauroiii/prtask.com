namespace WillowMaze.Wasm.Decompiled;


class MenuItemImpl$1 : androidx.core.view.ActionProvider$VisibilityListener {
    readonly androidx.appcompat.view.menu.MenuItemImpl this$0;

    MenuItemImpl$1(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        this.this$0 = menuItemImpl;
    }

    public static void PIJQHTxQKsftHIuo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        menuBuilder.onItemVisibleChanged(menuItemImpl);
    }

    public static void PIJQHTxQKsftHIuo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PIJQHTxQKsftHIuo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PIJQHTxQKsftHIuo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public override void OnActionProviderVisibilityChanged(bool z) {
        PIJQHTxQKsftHIuo(this.this$0.mMenu, this.this$0);
    }
}

