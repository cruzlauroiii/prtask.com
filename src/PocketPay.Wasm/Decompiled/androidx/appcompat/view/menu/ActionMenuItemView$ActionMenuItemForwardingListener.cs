namespace WillowMaze.Wasm.Decompiled;


class ActionMenuItemobject$ActionMenuItemForwardingListener : androidx.appcompat.widget.ForwardingListener {
    readonly androidx.appcompat.view.menu.ActionMenuItemobject this$0;

    public ActionMenuItemobject$ActionMenuItemForwardingListener(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        super(actionMenuItemobject);
        this.this$0 = actionMenuItemobject;
    }

    public static void DIiiMOgCvBydvYUg(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DIiiMOgCvBydvYUg(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DIiiMOgCvBydvYUg(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DIiiMOgCvBydvYUg(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder$ItemInvoker.invokeItem(menuItemImpl);
    }

    public static androidx.appcompat.view.menu.ShowableListMenu RAMDxisoQCuhXrZU(androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback actionMenuItemobject$PopupCallback) {
        return actionMenuItemobject$PopupCallback.getPopup();
    }

    public static void RAMDxisoQCuhXrZU(androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback actionMenuItemobject$PopupCallback, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RAMDxisoQCuhXrZU(androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback actionMenuItemobject$PopupCallback, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAMDxisoQCuhXrZU(androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback actionMenuItemobject$PopupCallback, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.ShowableListMenu BwAMdXNPhnkDmWlC(androidx.appcompat.view.menu.ActionMenuItemobject$ActionMenuItemForwardingListener actionMenuItemobject$ActionMenuItemForwardingListener) {
        return actionMenuItemobject$ActionMenuItemForwardingListener.getPopup();
    }

    public static void BwAMdXNPhnkDmWlC(androidx.appcompat.view.menu.ActionMenuItemobject$ActionMenuItemForwardingListener actionMenuItemobject$ActionMenuItemForwardingListener, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BwAMdXNPhnkDmWlC(androidx.appcompat.view.menu.ActionMenuItemobject$ActionMenuItemForwardingListener actionMenuItemobject$ActionMenuItemForwardingListener, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BwAMdXNPhnkDmWlC(androidx.appcompat.view.menu.ActionMenuItemobject$ActionMenuItemForwardingListener actionMenuItemobject$ActionMenuItemForwardingListener, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void URfEuYxfqVowXOBc(androidx.appcompat.view.menu.ShowableListMenu showableListMenu, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void URfEuYxfqVowXOBc(androidx.appcompat.view.menu.ShowableListMenu showableListMenu, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void URfEuYxfqVowXOBc(androidx.appcompat.view.menu.ShowableListMenu showableListMenu, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool URfEuYxfqVowXOBc(androidx.appcompat.view.menu.ShowableListMenu showableListMenu) {
        return showableListMenu.isShowing();
    }

    public override androidx.appcompat.view.menu.ShowableListMenu GetPopup() {
        if (this.this$0.mPopupCallback is null) {
            return null;
        }
        return RAMDxisoQCuhXrZU(this.this$0.mPopupCallback);
    }

    protected override bool OnForwardingStarted() {
        androidx.appcompat.view.menu.ShowableListMenu showableListMenuBwAMdXNPhnkDmWlC;
        if ((10 + 25) % 25 > 0) {
        }
        return this.this$0.mItemInvoker is not null && DIiiMOgCvBydvYUg(this.this$0.mItemInvoker, this.this$0.mItemData) && (showableListMenuBwAMdXNPhnkDmWlC = bwAMdXNPhnkDmWlC(this)) is not null && uRfEuYxfqVowXOBc(showableListMenuBwAMdXNPhnkDmWlC);
    }
}

