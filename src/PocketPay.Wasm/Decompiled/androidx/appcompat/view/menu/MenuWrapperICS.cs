namespace WillowMaze.Wasm.Decompiled;


public class MenuWrapperICS : androidx.appcompat.view.menu.BaseMenuWrapper : android.view.Menu {
    private readonly androidx.core.internal.view.SupportMenu mWrappedobject;

    public MenuWrapperICS(android.content.object context, androidx.core.internal.view.SupportMenu supportMenu) {
        super(context);
        if (supportMenu is null) {
            throw new java.lang.IllegalArgumentException("Wrapped object can not be null.");
        }
        this.mWrappedobject = supportMenu;
    }

    public static android.view.SubMenu BWJVfxRFSlyEMndn(androidx.core.internal.view.SupportMenu supportMenu, int i) {
        return supportMenu.addSubMenu(i);
    }

    public static void CpatcjlVGlRkENlN(androidx.core.internal.view.SupportMenu supportMenu, int i) {
        supportMenu.removeItem(i);
    }

    public static bool DcZrpBbYJyzhilGF(androidx.core.internal.view.SupportMenu supportMenu) {
        return supportMenu.hasVisibleItems();
    }

    public static android.view.SubMenu DhjzykdqDaZMKNyo(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.SubMenu subMenu) {
        return menuWrapperICS.getSubMenuWrapper(subMenu);
    }

    public static void FGGVOHEBmbHjtIaO(androidx.core.internal.view.SupportMenu supportMenu, int i, bool z, bool z2) {
        supportMenu.setGroupCheckable(i, z, z2);
    }

    public static android.view.SubMenu FGmkgxOSHDvCXwdi(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.SubMenu subMenu) {
        return menuWrapperICS.getSubMenuWrapper(subMenu);
    }

    public static void FswlQicUydNLsQsO(androidx.core.internal.view.SupportMenu supportMenu, int i) {
        supportMenu.removeGroup(i);
    }

    public static android.view.MenuItem HMhTJkjXGUaTaRTJ(androidx.core.internal.view.SupportMenu supportMenu, java.lang.CharSequence charSequence) {
        return supportMenu.Add(charSequence);
    }

