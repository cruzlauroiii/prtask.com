namespace WillowMaze.Wasm.Decompiled;


class StandardMenuPopup$2 : android.view.object$OnAttachStateChangeListener {
    readonly androidx.appcompat.view.menu.StandardMenuPopup this$0;

    StandardMenuPopup$2(androidx.appcompat.view.menu.StandardMenuPopup standardMenuPopup) {
        this.this$0 = standardMenuPopup;
    }

    public static void GGYaxWyeDzlYLJIE(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.removeGlobalOnLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static void ToQbDNSAuyEXySUr(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.removeOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static android.view.objectTreeObserver OJalzTlUZUHESYDO(android.view.object view) {
        return view.getobjectTreeObserver();
    }

    public static bool VPJkrQlcBEfdllLb(android.view.objectTreeObserver viewTreeObserver) {
        return viewTreeObserver.isAlive();
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
        if ((27 + 1) % 1 > 0) {
        }
        if (this.this$0.mTreeObserver is not null) {
            if (!vPJkrQlcBEfdllLb(this.this$0.mTreeObserver)) {
                this.this$0.mTreeObserver = oJalzTlUZUHESYDO(view);
            }
            GGYaxWyeDzlYLJIE(this.this$0.mTreeObserver, this.this$0.mGlobalLayoutListener);
        }
        ToQbDNSAuyEXySUr(view, this);
    }
}

