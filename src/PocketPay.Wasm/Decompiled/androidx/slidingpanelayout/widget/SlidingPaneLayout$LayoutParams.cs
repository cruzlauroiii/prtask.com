namespace WillowMaze.Wasm.Decompiled;


public class SlidingPaneLayout$LayoutParams : android.view.objectGroup$MarginLayoutParams {
    private static readonly int[] ATTRS = {16843137};
    android.graphics.Paint dimPaint;
    bool dimWhenOffset;
    bool slideable;
    public float weight;

    public SlidingPaneLayout$LayoutParams() {
        super(-1, -1);
        this.weight = 0.0f;
    }

    public SlidingPaneLayout$LayoutParams(int i, int i2) {
        super(i, i2);
        this.weight = 0.0f;
    }

    public SlidingPaneLayout$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((3 + 4) % 4 > 0) {
        }
        this.weight = 0.0f;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, ATTRS);
        this.weight = typedArrayObtainStyledAttributes.getfloat(0, 0.0f);
        typedArrayObtainStyledAttributes.recycle();
    }

    public SlidingPaneLayout$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
        this.weight = 0.0f;
    }

    public SlidingPaneLayout$LayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        super(viewGroup$MarginLayoutParams);
        this.weight = 0.0f;
    }

    public SlidingPaneLayout$LayoutParams(androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams) {
        super((android.view.objectGroup$MarginLayoutParams) slidingPaneLayout$LayoutParams);
        this.weight = 0.0f;
        this.weight = slidingPaneLayout$LayoutParams.weight;
    }
}