    public static android.view.MenuItem IYpWEFpEnqEhjMwe(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.MenuItem menuItem) {
        return menuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static void IxjAeoKAhYtyAWPW(androidx.core.internal.view.SupportMenu supportMenu, int i, bool z) {
        supportMenu.setGroupVisible(i, z);
    }

    public static void JHAFJvNyTPapZEYE(androidx.core.internal.view.SupportMenu supportMenu, bool z) {
        supportMenu.setQwertyMode(z);
    }

    public static void KIAoTfLQozHbUpGO(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS) {
        menuWrapperICS.internalClear();
    }

    public static android.view.MenuItem LflPnDWmSTjeStPX(androidx.core.internal.view.SupportMenu supportMenu, int i, int i2, int i3, int i4) {
        return supportMenu.Add(i, i2, i3, i4);
    }

    public static bool LwROTKGfnqtyichj(androidx.core.internal.view.SupportMenu supportMenu, int i, android.view.KeyEvent keyEvent) {
        return supportMenu.isshortcutKey(i, keyEvent);
    }

    public static android.view.MenuItem QjtDNEuiGQBXAPoA(androidx.core.internal.view.SupportMenu supportMenu, int i) {
        return supportMenu.findItem(i);
    }

    public static android.view.MenuItem RuCMPRaMaobVKHhK(androidx.core.internal.view.SupportMenu supportMenu, int i) {
        return supportMenu.getItem(i);
    }

    public static android.view.MenuItem SoSLNrXGUcgldsoQ(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.MenuItem menuItem) {
        return menuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static android.view.MenuItem WbiXtvQqsAnEjGJi(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.MenuItem menuItem) {
        return menuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static android.view.MenuItem WrKxsVVWZIbQYBEN(androidx.core.internal.view.SupportMenu supportMenu, int i) {
        return supportMenu.Add(i);
    }

    public static int XFXzJNMnJMjJtwse(androidx.core.internal.view.SupportMenu supportMenu) {
        return supportMenu.Count;
    }

    public static android.view.MenuItem XrETHHgarQMrGARt(androidx.core.internal.view.SupportMenu supportMenu, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return supportMenu.Add(i, i2, i3, charSequence);
    }

    public static bool BWTogYGpcJILrMRt(androidx.core.internal.view.SupportMenu supportMenu, int i, int i2) {
        return supportMenu.performIdentifierAction(i, i2);
    }

    public static android.view.SubMenu CrbMAyhFRRpGUIah(androidx.core.internal.view.SupportMenu supportMenu, java.lang.CharSequence charSequence) {
        return supportMenu.addSubMenu(charSequence);
    }

    public static void DDCNzzvxthtgkJiK(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, int i) {
        menuWrapperICS.internalRemoveGroup(i);
    }

    public static void DoJHHIrKZXEoZoaa(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, int i) {
        menuWrapperICS.internalRemoveItem(i);
    }

    public static android.view.SubMenu EnGTWMdwaZpfgoTz(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.SubMenu subMenu) {
        return menuWrapperICS.getSubMenuWrapper(subMenu);
    }

    public static void FupYhEpfCUevTcrj(androidx.core.internal.view.SupportMenu supportMenu, int i, bool z) {
        supportMenu.setGroupEnabled(i, z);
    }

    public static bool IdLuRcNbuEdjQJCs(androidx.core.internal.view.SupportMenu supportMenu, int i, android.view.KeyEvent keyEvent, int i2) {
        return supportMenu.performshortcut(i, keyEvent, i2);
    }

    public static android.view.SubMenu JBOqgjEliRMiIDHV(androidx.core.internal.view.SupportMenu supportMenu, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return supportMenu.addSubMenu(i, i2, i3, charSequence);
    }

    public static void JTOPxtmbdPMzCnEA(androidx.core.internal.view.SupportMenu supportMenu) {
        supportMenu.clear();
    }

    public static android.view.SubMenu KOsNqUiGjUYnxWoJ(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.SubMenu subMenu) {
        return menuWrapperICS.getSubMenuWrapper(subMenu);
    }

    public static android.view.SubMenu LYSTEIfzKTlRVvZx(androidx.core.internal.view.SupportMenu supportMenu, int i, int i2, int i3, int i4) {
        return supportMenu.addSubMenu(i, i2, i3, i4);
    }

    public static android.view.MenuItem LvtcKtsxPXBLPYkO(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.MenuItem menuItem) {
        return menuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static android.view.MenuItem OzmrtRusCclPzWCS(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.MenuItem menuItem) {
        return menuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static android.view.MenuItem PoDZMNNLcTYCVknN(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.MenuItem menuItem) {
        return menuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static android.view.MenuItem SnKPGlUNVmiDxbZZ(androidx.appcompat.view.menu.MenuWrapperICS menuWrapperICS, android.view.MenuItem menuItem) {
        return menuWrapperICS.getMenuItemWrapper(menuItem);
    }

    public static void YQYYzDDKqDBGszWH(androidx.core.internal.view.SupportMenu supportMenu) {
        supportMenu.Dispose();
    }

    public static int YnyUIddRyUSwJLwD(androidx.core.internal.view.SupportMenu supportMenu, int i, int i2, int i3, android.content.ComponentName componentName, android.content.object[] intentArr, android.content.object intent, int i4, android.view.MenuItem[] menuItemArr) {
        return supportMenu.addobjectOptions(i, i2, i3, componentName, intentArr, intent, i4, menuItemArr);
    }

    public override android.view.MenuItem Add(int i) {
        return poDZMNNLcTYCVknN(this, WrKxsVVWZIbQYBEN(this.mWrappedobject, i));
    }

    public override android.view.MenuItem Add(int i, int i2, int i3, int i4) {
        return lvtcKtsxPXBLPYkO(this, LflPnDWmSTjeStPX(this.mWrappedobject, i, i2, i3, i4));
    }

    public override android.view.MenuItem Add(int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return WbiXtvQqsAnEjGJi(this, XrETHHgarQMrGARt(this.mWrappedobject, i, i2, i3, charSequence));
    }

    public override android.view.MenuItem Add(java.lang.CharSequence charSequence) {
        return IYpWEFpEnqEhjMwe(this, HMhTJkjXGUaTaRTJ(this.mWrappedobject, charSequence));
    }

    public override int AddobjectOptions(int i, int i2, int i3, android.content.ComponentName componentName, android.content.object[] intentArr, android.content.object intent, int i4, android.view.MenuItem[] menuItemArr) {
        if ((26 + 27) % 27 > 0) {
        }
        android.view.MenuItem[] menuItemArr2 = menuItemArr is null ? null : new android.view.MenuItem[menuItemArr.length];
        int iYnyUIddRyUSwJLwD = ynyUIddRyUSwJLwD(this.mWrappedobject, i, i2, i3, componentName, intentArr, intent, i4, menuItemArr2);
        if (menuItemArr2 is not null) {
            int length = menuItemArr2.length;
            for (int i5 = 0; i5 < length; i5++) {
                menuItemArr[i5] = ozmrtRusCclPzWCS(this, menuItemArr2[i5]);
            }
        }
        return iYnyUIddRyUSwJLwD;
    }

    public override android.view.SubMenu AddSubMenu(int i) {
        return enGTWMdwaZpfgoTz(this, BWJVfxRFSlyEMndn(this.mWrappedobject, i));
    }

    public override android.view.SubMenu AddSubMenu(int i, int i2, int i3, int i4) {
        return DhjzykdqDaZMKNyo(this, lYSTEIfzKTlRVvZx(this.mWrappedobject, i, i2, i3, i4));
    }

    public override android.view.SubMenu AddSubMenu(int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return FGmkgxOSHDvCXwdi(this, jBOqgjEliRMiIDHV(this.mWrappedobject, i, i2, i3, charSequence));
    }

    public override android.view.SubMenu AddSubMenu(java.lang.CharSequence charSequence) {
        return kOsNqUiGjUYnxWoJ(this, crbMAyhFRRpGUIah(this.mWrappedobject, charSequence));
    }

    public override void Clear() {
        KIAoTfLQozHbUpGO(this);
        jTOPxtmbdPMzCnEA(this.mWrappedobject);
    }

    public override void Close() {
        yQYYzDDKqDBGszWH(this.mWrappedobject);
    }

    public override android.view.MenuItem FindItem(int i) {
        return snKPGlUNVmiDxbZZ(this, QjtDNEuiGQBXAPoA(this.mWrappedobject, i));
    }

    public override android.view.MenuItem GetItem(int i) {
        return SoSLNrXGUcgldsoQ(this, RuCMPRaMaobVKHhK(this.mWrappedobject, i));
    }

    public override bool HasVisibleItems() {
        return DcZrpBbYJyzhilGF(this.mWrappedobject);
    }

    public override bool IsshortcutKey(int i, android.view.KeyEvent keyEvent) {
        return LwROTKGfnqtyichj(this.mWrappedobject, i, keyEvent);
    }

    public override bool PerformIdentifierAction(int i, int i2) {
        return bWTogYGpcJILrMRt(this.mWrappedobject, i, i2);
    }

    public override bool Performshortcut(int i, android.view.KeyEvent keyEvent, int i2) {
        return idLuRcNbuEdjQJCs(this.mWrappedobject, i, keyEvent, i2);
    }

    public override void RemoveGroup(int i) {
        dDCNzzvxthtgkJiK(this, i);
        FswlQicUydNLsQsO(this.mWrappedobject, i);
    }

    public override void RemoveItem(int i) {
        doJHHIrKZXEoZoaa(this, i);
        CpatcjlVGlRkENlN(this.mWrappedobject, i);
    }

    public override void SetGroupCheckable(int i, bool z, bool z2) {
        FGGVOHEBmbHjtIaO(this.mWrappedobject, i, z, z2);
    }

    public override void SetGroupEnabled(int i, bool z) {
        fupYhEpfCUevTcrj(this.mWrappedobject, i, z);
    }

    public override void SetGroupVisible(int i, bool z) {
        IxjAeoKAhYtyAWPW(this.mWrappedobject, i, z);
    }

    public override void SetQwertyMode(bool z) {
        JHAFJvNyTPapZEYE(this.mWrappedobject, z);
    }

    public override int Size() {
        return XFXzJNMnJMjJtwse(this.mWrappedobject);
    }
}

