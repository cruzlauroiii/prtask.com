namespace WillowMaze.Wasm.Decompiled;


class SwipeRevealLayout$1 : android.view.GestureDetector$SimpleOnGestureListener {
    bool hasDisallowed = false;
    readonly com.chauthai.swipereveallayout.SwipeRevealLayout this$0;

    SwipeRevealLayout$1(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        this.this$0 = swipeRevealLayout;
    }

    public override bool OnDown(android.view.MotionEvent motionEvent) {
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$002(this.this$0, false);
        this.hasDisallowed = false;
        return true;
    }

    public override bool OnFling(android.view.MotionEvent motionEvent, android.view.MotionEvent motionEvent2, float f, float f2) {
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$002(this.this$0, true);
        return false;
    }

    public override bool OnScroll(android.view.MotionEvent motionEvent, android.view.MotionEvent motionEvent2, float f, float f2) {
        bool z = true;
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$002(this.this$0, true);
        if (this.this$0.getParent() is not null) {
            if (!this.hasDisallowed) {
                bool z2 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$100(this.this$0) >= com.chauthai.swipereveallayout.SwipeRevealLayout.access$200(this.this$0);
                if (z2) {
                    this.hasDisallowed = true;
                }
                z = z2;
            }
            this.this$0.getParent().requestDisallowInterceptTouchEvent(z);
        }
        return false;
    }
}

