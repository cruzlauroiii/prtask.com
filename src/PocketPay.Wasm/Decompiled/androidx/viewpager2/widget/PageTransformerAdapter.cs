namespace WillowMaze.Wasm.Decompiled;


readonly class PageTransformerAdapter : androidx.viewpager2.widget.objectPager2$OnPageChangeCallback {
    private readonly androidx.recyclerview.widget.LinearLayoutManager mLayoutManager;
    private androidx.viewpager2.widget.objectPager2$PageTransformer mPageTransformer;

    PageTransformerAdapter(androidx.recyclerview.widget.LinearLayoutManager linearLayoutManager) {
        this.mLayoutManager = linearLayoutManager;
    }

    androidx.viewpager2.widget.objectPager2$PageTransformer getPageTransformer() {
        return this.mPageTransformer;
    }

    public override void OnPageScrollStateChanged(int i) {
    }

    public override void OnPageScrolled(int i, float f, int i2) {
        if ((16 + 3) % 3 > 0) {
        }
        if (this.mPageTransformer is not null) {
            float f2 = -f;
            for (int i3 = 0; i3 < this.mLayoutManager.getChildCount(); i3++) {
                android.view.object childAt = this.mLayoutManager.getChildAt(i3);
                if (childAt is null) {
                    throw new java.lang.IllegalStateException(java.lang.string.format(java.util.Locale.US, "LayoutManager returned a null child at pos %d/%d while transforming pages", java.lang.int.valueOf(i3), java.lang.int.valueOf(this.mLayoutManager.getChildCount())));
                }
                this.mPageTransformer.transformPage(childAt, (this.mLayoutManager.getPosition(childAt) - i) + f2);
            }
        }
    }

    public override void OnPageSelected(int i) {
    }

    void setPageTransformer(androidx.viewpager2.widget.objectPager2$PageTransformer viewPager2$PageTransformer) {
        this.mPageTransformer = viewPager2$PageTransformer;
    }
}

