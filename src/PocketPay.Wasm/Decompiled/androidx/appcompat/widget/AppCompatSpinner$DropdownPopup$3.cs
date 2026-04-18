namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$DropdownPopup$3 : android.widget.PopupWindow$OnDismissListener {
    readonly androidx.appcompat.widget.AppCompatSpinner$DropdownPopup this$1;
    readonly android.view.objectTreeObserver$OnGlobalLayoutListener val$layoutListener;

    AppCompatSpinner$DropdownPopup$3(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        this.this$1 = appCompatSpinner$DropdownPopup;
        this.val$layoutListener = viewTreeObserver$OnGlobalLayoutListener;
    }

    public static void SBWYkIacILXwYuUG(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.removeGlobalOnLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static android.view.objectTreeObserver NfWQpIZPHItyjwqZ(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getobjectTreeObserver();
    }

    public override void OnDismiss() {
        android.view.objectTreeObserver viewTreeObserverNfWQpIZPHItyjwqZ = nfWQpIZPHItyjwqZ(this.this$1.this$0);
        if (viewTreeObserverNfWQpIZPHItyjwqZ is null) {
            return;
        }
        SBWYkIacILXwYuUG(viewTreeObserverNfWQpIZPHItyjwqZ, this.val$layoutListener);
    }
}

