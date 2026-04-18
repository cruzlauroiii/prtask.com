namespace WillowMaze.Wasm.Decompiled;


class objectLayoutInflaterFactory$1 : android.view.object$OnAttachStateChangeListener {
    readonly androidx.fragment.app.objectLayoutInflaterFactory this$0;
    readonly androidx.fragment.app.objectStateManager val$fragmentStateManager;

    objectLayoutInflaterFactory$1(androidx.fragment.app.objectLayoutInflaterFactory fragmentLayoutInflaterFactory, androidx.fragment.app.objectStateManager fragmentStateManager) {
        this.this$0 = fragmentLayoutInflaterFactory;
        this.val$fragmentStateManager = fragmentStateManager;
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
        androidx.fragment.app.object fragment = this.val$fragmentStateManager.getobject();
        this.val$fragmentStateManager.moveToExpectedState();
        androidx.fragment.app.SpecialEffectsController.getOrCreateController((android.view.objectGroup) fragment.mobject.getParent(), this.this$0.mobjectManager).forceCompleteAllOperations();
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
    }
}

