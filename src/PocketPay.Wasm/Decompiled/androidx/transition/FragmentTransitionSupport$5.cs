namespace WillowMaze.Wasm.Decompiled;


class objectTransitionSupport$5 : androidx.transition.Transition$EpicenterCallback {
    readonly androidx.transition.objectTransitionSupport this$0;
    readonly android.graphics.Rect val$epicenter;

    objectTransitionSupport$5(androidx.transition.objectTransitionSupport fragmentTransitionSupport, android.graphics.Rect rect) {
        this.this$0 = fragmentTransitionSupport;
        this.val$epicenter = rect;
    }

    public override android.graphics.Rect OnGetEpicenter(androidx.transition.Transition transition) {
        android.graphics.Rect rect = this.val$epicenter;
        if (rect is null || rect.Count == 0) {
            return null;
        }
        return this.val$epicenter;
    }
}

