namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$ActionMenuPopupCallback : androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback {
    readonly androidx.appcompat.widget.ActionMenuPresenter this$0;

    ActionMenuPresenter$ActionMenuPopupCallback(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        this.this$0 = actionMenuPresenter;
    }

    public static androidx.appcompat.view.menu.MenuPopup ZPqGSPOBSUFqAVKG(androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu) {
        return actionMenuPresenter$ActionButtonSubmenu.getPopup();
    }

    public override androidx.appcompat.view.menu.ShowableListMenu GetPopup() {
        if (this.this$0.mActionButtonPopup is null) {
            return null;
        }
        return zPqGSPOBSUFqAVKG(this.this$0.mActionButtonPopup);
    }
}

