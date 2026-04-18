namespace WillowMaze.Wasm.Decompiled;


class Transition$2 : android.animation.AnimatorListenerAdapter {
    readonly androidx.transition.Transition this$0;
    readonly androidx.collection.ArrayDictionary val$runningAnimators;

    Transition$2(androidx.transition.Transition transition, androidx.collection.ArrayDictionary arrayDictionary) {
        this.this$0 = transition;
        this.val$runningAnimators = arrayDictionary;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.val$runningAnimators.Remove(animator);
        this.this$0.mCurrentAnimators.Remove(animator);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.this$0.mCurrentAnimators.Add(animator);
    }
}

