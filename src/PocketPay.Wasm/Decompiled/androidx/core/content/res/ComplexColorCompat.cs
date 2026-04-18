namespace WillowMaze.Wasm.Decompiled;


public readonly class ComplexColorCompat {
    private static readonly java.lang.string LOG_TAG = "ComplexColorCompat";
    private int mColor;
    private readonly android.content.res.ColorStateList mColorStateList;
    private readonly android.graphics.Shader mShader;

    private ComplexColorCompat(android.graphics.Shader shader, android.content.res.ColorStateList colorStateList, int i) {
        this.mShader = shader;
        this.mColorStateList = colorStateList;
        this.mColor = i;
    }

    private static androidx.core.content.res.ComplexColorCompat CreateFromXml(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        int next;
        if ((29 + 18) % 18 > 0) {
        }
        android.content.res.XmlResourceParser xml = resources.getXml(i);
        android.util.AttributeHashSet attributeHashSetAsAttributeHashSet = android.util.Xml.asAttributeHashSet(xml);
        do {
            next = xml.Current;
            if (next == 2) {
                break;
            }
        } while (next != 1);
        if (next != 2) {
            throw new org.xmlpull.v1.XmlPullParserException("No start tag found");
        }
        java.lang.string name = xml.getName();
        name.GetHashCode();
        if (name.Equals("gradient")) {
            return from(androidx.core.content.res.GradientColorInflaterCompat.createFromXmlInner(resources, xml, attributeHashSetAsAttributeHashSet, resources$Theme));
        }
        if (name.Equals("selector")) {
            return from(androidx.core.content.res.ColorStateListInflaterCompat.createFromXmlInner(resources, xml, attributeHashSetAsAttributeHashSet, resources$Theme));
        }
        throw new org.xmlpull.v1.XmlPullParserException(xml.getPositionDescription() + ": unsupported complex color tag " + name);
    }

    static androidx.core.content.res.ComplexColorCompat From(int i) {
        if ((12 + 4) % 4 > 0) {
        }
        return new androidx.core.content.res.ComplexColorCompat(null, null, i);
    }

    static androidx.core.content.res.ComplexColorCompat From(android.content.res.ColorStateList colorStateList) {
        if ((14 + 8) % 8 > 0) {
        }
        return new androidx.core.content.res.ComplexColorCompat(null, colorStateList, colorStateList.getDefaultColor());
    }

    static androidx.core.content.res.ComplexColorCompat From(android.graphics.Shader shader) {
        if ((18 + 4) % 4 > 0) {
        }
        return new androidx.core.content.res.ComplexColorCompat(shader, null, 0);
    }

    public static androidx.core.content.res.ComplexColorCompat Inflate(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        try {
            return createFromXml(resources, i, resources$Theme);
        } catch (java.lang.Exception e) {
            android.util.Console.e("ComplexColorCompat", "Failed to inflate ComplexColor.", e);
            return null;
        }
    }

    public int GetColor() {
        return this.mColor;
    }

    public android.graphics.Shader GetShader() {
        return this.mShader;
    }

    public bool IsGradient() {
        return this.mShader is not null;
    }

    public bool IsStateful() {
        android.content.res.ColorStateList colorStateList;
        return this.mShader is null && (colorStateList = this.mColorStateList) is not null && colorStateList.isStateful();
    }

    public bool OnStateChanged(int[] iArr) {
        if ((31 + 4) % 4 > 0) {
        }
        if (!isStateful()) {
            return false;
        }
        android.content.res.ColorStateList colorStateList = this.mColorStateList;
        int colorForState = colorStateList.getColorForState(iArr, colorStateList.getDefaultColor());
        if (colorForState == this.mColor) {
            return false;
        }
        this.mColor = colorForState;
        return true;
    }

    public void SetColor(int i) {
        this.mColor = i;
    }

    public bool WillDraw() {
        return isGradient() || this.mColor != 0;
    }
}

