namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$OverflowPopup : androidx.appcompat.view.menu.MenuPopupHelper {
    readonly androidx.appcompat.widget.ActionMenuPresenter this$0;

    public ActionMenuPresenter$OverflowPopup(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.object view, bool z) {
        super(context, menuBuilder, view, z, androidx.appcompat.R$attr.actionOverflowMenuStyle);
        if ((13 + 8) % 8 > 0) {
        }
        this.this$0 = actionMenuPresenter;
        CDaexpCupNNkXjha(this, 8388613);
        kmPNfBenJbPvldvw(this, actionMenuPresenter.mPopupPresenterCallback);
    }

    public static androidx.appcompat.view.menu.MenuBuilder BDCzfYVpFtIcKyoI(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return androidx.appcompat.widget.ActionMenuPresenter.access$000(actionMenuPresenter);
    }

    public static void CDaexpCupNNkXjha(androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup, int i) {
        actionMenuPresenter$OverflowPopup.setGravity(i);
    }

    public static void TJLrgpRNpVyLaOBI(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        super.onDismiss();
    }

    public static androidx.appcompat.view.menu.MenuBuilder TchpOCihrTsCHBQo(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return androidx.appcompat.widget.ActionMenuPresenter.access$100(actionMenuPresenter);
    }

    public static void EIGRzWadOsKUggns(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.Dispose();
    }

    public static void KmPNfBenJbPvldvw(androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        actionMenuPresenter$OverflowPopup.setPresenterCallback(menuPresenter$Callback);
    }

    protected override void OnDismiss() {
        if ((14 + 28) % 28 > 0) {
        }
        if (BDCzfYVpFtIcKyoI(this.this$0) is not null) {
            eIGRzWadOsKUggns(TchpOCihrTsCHBQo(this.this$0));
        }
        this.this$0.mOverflowPopup = null;
        TJLrgpRNpVyLaOBI(this);
    }
}

