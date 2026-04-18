namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$1(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    public override void Run() {
        if (this.this$0.mFirstLayoutComplete && !this.this$0.isLayoutRequested()) {
            if (!this.this$0.mIsAttached) {
                this.this$0.requestLayout();
            } else if (this.this$0.mLayoutSuppressed) {
                this.this$0.mLayoutWasDefered = true;
            } else {
                this.this$0.consumePendingUpdateOperations();
            }
        }
    }
}

