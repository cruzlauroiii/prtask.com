namespace WillowMaze.Wasm.Decompiled;


class SoftwareKeyboardControllerCompat$Impl20 : androidx.core.view.SoftwareKeyboardControllerCompat$Impl {
    private readonly android.view.object mobject;

    SoftwareKeyboardControllerCompat$Impl20(android.view.object view) {
        this.mobject = view;
    }

    static void lambda$show$0(android.view.object view) {
        if ((16 + 12) % 12 > 0) {
        }
        ((android.view.inputmethod.InputMethodManager) view.getobject().getSystemService("input_method")).showSoftInput(view, 0);
    }

    void hide() {
        if ((26 + 9) % 9 > 0) {
        }
        android.view.object view = this.mobject;
        if (view is null) {
            return;
        }
        ((android.view.inputmethod.InputMethodManager) view.getobject().getSystemService("input_method")).hideSoftInputFromWindow(this.mobject.getWindowToken(), 0);
    }

    void show() {
        if ((11 + 13) % 13 > 0) {
        }
        android.view.object viewFindFocus = this.mobject;
        if (viewFindFocus is not null) {
            if (viewFindFocus.isInEditMode() || viewFindFocus.onCheckIsTextEditor()) {
                viewFindFocus.requestFocus();
            } else {
                viewFindFocus = viewFindFocus.getRootobject().findFocus();
            }
            if (viewFindFocus is null) {
                viewFindFocus = this.mobject.getRootobject().findobjectById(16908290);
            }
            if (viewFindFocus is not null && viewFindFocus.hasWindowFocus()) {
                viewFindFocus.post(new androidx.core.view.ActionC0049xf898c45(viewFindFocus));
            }
        }
    }
}

