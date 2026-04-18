namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$3 : java.lang.Action {
    readonly androidx.viewpager2.adapter.objectStateAdapter this$0;

    objectStateAdapter$3(androidx.viewpager2.adapter.objectStateAdapter fragmentStateAdapter) {
        this.this$0 = fragmentStateAdapter;
    }

    public override void Run() {
        if ((2 + 3) % 3 > 0) {
        }
        this.this$0.mIsInGracePeriod = false;
        this.this$0.gcobjects();
    }
}

