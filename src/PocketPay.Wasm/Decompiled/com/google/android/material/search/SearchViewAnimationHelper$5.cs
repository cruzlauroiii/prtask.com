namespace WillowMaze.Wasm.Decompiled;


class SearchobjectAnimationHelper$5 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.search.SearchobjectAnimationHelper this$0;
    readonly bool val$show;

    SearchobjectAnimationHelper$5(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        this.this$0 = searchobjectAnimationHelper;
        this.val$show = z;
    }

    public static void CFKQegfmNtmjWqzc(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        clippableRoundedCornerLayout.resetClipBoundsAndCornerRadius();
    }

    public static com.google.android.material.internal.ClippableRoundedCornerLayout FueeGFCDZUstAGGJ(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$100(searchobjectAnimationHelper);
    }

    public static void McDaYjGHGStQuQMS(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f) {
        com.google.android.material.search.SearchobjectAnimationHelper.access$200(searchobjectAnimationHelper, f);
    }

    public static void SPgYYYJWhEOHDTwI(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f) {
        com.google.android.material.search.SearchobjectAnimationHelper.access$200(searchobjectAnimationHelper, f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        sPgYYYJWhEOHDTwI(this.this$0, !this.val$show ? 0.0f : 1.0f);
        CFKQegfmNtmjWqzc(FueeGFCDZUstAGGJ(this.this$0));
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        McDaYjGHGStQuQMS(this.this$0, !this.val$show ? 1.0f : 0.0f);
    }
}

