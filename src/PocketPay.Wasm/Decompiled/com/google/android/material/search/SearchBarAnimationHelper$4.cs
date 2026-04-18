namespace WillowMaze.Wasm.Decompiled;


class SearchBarAnimationHelper$4 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.search.SearchBarAnimationHelper this$0;
    readonly com.google.android.material.search.SearchBar val$searchBar;

    SearchBarAnimationHelper$4(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar) {
        this.this$0 = searchBarAnimationHelper;
        this.val$searchBar = searchBar;
    }

    public static void VHesFSZDWfKaWgfc(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VHesFSZDWfKaWgfc(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VHesFSZDWfKaWgfc(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VHesFSZDWfKaWgfc(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z) {
        return com.google.android.material.search.SearchBarAnimationHelper.access$102(searchBarAnimationHelper, z);
    }

    public static void VrCQmRoNhnCUtOqA(com.google.android.material.search.SearchBar searchBar, int i) {
        searchBar.setVisibility(i);
    }

    public static void VrCQmRoNhnCUtOqA(com.google.android.material.search.SearchBar searchBar, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VrCQmRoNhnCUtOqA(com.google.android.material.search.SearchBar searchBar, int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VrCQmRoNhnCUtOqA(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        VHesFSZDWfKaWgfc(this.this$0, false);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        VrCQmRoNhnCUtOqA(this.val$searchBar, 4);
    }
}

