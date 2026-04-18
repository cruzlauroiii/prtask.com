namespace WillowMaze.Wasm.Decompiled;


class SubMenuWrapperICS : androidx.appcompat.view.menu.MenuWrapperICS : android.view.SubMenu {
    private readonly androidx.core.internal.view.SupportSubMenu mSubMenu;

    SubMenuWrapperICS(android.content.object context, androidx.core.internal.view.SupportSubMenu supportSubMenu) {
        super(context, supportSubMenu);
        this.mSubMenu = supportSubMenu;
    }

    public static android.view.SubMenu EAeBQmQjslWfjAJM(androidx.core.internal.view.SupportSubMenu supportSubMenu, int i) {
        return supportSubMenu.setHeaderIcon(i);
    }

    public static android.view.SubMenu PQydepdATmNHqySw(androidx.core.internal.view.SupportSubMenu supportSubMenu, java.lang.CharSequence charSequence) {
        return supportSubMenu.setHeaderTitle(charSequence);
    }

    public static android.view.SubMenu RiiCCLKHzUmsEtZS(androidx.core.internal.view.SupportSubMenu supportSubMenu, int i) {
        return supportSubMenu.setHeaderTitle(i);
    }

    public static void WUplUkUvpQJYvDLC(androidx.core.internal.view.SupportSubMenu supportSubMenu) {
        supportSubMenu.clearHeader();
    }

    public static android.view.SubMenu WykfGDWhmYAKsEgc(androidx.core.internal.view.SupportSubMenu supportSubMenu, android.graphics.drawable.Drawable drawable) {
        return supportSubMenu.setIcon(drawable);
    }

    public static android.view.SubMenu ZufPGfqTrglJJmyP(androidx.core.internal.view.SupportSubMenu supportSubMenu, android.graphics.drawable.Drawable drawable) {
        return supportSubMenu.setHeaderIcon(drawable);
    }

    public static android.view.MenuItem AIGysdTsDomKagFD(androidx.core.internal.view.SupportSubMenu supportSubMenu) {
        return supportSubMenu.getItem();
    }

    public static android.view.MenuItem NMeHecEgUDxlAfRc(androidx.appcompat.view.menu.SubMenuWrapperICS subMenuWrapperICS, android.view.MenuItem menuItem) {
        return subMenuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static android.view.SubMenu RZmBwoRqudjYyjji(androidx.core.internal.view.SupportSubMenu supportSubMenu, android.view.object view) {
        return supportSubMenu.setHeaderobject(view);
    }

    public static android.view.SubMenu YGbYQyIcpPLEsVTw(androidx.core.internal.view.SupportSubMenu supportSubMenu, int i) {
        return supportSubMenu.setIcon(i);
    }

    public override void ClearHeader() {
        WUplUkUvpQJYvDLC(this.mSubMenu);
    }

    public override android.view.MenuItem GetItem() {
        return nMeHecEgUDxlAfRc(this, aIGysdTsDomKagFD(this.mSubMenu));
    }

    public override android.view.SubMenu SetHeaderIcon(int i) {
        EAeBQmQjslWfjAJM(this.mSubMenu, i);
        return this;
    }

    public override android.view.SubMenu SetHeaderIcon(android.graphics.drawable.Drawable drawable) {
        ZufPGfqTrglJJmyP(this.mSubMenu, drawable);
        return this;
    }

    public override android.view.SubMenu SetHeaderTitle(int i) {
        RiiCCLKHzUmsEtZS(this.mSubMenu, i);
        return this;
    }

    public override android.view.SubMenu SetHeaderTitle(java.lang.CharSequence charSequence) {
        PQydepdATmNHqySw(this.mSubMenu, charSequence);
        return this;
    }

    public override android.view.SubMenu SetHeaderobject(android.view.object view) {
        rZmBwoRqudjYyjji(this.mSubMenu, view);
        return this;
    }

    public override android.view.SubMenu SetIcon(int i) {
        yGbYQyIcpPLEsVTw(this.mSubMenu, i);
        return this;
    }

    public override android.view.SubMenu SetIcon(android.graphics.drawable.Drawable drawable) {
        WykfGDWhmYAKsEgc(this.mSubMenu, drawable);
        return this;
    }
}

