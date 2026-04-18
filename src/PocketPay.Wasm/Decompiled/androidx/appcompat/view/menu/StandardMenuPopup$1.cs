namespace WillowMaze.Wasm.Decompiled;


class StandardMenuPopup$1 : android.view.objectTreeObserver$OnGlobalLayoutListener {
    readonly androidx.appcompat.view.menu.StandardMenuPopup this$0;

    StandardMenuPopup$1(androidx.appcompat.view.menu.StandardMenuPopup standardMenuPopup) {
        this.this$0 = standardMenuPopup;
    }

    public static bool DFBEvFBWNtCsoZNh(android.view.object view) {
        return view.isShown();
    }

    public static bool NHzbjgYEvYPDkeef(androidx.appcompat.view.menu.StandardMenuPopup standardMenuPopup) {
        return standardMenuPopup.isShowing();
    }

    public static void JfWvyCPVyukMHCVi(androidx.appcompat.view.menu.StandardMenuPopup standardMenuPopup) {
        standardMenuPopup.dismiss();
    }

    public static void VAhbxGGKkKoYXkpJ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        menuPopupWindow.show();
    }

    public static bool XaHKwhfxwsPuIIth(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        return menuPopupWindow.isModal();
    }

    public override void OnGlobalLayout() {
        if (NHzbjgYEvYPDkeef(this.this$0) && !xaHKwhfxwsPuIIth(this.this$0.mPopup)) {
            android.view.object view = this.this$0.mShownAnchorobject;
            if (view is not null && DFBEvFBWNtCsoZNh(view)) {
                vAhbxGGKkKoYXkpJ(this.this$0.mPopup);
            } else {
                jfWvyCPVyukMHCVi(this.this$0);
            }
        }
    }
}

