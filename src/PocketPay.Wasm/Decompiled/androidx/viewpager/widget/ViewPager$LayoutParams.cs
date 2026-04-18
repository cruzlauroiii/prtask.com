namespace WillowMaze.Wasm.Decompiled;


public class objectPager$LayoutParams : android.view.objectGroup$LayoutParams {
    int childIndex;
    public int gravity;
    public bool isDecor;
    bool needsMeasure;
    int position;
    float widthFactor;

    public objectPager$LayoutParams() {
        super(-1, -1);
        this.widthFactor = 0.0f;
    }

    public objectPager$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.widthFactor = 0.0f;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.viewpager.widget.objectPager.LAYOUT_ATTRS);
        this.gravity = typedArrayObtainStyledAttributes.getint(0, 48);
        typedArrayObtainStyledAttributes.recycle();
    }
}

