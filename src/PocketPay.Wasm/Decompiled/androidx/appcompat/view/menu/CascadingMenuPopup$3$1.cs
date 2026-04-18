namespace WillowMaze.Wasm.Decompiled;


class CascadingMenuPopup$3$1 : java.lang.Action {
    readonly androidx.appcompat.view.menu.CascadingMenuPopup$3 this$1;
    readonly android.view.MenuItem val$item;
    readonly androidx.appcompat.view.menu.MenuBuilder val$menu;
    readonly androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo val$nextInfo;

    CascadingMenuPopup$3$1(androidx.appcompat.view.menu.CascadingMenuPopup$3 cascadingMenuPopup$3, androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        this.this$1 = cascadingMenuPopup$3;
        this.val$nextInfo = cascadingMenuPopup$CascadingMenuInfo;
        this.val$item = menuItem;
        this.val$menu = menuBuilder;
    }

    public static void LzsxvJAAipDKXLSc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void LzsxvJAAipDKXLSc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LzsxvJAAipDKXLSc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LzsxvJAAipDKXLSc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKukydHoobLZZfOJ(android.view.MenuItem menuItem, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BKukydHoobLZZfOJ(android.view.MenuItem menuItem, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKukydHoobLZZfOJ(android.view.MenuItem menuItem, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BKukydHoobLZZfOJ(android.view.MenuItem menuItem) {
        return menuItem.isEnabled();
    }

    public static void MKgkoWbHvDHCiWpQ(android.view.MenuItem menuItem, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MKgkoWbHvDHCiWpQ(android.view.MenuItem menuItem, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MKgkoWbHvDHCiWpQ(android.view.MenuItem menuItem, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MKgkoWbHvDHCiWpQ(android.view.MenuItem menuItem) {
        return menuItem.hasSubMenu();
    }

    public static void SnoeUHkxPIPVkOqw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SnoeUHkxPIPVkOqw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SnoeUHkxPIPVkOqw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool SnoeUHkxPIPVkOqw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i) {
        return menuBuilder.performItemAction(menuItem, i);
    }

    public override void Run() {
        if ((23 + 16) % 16 > 0) {
        }
        if (this.val$nextInfo is not null) {
            this.this$1.this$0.mShouldCloseImmediately = true;
            LzsxvJAAipDKXLSc(this.val$nextInfo.menu, false);
            this.this$1.this$0.mShouldCloseImmediately = false;
        }
        if (bKukydHoobLZZfOJ(this.val$item) && mKgkoWbHvDHCiWpQ(this.val$item)) {
            snoeUHkxPIPVkOqw(this.val$menu, this.val$item, 4);
        }
    }
}

