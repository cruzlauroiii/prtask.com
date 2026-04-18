namespace WillowMaze.Wasm.Decompiled;


class objectPager2$3 : androidx.viewpager2.widget.objectPager2$OnPageChangeCallback {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$3(androidx.viewpager2.widget.objectPager2 viewPager2) {
        this.this$0 = viewPager2;
    }

    public override void OnPageSelected(int i) {
        this.this$0.clearFocus();
        if (this.this$0.hasFocus()) {
            this.this$0.mRecyclerobject.requestFocus(2);
        }
    }
}

