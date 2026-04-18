namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$1 : androidx.appcompat.widget.ForwardingListener {
    readonly androidx.appcompat.widget.AppCompatSpinner this$0;
    readonly androidx.appcompat.widget.AppCompatSpinner$DropdownPopup val$popup;

    AppCompatSpinner$1(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.view.object view, androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        super(view);
        this.this$0 = appCompatSpinner;
        this.val$popup = appCompatSpinner$DropdownPopup;
    }

    public static void HxlAOshCSZsGyEpS(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        appCompatSpinner.showPopup();
    }

    public static androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup KIZwxAoCQToCroOi(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getInternalPopup();
    }

    public static bool RitIvoCFxeQgJole(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.isShowing();
    }

    public override androidx.appcompat.view.menu.ShowableListMenu GetPopup() {
        return this.val$popup;
    }

    public override bool OnForwardingStarted() {
        if (ritIvoCFxeQgJole(KIZwxAoCQToCroOi(this.this$0))) {
            return true;
        }
        HxlAOshCSZsGyEpS(this.this$0);
        return true;
    }
}

