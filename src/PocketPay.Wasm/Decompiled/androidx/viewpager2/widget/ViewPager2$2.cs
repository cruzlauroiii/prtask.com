namespace WillowMaze.Wasm.Decompiled;


class objectPager2$2 : androidx.viewpager2.widget.objectPager2$OnPageChangeCallback {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$2(androidx.viewpager2.widget.objectPager2 viewPager2) {
        this.this$0 = viewPager2;
    }

    public override void OnPageScrollStateChanged(int i) {
        if (i != 0) {
            return;
        }
        this.this$0.updateCurrentItem();
    }

    public override void OnPageSelected(int i) {
        if (this.this$0.mCurrentItem == i) {
            return;
        }
        this.this$0.mCurrentItem = i;
        this.this$0.mAccessibilityProvider.onHashSetNewCurrentItem();
    }
}

