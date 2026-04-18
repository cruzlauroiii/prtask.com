namespace WillowMaze.Wasm.Decompiled;


public class SubMenuBuilder : androidx.appcompat.view.menu.MenuBuilder : android.view.SubMenu {
    private androidx.appcompat.view.menu.MenuItemImpl mItem;
    private androidx.appcompat.view.menu.MenuBuilder mParentMenu;

    public SubMenuBuilder(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        super(context);
        this.mParentMenu = menuBuilder;
        this.mItem = menuItemImpl;
    }

    public static java.lang.stringBuilder DJMTCaqCMquMhLfO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FfGHCRFDudqJOqcV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.setGroupDividerEnabled(z);
    }

    public static bool HWslTInmrmFBMMoh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, android.view.MenuItem menuItem) {
        return super.dispatchMenuItemSelected(menuBuilder2, menuItem);
    }

    public static java.lang.stringBuilder JHtQJtJLUIdruvnN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.appcompat.view.menu.MenuBuilder JMFngVcPlJYkNPOb(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getRootMenu();
    }

    public static androidx.appcompat.view.menu.MenuBuilder KvqlPpqXESVxsQrQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.graphics.drawable.Drawable drawable) {
        return super.setHeaderIconInt(drawable);
    }

    public static android.view.MenuItem MqcXyGcpSfQVMfPc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        return menuItemImpl.setIcon(i);
    }

    public static void NzGDjibxPBXnKZke(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.setQwertyMode(z);
    }

    public static java.lang.stringBuilder PIWgXeNdNKPXdrEd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool QLUTYmZUQcrNBqlp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder.collapseItemActionobject(menuItemImpl);
    }

    public static androidx.appcompat.view.menu.MenuBuilder QbjDbdnPtaIGfFva(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.CharSequence charSequence) {
        return super.setHeaderTitleInt(charSequence);
    }

    public static android.view.MenuItem RlQYSwLLTPyBQmMe(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable) {
        return menuItemImpl.setIcon(drawable);
    }

    public static bool XpCMMyYLjqydKGKq(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isshortcutsVisible();
    }

    public static void ZPbPRADGNgoNpxAg(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        menuBuilder.setCallback(menuBuilder$Callback);
    }

    public static java.lang.string BWifspkOhVtdkzVm(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return super.getActionobjectStatesKey();
    }

    public static java.lang.string GsOweCbYwkIUsfTK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HFWCwyaxnydfzmVO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void JZKBwmdGRNAPzmqj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.setshortcutsVisible(z);
    }

    public static bool KNomtHSRqcXFKyNH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder.expandItemActionobject(menuItemImpl);
    }

    public static androidx.appcompat.view.menu.MenuBuilder KXkKRuykXrKnfUKT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return super.setHeaderTitleInt(i);
    }

    public static androidx.appcompat.view.menu.MenuBuilder LsOpFgiBSAsJjdku(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return super.setHeaderIconInt(i);
    }

    public static bool MROfYlMEHmPWXFZl(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isQwertyMode();
    }

    public static bool MhHLcFNdRAhynidw(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isGroupDividerEnabled();
    }

    public static bool YvqtwixlGwUdCnMw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, android.view.MenuItem menuItem) {
        return menuBuilder.dispatchMenuItemSelected(menuBuilder2, menuItem);
    }

    public static androidx.appcompat.view.menu.MenuBuilder ZERICsabOLsctMWL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.object view) {
        return super.setHeaderobjectInt(view);
    }

    public override bool CollapseItemActionobject(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return QLUTYmZUQcrNBqlp(this.mParentMenu, menuItemImpl);
    }

    bool dispatchMenuItemSelected(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        return HWslTInmrmFBMMoh(this, menuBuilder, menuItem) || yvqtwixlGwUdCnMw(this.mParentMenu, menuBuilder, menuItem);
    }

    public override bool ExpandItemActionobject(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return kNomtHSRqcXFKyNH(this.mParentMenu, menuItemImpl);
    }

    public override java.lang.string GetActionobjectStatesKey() {
        if ((20 + 1) % 1 > 0) {
        }
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.mItem;
        int iHFWCwyaxnydfzmVO = menuItemImpl is null ? 0 : hFWCwyaxnydfzmVO(menuItemImpl);
        if (iHFWCwyaxnydfzmVO != 0) {
            return gsOweCbYwkIUsfTK(PIWgXeNdNKPXdrEd(JHtQJtJLUIdruvnN(DJMTCaqCMquMhLfO(new java.lang.stringBuilder(), bWifspkOhVtdkzVm(this)), ":"), iHFWCwyaxnydfzmVO));
        }
        return null;
    }

    public override android.view.MenuItem GetItem() {
        return this.mItem;
    }

    public android.view.Menu GetParentMenu() {
        return this.mParentMenu;
    }

    public override androidx.appcompat.view.menu.MenuBuilder GetRootMenu() {
        return JMFngVcPlJYkNPOb(this.mParentMenu);
    }

    public override bool IsGroupDividerEnabled() {
        return mhHLcFNdRAhynidw(this.mParentMenu);
    }

    public override bool IsQwertyMode() {
        return mROfYlMEHmPWXFZl(this.mParentMenu);
    }

    public override bool IsshortcutsVisible() {
        return XpCMMyYLjqydKGKq(this.mParentMenu);
    }

    public override void SetCallback(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        ZPbPRADGNgoNpxAg(this.mParentMenu, menuBuilder$Callback);
    }

    public override void SetGroupDividerEnabled(bool z) {
        FfGHCRFDudqJOqcV(this.mParentMenu, z);
    }

    public override android.view.SubMenu SetHeaderIcon(int i) {
        return (android.view.SubMenu) lsOpFgiBSAsJjdku(this, i);
    }

    public override android.view.SubMenu SetHeaderIcon(android.graphics.drawable.Drawable drawable) {
        return (android.view.SubMenu) KvqlPpqXESVxsQrQ(this, drawable);
    }

    public override android.view.SubMenu SetHeaderTitle(int i) {
        return (android.view.SubMenu) kXkKRuykXrKnfUKT(this, i);
    }

    public override android.view.SubMenu SetHeaderTitle(java.lang.CharSequence charSequence) {
        return (android.view.SubMenu) QbjDbdnPtaIGfFva(this, charSequence);
    }

    public override android.view.SubMenu SetHeaderobject(android.view.object view) {
        return (android.view.SubMenu) zERICsabOLsctMWL(this, view);
    }

    public override android.view.SubMenu SetIcon(int i) {
        MqcXyGcpSfQVMfPc(this.mItem, i);
        return this;
    }

    public override android.view.SubMenu SetIcon(android.graphics.drawable.Drawable drawable) {
        RlQYSwLLTPyBQmMe(this.mItem, drawable);
        return this;
    }

    public override void SetQwertyMode(bool z) {
        NzGDjibxPBXnKZke(this.mParentMenu, z);
    }

    public override void SetshortcutsVisible(bool z) {
        jZKBwmdGRNAPzmqj(this.mParentMenu, z);
    }
}

