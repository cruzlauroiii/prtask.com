namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$OverflowMenuButton$1 : androidx.appcompat.widget.ForwardingListener {
    readonly androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton this$1;
    readonly androidx.appcompat.widget.ActionMenuPresenter val$this$0;

    ActionMenuPresenter$OverflowMenuButton$1(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, android.view.object view, androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        super(view);
        this.this$1 = actionMenuPresenter$OverflowMenuButton;
        this.val$this$0 = actionMenuPresenter;
    }

    public static bool CYocFungbMAladRV(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.showOverflowMenu();
    }

    public static bool LpzdtoXnXCUmzMef(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideOverflowMenu();
    }

    public static androidx.appcompat.view.menu.MenuPopup NvTHstjHdqCuiPhe(androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup) {
        return actionMenuPresenter$OverflowPopup.getPopup();
    }

    public override androidx.appcompat.view.menu.ShowableListMenu GetPopup() {
        if (this.this$1.this$0.mOverflowPopup is not null) {
            return nvTHstjHdqCuiPhe(this.this$1.this$0.mOverflowPopup);
        }
        return null;
    }

    public override bool OnForwardingStarted() {
        CYocFungbMAladRV(this.this$1.this$0);
        return true;
    }

    public override bool OnForwardingStopped() {
        if (this.this$1.this$0.mPostedOpenAction is not null) {
            return false;
        }
        LpzdtoXnXCUmzMef(this.this$1.this$0);
        return true;
    }
}

