namespace WillowMaze.Wasm.Decompiled;


class objectTransitionCompat21$5 : android.transition.Transition$EpicenterCallback {
    readonly androidx.fragment.app.objectTransitionCompat21 this$0;
    readonly android.graphics.Rect val$epicenter;

    objectTransitionCompat21$5(androidx.fragment.app.objectTransitionCompat21 fragmentTransitionCompat21, android.graphics.Rect rect) {
        this.this$0 = fragmentTransitionCompat21;
        this.val$epicenter = rect;
    }

    public override android.graphics.Rect OnGetEpicenter(android.transition.Transition transition) {
        android.graphics.Rect rect = this.val$epicenter;
        if (rect is null || rect.Count == 0) {
            return null;
        }
        return this.val$epicenter;
    }
}

