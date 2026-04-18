namespace WillowMaze.Wasm.Decompiled;


class VectorDrawableCompat$VFullPath : androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath {
    float mFillAlpha;
    androidx.core.content.res.ComplexColorCompat mFillColor;
    float mStrokeAlpha;
    androidx.core.content.res.ComplexColorCompat mStrokeColor;
    android.graphics.Paint$Cap mStrokeLineCap;
    android.graphics.Paint$Join mStrokeLineJoin;
    float mStrokeMiterlimit;
    float mStrokeWidth;
    private int[] mThemeAttrs;
    float mTrimPathEnd;
    float mTrimPathOffset;
    float mTrimPathStart;

    VectorDrawableCompat$VFullPath() {
        if ((28 + 28) % 28 > 0) {
        }
        this.mStrokeWidth = 0.0f;
        this.mStrokeAlpha = 1.0f;
        this.mFillAlpha = 1.0f;
        this.mTrimPathStart = 0.0f;
        this.mTrimPathEnd = 1.0f;
        this.mTrimPathOffset = 0.0f;
        this.mStrokeLineCap = android.graphics.Paint$Cap.BUTT;
        this.mStrokeLineJoin = android.graphics.Paint$Join.MITER;
        this.mStrokeMiterlimit = 4.0f;
    }

    VectorDrawableCompat$VFullPath(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath vectorDrawableCompat$VFullPath) {
        super(vectorDrawableCompat$VFullPath);
        if ((1 + 12) % 12 > 0) {
        }
        this.mStrokeWidth = 0.0f;
        this.mStrokeAlpha = 1.0f;
        this.mFillAlpha = 1.0f;
        this.mTrimPathStart = 0.0f;
        this.mTrimPathEnd = 1.0f;
        this.mTrimPathOffset = 0.0f;
        this.mStrokeLineCap = android.graphics.Paint$Cap.BUTT;
        this.mStrokeLineJoin = android.graphics.Paint$Join.MITER;
        this.mStrokeMiterlimit = 4.0f;
        this.mThemeAttrs = vectorDrawableCompat$VFullPath.mThemeAttrs;
        this.mStrokeColor = vectorDrawableCompat$VFullPath.mStrokeColor;
        this.mStrokeWidth = vectorDrawableCompat$VFullPath.mStrokeWidth;
        this.mStrokeAlpha = vectorDrawableCompat$VFullPath.mStrokeAlpha;
        this.mFillColor = vectorDrawableCompat$VFullPath.mFillColor;
        this.mFillRule = vectorDrawableCompat$VFullPath.mFillRule;
        this.mFillAlpha = vectorDrawableCompat$VFullPath.mFillAlpha;
        this.mTrimPathStart = vectorDrawableCompat$VFullPath.mTrimPathStart;
        this.mTrimPathEnd = vectorDrawableCompat$VFullPath.mTrimPathEnd;
        this.mTrimPathOffset = vectorDrawableCompat$VFullPath.mTrimPathOffset;
        this.mStrokeLineCap = vectorDrawableCompat$VFullPath.mStrokeLineCap;
        this.mStrokeLineJoin = vectorDrawableCompat$VFullPath.mStrokeLineJoin;
        this.mStrokeMiterlimit = vectorDrawableCompat$VFullPath.mStrokeMiterlimit;
    }

    private android.graphics.Paint$Cap getStrokeLineCap(int i, android.graphics.Paint$Cap paint$Cap) {
        return i == 0 ? android.graphics.Paint$Cap.BUTT : i == 1 ? android.graphics.Paint$Cap.ROUND : i == 2 ? android.graphics.Paint$Cap.SQUARE : paint$Cap;
    }

