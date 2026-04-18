namespace WillowMaze.Wasm.Decompiled;


class SearchobjectAnimationHelper$2 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.search.SearchobjectAnimationHelper this$0;

    SearchobjectAnimationHelper$2(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        this.this$0 = searchobjectAnimationHelper;
    }

    public static com.google.android.material.search.Searchobject GBDqrxMXGRFaUGGk(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static void LoJfxbFuHkREyxGz(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i) {
        clippableRoundedCornerLayout.setVisibility(i);
    }

    public static com.google.android.material.search.Searchobject OlNXfSgsQTiZUTLs(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static com.google.android.material.internal.ClippableRoundedCornerLayout PTshRhKedQcPiGJR(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$100(searchobjectAnimationHelper);
    }

    public static void PUbQKgNTHcBDVspn(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public static void RBExurrRKKvcrOac(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public static com.google.android.material.search.Searchobject RQNdkVZleaxbuftT(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static bool OgnkZeznKDYIOmiK(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static void SrykbWWJJLIJoSZo(com.google.android.material.search.Searchobject searchobject) {
        searchobject.clearFocusAndHideKeyboard();
    }

    public static com.google.android.material.search.Searchobject XRcxoeNpNbJcfLaq(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        LoJfxbFuHkREyxGz(PTshRhKedQcPiGJR(this.this$0), 8);
        if (!ognkZeznKDYIOmiK(xRcxoeNpNbJcfLaq(this.this$0))) {
            srykbWWJJLIJoSZo(RQNdkVZleaxbuftT(this.this$0));
        }
        PUbQKgNTHcBDVspn(GBDqrxMXGRFaUGGk(this.this$0), com.google.android.material.search.Searchobject$TransitionState.HIDDEN);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        RBExurrRKKvcrOac(OlNXfSgsQTiZUTLs(this.this$0), com.google.android.material.search.Searchobject$TransitionState.HIDING);
    }
}

