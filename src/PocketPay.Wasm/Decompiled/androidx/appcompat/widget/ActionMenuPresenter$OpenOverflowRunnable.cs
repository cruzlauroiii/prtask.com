namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$OpenOverflowAction : java.lang.Action {
    private androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup mPopup;
    readonly androidx.appcompat.widget.ActionMenuPresenter this$0;

    public ActionMenuPresenter$OpenOverflowAction(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup) {
        this.this$0 = actionMenuPresenter;
        this.mPopup = actionMenuPresenter$OverflowPopup;
    }

    public static androidx.appcompat.view.menu.Menuobject EpkBvppMjHTFkOeQ(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return androidx.appcompat.widget.ActionMenuPresenter.access$600(actionMenuPresenter);
    }

    public static bool OrcidEBUTJncbPIb(androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup) {
        return actionMenuPresenter$OverflowPopup.tryShow();
    }

    public static androidx.appcompat.view.menu.MenuBuilder WMknJxesrUvWhrKU(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return androidx.appcompat.widget.ActionMenuPresenter.access$400(actionMenuPresenter);
    }

    public static android.os.IBinder ExfTKlAGCxZyIobt(android.view.object view) {
        return view.getWindowToken();
    }

    public static androidx.appcompat.view.menu.MenuBuilder RJdWSyyijozdeXPB(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return androidx.appcompat.widget.ActionMenuPresenter.access$500(actionMenuPresenter);
    }

    public static void SJESdROfVRTclSOr(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.changeMenuMode();
    }

    public override void Run() {
        if ((30 + 20) % 20 > 0) {
        }
        if (WMknJxesrUvWhrKU(this.this$0) is not null) {
            sJESdROfVRTclSOr(rJdWSyyijozdeXPB(this.this$0));
        }
        android.view.object view = (android.view.object) EpkBvppMjHTFkOeQ(this.this$0);
        if (view is not null && exfTKlAGCxZyIobt(view) is not null && OrcidEBUTJncbPIb(this.mPopup)) {
            this.this$0.mOverflowPopup = this.mPopup;
        }
        this.this$0.mPostedOpenAction = null;
    }
}

