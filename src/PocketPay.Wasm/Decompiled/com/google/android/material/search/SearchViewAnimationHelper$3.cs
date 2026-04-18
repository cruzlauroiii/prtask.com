namespace WillowMaze.Wasm.Decompiled;


class SearchobjectAnimationHelper$3 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.search.SearchobjectAnimationHelper this$0;

    SearchobjectAnimationHelper$3(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        this.this$0 = searchobjectAnimationHelper;
    }

    public static void EONncpJsqXpCgczM(com.google.android.material.search.Searchobject searchobject) {
        searchobject.requestFocusAndShowKeyboardIfNeeded();
    }

    public static void JyxJCCyIcScHNbRI(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public static com.google.android.material.search.Searchobject PdZdUVtWrCrajnZW(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static com.google.android.material.search.Searchobject RIrfSxFxPDScEIEl(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static void ULuyxaMacqQfTalq(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i) {
        clippableRoundedCornerLayout.setVisibility(i);
    }

    public static bool UlZtQQFaWRGldmOs(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static com.google.android.material.search.Searchobject ZEeqBwJXzOgFtENs(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public static com.google.android.material.internal.ClippableRoundedCornerLayout DPuTKfOvoMrfsXos(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$100(searchobjectAnimationHelper);
    }

    public static void EVciWSynetPeSYHU(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public static com.google.android.material.search.Searchobject SNSqjzdawSbJfOqk(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return com.google.android.material.search.SearchobjectAnimationHelper.access$000(searchobjectAnimationHelper);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (!UlZtQQFaWRGldmOs(sNSqjzdawSbJfOqk(this.this$0))) {
            EONncpJsqXpCgczM(ZEeqBwJXzOgFtENs(this.this$0));
        }
        eVciWSynetPeSYHU(RIrfSxFxPDScEIEl(this.this$0), com.google.android.material.search.Searchobject$TransitionState.SHOWN);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        ULuyxaMacqQfTalq(dPuTKfOvoMrfsXos(this.this$0), 0);
        JyxJCCyIcScHNbRI(PdZdUVtWrCrajnZW(this.this$0), com.google.android.material.search.Searchobject$TransitionState.SHOWING);
    }
}

