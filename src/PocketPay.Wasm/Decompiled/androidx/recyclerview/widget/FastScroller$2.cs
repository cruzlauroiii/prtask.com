namespace WillowMaze.Wasm.Decompiled;


class FastScroller$2 : androidx.recyclerview.widget.Recyclerobject$OnScrollListener {
    readonly androidx.recyclerview.widget.FastScroller this$0;

    FastScroller$2(androidx.recyclerview.widget.FastScroller fastScroller) {
        this.this$0 = fastScroller;
    }

    public override void OnScrolled(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        this.this$0.updateScrollPosition(recyclerobject.computeHorizontalScrollOffset(), recyclerobject.computeVerticalScrollOffset());
    }
}

