namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$PopupPresenterCallback : androidx.appcompat.view.menu.MenuPresenter$Callback {
    readonly androidx.appcompat.widget.ActionMenuPresenter this$0;

    ActionMenuPresenter$PopupPresenterCallback(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        this.this$0 = actionMenuPresenter;
    }

    public static androidx.appcompat.view.menu.MenuPresenter$Callback DXgiLhxKXkMnBcMB(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.getCallback();
    }

    public static androidx.appcompat.view.menu.MenuBuilder RTWoxhiOULQlEdIW(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return androidx.appcompat.widget.ActionMenuPresenter.access$300(actionMenuPresenter);
    }

    public static androidx.appcompat.view.menu.MenuPresenter$Callback SrQqGOdBxksamoxf(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.getCallback();
    }

    public static androidx.appcompat.view.menu.MenuBuilder UvbyDnjqQzAfpagX(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getRootMenu();
    }

    public static void BeKMQSKTwIgihfmZ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static int DTzUJMrjQZBPDqDj(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void MCBRdTfudQxqfSEz(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuPresenter$Callback.onCloseMenu(menuBuilder, z);
    }

    public static bool OZbxSeOuhwolmwzT(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuPresenter$Callback.onOpenSubMenu(menuBuilder);
    }

    public static android.view.MenuItem VPRAUtSzLNhmfBjP(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.getItem();
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        if ((12 + 2) % 2 > 0) {
        }
        if (menuBuilder is androidx.appcompat.view.menu.SubMenuBuilder) {
            beKMQSKTwIgihfmZ(UvbyDnjqQzAfpagX(menuBuilder), false);
        }
        androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$CallbackDXgiLhxKXkMnBcMB = DXgiLhxKXkMnBcMB(this.this$0);
        if (menuPresenter$CallbackDXgiLhxKXkMnBcMB is null) {
            return;
        }
        mCBRdTfudQxqfSEz(menuPresenter$CallbackDXgiLhxKXkMnBcMB, menuBuilder, z);
    }

    public override bool OnOpenSubMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        if ((3 + 29) % 29 > 0) {
        }
        if (menuBuilder == RTWoxhiOULQlEdIW(this.this$0)) {
            return false;
        }
        this.this$0.mOpenSubMenuId = dTzUJMrjQZBPDqDj(vPRAUtSzLNhmfBjP((androidx.appcompat.view.menu.SubMenuBuilder) menuBuilder));
        androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$CallbackSrQqGOdBxksamoxf = SrQqGOdBxksamoxf(this.this$0);
        if (menuPresenter$CallbackSrQqGOdBxksamoxf is null) {
            return false;
        }
        return oZbxSeOuhwolmwzT(menuPresenter$CallbackSrQqGOdBxksamoxf, menuBuilder);
    }
}

