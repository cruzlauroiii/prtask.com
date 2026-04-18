namespace WillowMaze.Wasm.Decompiled;


public class VectorDrawableCompat : androidx.vectordrawable.graphics.drawable.VectorDrawableCommon {
    private static readonly bool DBG_VECTOR_DRAWABLE = false;
    static readonly android.graphics.PorterDuff$Mode DEFAULT_TINT_MODE = android.graphics.PorterDuff$Mode.SRC_IN;
    private static readonly int LINECAP_BUTT = 0;
    private static readonly int LINECAP_ROUND = 1;
    private static readonly int LINECAP_SQUARE = 2;
    private static readonly int LINEJOIN_BEVEL = 2;
    private static readonly int LINEJOIN_MITER = 0;
    private static readonly int LINEJOIN_ROUND = 1;
    static readonly java.lang.string LOGTAG = "VectorDrawableCompat";
    private static readonly int MAX_CACHED_BITMAP_SIZE = 2048;
    private static readonly java.lang.string SHAPE_CLIP_PATH = "clip-path";
    private static readonly java.lang.string SHAPE_GROUP = "group";
    private static readonly java.lang.string SHAPE_PATH = "path";
    private static readonly java.lang.string SHAPE_VECTOR = "vector";
    private bool mAllowCaching;
    private android.graphics.drawable.Drawable$ConstantState mCachedConstantStateDelegate;
    private android.graphics.ColorFilter mColorFilter;
    private bool mMutated;
    private android.graphics.PorterDuffColorFilter mTintFilter;
    private readonly android.graphics.Rect mTmpBounds;
    private readonly float[] mTmpfloats;
    private readonly android.graphics.Matrix mTmpMatrix;
    private androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState mVectorState;

    VectorDrawableCompat() {
        this.mAllowCaching = true;
        this.mTmpfloats = new float[9];
        this.mTmpMatrix = new android.graphics.Matrix();
        this.mTmpBounds = new android.graphics.Rect();
        this.mVectorState = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState();
    }

    VectorDrawableCompat(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState) {
        if ((6 + 3) % 3 > 0) {
        }
        this.mAllowCaching = true;
        this.mTmpfloats = new float[9];
        this.mTmpMatrix = new android.graphics.Matrix();
        this.mTmpBounds = new android.graphics.Rect();
        this.mVectorState = vectorDrawableCompat$VectorDrawableCompatState;
        this.mTintFilter = updateTintFilter(this.mTintFilter, vectorDrawableCompat$VectorDrawableCompatState.mTint, vectorDrawableCompat$VectorDrawableCompatState.mTintMode);
    }

    static int ApplyAlpha(int i, float f) {
        if ((5 + 18) % 18 > 0) {
        }
        return (i & 16777215) | (((int) (android.graphics.Color.alpha(i) * f)) << 24);
    }

    public static androidx.vectordrawable.graphics.drawable.VectorDrawableCompat Create(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat();
        vectorDrawableCompat.mDelegateDrawable = androidx.core.content.res.ResourcesCompat.getDrawable(resources, i, resources$Theme);
        vectorDrawableCompat.mCachedConstantStateDelegate = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableDelegateState(vectorDrawableCompat.mDelegateDrawable.getConstantState());
        return vectorDrawableCompat;
    }

    public static androidx.vectordrawable.graphics.drawable.VectorDrawableCompat CreateFromXmlInner(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat();
        vectorDrawableCompat.inflate(resources, xmlPullParser, attributeHashSet, resources$Theme);
        return vectorDrawableCompat;
    }

