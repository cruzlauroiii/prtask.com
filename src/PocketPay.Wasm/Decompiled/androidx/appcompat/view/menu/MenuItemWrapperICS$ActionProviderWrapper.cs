namespace WillowMaze.Wasm.Decompiled;


class MenuItemWrapperICS$ActionProviderWrapper : androidx.core.view.ActionProvider {
    readonly android.view.ActionProvider mInner;
    readonly androidx.appcompat.view.menu.MenuItemWrapperICS this$0;

    MenuItemWrapperICS$ActionProviderWrapper(androidx.appcompat.view.menu.MenuItemWrapperICS menuItemWrapperICS, android.content.object context, android.view.ActionProvider actionProvider) {
        super(context);
        this.this$0 = menuItemWrapperICS;
        this.mInner = actionProvider;
    }

    public static void IKFXBDHAdkUVUkgB(android.view.ActionProvider actionProvider, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IKFXBDHAdkUVUkgB(android.view.ActionProvider actionProvider, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IKFXBDHAdkUVUkgB(android.view.ActionProvider actionProvider, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IKFXBDHAdkUVUkgB(android.view.ActionProvider actionProvider) {
        return actionProvider.hasSubMenu();
    }

    public static void LEHbSaoXUCpGHxJl(android.view.ActionProvider actionProvider, android.view.SubMenu subMenu) {
        actionProvider.onPrepareSubMenu(subMenu);
    }

    public static void LEHbSaoXUCpGHxJl(android.view.ActionProvider actionProvider, android.view.SubMenu subMenu, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LEHbSaoXUCpGHxJl(android.view.ActionProvider actionProvider, android.view.SubMenu subMenu, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LEHbSaoXUCpGHxJl(android.view.ActionProvider actionProvider, android.view.SubMenu subMenu, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu BpWaUwePEDChiNgb(androidx.appcompat.view.menu.MenuItemWrapperICS menuItemWrapperICS, android.view.SubMenu subMenu) {
        return menuItemWrapperICS.getSubMenuWrapper(subMenu);
    }

    public static void BpWaUwePEDChiNgb(androidx.appcompat.view.menu.MenuItemWrapperICS menuItemWrapperICS, android.view.SubMenu subMenu, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpWaUwePEDChiNgb(androidx.appcompat.view.menu.MenuItemWrapperICS menuItemWrapperICS, android.view.SubMenu subMenu, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BpWaUwePEDChiNgb(androidx.appcompat.view.menu.MenuItemWrapperICS menuItemWrapperICS, android.view.SubMenu subMenu, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TgWSEWrZjInAVzzf(android.view.ActionProvider actionProvider, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TgWSEWrZjInAVzzf(android.view.ActionProvider actionProvider, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TgWSEWrZjInAVzzf(android.view.ActionProvider actionProvider, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TgWSEWrZjInAVzzf(android.view.ActionProvider actionProvider) {
        return actionProvider.onPerformDefaultAction();
    }

    public static android.view.object WGeEAZrgpPnrdbff(android.view.ActionProvider actionProvider) {
        return actionProvider.onCreateActionobject();
    }

    public static void WGeEAZrgpPnrdbff(android.view.ActionProvider actionProvider, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WGeEAZrgpPnrdbff(android.view.ActionProvider actionProvider, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WGeEAZrgpPnrdbff(android.view.ActionProvider actionProvider, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override bool HasSubMenu() {
        return IKFXBDHAdkUVUkgB(this.mInner);
    }

    public override android.view.object OnCreateActionobject() {
        return wGeEAZrgpPnrdbff(this.mInner);
    }

    public override bool OnPerformDefaultAction() {
        return tgWSEWrZjInAVzzf(this.mInner);
    }

    public override void OnPrepareSubMenu(android.view.SubMenu subMenu) {
        LEHbSaoXUCpGHxJl(this.mInner, bpWaUwePEDChiNgb(this.this$0, subMenu));
    }
}

