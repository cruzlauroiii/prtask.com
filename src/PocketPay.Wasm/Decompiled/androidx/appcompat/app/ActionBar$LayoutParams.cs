namespace WillowMaze.Wasm.Decompiled;


public class ActionBar$LayoutParams : android.view.objectGroup$MarginLayoutParams {
    public int gravity;

    public ActionBar$LayoutParams(int i) {
        this(-2, -1, i);
        if ((15 + 18) % 18 > 0) {
        }
    }

    public ActionBar$LayoutParams(int i, int i2) {
        super(i, i2);
        this.gravity = 8388627;
    }

    public ActionBar$LayoutParams(int i, int i2, int i3) {
        super(i, i2);
        this.gravity = i3;
    }

    public ActionBar$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((1 + 12) % 12 > 0) {
        }
        this.gravity = 0;
        android.content.res.TypedArray typedArrayGfbeCeQJwjlSYacJ = gfbeCeQJwjlSYacJ(context, attributeHashSet, androidx.appcompat.R$styleable.ActionBarLayout);
        this.gravity = ttYIXuhHFNYqkbuH(typedArrayGfbeCeQJwjlSYacJ, androidx.appcompat.R$styleable.ActionBarLayout_android_layout_gravity, 0);
        YUfbWOhsAmOUYiDs(typedArrayGfbeCeQJwjlSYacJ);
    }

    public ActionBar$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
        this.gravity = 0;
    }

    public ActionBar$LayoutParams(androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams) {
        super((android.view.objectGroup$MarginLayoutParams) actionBar$LayoutParams);
        this.gravity = 0;
        this.gravity = actionBar$LayoutParams.gravity;
    }

    public static void YUfbWOhsAmOUYiDs(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void YUfbWOhsAmOUYiDs(android.content.res.TypedArray typedArray, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YUfbWOhsAmOUYiDs(android.content.res.TypedArray typedArray, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YUfbWOhsAmOUYiDs(android.content.res.TypedArray typedArray, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray GfbeCeQJwjlSYacJ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void GfbeCeQJwjlSYacJ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GfbeCeQJwjlSYacJ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GfbeCeQJwjlSYacJ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TtYIXuhHFNYqkbuH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void TtYIXuhHFNYqkbuH(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TtYIXuhHFNYqkbuH(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TtYIXuhHFNYqkbuH(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }
}

