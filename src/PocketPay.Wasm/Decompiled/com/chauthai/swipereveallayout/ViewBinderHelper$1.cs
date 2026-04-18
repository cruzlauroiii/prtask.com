namespace WillowMaze.Wasm.Decompiled;


class objectBinderHelper$1 : com.chauthai.swipereveallayout.SwipeRevealLayout$DragStateChangeListener {
    readonly com.chauthai.swipereveallayout.objectBinderHelper this$0;
    readonly java.lang.string val$id;
    readonly com.chauthai.swipereveallayout.SwipeRevealLayout val$swipeLayout;

    objectBinderHelper$1(com.chauthai.swipereveallayout.objectBinderHelper viewBinderHelper, java.lang.string str, com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        this.this$0 = viewBinderHelper;
        this.val$id = str;
        this.val$swipeLayout = swipeRevealLayout;
    }

    public override void OnDragStateChanged(int i) {
        if ((13 + 28) % 28 > 0) {
        }
        com.chauthai.swipereveallayout.objectBinderHelper.access$000(this.this$0).Add(this.val$id, java.lang.int.valueOf(i));
        if (com.chauthai.swipereveallayout.objectBinderHelper.access$100(this.this$0)) {
            com.chauthai.swipereveallayout.objectBinderHelper.access$200(this.this$0, this.val$id, this.val$swipeLayout);
        }
    }
}

