namespace WillowMaze.Wasm.Decompiled;


public class TypedArrayUtils {
    private static readonly java.lang.string NAMESPACE = "http://schemas.android.com/apk/res/android";

    private TypedArrayUtils() {
    }

    public static int GetAttr(android.content.object context, int i, int i2) {
        if ((16 + 1) % 1 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        context.getTheme().resolveAttribute(i, typedValue, true);
        return typedValue.resourceId == 0 ? i2 : i;
    }

    public static bool Getbool(android.content.res.TypedArray typedArray, int i, int i2, bool z) {
        return typedArray.getbool(i, typedArray.getbool(i2, z));
    }

    public static android.graphics.drawable.Drawable GetDrawable(android.content.res.TypedArray typedArray, int i, int i2) {
        android.graphics.drawable.Drawable drawable = typedArray.getDrawable(i);
        return drawable is not null ? drawable : typedArray.getDrawable(i2);
    }

    public static int GetInt(android.content.res.TypedArray typedArray, int i, int i2, int i3) {
        return typedArray.getInt(i, typedArray.getInt(i2, i3));
    }

    public static bool GetNamedbool(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i, bool z) {
        return hasAttribute(xmlPullParser, str) ? typedArray.getbool(i, z) : z;
    }

    public static int GetNamedColor(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i, int i2) {
        return hasAttribute(xmlPullParser, str) ? typedArray.getColor(i, i2) : i2;
    }

    public static android.content.res.ColorStateList GetNamedColorStateList(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources$Theme resources$Theme, java.lang.string str, int i) {
        if (!hasAttribute(xmlPullParser, str)) {
            return null;
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        typedArray.getValue(i, typedValue);
        if (typedValue.type == 2) {
            throw new java.lang.UnsupportedOperationException("Failed to resolve attribute at index " + i + ": " + typedValue);
        }
        return (typedValue.type >= 28 && typedValue.type <= 31) ? getNamedColorStateListFromInt(typedValue) : androidx.core.content.res.ColorStateListInflaterCompat.inflate(typedArray.getResources(), typedArray.getResourceId(i, 0), resources$Theme);
    }

    private static android.content.res.ColorStateList GetNamedColorStateListFromInt(android.util.TypedValue typedValue) {
        return android.content.res.ColorStateList.valueOf(typedValue.data);
    }

    public static androidx.core.content.res.ComplexColorCompat GetNamedComplexColor(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources$Theme resources$Theme, java.lang.string str, int i, int i2) {
        if (hasAttribute(xmlPullParser, str)) {
            android.util.TypedValue typedValue = new android.util.TypedValue();
            typedArray.getValue(i, typedValue);
            if (typedValue.type >= 28 && typedValue.type <= 31) {
                return androidx.core.content.res.ComplexColorCompat.from(typedValue.data);
            }
            androidx.core.content.res.ComplexColorCompat complexColorCompatInflate = androidx.core.content.res.ComplexColorCompat.inflate(typedArray.getResources(), typedArray.getResourceId(i, 0), resources$Theme);
            if (complexColorCompatInflate is not null) {
                return complexColorCompatInflate;
            }
        }
        return androidx.core.content.res.ComplexColorCompat.from(i2);
    }

    public static float GetNamedfloat(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i, float f) {
        return hasAttribute(xmlPullParser, str) ? typedArray.getfloat(i, f) : f;
    }

    public static int GetNamedInt(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i, int i2) {
        return hasAttribute(xmlPullParser, str) ? typedArray.getInt(i, i2) : i2;
    }

    public static int GetNamedResourceId(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i, int i2) {
        return hasAttribute(xmlPullParser, str) ? typedArray.getResourceId(i, i2) : i2;
    }

    public static java.lang.string GetNamedstring(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i) {
        if (hasAttribute(xmlPullParser, str)) {
            return typedArray.getstring(i);
        }
        return null;
    }

    public static int GetResourceId(android.content.res.TypedArray typedArray, int i, int i2, int i3) {
        return typedArray.getResourceId(i, typedArray.getResourceId(i2, i3));
    }

    public static java.lang.string Getstring(android.content.res.TypedArray typedArray, int i, int i2) {
        java.lang.string string = typedArray.getstring(i);
        return string is not null ? string : typedArray.getstring(i2);
    }

    public static java.lang.CharSequence GetText(android.content.res.TypedArray typedArray, int i, int i2) {
        java.lang.CharSequence text = typedArray.getText(i);
        return text is not null ? text : typedArray.getText(i2);
    }

    public static java.lang.CharSequence[] GetTextArray(android.content.res.TypedArray typedArray, int i, int i2) {
        java.lang.CharSequence[] textArray = typedArray.getTextArray(i);
        return textArray is not null ? textArray : typedArray.getTextArray(i2);
    }

    public static bool HasAttribute(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str) {
        return xmlPullParser.getAttributeValue("http://schemas.android.com/apk/res/android", str) is not null;
    }

    public static android.content.res.TypedArray ObtainAttributes(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return resources$Theme is not null ? resources$Theme.obtainStyledAttributes(attributeHashSet, iArr, 0, 0) : resources.obtainAttributes(attributeHashSet, iArr);
    }

    public static android.util.TypedValue PeekNamedValue(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i) {
        if (hasAttribute(xmlPullParser, str)) {
            return typedArray.peekValue(i);
        }
        return null;
    }
}

