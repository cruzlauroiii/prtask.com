namespace WillowMaze.Wasm.Decompiled;


class SearchobjectAnimationHelper$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.search.SearchobjectAnimationHelper this$0;

    SearchobjectAnimationHelper$1(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        this.this$0 = searchobjectAnimationHelper;
    }

    public static com.google.android.material.search.Searchobject OgeEQFGcuhPPUKpm(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static com.google.android.material.search.SearchBar PRwEZntljmDxiBUm(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$300(searchobjectAnimationHelper);
    }

    public static com.google.android.material.search.Searchobject TYwaswIAzMxBcNqB(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static void XqQsutjmUofmtALc(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i) {
        clippableRoundedCornerLayout.setVisibility(i);
    }

    public static com.google.android.material.internal.ClippableRoundedCornerLayout ZDvjOKbUwYZehCRw(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$100(searchobjectAnimationHelper);
    }

    public static void ZbHOAqyVvZZiXLjo(com.google.android.material.search.SearchBar searchBar) {
        searchBar.stopOnLoadAnimation();
    }

    public static void ABSpMQiznTHYsPmj(com.google.android.material.search.Searchobject searchobject) {
        searchobject.requestFocusAndShowKeyboardIfNeeded();
    }

    public static bool AuCBhRBFNfUesVWI(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static com.google.android.material.search.Searchobject BvAMDLxRiAyDftUU(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static void XUxdweuSlpIbrKKF(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (!auCBhRBFNfUesVWI(bvAMDLxRiAyDftUU(this.this$0))) {
            aBSpMQiznTHYsPmj(OgeEQFGcuhPPUKpm(this.this$0));
        }
        xUxdweuSlpIbrKKF(TYwaswIAzMxBcNqB(this.this$0), com.google.android.material.search.Searchobject$TransitionState.SHOWN);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        XqQsutjmUofmtALc(ZDvjOKbUwYZehCRw(this.this$0), 0);
        ZbHOAqyVvZZiXLjo(PRwEZntljmDxiBUm(this.this$0));
    }
}

