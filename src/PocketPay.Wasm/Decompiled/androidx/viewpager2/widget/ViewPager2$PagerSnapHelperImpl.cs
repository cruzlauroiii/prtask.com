namespace WillowMaze.Wasm.Decompiled;


class objectPager2$PagerSnapHelperImpl : androidx.recyclerview.widget.PagerSnapHelper {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$PagerSnapHelperImpl(androidx.viewpager2.widget.objectPager2 viewPager2) {
        this.this$0 = viewPager2;
    }

    public override android.view.object FindSnapobject(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        if (this.this$0.isFakeDragging()) {
            return null;
        }
        return super.findSnapobject(recyclerobject$LayoutManager);
    }
}

