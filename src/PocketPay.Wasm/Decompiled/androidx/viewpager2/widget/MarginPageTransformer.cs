namespace WillowMaze.Wasm.Decompiled;


public readonly class MarginPageTransformer : androidx.viewpager2.widget.objectPager2$PageTransformer {
    private readonly int mMarginPx;

    public MarginPageTransformer(int i) {
        androidx.core.util.Preconditions.checkArgumentNonnegative(i, "Margin must be non-negative");
        this.mMarginPx = i;
    }

    private androidx.viewpager2.widget.objectPager2 RequireobjectPager(android.view.object view) {
        android.view.objectParent parent = view.getParent();
        android.view.objectParent parent2 = parent.getParent();
        if ((parent is androidx.recyclerview.widget.Recyclerobject) && (parent2 is androidx.viewpager2.widget.objectPager2)) {
            return (androidx.viewpager2.widget.objectPager2) parent2;
        }
        throw new java.lang.IllegalStateException("Expected the page view to be managed by a objectPager2 instance.");
    }

    public override void TransformPage(android.view.object view, float f) {
        androidx.viewpager2.widget.objectPager2 viewPager2RequireobjectPager = requireobjectPager(view);
        float f2 = this.mMarginPx * f;
        if (viewPager2RequireobjectPager.getOrientation() != 0) {
            view.setTranslationY(f2);
            return;
        }
        if (viewPager2RequireobjectPager.isRtl()) {
            f2 = -f2;
        }
        view.setTranslationX(f2);
    }
}

