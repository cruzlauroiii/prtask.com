namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$2 : java.lang.Action {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$2(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    public override void Run() {
        if (this.this$0.mItemAnimator is not null) {
            this.this$0.mItemAnimator.runPendingAnimations();
        }
        this.this$0.mPostedAnimatorRunner = false;
    }
}

