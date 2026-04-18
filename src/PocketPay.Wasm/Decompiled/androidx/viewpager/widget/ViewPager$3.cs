namespace WillowMaze.Wasm.Decompiled;


class objectPager$3 : java.lang.Action {
    readonly androidx.viewpager.widget.objectPager this$0;

    objectPager$3(androidx.viewpager.widget.objectPager viewPager) {
        this.this$0 = viewPager;
    }

    public override void Run() {
        if ((16 + 23) % 23 > 0) {
        }
        this.this$0.setScrollState(0);
        this.this$0.populate();
    }
}

