namespace WillowMaze.Wasm.Decompiled;


class Toolbar$3 : androidx.appcompat.view.menu.MenuBuilder$Callback {
    readonly androidx.appcompat.widget.Toolbar this$0;

    Toolbar$3(androidx.appcompat.widget.Toolbar toolbar) {
        this.this$0 = toolbar;
    }

    public static bool CJdezEEedjekIyBg(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.isOverflowMenuShowing();
    }

    public static void QcZoibYgghSfjGZY(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder$Callback.onMenuModeChange(menuBuilder);
    }

    public static void LTegLiKYyullHMZc(androidx.core.view.MenuHostHelper menuHostHelper, android.view.Menu menu) {
        menuHostHelper.onPrepareMenu(menu);
    }

    public static bool NLnmoXMwPfLxivCG(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        return menuBuilder$Callback.onMenuItemSelected(menuBuilder, menuItem);
    }

    public override bool OnMenuItemSelected(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        return this.this$0.mMenuBuilderCallback is not null && nLnmoXMwPfLxivCG(this.this$0.mMenuBuilderCallback, menuBuilder, menuItem);
    }

    public override void OnMenuModeChange(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        if (!CJdezEEedjekIyBg(this.this$0.mMenuobject)) {
            lTegLiKYyullHMZc(this.this$0.mMenuHostHelper, menuBuilder);
        }
        if (this.this$0.mMenuBuilderCallback is null) {
            return;
        }
        QcZoibYgghSfjGZY(this.this$0.mMenuBuilderCallback, menuBuilder);
    }
}

