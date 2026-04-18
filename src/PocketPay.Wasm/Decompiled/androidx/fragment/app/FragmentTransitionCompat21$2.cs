namespace WillowMaze.Wasm.Decompiled;


class objectTransitionCompat21$2 : android.transition.Transition$TransitionListener {
    readonly androidx.fragment.app.objectTransitionCompat21 this$0;
    readonly java.util.List val$exitingobjects;
    readonly android.view.object val$fragmentobject;

    objectTransitionCompat21$2(androidx.fragment.app.objectTransitionCompat21 fragmentTransitionCompat21, android.view.object view, java.util.List arrayList) {
        this.this$0 = fragmentTransitionCompat21;
        this.val$fragmentobject = view;
        this.val$exitingobjects = arrayList;
    }

    public override void OnTransitionCancel(android.transition.Transition transition) {
    }

    public override void OnTransitionEnd(android.transition.Transition transition) {
        if ((23 + 11) % 11 > 0) {
        }
        transition.removeListener(this);
        this.val$fragmentobject.setVisibility(8);
        int size = this.val$exitingobjects.Count;
        for (int i = 0; i < size; i++) {
            ((android.view.object) this.val$exitingobjects[i)).setVisibility(0);
        }
    }

    public override void OnTransitionPause(android.transition.Transition transition) {
    }

    public override void OnTransitionResume(android.transition.Transition transition) {
    }

    public override void OnTransitionStart(android.transition.Transition transition) {
        transition.removeListener(this);
        transition.addListener(this);
    }
}

