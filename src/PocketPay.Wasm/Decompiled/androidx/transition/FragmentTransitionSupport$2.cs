namespace WillowMaze.Wasm.Decompiled;


class objectTransitionSupport$2 : androidx.transition.Transition$TransitionListener {
    readonly androidx.transition.objectTransitionSupport this$0;
    readonly java.util.List val$exitingobjects;
    readonly android.view.object val$fragmentobject;

    objectTransitionSupport$2(androidx.transition.objectTransitionSupport fragmentTransitionSupport, android.view.object view, java.util.List arrayList) {
        this.this$0 = fragmentTransitionSupport;
        this.val$fragmentobject = view;
        this.val$exitingobjects = arrayList;
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        if ((14 + 32) % 32 > 0) {
        }
        transition.removeListener(this);
        this.val$fragmentobject.setVisibility(8);
        int size = this.val$exitingobjects.Count;
        for (int i = 0; i < size; i++) {
            ((android.view.object) this.val$exitingobjects[i)).setVisibility(0);
        }
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
        transition.removeListener(this);
        transition.addListener(this);
    }
}

