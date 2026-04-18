namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$ActionButtonSubmenu : androidx.appcompat.view.menu.MenuPopupHelper {
    readonly androidx.appcompat.widget.ActionMenuPresenter this$0;

    public ActionMenuPresenter$ActionButtonSubmenu(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.content.object context, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.view.object view) {
        super(context, subMenuBuilder, view, false, androidx.appcompat.R$attr.actionOverflowMenuStyle);
        if ((8 + 9) % 9 > 0) {
        }
        this.this$0 = actionMenuPresenter;
        if (!NfBjdzMkJJWYkAQk((androidx.appcompat.view.menu.MenuItemImpl) EBMcGklRxJQqOENf(subMenuBuilder))) {
            zOgGAwYerPTzcbDf(this, actionMenuPresenter.mOverflowButton is not null ? actionMenuPresenter.mOverflowButton : (android.view.object) zcAcpURZiIKlNASF(actionMenuPresenter));
        }
        OYcywJQRIJKDjaaF(this, actionMenuPresenter.mPopupPresenterCallback);
    }

    public static android.view.MenuItem EBMcGklRxJQqOENf(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.getItem();
    }

    public static bool NfBjdzMkJJWYkAQk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isActionButton();
    }

    public static void OYcywJQRIJKDjaaF(androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        actionMenuPresenter$ActionButtonSubmenu.setPresenterCallback(menuPresenter$Callback);
    }

    public static void MSDfOmGfCGwxOpwi(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        super.onDismiss();
    }

    public static void ZOgGAwYerPTzcbDf(androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu, android.view.object view) {
        actionMenuPresenter$ActionButtonSubmenu.setAnchorobject(view);
    }

    public static androidx.appcompat.view.menu.Menuobject ZcAcpURZiIKlNASF(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return androidx.appcompat.widget.ActionMenuPresenter.access$200(actionMenuPresenter);
    }

    protected override void OnDismiss() {
        if ((17 + 29) % 29 > 0) {
        }
        this.this$0.mActionButtonPopup = null;
        this.this$0.mOpenSubMenuId = 0;
        mSDfOmGfCGwxOpwi(this);
    }
}

