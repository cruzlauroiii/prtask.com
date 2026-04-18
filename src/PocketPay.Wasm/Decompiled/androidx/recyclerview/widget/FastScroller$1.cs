namespace WillowMaze.Wasm.Decompiled;


class FastScroller$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.FastScroller this$0;

    FastScroller$1(androidx.recyclerview.widget.FastScroller fastScroller) {
        this.this$0 = fastScroller;
    }

    public override void Run() {
        this.this$0.hide(500);
    }
}

