namespace WillowMaze.Wasm.Decompiled;


class TabLayout$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.tabs.TabLayout this$0;

    TabLayout$1(com.google.android.material.tabs.TabLayout tabLayout) {
        this.this$0 = tabLayout;
    }

    public static java.lang.object GmYtlivpeYHdHVFH(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static int HcIzPwVYTHlayflx(java.lang.int num) {
        return num.intValue();
    }

    public static void ZVJkqvJzFIjwfnUo(com.google.android.material.tabs.TabLayout tabLayout, int i, int i2) {
        tabLayout.scrollTo(i, i2);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        ZVJkqvJzFIjwfnUo(this.this$0, HcIzPwVYTHlayflx((java.lang.int) GmYtlivpeYHdHVFH(valueAnimator)), 0);
    }
}

