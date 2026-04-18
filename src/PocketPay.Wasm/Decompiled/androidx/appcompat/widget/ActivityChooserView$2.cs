namespace WillowMaze.Wasm.Decompiled;


class objectChooserobject$2 : android.view.objectTreeObserver$OnGlobalLayoutListener {
    readonly androidx.appcompat.widget.objectChooserobject this$0;

    objectChooserobject$2(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        this.this$0 = activityChooserobject;
    }

    public static void KRBrJvhOpWLvaiFS(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public static androidx.appcompat.widget.ListPopupWindow UvkHIDXQwrqyOlNb(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getListPopupWindow();
    }

    public static void YRpDEkhZdGlEERhx(androidx.core.view.ActionProvider actionProvider, bool z) {
        actionProvider.subUiVisibilityChanged(z);
    }

    public static androidx.appcompat.widget.ListPopupWindow BGzimqGSopkeNvCE(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getListPopupWindow();
    }

    public static bool KehOngQcATPBTnoa(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.isShowingPopup();
    }

    public static void YyzUURxhAjCkCLin(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.dismiss();
    }

    public static bool ZjXhwZYDzjNByRWm(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.isShown();
    }

    public override void OnGlobalLayout() {
        if (kehOngQcATPBTnoa(this.this$0)) {
            if (!zjXhwZYDzjNByRWm(this.this$0)) {
                yyzUURxhAjCkCLin(bGzimqGSopkeNvCE(this.this$0));
                return;
            }
            KRBrJvhOpWLvaiFS(UvkHIDXQwrqyOlNb(this.this$0));
            if (this.this$0.mProvider is null) {
                return;
            }
            YRpDEkhZdGlEERhx(this.this$0.mProvider, true);
        }
    }
}

