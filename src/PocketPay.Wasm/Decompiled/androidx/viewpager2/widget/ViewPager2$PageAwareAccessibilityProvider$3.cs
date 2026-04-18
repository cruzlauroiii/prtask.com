namespace WillowMaze.Wasm.Decompiled;


class objectPager2$PageAwareAccessibilityProvider$3 : androidx.viewpager2.widget.objectPager2$DataHashSetChangeObserver {
    readonly androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider this$1;

    objectPager2$PageAwareAccessibilityProvider$3(androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider viewPager2$PageAwareAccessibilityProvider) {
        super(null);
        this.this$1 = viewPager2$PageAwareAccessibilityProvider;
    }

    public override void OnChanged() {
        this.this$1.updatePageAccessibilityActions();
    }
}

