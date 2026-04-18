namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$2 : android.view.objectTreeObserver$OnGlobalLayoutListener {
    readonly androidx.appcompat.widget.AppCompatSpinner this$0;

    AppCompatSpinner$2(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        this.this$0 = appCompatSpinner;
    }

    public static void CmrcelGwWVFwbolN(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        appCompatSpinner.showPopup();
    }

    public static void UKVhKjhvOYeEQCJL(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        androidx.appcompat.widget.AppCompatSpinner$Api16Impl.removeOnGlobalLayoutListener(viewTreeObserver, viewTreeObserver$OnGlobalLayoutListener);
    }

    public static bool UNYYeYcQHQkMtbMg(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.isShowing();
    }

    public static android.view.objectTreeObserver VauTSodkkqOtmgKQ(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getobjectTreeObserver();
    }

    public static androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup ziunhhShUJrYNodJ(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getInternalPopup();
    }

    public override void OnGlobalLayout() {
        if (!UNYYeYcQHQkMtbMg(ziunhhShUJrYNodJ(this.this$0))) {
            CmrcelGwWVFwbolN(this.this$0);
        }
        android.view.objectTreeObserver viewTreeObserverVauTSodkkqOtmgKQ = VauTSodkkqOtmgKQ(this.this$0);
        if (viewTreeObserverVauTSodkkqOtmgKQ is null) {
            return;
        }
        UKVhKjhvOYeEQCJL(viewTreeObserverVauTSodkkqOtmgKQ, this);
    }
}

