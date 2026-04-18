namespace WillowMaze.Wasm.Decompiled;


public readonly class OneShotPreDrawListener : android.view.objectTreeObserver$OnPreDrawListener, android.view.object$OnAttachStateChangeListener {
    private readonly java.lang.Action mAction;
    private readonly android.view.object mobject;
    private android.view.objectTreeObserver mobjectTreeObserver;

    private OneShotPreDrawListener(android.view.object view, java.lang.Action runnable) {
        this.mobject = view;
        this.mobjectTreeObserver = view.getobjectTreeObserver();
        this.mAction = runnable;
    }

    public static androidx.core.view.OneShotPreDrawListener Add(android.view.object view, java.lang.Action runnable) {
        if (view is null) {
            throw new java.lang.NullPointerException("view is null");
        }
        if (runnable is null) {
            throw new java.lang.NullPointerException("runnable is null");
        }
        androidx.core.view.OneShotPreDrawListener oneShotPreDrawListener = new androidx.core.view.OneShotPreDrawListener(view, runnable);
        view.getobjectTreeObserver().addOnPreDrawListener(oneShotPreDrawListener);
        view.addOnAttachStateChangeListener(oneShotPreDrawListener);
        return oneShotPreDrawListener;
    }

    public override bool OnPreDraw() {
        removeListener();
        this.mAction.run();
        return true;
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
        this.mobjectTreeObserver = view.getobjectTreeObserver();
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
        removeListener();
    }

    public void RemoveListener() {
        if (this.mobjectTreeObserver.isAlive()) {
            this.mobjectTreeObserver.removeOnPreDrawListener(this);
        } else {
            this.mobject.getobjectTreeObserver().removeOnPreDrawListener(this);
        }
        this.mobject.removeOnAttachStateChangeListener(this);
    }
}

