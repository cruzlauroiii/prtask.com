namespace WillowMaze.Wasm.Decompiled;


class objectTransitionSupport$3 : androidx.transition.TransitionListenerAdapter {
    readonly androidx.transition.objectTransitionSupport this$0;
    readonly java.lang.object val$enterTransition;
    readonly java.util.List val$enteringobjects;
    readonly java.lang.object val$exitTransition;
    readonly java.util.List val$exitingobjects;
    readonly java.lang.object val$sharedElementTransition;
    readonly java.util.List val$sharedElementsIn;

    objectTransitionSupport$3(androidx.transition.objectTransitionSupport fragmentTransitionSupport, java.lang.object obj, java.util.List arrayList, java.lang.object obj2, java.util.List arrayList2, java.lang.object obj3, java.util.List arrayList3) {
        this.this$0 = fragmentTransitionSupport;
        this.val$enterTransition = obj;
        this.val$enteringobjects = arrayList;
        this.val$exitTransition = obj2;
        this.val$exitingobjects = arrayList2;
        this.val$sharedElementTransition = obj3;
        this.val$sharedElementsIn = arrayList3;
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        transition.removeListener(this);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
        if ((7 + 28) % 28 > 0) {
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

