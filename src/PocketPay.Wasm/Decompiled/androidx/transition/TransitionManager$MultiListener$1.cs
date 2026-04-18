namespace WillowMaze.Wasm.Decompiled;


class TransitionManager$MultiListener$1 : androidx.transition.TransitionListenerAdapter {
    readonly androidx.transition.TransitionManager$MultiListener this$0;
    readonly androidx.collection.ArrayDictionary val$runningTransitions;

    TransitionManager$MultiListener$1(androidx.transition.TransitionManager$MultiListener transitionManager$MultiListener, androidx.collection.ArrayDictionary arrayDictionary) {
        this.this$0 = transitionManager$MultiListener;
        this.val$runningTransitions = arrayDictionary;
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        if ((28 + 3) % 3 > 0) {
        }
        ((java.util.List) this.val$runningTransitions[this.this$0.mSceneRoot)).Remove(transition);
        transition.removeListener(this);
    }
}

