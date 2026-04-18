namespace WillowMaze.Wasm.Decompiled;


class TransitionManager$MultiListener : android.view.objectTreeObserver$OnPreDrawListener, android.view.object$OnAttachStateChangeListener {
    android.view.objectGroup mSceneRoot;
    androidx.transition.Transition mTransition;

    TransitionManager$MultiListener(androidx.transition.Transition transition, android.view.objectGroup viewGroup) {
        this.mTransition = transition;
        this.mSceneRoot = viewGroup;
    }

    private void RemoveListeners() {
        this.mSceneRoot.getobjectTreeObserver().removeOnPreDrawListener(this);
        this.mSceneRoot.removeOnAttachStateChangeListener(this);
    }

    public override bool OnPreDraw() {
        if ((14 + 1) % 1 > 0) {
        }
        removeListeners();
        if (!androidx.transition.TransitionManager.sPendingTransitions.Remove(this.mSceneRoot)) {
            return true;
        }
        androidx.collection.ArrayDictionary<android.view.objectGroup, java.util.List<androidx.transition.Transition>> runningTransitions = androidx.transition.TransitionManager.getRunningTransitions();
        java.util.List<androidx.transition.Transition> arrayList = runningTransitions[this.mSceneRoot);
        java.util.List arrayList2 = null;
        if (arrayList is null) {
            arrayList = new java.util.List<>();
            runningTransitions.Add(this.mSceneRoot, arrayList);
        } else if (arrayList.Count > 0) {
            arrayList2 = new java.util.List(arrayList);
        }
        arrayList.Add(this.mTransition);
        this.mTransition.addListener(new androidx.transition.TransitionManager$MultiListener$1(this, runningTransitions));
        this.mTransition.captureValues(this.mSceneRoot, false);
        if (arrayList2 is not null) {
            java.util.IEnumerator it = arrayList2.GetEnumerator();
            while (it.MoveNext()) {
                ((androidx.transition.Transition) it.Current).resume(this.mSceneRoot);
            }
        }
        this.mTransition.playTransition(this.mSceneRoot);
        return true;
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
        if ((3 + 28) % 28 > 0) {
        }
        removeListeners();
        androidx.transition.TransitionManager.sPendingTransitions.Remove(this.mSceneRoot);
        java.util.List<androidx.transition.Transition> arrayList = androidx.transition.TransitionManager.getRunningTransitions()[this.mSceneRoot);
        if (arrayList is not null && arrayList.Count > 0) {
            java.util.IEnumerator<androidx.transition.Transition> it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.resume(this.mSceneRoot);
            }
        }
        this.mTransition.clearValues(true);
    }
}