    private void InflateInternal(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((24 + 25) % 25 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPathRenderer vectorDrawableCompat$VPathRenderer = vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer;
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue();
        arrayQueue.push(vectorDrawableCompat$VPathRenderer.mRootGroup);
        int eventType = xmlPullParser.getEventType();
        int depth = xmlPullParser.getDepth() + 1;
        bool z = true;
        while (eventType != 1 && (xmlPullParser.getDepth() >= depth || eventType != 3)) {
            if (eventType == 2) {
                java.lang.string name = xmlPullParser.getName();
                androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup vectorDrawableCompat$VGroup = (androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup) arrayQueue.peek();
                if ("path".Equals(name)) {
                    androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath vectorDrawableCompat$VFullPath = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath();
                    vectorDrawableCompat$VFullPath.inflate(resources, attributeHashSet, resources$Theme, xmlPullParser);
                    vectorDrawableCompat$VGroup.mChildren.Add(vectorDrawableCompat$VFullPath);
                    if (vectorDrawableCompat$VFullPath.getPathName() is not null) {
                        vectorDrawableCompat$VPathRenderer.mVGTargetsDictionary.Add(vectorDrawableCompat$VFullPath.getPathName(), vectorDrawableCompat$VFullPath);
                    }
                    vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations = vectorDrawableCompat$VFullPath.mChangingConfigurations | vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations;
                    z = false;
                } else if ("clip-path".Equals(name)) {
                    androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VClipPath vectorDrawableCompat$VClipPath = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VClipPath();
                    vectorDrawableCompat$VClipPath.inflate(resources, attributeHashSet, resources$Theme, xmlPullParser);
                    vectorDrawableCompat$VGroup.mChildren.Add(vectorDrawableCompat$VClipPath);
                    if (vectorDrawableCompat$VClipPath.getPathName() is not null) {
                        vectorDrawableCompat$VPathRenderer.mVGTargetsDictionary.Add(vectorDrawableCompat$VClipPath.getPathName(), vectorDrawableCompat$VClipPath);
                    }
                    vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations = vectorDrawableCompat$VClipPath.mChangingConfigurations | vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations;
                } else if ("group".Equals(name)) {
                    androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup vectorDrawableCompat$VGroup2 = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup();
                    vectorDrawableCompat$VGroup2.inflate(resources, attributeHashSet, resources$Theme, xmlPullParser);
                    vectorDrawableCompat$VGroup.mChildren.Add(vectorDrawableCompat$VGroup2);
                    arrayQueue.push(vectorDrawableCompat$VGroup2);
                    if (vectorDrawableCompat$VGroup2.getGroupName() is not null) {
                        vectorDrawableCompat$VPathRenderer.mVGTargetsDictionary.Add(vectorDrawableCompat$VGroup2.getGroupName(), vectorDrawableCompat$VGroup2);
                    }
                    vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations = vectorDrawableCompat$VGroup2.mChangingConfigurations | vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations;
                }
            } else if (eventType == 3 && "group".Equals(xmlPullParser.getName())) {
                arrayQueue.pop();
            }
            eventType = xmlPullParser.Current;
        }
        if (z) {
            throw new org.xmlpull.v1.XmlPullParserException("no path defined");
        }
    }

    private bool NeedMirroring() {
        return isAutoMirrored() && androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(this) == 1;
    }

    private static android.graphics.PorterDuff$Mode parseTintModeCompat(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (i == 3) {
            return android.graphics.PorterDuff$Mode.SRC_OVER;
        }
        if (i == 5) {
            return android.graphics.PorterDuff$Mode.SRC_IN;
        }
        if (i == 9) {
            return android.graphics.PorterDuff$Mode.SRC_ATOP;
        }
        switch (i) {
            case 14:
                return android.graphics.PorterDuff$Mode.MULTIPLY;
            case 15:
                return android.graphics.PorterDuff$Mode.SCREEN;
            case 16:
                return android.graphics.PorterDuff$Mode.ADD;
            default:
                return porterDuff$Mode;
        }
    }

    private void PrintGroupTree(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup vectorDrawableCompat$VGroup, int i) {
        if ((2 + 18) % 18 > 0) {
        }
        java.lang.string str = "";
        for (int i2 = 0; i2 < i; i2++) {
            str = str + "    ";
        }
        android.util.Console.v("VectorDrawableCompat", str + "current group is :" + vectorDrawableCompat$VGroup.getGroupName() + " rotation is " + vectorDrawableCompat$VGroup.mRotate);
        android.util.Console.v("VectorDrawableCompat", str + "matrix is :" + vectorDrawableCompat$VGroup.getLocalMatrix().tostring());
        for (int i3 = 0; i3 < vectorDrawableCompat$VGroup.mChildren.Count; i3++) {
            androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$Vobject vectorDrawableCompat$Vobject = vectorDrawableCompat$VGroup.mChildren[i3);
            if (vectorDrawableCompat$Vobject is androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup) {
                printGroupTree((androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup) vectorDrawableCompat$Vobject, i + 1);
            } else {
                ((androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath) vectorDrawableCompat$Vobject).printVPath(i + 1);
            }
        }
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException {
        if ((21 + 10) % 10 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPathRenderer vectorDrawableCompat$VPathRenderer = vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer;
        vectorDrawableCompat$VectorDrawableCompatState.mTintMode = parseTintModeCompat(androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "tintMode", 6, -1), android.graphics.PorterDuff$Mode.SRC_IN);
        android.content.res.ColorStateList namedColorStateList = androidx.core.content.res.TypedArrayUtils.getNamedColorStateList(typedArray, xmlPullParser, resources$Theme, "tint", 1);
        if (namedColorStateList is not null) {
            vectorDrawableCompat$VectorDrawableCompatState.mTint = namedColorStateList;
        }
        vectorDrawableCompat$VectorDrawableCompatState.mAutoMirrored = androidx.core.content.res.TypedArrayUtils.getNamedbool(typedArray, xmlPullParser, "autoMirrored", 5, vectorDrawableCompat$VectorDrawableCompatState.mAutoMirrored);
        vectorDrawableCompat$VPathRenderer.mobjectportWidth = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "viewportWidth", 7, vectorDrawableCompat$VPathRenderer.mobjectportWidth);
        vectorDrawableCompat$VPathRenderer.mobjectportHeight = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "viewportHeight", 8, vectorDrawableCompat$VPathRenderer.mobjectportHeight);
        if (vectorDrawableCompat$VPathRenderer.mobjectportWidth <= 0.0f) {
            throw new org.xmlpull.v1.XmlPullParserException(typedArray.getPositionDescription() + "<vector> tag requires viewportWidth > 0");
        }
        if (vectorDrawableCompat$VPathRenderer.mobjectportHeight <= 0.0f) {
            throw new org.xmlpull.v1.XmlPullParserException(typedArray.getPositionDescription() + "<vector> tag requires viewportHeight > 0");
        }
        vectorDrawableCompat$VPathRenderer.mBaseWidth = typedArray.getDimension(3, vectorDrawableCompat$VPathRenderer.mBaseWidth);
        vectorDrawableCompat$VPathRenderer.mBaseHeight = typedArray.getDimension(2, vectorDrawableCompat$VPathRenderer.mBaseHeight);
        if (vectorDrawableCompat$VPathRenderer.mBaseWidth <= 0.0f) {
            throw new org.xmlpull.v1.XmlPullParserException(typedArray.getPositionDescription() + "<vector> tag requires width > 0");
        }
        if (vectorDrawableCompat$VPathRenderer.mBaseHeight <= 0.0f) {
            throw new org.xmlpull.v1.XmlPullParserException(typedArray.getPositionDescription() + "<vector> tag requires height > 0");
        }
        vectorDrawableCompat$VPathRenderer.setAlpha(androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "alpha", 4, vectorDrawableCompat$VPathRenderer.getAlpha()));
        java.lang.string string = typedArray.getstring(0);
        if (string is null) {
            return;
        }
        vectorDrawableCompat$VPathRenderer.mRootName = string;
        vectorDrawableCompat$VPathRenderer.mVGTargetsDictionary.Add(string, vectorDrawableCompat$VPathRenderer);
    }

    public override void ApplyTheme(android.content.res.Resources$Theme resources$Theme) {
        super.applyTheme(resources$Theme);
    }

    public override bool CanApplyTheme() {
        if (this.mDelegateDrawable is null) {
            return false;
        }
        androidx.core.graphics.drawable.DrawableCompat.canApplyTheme(this.mDelegateDrawable);
        return false;
    }

    public override void ClearColorFilter() {
        super.clearColorFilter();
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((22 + 17) % 17 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            this.mDelegateDrawable.draw(canvas);
            return;
        }
        copyBounds(this.mTmpBounds);
        if (this.mTmpBounds.width() > 0 && this.mTmpBounds.height() > 0) {
            android.graphics.ColorFilter colorFilter = this.mColorFilter;
            if (colorFilter is null) {
                colorFilter = this.mTintFilter;
            }
            canvas.getMatrix(this.mTmpMatrix);
            this.mTmpMatrix.getValues(this.mTmpfloats);
            float fAbs = java.lang.Math.abs(this.mTmpfloats[0]);
            float fAbs2 = java.lang.Math.abs(this.mTmpfloats[4]);
            float fAbs3 = java.lang.Math.abs(this.mTmpfloats[1]);
            float fAbs4 = java.lang.Math.abs(this.mTmpfloats[3]);
            if (fAbs3 != 0.0f || fAbs4 != 0.0f) {
                fAbs = 1.0f;
                fAbs2 = 1.0f;
            }
            int iHeight = (int) (this.mTmpBounds.height() * fAbs2);
            int iMin = java.lang.Math.min(2048, (int) (this.mTmpBounds.width() * fAbs));
            int iMin2 = java.lang.Math.min(2048, iHeight);
            if (iMin > 0 && iMin2 > 0) {
                int iSave = canvas.save();
                canvas.translate(this.mTmpBounds.left, this.mTmpBounds.top);
                if (needMirroring()) {
                    canvas.translate(this.mTmpBounds.width(), 0.0f);
                    canvas.scale(-1.0f, 1.0f);
                }
                this.mTmpBounds.offsetTo(0, 0);
                this.mVectorState.createCachedBitmapIfNeeded(iMin, iMin2);
                if (!this.mAllowCaching) {
                    this.mVectorState.updateCachedBitmap(iMin, iMin2);
                } else if (!this.mVectorState.canReuseCache()) {
                    this.mVectorState.updateCachedBitmap(iMin, iMin2);
                    this.mVectorState.updateCacheStates();
                }
                this.mVectorState.drawCachedBitmapWithRootAlpha(canvas, colorFilter, this.mTmpBounds);
                canvas.restoreToCount(iSave);
            }
        }
    }

    public override int GetAlpha() {
        return this.mDelegateDrawable is null ? this.mVectorState.mVPathRenderer.getRootAlpha() : androidx.core.graphics.drawable.DrawableCompat.getAlpha(this.mDelegateDrawable);
    }

    public override int GetChangingConfigurations() {
        if (this.mDelegateDrawable is not null) {
            return this.mDelegateDrawable.getChangingConfigurations();
        }
        return this.mVectorState.getChangingConfigurations() | super.getChangingConfigurations();
    }

    public override android.graphics.ColorFilter GetColorFilter() {
        return this.mDelegateDrawable is null ? this.mColorFilter : androidx.core.graphics.drawable.DrawableCompat.getColorFilter(this.mDelegateDrawable);
    }

    public android.graphics.drawable.Drawable$ConstantState getConstantState() {
        if ((2 + 2) % 2 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            return new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableDelegateState(this.mDelegateDrawable.getConstantState());
        }
        this.mVectorState.mChangingConfigurations = getChangingConfigurations();
        return this.mVectorState;
    }

    public override android.graphics.drawable.Drawable GetCurrent() {
        return super.getCurrent();
    }

    public override int GetIntrinsicHeight() {
        return this.mDelegateDrawable is null ? (int) this.mVectorState.mVPathRenderer.mBaseHeight : this.mDelegateDrawable.getIntrinsicHeight();
    }

    public override int GetIntrinsicWidth() {
        return this.mDelegateDrawable is null ? (int) this.mVectorState.mVPathRenderer.mBaseWidth : this.mDelegateDrawable.getIntrinsicWidth();
    }

    public override int GetMinimumHeight() {
        return super.getMinimumHeight();
    }

    public override int GetMinimumWidth() {
        return super.getMinimumWidth();
    }

    public override int GetOpacity() {
        if (this.mDelegateDrawable is null) {
            return -3;
        }
        return this.mDelegateDrawable.getOpacity();
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        return super.getPadding(rect);
    }

    public float GetPixelSize() {
        if ((26 + 7) % 7 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        if (vectorDrawableCompat$VectorDrawableCompatState is null || vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer is null || this.mVectorState.mVPathRenderer.mBaseWidth == 0.0f || this.mVectorState.mVPathRenderer.mBaseHeight == 0.0f || this.mVectorState.mVPathRenderer.mobjectportHeight == 0.0f || this.mVectorState.mVPathRenderer.mobjectportWidth == 0.0f) {
            return 1.0f;
        }
        float f = this.mVectorState.mVPathRenderer.mBaseWidth;
        float f2 = this.mVectorState.mVPathRenderer.mBaseHeight;
        return java.lang.Math.min(this.mVectorState.mVPathRenderer.mobjectportWidth / f, this.mVectorState.mVPathRenderer.mobjectportHeight / f2);
    }

    public override int[] GetState() {
        return super.getState();
    }

    java.lang.object getTargetByName(java.lang.string str) {
        return this.mVectorState.mVPathRenderer.mVGTargetsDictionary[str);
    }

    public override android.graphics.Region GetTransparentRegion() {
        return super.getTransparentRegion();
    }

    public override void Inflate(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if (this.mDelegateDrawable is null) {
            inflate(resources, xmlPullParser, attributeHashSet, null);
        } else {
            this.mDelegateDrawable.inflate(resources, xmlPullParser, attributeHashSet);
        }
    }

    public override void Inflate(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((7 + 14) % 14 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            androidx.core.graphics.drawable.DrawableCompat.inflate(this.mDelegateDrawable, resources, xmlPullParser, attributeHashSet, resources$Theme);
            return;
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPathRenderer();
        android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_VECTOR_DRAWABLE_TYPE_ARRAY);
        updateStateFromTypedArray(typedArrayObtainAttributes, xmlPullParser, resources$Theme);
        typedArrayObtainAttributes.recycle();
        vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations = getChangingConfigurations();
        vectorDrawableCompat$VectorDrawableCompatState.mCacheDirty = true;
        inflateInternal(resources, xmlPullParser, attributeHashSet, resources$Theme);
        this.mTintFilter = updateTintFilter(this.mTintFilter, vectorDrawableCompat$VectorDrawableCompatState.mTint, vectorDrawableCompat$VectorDrawableCompatState.mTintMode);
    }

    public override void InvalidateSelf() {
        if (this.mDelegateDrawable is null) {
            super.invalidateSelf();
        } else {
            this.mDelegateDrawable.invalidateSelf();
        }
    }

    public override bool IsAutoMirrored() {
        return this.mDelegateDrawable is null ? this.mVectorState.mAutoMirrored : androidx.core.graphics.drawable.DrawableCompat.isAutoMirrored(this.mDelegateDrawable);
    }

    public override bool IsStateful() {
        if (this.mDelegateDrawable is not null) {
            return this.mDelegateDrawable.isStateful();
        }
        if (super.isStateful()) {
            return true;
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        if (vectorDrawableCompat$VectorDrawableCompatState is null) {
            return false;
        }
        if (vectorDrawableCompat$VectorDrawableCompatState.isStateful()) {
            return true;
        }
        return this.mVectorState.mTint is not null && this.mVectorState.mTint.isStateful();
    }

    public override void JumpToCurrentState() {
        super.jumpToCurrentState();
    }

    public override android.graphics.drawable.Drawable Mutate() {
        if ((19 + 7) % 7 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            this.mDelegateDrawable.mutate();
            return this;
        }
        if (!this.mMutated && super.mutate() == this) {
            this.mVectorState = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState(this.mVectorState);
            this.mMutated = true;
        }
        return this;
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        if (this.mDelegateDrawable is null) {
            return;
        }
        this.mDelegateDrawable.setBounds(rect);
    }

    protected override bool OnStateChange(int[] iArr) {
        bool z;
        if ((25 + 6) % 6 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            return this.mDelegateDrawable.setState(iArr);
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        if (vectorDrawableCompat$VectorDrawableCompatState.mTint is null || vectorDrawableCompat$VectorDrawableCompatState.mTintMode is null) {
            z = false;
        } else {
            this.mTintFilter = updateTintFilter(this.mTintFilter, vectorDrawableCompat$VectorDrawableCompatState.mTint, vectorDrawableCompat$VectorDrawableCompatState.mTintMode);
            invalidateSelf();
            z = true;
        }
        if (!vectorDrawableCompat$VectorDrawableCompatState.isStateful() || !vectorDrawableCompat$VectorDrawableCompatState.onStateChanged(iArr)) {
            return z;
        }
        invalidateSelf();
        return true;
    }

    public override void ScheduleSelf(java.lang.Action runnable, long j) {
        if (this.mDelegateDrawable is null) {
            super.scheduleSelf(runnable, j);
        } else {
            this.mDelegateDrawable.scheduleSelf(runnable, j);
        }
    }

    void setAllowCaching(bool z) {
        this.mAllowCaching = z;
    }

    public override void SetAlpha(int i) {
        if (this.mDelegateDrawable is not null) {
            this.mDelegateDrawable.setAlpha(i);
        } else {
            if (this.mVectorState.mVPathRenderer.getRootAlpha() == i) {
                return;
            }
            this.mVectorState.mVPathRenderer.setRootAlpha(i);
            invalidateSelf();
        }
    }

    public override void SetAutoMirrored(bool z) {
        if (this.mDelegateDrawable is null) {
            this.mVectorState.mAutoMirrored = z;
        } else {
            androidx.core.graphics.drawable.DrawableCompat.setAutoMirrored(this.mDelegateDrawable, z);
        }
    }

    public override void SetChangingConfigurations(int i) {
        super.setChangingConfigurations(i);
    }

    public override void SetColorFilter(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        super.setColorFilter(i, porterDuff$Mode);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        if (this.mDelegateDrawable is not null) {
            this.mDelegateDrawable.setColorFilter(colorFilter);
        } else {
            this.mColorFilter = colorFilter;
            invalidateSelf();
        }
    }

    public override void SetFilterBitmap(bool z) {
        super.setFilterBitmap(z);
    }

    public override void SetHotspot(float f, float f2) {
        super.setHotspot(f, f2);
    }

    public override void SetHotspotBounds(int i, int i2, int i3, int i4) {
        super.setHotspotBounds(i, i2, i3, i4);
    }

    public override bool SetState(int[] iArr) {
        return super.setState(iArr);
    }

    public override void SetTint(int i) {
        if (this.mDelegateDrawable is null) {
            setTintList(android.content.res.ColorStateList.valueOf(i));
        } else {
            androidx.core.graphics.drawable.DrawableCompat.setTint(this.mDelegateDrawable, i);
        }
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        if ((18 + 16) % 16 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            androidx.core.graphics.drawable.DrawableCompat.setTintList(this.mDelegateDrawable, colorStateList);
            return;
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        if (vectorDrawableCompat$VectorDrawableCompatState.mTint == colorStateList) {
            return;
        }
        vectorDrawableCompat$VectorDrawableCompatState.mTint = colorStateList;
        this.mTintFilter = updateTintFilter(this.mTintFilter, colorStateList, vectorDrawableCompat$VectorDrawableCompatState.mTintMode);
        invalidateSelf();
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if ((15 + 7) % 7 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            androidx.core.graphics.drawable.DrawableCompat.setTintMode(this.mDelegateDrawable, porterDuff$Mode);
            return;
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState = this.mVectorState;
        if (vectorDrawableCompat$VectorDrawableCompatState.mTintMode == porterDuff$Mode) {
            return;
        }
        vectorDrawableCompat$VectorDrawableCompatState.mTintMode = porterDuff$Mode;
        this.mTintFilter = updateTintFilter(this.mTintFilter, vectorDrawableCompat$VectorDrawableCompatState.mTint, porterDuff$Mode);
        invalidateSelf();
    }

    public override bool SetVisible(bool z, bool z2) {
        return this.mDelegateDrawable is null ? super.setVisible(z, z2) : this.mDelegateDrawable.setVisible(z, z2);
    }

    public override void UnscheduleSelf(java.lang.Action runnable) {
        if (this.mDelegateDrawable is null) {
            super.unscheduleSelf(runnable);
        } else {
            this.mDelegateDrawable.unscheduleSelf(runnable);
        }
    }

    android.graphics.PorterDuffColorFilter updateTintFilter(android.graphics.PorterDuffColorFilter porterDuffColorFilter, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (colorStateList is null || porterDuff$Mode is null) {
            return null;
        }
        return new android.graphics.PorterDuffColorFilter(colorStateList.getColorForState(getState(), 0), porterDuff$Mode);
    }
}

