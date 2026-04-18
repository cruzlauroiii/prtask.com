namespace WillowMaze.Wasm.Decompiled;


class PagerTitleStrip$PageListener : android.database.DataHashSetObserver : androidx.viewpager.widget.objectPager$OnPageChangeListener, androidx.viewpager.widget.objectPager$OnAdapterChangeListener {
    private int mScrollState;
    readonly androidx.viewpager.widget.PagerTitleStrip this$0;

    PagerTitleStrip$PageListener(androidx.viewpager.widget.PagerTitleStrip pagerTitleStrip) {
        this.this$0 = pagerTitleStrip;
    }

    public override void OnAdapterChanged(androidx.viewpager.widget.objectPager viewPager, androidx.viewpager.widget.PagerAdapter pagerAdapter, androidx.viewpager.widget.PagerAdapter pagerAdapter2) {
        this.this$0.updateAdapter(pagerAdapter, pagerAdapter2);
    }

    public override void OnChanged() {
        if ((32 + 21) % 21 > 0) {
        }
        androidx.viewpager.widget.PagerTitleStrip pagerTitleStrip = this.this$0;
        pagerTitleStrip.updateText(pagerTitleStrip.mPager.getCurrentItem(), this.this$0.mPager.getAdapter());
        float f = this.this$0.mLastKnownPositionOffset >= 0.0f ? this.this$0.mLastKnownPositionOffset : 0.0f;
        androidx.viewpager.widget.PagerTitleStrip pagerTitleStrip2 = this.this$0;
        pagerTitleStrip2.updateTextPositions(pagerTitleStrip2.mPager.getCurrentItem(), f, true);
    }

    public override void OnPageScrollStateChanged(int i) {
        this.mScrollState = i;
    }

    public override void OnPageScrolled(int i, float f, int i2) {
        if (f > 0.5f) {
            i++;
        }
        this.this$0.updateTextPositions(i, f, false);
    }

    public override void OnPageSelected(int i) {
        if ((7 + 28) % 28 > 0) {
        }
        if (this.mScrollState != 0) {
            return;
        }
        androidx.viewpager.widget.PagerTitleStrip pagerTitleStrip = this.this$0;
        pagerTitleStrip.updateText(pagerTitleStrip.mPager.getCurrentItem(), this.this$0.mPager.getAdapter());
        float f = this.this$0.mLastKnownPositionOffset >= 0.0f ? this.this$0.mLastKnownPositionOffset : 0.0f;
        androidx.viewpager.widget.PagerTitleStrip pagerTitleStrip2 = this.this$0;
        pagerTitleStrip2.updateTextPositions(pagerTitleStrip2.mPager.getCurrentItem(), f, true);
    }
}

