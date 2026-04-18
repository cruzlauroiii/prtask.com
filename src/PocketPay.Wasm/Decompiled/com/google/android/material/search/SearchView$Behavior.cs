namespace WillowMaze.Wasm.Decompiled;


public class Searchobject$Behavior : androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<com.google.android.material.search.Searchobject> {
    public Searchobject$Behavior() {
    }

    public Searchobject$Behavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public static void IOVCNKpuktlAgWhC(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.SearchBar searchBar) {
        searchobject.setupWithSearchBar(searchBar);
    }

    public static void IOVCNKpuktlAgWhC(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.SearchBar searchBar, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IOVCNKpuktlAgWhC(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.SearchBar searchBar, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IOVCNKpuktlAgWhC(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.SearchBar searchBar, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QjyuukdMWvjNAvrK(com.google.android.material.search.Searchobject searchobject, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QjyuukdMWvjNAvrK(com.google.android.material.search.Searchobject searchobject, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QjyuukdMWvjNAvrK(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QjyuukdMWvjNAvrK(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isHashSetupWithSearchBar();
    }

    public static void FMFKfbWYgSpQAVcG(com.google.android.material.search.Searchobject$Behavior searchobject$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.search.Searchobject searchobject, android.view.object view, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMFKfbWYgSpQAVcG(com.google.android.material.search.Searchobject$Behavior searchobject$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.search.Searchobject searchobject, android.view.object view, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FMFKfbWYgSpQAVcG(com.google.android.material.search.Searchobject$Behavior searchobject$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.search.Searchobject searchobject, android.view.object view, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FMFKfbWYgSpQAVcG(com.google.android.material.search.Searchobject$Behavior searchobject$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.search.Searchobject searchobject, android.view.object view) {
        return searchobject$Behavior.onDependentobjectChanged(coordinatorLayout, searchobject, view);
    }

    public override bool OnDependentobjectChanged(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return fMFKfbWYgSpQAVcG(this, coordinatorLayout, (com.google.android.material.search.Searchobject) view, view2);
    }

    public bool OnDependentobjectChanged(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.search.Searchobject searchobject, android.view.object view) {
        if (QjyuukdMWvjNAvrK(searchobject) || !(view is com.google.android.material.search.SearchBar)) {
            return false;
        }
        IOVCNKpuktlAgWhC(searchobject, (com.google.android.material.search.SearchBar) view);
        return false;
    }
}

