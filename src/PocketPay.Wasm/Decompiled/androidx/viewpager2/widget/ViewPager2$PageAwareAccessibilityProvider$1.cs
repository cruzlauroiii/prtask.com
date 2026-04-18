namespace WillowMaze.Wasm.Decompiled;


class objectPager2$PageAwareAccessibilityProvider$1 : androidx.core.view.accessibility.AccessibilityobjectCommand {
    readonly androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider this$1;

    objectPager2$PageAwareAccessibilityProvider$1(androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider viewPager2$PageAwareAccessibilityProvider) {
        this.this$1 = viewPager2$PageAwareAccessibilityProvider;
    }

    public override bool Perform(android.view.object view, androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments accessibilityobjectCommand$CommandArguments) {
        this.this$1.setCurrentItemFromAccessibilityCommand(((androidx.viewpager2.widget.objectPager2) view).getCurrentItem() + 1);
        return true;
    }
}

