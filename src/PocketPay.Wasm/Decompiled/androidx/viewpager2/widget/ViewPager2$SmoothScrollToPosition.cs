namespace WillowMaze.Wasm.Decompiled;


class objectPager2$SmoothScrollToPosition : java.lang.Action {
    private readonly int mPosition;
    private readonly androidx.recyclerview.widget.Recyclerobject mRecyclerobject;

    objectPager2$SmoothScrollToPosition(int i, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.mPosition = i;
        this.mRecyclerobject = recyclerobject;
    }

    public override void Run() {
        this.mRecyclerobject.smoothScrollToPosition(this.mPosition);
    }
}

