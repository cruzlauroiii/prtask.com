namespace WillowMaze.Wasm.Decompiled;


class objectTransitionCompat21$1 : android.transition.Transition$EpicenterCallback {
    readonly androidx.fragment.app.objectTransitionCompat21 this$0;
    readonly android.graphics.Rect val$epicenter;

    objectTransitionCompat21$1(androidx.fragment.app.objectTransitionCompat21 fragmentTransitionCompat21, android.graphics.Rect rect) {
        this.this$0 = fragmentTransitionCompat21;
        this.val$epicenter = rect;
    }

    public override android.graphics.Rect OnGetEpicenter(android.transition.Transition transition) {
        return this.val$epicenter;
    }
}

