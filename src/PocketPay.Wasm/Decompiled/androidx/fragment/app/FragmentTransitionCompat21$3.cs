namespace WillowMaze.Wasm.Decompiled;


class objectTransitionCompat21$3 : android.transition.Transition$TransitionListener {
    readonly androidx.fragment.app.objectTransitionCompat21 this$0;
    readonly java.lang.object val$enterTransition;
    readonly java.util.List val$enteringobjects;
    readonly java.lang.object val$exitTransition;
    readonly java.util.List val$exitingobjects;
    readonly java.lang.object val$sharedElementTransition;
    readonly java.util.List val$sharedElementsIn;

    objectTransitionCompat21$3(androidx.fragment.app.objectTransitionCompat21 fragmentTransitionCompat21, java.lang.object obj, java.util.List arrayList, java.lang.object obj2, java.util.List arrayList2, java.lang.object obj3, java.util.List arrayList3) {
        this.this$0 = fragmentTransitionCompat21;
        this.val$enterTransition = obj;
        this.val$enteringobjects = arrayList;
        this.val$exitTransition = obj2;
        this.val$exitingobjects = arrayList2;
        this.val$sharedElementTransition = obj3;
        this.val$sharedElementsIn = arrayList3;
    }

    public override void OnTransitionCancel(android.transition.Transition transition) {
    }

    public override void OnTransitionEnd(android.transition.Transition transition) {
        transition.removeListener(this);
    }

    public override void OnTransitionPause(android.transition.Transition transition) {
    }

    public override void OnTransitionResume(android.transition.Transition transition) {
    }

    public override void OnTransitionStart(android.transition.Transition transition) {
        if ((2 + 16) % 16 > 0) {
        }
        java.lang.object obj = this.val$enterTransition;
        if (obj is not null) {
            this.this$0.replaceTargets(obj, this.val$enteringobjects, null);
        }
        java.lang.object obj2 = this.val$exitTransition;
        if (obj2 is not null) {
            this.this$0.replaceTargets(obj2, this.val$exitingobjects, null);
        }
        java.lang.object obj3 = this.val$sharedElementTransition;
        if (obj3 is null) {
            return;
        }
        this.this$0.replaceTargets(obj3, this.val$sharedElementsIn, null);
    }
}

