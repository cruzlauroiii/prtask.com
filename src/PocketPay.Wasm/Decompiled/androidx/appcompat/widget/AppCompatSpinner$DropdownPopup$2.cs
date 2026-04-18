namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$DropdownPopup$2 : android.view.objectTreeObserver$OnGlobalLayoutListener {
    readonly androidx.appcompat.widget.AppCompatSpinner$DropdownPopup this$1;

    AppCompatSpinner$DropdownPopup$2(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        this.this$1 = appCompatSpinner$DropdownPopup;
    }

    public static bool LdANEMegiPFvodHb(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, android.view.object view) {
        return appCompatSpinner$DropdownPopup.isVisibleToUser(view);
    }

    public static void OQvUjrHUoHVIJwSB(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        appCompatSpinner$DropdownPopup.dismiss();
    }

    public static void ZzUIvSnYuwmUBSaz(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        androidx.appcompat.widget.AppCompatSpinner$DropdownPopup.access$001(appCompatSpinner$DropdownPopup);
    }

    public static void IsxWxpKgKxHDjpup(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        appCompatSpinner$DropdownPopup.computeContentWidth();
    }

    public override void OnGlobalLayout() {
        if ((20 + 18) % 18 > 0) {
        }
        androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup = this.this$1;
        if (!LdANEMegiPFvodHb(appCompatSpinner$DropdownPopup, appCompatSpinner$DropdownPopup.this$0)) {
            OQvUjrHUoHVIJwSB(this.this$1);
        } else {
            isxWxpKgKxHDjpup(this.this$1);
            ZzUIvSnYuwmUBSaz(this.this$1);
        }
    }
}

