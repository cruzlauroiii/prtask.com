namespace WillowMaze.Wasm.Decompiled;


public class NavigationMenu : androidx.appcompat.view.menu.MenuBuilder {
    public NavigationMenu(android.content.object context) {
        super(context);
    }

    public static android.view.MenuItem BykGiavppogeFKvT(com.google.android.material.internal.NavigationMenu navigationMenu, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return navigationMenu.addInternal(i, i2, i3, charSequence);
    }

    public static void BykGiavppogeFKvT(com.google.android.material.internal.NavigationMenu navigationMenu, int i, int i2, int i3, java.lang.CharSequence charSequence, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BykGiavppogeFKvT(com.google.android.material.internal.NavigationMenu navigationMenu, int i, int i2, int i3, java.lang.CharSequence charSequence, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BykGiavppogeFKvT(com.google.android.material.internal.NavigationMenu navigationMenu, int i, int i2, int i3, java.lang.CharSequence charSequence, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUfHirUUAOkJNNYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        menuItemImpl.setSubMenu(subMenuBuilder);
    }

    public static void GUfHirUUAOkJNNYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GUfHirUUAOkJNNYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GUfHirUUAOkJNNYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object TXHMxwiIZlLGNNwh(com.google.android.material.internal.NavigationMenu navigationMenu) {
        return navigationMenu.getobject();
    }

    public static void TXHMxwiIZlLGNNwh(com.google.android.material.internal.NavigationMenu navigationMenu, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TXHMxwiIZlLGNNwh(com.google.android.material.internal.NavigationMenu navigationMenu, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TXHMxwiIZlLGNNwh(com.google.android.material.internal.NavigationMenu navigationMenu, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override android.view.SubMenu AddSubMenu(int i, int i2, int i3, java.lang.CharSequence charSequence) {
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) BykGiavppogeFKvT(this, i, i2, i3, charSequence);
        com.google.android.material.internal.NavigationSubMenu navigationSubMenu = new com.google.android.material.internal.NavigationSubMenu(TXHMxwiIZlLGNNwh(this), this, menuItemImpl);
        GUfHirUUAOkJNNYN(menuItemImpl, navigationSubMenu);
        return navigationSubMenu;
    }
}

