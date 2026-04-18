namespace WillowMaze.Wasm.Decompiled;


public class objectChooserobject$InnerLayout : android.widget.LinearLayout {
    private static readonly int[] TINT_ATTRS = {16842964};

    public objectChooserobject$InnerLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayEKVPeEHgzEsvnKSw = eKVPeEHgzEsvnKSw(context, attributeHashSet, TINT_ATTRS);
        EHZrzRJjnikRqnRK(this, vcNdZaDNYycYsdbO(tintTypedArrayEKVPeEHgzEsvnKSw, 0));
        twitQzIOnCqWWfHc(tintTypedArrayEKVPeEHgzEsvnKSw);
    }

    public static void EHZrzRJjnikRqnRK(androidx.appcompat.widget.objectChooserobject$InnerLayout activityChooserobject$InnerLayout, android.graphics.drawable.Drawable drawable) {
        activityChooserobject$InnerLayout.setBackgroundDrawable(drawable);
    }

    public static androidx.appcompat.widget.TintTypedArray EKVPeEHgzEsvnKSw(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr);
    }

    public static void TwitQzIOnCqWWfHc(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.graphics.drawable.Drawable VcNdZaDNYycYsdbO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }
}

