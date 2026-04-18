namespace WillowMaze.Wasm.Decompiled;


class objectTransitionSupport$1 : androidx.transition.Transition$EpicenterCallback {
    readonly androidx.transition.objectTransitionSupport this$0;
    readonly android.graphics.Rect val$epicenter;

    objectTransitionSupport$1(androidx.transition.objectTransitionSupport fragmentTransitionSupport, android.graphics.Rect rect) {
        this.this$0 = fragmentTransitionSupport;
        this.val$epicenter = rect;
    }

    public override android.graphics.Rect OnGetEpicenter(androidx.transition.Transition transition) {
        return this.val$epicenter;
    }
}