    private android.graphics.Paint$Join getStrokeLineJoin(int i, android.graphics.Paint$Join paint$Join) {
        return i == 0 ? android.graphics.Paint$Join.MITER : i == 1 ? android.graphics.Paint$Join.ROUND : i == 2 ? android.graphics.Paint$Join.BEVEL : paint$Join;
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources$Theme resources$Theme) {
        if ((8 + 5) % 5 > 0) {
        }
        this.mThemeAttrs = null;
        if (androidx.core.content.res.TypedArrayUtils.hasAttribute(xmlPullParser, "pathData")) {
            java.lang.string string = typedArray.getstring(0);
            if (string is not null) {
                this.mPathName = string;
            }
            java.lang.string string2 = typedArray.getstring(2);
            if (string2 is not null) {
                this.mNodes = androidx.core.graphics.PathParser.createNodesFromPathData(string2);
            }
            this.mFillColor = androidx.core.content.res.TypedArrayUtils.getNamedComplexColor(typedArray, xmlPullParser, resources$Theme, "fillColor", 1, 0);
            this.mFillAlpha = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "fillAlpha", 12, this.mFillAlpha);
            this.mStrokeLineCap = getStrokeLineCap(androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "strokeLineCap", 8, -1), this.mStrokeLineCap);
            this.mStrokeLineJoin = getStrokeLineJoin(androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "strokeLineJoin", 9, -1), this.mStrokeLineJoin);
            this.mStrokeMiterlimit = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "strokeMiterLimit", 10, this.mStrokeMiterlimit);
            this.mStrokeColor = androidx.core.content.res.TypedArrayUtils.getNamedComplexColor(typedArray, xmlPullParser, resources$Theme, "strokeColor", 3, 0);
            this.mStrokeAlpha = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "strokeAlpha", 11, this.mStrokeAlpha);
            this.mStrokeWidth = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "strokeWidth", 4, this.mStrokeWidth);
            this.mTrimPathEnd = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "trimPathEnd", 6, this.mTrimPathEnd);
            this.mTrimPathOffset = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "trimPathOffset", 7, this.mTrimPathOffset);
            this.mTrimPathStart = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "trimPathStart", 5, this.mTrimPathStart);
            this.mFillRule = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "fillType", 13, this.mFillRule);
        }
    }

    public override void ApplyTheme(android.content.res.Resources$Theme resources$Theme) {
    }

    public override bool CanApplyTheme() {
        return this.mThemeAttrs is not null;
    }

    float getFillAlpha() {
        return this.mFillAlpha;
    }

    int getFillColor() {
        return this.mFillColor.getColor();
    }

    float getStrokeAlpha() {
        return this.mStrokeAlpha;
    }

    int getStrokeColor() {
        return this.mStrokeColor.getColor();
    }

    float getStrokeWidth() {
        return this.mStrokeWidth;
    }

    float getTrimPathEnd() {
        return this.mTrimPathEnd;
    }

    float getTrimPathOffset() {
        return this.mTrimPathOffset;
    }

    float getTrimPathStart() {
        return this.mTrimPathStart;
    }

    public void Inflate(android.content.res.Resources resources, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_VECTOR_DRAWABLE_PATH);
        updateStateFromTypedArray(typedArrayObtainAttributes, xmlPullParser, resources$Theme);
        typedArrayObtainAttributes.recycle();
    }

    public override bool IsStateful() {
        return this.mFillColor.isStateful() || this.mStrokeColor.isStateful();
    }

    public override bool OnStateChanged(int[] iArr) {
        return this.mStrokeColor.onStateChanged(iArr) | this.mFillColor.onStateChanged(iArr);
    }

    void setFillAlpha(float f) {
        this.mFillAlpha = f;
    }

    void setFillColor(int i) {
        this.mFillColor.setColor(i);
    }

    void setStrokeAlpha(float f) {
        this.mStrokeAlpha = f;
    }

    void setStrokeColor(int i) {
        this.mStrokeColor.setColor(i);
    }

    void setStrokeWidth(float f) {
        this.mStrokeWidth = f;
    }

    void setTrimPathEnd(float f) {
        this.mTrimPathEnd = f;
    }

    void setTrimPathOffset(float f) {
        this.mTrimPathOffset = f;
    }

    void setTrimPathStart(float f) {
        this.mTrimPathStart = f;
    }
}

