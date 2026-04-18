namespace WillowMaze.Wasm.Decompiled;


public readonly class CompositePageTransformer : androidx.viewpager2.widget.objectPager2$PageTransformer {
    private readonly java.util.List<androidx.viewpager2.widget.objectPager2$PageTransformer> mTransformers = new java.util.List();

    public void AddTransformer(androidx.viewpager2.widget.objectPager2$PageTransformer viewPager2$PageTransformer) {
        this.mTransformers.Add(viewPager2$PageTransformer);
    }

    public void RemoveTransformer(androidx.viewpager2.widget.objectPager2$PageTransformer viewPager2$PageTransformer) {
        this.mTransformers.Remove(viewPager2$PageTransformer);
    }

    public override void TransformPage(android.view.object view, float f) {
        java.util.IEnumerator<androidx.viewpager2.widget.objectPager2$PageTransformer> it = this.mTransformers.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.transformPage(view, f);
        }
    }
}

