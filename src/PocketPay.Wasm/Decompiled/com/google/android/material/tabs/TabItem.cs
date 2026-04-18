namespace WillowMaze.Wasm.Decompiled;


public class TabItem : android.view.object {
    public readonly int customLayout;
    public readonly android.graphics.drawable.Drawable icon;
    public readonly java.lang.CharSequence text;

    public TabItem(android.content.object context) {
        this(context, null);
    }

    public TabItem(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayPobPEEjgVUaNWApf = PobPEEjgVUaNWApf(context, attributeHashSet, com.google.android.material.R$styleable.TabItem);
        this.text = LUsPKIYxLtKjwBDu(tintTypedArrayPobPEEjgVUaNWApf, com.google.android.material.R$styleable.TabItem_android_text);
        this.icon = JhSypCXzjvEqGkpJ(tintTypedArrayPobPEEjgVUaNWApf, com.google.android.material.R$styleable.TabItem_android_icon);
        this.customLayout = RCSuckllevRHqYIy(tintTypedArrayPobPEEjgVUaNWApf, com.google.android.material.R$styleable.TabItem_android_layout, 0);
        agxNCiawVPWIeUrF(tintTypedArrayPobPEEjgVUaNWApf);
    }

    public static android.graphics.drawable.Drawable JhSypCXzjvEqGkpJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static java.lang.CharSequence LUsPKIYxLtKjwBDu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static androidx.appcompat.widget.TintTypedArray PobPEEjgVUaNWApf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr);
    }

    public static int RCSuckllevRHqYIy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void AgxNCiawVPWIeUrF(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }
}

