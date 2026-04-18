namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$objectMaxLifecycleEnforcer$1 : androidx.viewpager2.widget.objectPager2$OnPageChangeCallback {
    readonly androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer this$1;

    objectStateAdapter$objectMaxLifecycleEnforcer$1(androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer fragmentStateAdapter$objectMaxLifecycleEnforcer) {
        this.this$1 = fragmentStateAdapter$objectMaxLifecycleEnforcer;
    }

    public override void OnPageScrollStateChanged(int i) {
        this.this$1.updateobjectMaxLifecycle(false);
    }

    public override void OnPageSelected(int i) {
        this.this$1.updateobjectMaxLifecycle(false);
    }
}

