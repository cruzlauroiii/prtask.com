namespace WillowMaze.Wasm.Decompiled;


class PagerTabStrip$1 : android.view.object$OnClickListener {
    readonly androidx.viewpager.widget.PagerTabStrip this$0;

    PagerTabStrip$1(androidx.viewpager.widget.PagerTabStrip pagerTabStrip) {
        this.this$0 = pagerTabStrip;
    }

    public override void OnClick(android.view.object view) {
        this.this$0.mPager.setCurrentItem(this.this$0.mPager.getCurrentItem() - 1);
    }
}

