namespace WillowMaze.Wasm.Decompiled;


class SearchobjectAnimationHelper$4 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.search.SearchobjectAnimationHelper this$0;

    SearchobjectAnimationHelper$4(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        this.this$0 = searchobjectAnimationHelper;
    }

    public static void FcMGsQxoRMXBAtBe(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i) {
        clippableRoundedCornerLayout.setVisibility(i);
    }

    public static bool IPCyZpVOjBuVQOYc(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static void InkKEsnblBGpOkTR(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public static void CcsiBYgNtNUBUDjb(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public static com.google.android.material.search.Searchobject MGyFMQRmpmUXMSYQ(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static com.google.android.material.search.Searchobject MZceAAcULLNrRqda(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static void OwNNZVrIyiUBgEfr(com.google.android.material.search.Searchobject searchobject) {
        searchobject.clearFocusAndHideKeyboard();
    }

    public static com.google.android.material.search.Searchobject RkycgxjiIXkkfBZL(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static com.google.android.material.search.Searchobject WRckMDfpWsfpbBuh(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static com.google.android.material.internal.ClippableRoundedCornerLayout ZmYhXLIsCqUCJiAM(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$100(searchobjectAnimationHelper);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        FcMGsQxoRMXBAtBe(zmYhXLIsCqUCJiAM(this.this$0), 8);
        if (!IPCyZpVOjBuVQOYc(wRckMDfpWsfpbBuh(this.this$0))) {
            owNNZVrIyiUBgEfr(mGyFMQRmpmUXMSYQ(this.this$0));
        }
        InkKEsnblBGpOkTR(mZceAAcULLNrRqda(this.this$0), com.google.android.material.search.Searchobject$TransitionState.HIDDEN);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        ccsiBYgNtNUBUDjb(rkycgxjiIXkkfBZL(this.this$0), com.google.android.material.search.Searchobject$TransitionState.HIDING);
    }
}

