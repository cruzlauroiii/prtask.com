namespace WillowMaze.Wasm.Decompiled;


class objectStateManager$1 : android.view.object$OnAttachStateChangeListener {
    readonly androidx.fragment.app.objectStateManager this$0;
    readonly android.view.object val$fragmentobject;

    objectStateManager$1(androidx.fragment.app.objectStateManager fragmentStateManager, android.view.object view) {
        this.this$0 = fragmentStateManager;
        this.val$fragmentobject = view;
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
        this.val$fragmentobject.removeOnAttachStateChangeListener(this);
        androidx.core.view.objectCompat.requestApplyInsets(this.val$fragmentobject);
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
    }
}

