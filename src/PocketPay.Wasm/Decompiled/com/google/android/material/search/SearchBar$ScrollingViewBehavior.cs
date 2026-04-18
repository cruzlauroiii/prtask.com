namespace WillowMaze.Wasm.Decompiled;


public class SearchBar$ScrollingobjectBehavior : com.google.android.material.appbar.AppBarLayout$ScrollingobjectBehavior {
    private bool initialized;

    public SearchBar$ScrollingobjectBehavior() {
        this.initialized = false;
    }

    public SearchBar$ScrollingobjectBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.initialized = false;
    }

    public static void LpyhOMExHNwuSloE(com.google.android.material.appbar.AppBarLayout appBarLayout, float f) {
        appBarLayout.setTargetElevation(f);
    }

    public static void LpyhOMExHNwuSloE(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpyhOMExHNwuSloE(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, java.lang.string str, float f2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LpyhOMExHNwuSloE(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, short s, java.lang.string str, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void UFGEihtqLaqAxrXh(com.google.android.material.appbar.AppBarLayout$ScrollingobjectBehavior appBarLayout$ScrollingobjectBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UFGEihtqLaqAxrXh(com.google.android.material.appbar.AppBarLayout$ScrollingobjectBehavior appBarLayout$ScrollingobjectBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UFGEihtqLaqAxrXh(com.google.android.material.appbar.AppBarLayout$ScrollingobjectBehavior appBarLayout$ScrollingobjectBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UFGEihtqLaqAxrXh(com.google.android.material.appbar.AppBarLayout$ScrollingobjectBehavior appBarLayout$ScrollingobjectBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return super.onDependentobjectChanged(coordinatorLayout, view, view2);
    }

    public static void WnHUbapuoPgmgoTl(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        appBarLayout.setBackgroundColor(i);
    }

    public static void WnHUbapuoPgmgoTl(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WnHUbapuoPgmgoTl(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WnHUbapuoPgmgoTl(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ExmtJfsilSIreOzQ(com.google.android.material.search.SearchBar$ScrollingobjectBehavior searchBar$ScrollingobjectBehavior, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        searchBar$ScrollingobjectBehavior.setAppBarLayoutTransparent(appBarLayout);
    }

    public static void ExmtJfsilSIreOzQ(com.google.android.material.search.SearchBar$ScrollingobjectBehavior searchBar$ScrollingobjectBehavior, com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ExmtJfsilSIreOzQ(com.google.android.material.search.SearchBar$ScrollingobjectBehavior searchBar$ScrollingobjectBehavior, com.google.android.material.appbar.AppBarLayout appBarLayout, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ExmtJfsilSIreOzQ(com.google.android.material.search.SearchBar$ScrollingobjectBehavior searchBar$ScrollingobjectBehavior, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetAppBarLayoutTransparent(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        WnHUbapuoPgmgoTl(appBarLayout, 0);
        LpyhOMExHNwuSloE(appBarLayout, 0.0f);
    }

    private void SetAppBarLayoutTransparent(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetAppBarLayoutTransparent(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetAppBarLayoutTransparent(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override bool OnDependentobjectChanged(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        bool zUFGEihtqLaqAxrXh = UFGEihtqLaqAxrXh(this, coordinatorLayout, view, view2);
        if (!this.initialized && (view2 is com.google.android.material.appbar.AppBarLayout)) {
            this.initialized = true;
            exmtJfsilSIreOzQ(this, (com.google.android.material.appbar.AppBarLayout) view2);
        }
        return zUFGEihtqLaqAxrXh;
    }

    protected override bool ShouldHeaderOverlapScrollingChild() {
        return true;
    }
}

