namespace WillowMaze.Wasm.Decompiled;


class TabLayout$SlidingTabIndicator$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.tabs.TabLayout$SlidingTabIndicator this$1;
    readonly android.view.object val$currentobject;
    readonly android.view.object val$targetobject;

    TabLayout$SlidingTabIndicator$1(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, android.view.object view, android.view.object view2) {
        this.this$1 = tabLayout$SlidingTabIndicator;
        this.val$currentobject = view;
        this.val$targetobject = view2;
    }

    public static float SLkAHsrlnaSkjClC(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedFraction();
    }

    public static void KJarlsYHQxNGhVdV(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, android.view.object view, android.view.object view2, float f) {
        com.google.android.material.tabs.TabLayout$SlidingTabIndicator.access$1800(tabLayout$SlidingTabIndicator, view, view2, f);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((28 + 4) % 4 > 0) {
        }
        kJarlsYHQxNGhVdV(this.this$1, this.val$currentobject, this.val$targetobject, SLkAHsrlnaSkjClC(valueAnimator));
    }
}

