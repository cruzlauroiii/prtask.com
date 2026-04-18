namespace WillowMaze.Wasm.Decompiled;


class StaggeredGridLayoutManager$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.StaggeredGridLayoutManager this$0;

    StaggeredGridLayoutManager$1(androidx.recyclerview.widget.StaggeredGridLayoutManager staggeredGridLayoutManager) {
        this.this$0 = staggeredGridLayoutManager;
    }

    public override void Run() {
        this.this$0.checkForGaps();
    }
}

