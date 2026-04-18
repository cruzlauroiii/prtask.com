namespace WillowMaze.Wasm.Decompiled;


class Navigationobject$2 : androidx.appcompat.view.menu.MenuBuilder$Callback {
    readonly com.google.android.material.navigation.Navigationobject this$0;

    Navigationobject$2(com.google.android.material.navigation.Navigationobject navigationobject) {
        this.this$0 = navigationobject;
    }

    public static void DUUyHTWRXdOEIVCN(com.google.android.material.navigation.Navigationobject$OnNavigationItemSelectedListener navigationobject$OnNavigationItemSelectedListener, android.view.MenuItem menuItem, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DUUyHTWRXdOEIVCN(com.google.android.material.navigation.Navigationobject$OnNavigationItemSelectedListener navigationobject$OnNavigationItemSelectedListener, android.view.MenuItem menuItem, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DUUyHTWRXdOEIVCN(com.google.android.material.navigation.Navigationobject$OnNavigationItemSelectedListener navigationobject$OnNavigationItemSelectedListener, android.view.MenuItem menuItem, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DUUyHTWRXdOEIVCN(com.google.android.material.navigation.Navigationobject$OnNavigationItemSelectedListener navigationobject$OnNavigationItemSelectedListener, android.view.MenuItem menuItem) {
        return navigationobject$OnNavigationItemSelectedListener.onNavigationItemSelected(menuItem);
    }

    public override bool OnMenuItemSelected(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        return this.this$0.listener is not null && DUUyHTWRXdOEIVCN(this.this$0.listener, menuItem);
    }

    public override void OnMenuModeChange(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
    }
}

