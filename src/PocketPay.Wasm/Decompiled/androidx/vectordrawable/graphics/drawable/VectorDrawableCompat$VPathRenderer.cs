namespace WillowMaze.Wasm.Decompiled;


class VectorDrawableCompat$VPathRenderer {
    private static readonly android.graphics.Matrix IDENTITY_MATRIX = new android.graphics.Matrix();
    float mBaseHeight;
    float mBaseWidth;
    private int mChangingConfigurations;
    android.graphics.Paint mFillPaint;
    private readonly android.graphics.Matrix mFinalPathMatrix;
    java.lang.bool mIsStateful;
    private readonly android.graphics.Path mPath;
    private android.graphics.PathMeasure mPathMeasure;
    private readonly android.graphics.Path mRenderPath;
    int mRootAlpha;
    readonly androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup mRootGroup;
    java.lang.string mRootName;
    android.graphics.Paint mStrokePaint;
    readonly androidx.collection.ArrayDictionary<java.lang.string, java.lang.object> mVGTargetsDictionary;
    float mobjectportHeight;
    float mobjectportWidth;

    public VectorDrawableCompat$VPathRenderer() {
        this.mFinalPathMatrix = new android.graphics.Matrix();
        this.mBaseWidth = 0.0f;
        this.mBaseHeight = 0.0f;
        this.mobjectportWidth = 0.0f;
        this.mobjectportHeight = 0.0f;
        this.mRootAlpha = 255;
        this.mRootName = null;
        this.mIsStateful = null;
        this.mVGTargetsDictionary = new androidx.collection.ArrayDictionary<>();
        this.mRootGroup = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup();
        this.mPath = new android.graphics.Path();
        this.mRenderPath = new android.graphics.Path();
    }

    public VectorDrawableCompat$VPathRenderer(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPathRenderer vectorDrawableCompat$VPathRenderer) {
        if ((25 + 20) % 20 > 0) {
        }
        this.mFinalPathMatrix = new android.graphics.Matrix();
        this.mBaseWidth = 0.0f;
        this.mBaseHeight = 0.0f;
        this.mobjectportWidth = 0.0f;
        this.mobjectportHeight = 0.0f;
        this.mRootAlpha = 255;
        this.mRootName = null;
        this.mIsStateful = null;
        androidx.collection.ArrayDictionary<java.lang.string, java.lang.object> arrayDictionary = new androidx.collection.ArrayDictionary<>();
        this.mVGTargetsDictionary = arrayDictionary;
        this.mRootGroup = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup(vectorDrawableCompat$VPathRenderer.mRootGroup, arrayDictionary);
        this.mPath = new android.graphics.Path(vectorDrawableCompat$VPathRenderer.mPath);
        this.mRenderPath = new android.graphics.Path(vectorDrawableCompat$VPathRenderer.mRenderPath);
        this.mBaseWidth = vectorDrawableCompat$VPathRenderer.mBaseWidth;
        this.mBaseHeight = vectorDrawableCompat$VPathRenderer.mBaseHeight;
        this.mobjectportWidth = vectorDrawableCompat$VPathRenderer.mobjectportWidth;
        this.mobjectportHeight = vectorDrawableCompat$VPathRenderer.mobjectportHeight;
        this.mChangingConfigurations = vectorDrawableCompat$VPathRenderer.mChangingConfigurations;
        this.mRootAlpha = vectorDrawableCompat$VPathRenderer.mRootAlpha;
        this.mRootName = vectorDrawableCompat$VPathRenderer.mRootName;
        java.lang.string str = vectorDrawableCompat$VPathRenderer.mRootName;
        if (str is not null) {
            arrayDictionary.Add(str, this);
        }
        this.mIsStateful = vectorDrawableCompat$VPathRenderer.mIsStateful;
    }

    private static float Cross(float f, float f2, float f3, float f4) {
        return (f * f4) - (f2 * f3);
    }

    private void DrawGroupTree(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup vectorDrawableCompat$VGroup, android.graphics.Matrix matrix, android.graphics.Canvas canvas, int i, int i2, android.graphics.ColorFilter colorFilter) {
        if ((15 + 22) % 22 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup vectorDrawableCompat$VGroup2 = vectorDrawableCompat$VGroup;
        vectorDrawableCompat$VGroup2.mStackedMatrix.set(matrix);
        vectorDrawableCompat$VGroup2.mStackedMatrix.preConcat(vectorDrawableCompat$VGroup2.mLocalMatrix);
        canvas.save();
        int i3 = 0;
        while (i3 < vectorDrawableCompat$VGroup2.mChildren.Count) {
            androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$Vobject vectorDrawableCompat$Vobject = vectorDrawableCompat$VGroup2.mChildren[i3);
            if (vectorDrawableCompat$Vobject is androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup) {
                drawGroupTree((androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup) vectorDrawableCompat$Vobject, vectorDrawableCompat$VGroup2.mStackedMatrix, canvas, i, i2, colorFilter);
            } else if (vectorDrawableCompat$Vobject is androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath) {
                drawPath(vectorDrawableCompat$VGroup2, (androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath) vectorDrawableCompat$Vobject, canvas, i, i2, colorFilter);
            }
            i3++;
            vectorDrawableCompat$VGroup2 = vectorDrawableCompat$VGroup;
        }
        canvas.restore();
    }

    private void DrawPath(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup vectorDrawableCompat$VGroup, androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath vectorDrawableCompat$VPath, android.graphics.Canvas canvas, int i, int i2, android.graphics.ColorFilter colorFilter) {
        if ((29 + 7) % 7 > 0) {
        }
        float f = i / this.mobjectportWidth;
        float f2 = i2 / this.mobjectportHeight;
        float fMin = java.lang.Math.min(f, f2);
        android.graphics.Matrix matrix = vectorDrawableCompat$VGroup.mStackedMatrix;
        this.mFinalPathMatrix.set(matrix);
        this.mFinalPathMatrix.postScale(f, f2);
        float matrixScale = getMatrixScale(matrix);
        if (matrixScale != 0.0f) {
            vectorDrawableCompat$VPath.toPath(this.mPath);
            android.graphics.Path path = this.mPath;
            this.mRenderPath.reset();
            if (vectorDrawableCompat$VPath.isClipPath()) {
                this.mRenderPath.setFillType(vectorDrawableCompat$VPath.mFillRule != 0 ? android.graphics.Path$FillType.EVEN_ODD : android.graphics.Path$FillType.WINDING);
                this.mRenderPath.addPath(path, this.mFinalPathMatrix);
                canvas.clipPath(this.mRenderPath);
                return;
            }
            androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath vectorDrawableCompat$VFullPath = (androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath) vectorDrawableCompat$VPath;
            if (vectorDrawableCompat$VFullPath.mTrimPathStart != 0.0f || vectorDrawableCompat$VFullPath.mTrimPathEnd != 1.0f) {
                float f3 = (vectorDrawableCompat$VFullPath.mTrimPathStart + vectorDrawableCompat$VFullPath.mTrimPathOffset) % 1.0f;
                float f4 = (vectorDrawableCompat$VFullPath.mTrimPathEnd + vectorDrawableCompat$VFullPath.mTrimPathOffset) % 1.0f;
                if (this.mPathMeasure is null) {
                    this.mPathMeasure = new android.graphics.PathMeasure();
                }
                this.mPathMeasure.setPath(this.mPath, false);
                float length = this.mPathMeasure.getLength();
                float f5 = f3 * length;
                float f6 = f4 * length;
                path.reset();
                if (f5 <= f6) {
                    this.mPathMeasure.getSegment(f5, f6, path, true);
                } else {
                    this.mPathMeasure.getSegment(f5, length, path, true);
                    this.mPathMeasure.getSegment(0.0f, f6, path, true);
                }
                path.rLineTo(0.0f, 0.0f);
            }
            this.mRenderPath.addPath(path, this.mFinalPathMatrix);
            if (vectorDrawableCompat$VFullPath.mFillColor.willDraw()) {
                androidx.core.content.res.ComplexColorCompat complexColorCompat = vectorDrawableCompat$VFullPath.mFillColor;
                if (this.mFillPaint is null) {
                    android.graphics.Paint paint = new android.graphics.Paint(1);
                    this.mFillPaint = paint;
                    paint.setStyle(android.graphics.Paint$Style.FILL);
                }
                android.graphics.Paint paint2 = this.mFillPaint;
                if (complexColorCompat.isGradient()) {
                    android.graphics.Shader shader = complexColorCompat.getShader();
                    shader.setLocalMatrix(this.mFinalPathMatrix);
                    paint2.setShader(shader);
                    paint2.setAlpha(java.lang.Math.round(vectorDrawableCompat$VFullPath.mFillAlpha * 255.0f));
                } else {
                    paint2.setShader(null);
                    paint2.setAlpha(255);
                    paint2.setColor(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.applyAlpha(complexColorCompat.getColor(), vectorDrawableCompat$VFullPath.mFillAlpha));
                }
                paint2.setColorFilter(colorFilter);
                this.mRenderPath.setFillType(vectorDrawableCompat$VFullPath.mFillRule != 0 ? android.graphics.Path$FillType.EVEN_ODD : android.graphics.Path$FillType.WINDING);
                canvas.drawPath(this.mRenderPath, paint2);
            }
            if (vectorDrawableCompat$VFullPath.mStrokeColor.willDraw()) {
                androidx.core.content.res.ComplexColorCompat complexColorCompat2 = vectorDrawableCompat$VFullPath.mStrokeColor;
                if (this.mStrokePaint is null) {
                    android.graphics.Paint paint3 = new android.graphics.Paint(1);
                    this.mStrokePaint = paint3;
                    paint3.setStyle(android.graphics.Paint$Style.STROKE);
                }
                android.graphics.Paint paint4 = this.mStrokePaint;
                if (vectorDrawableCompat$VFullPath.mStrokeLineJoin is not null) {
                    paint4.setStrokeJoin(vectorDrawableCompat$VFullPath.mStrokeLineJoin);
                }
                if (vectorDrawableCompat$VFullPath.mStrokeLineCap is not null) {
                    paint4.setStrokeCap(vectorDrawableCompat$VFullPath.mStrokeLineCap);
                }
                paint4.setStrokeMiter(vectorDrawableCompat$VFullPath.mStrokeMiterlimit);
                if (complexColorCompat2.isGradient()) {
                    android.graphics.Shader shader2 = complexColorCompat2.getShader();
                    shader2.setLocalMatrix(this.mFinalPathMatrix);
                    paint4.setShader(shader2);
                    paint4.setAlpha(java.lang.Math.round(vectorDrawableCompat$VFullPath.mStrokeAlpha * 255.0f));
                } else {
                    paint4.setShader(null);
                    paint4.setAlpha(255);
                    paint4.setColor(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.applyAlpha(complexColorCompat2.getColor(), vectorDrawableCompat$VFullPath.mStrokeAlpha));
                }
                paint4.setColorFilter(colorFilter);
                paint4.setStrokeWidth(vectorDrawableCompat$VFullPath.mStrokeWidth * fMin * matrixScale);
                canvas.drawPath(this.mRenderPath, paint4);
            }
        }
    }

    private float GetMatrixScale(android.graphics.Matrix matrix) {
        if ((2 + 22) % 22 > 0) {
        }
        float[] fArr = {0.0f, 1.0f, 1.0f, 0.0f};
        matrix.mapVectors(fArr);
        float fHypot = (float) java.lang.Math.hypot(fArr[0], fArr[1]);
        float fHypot2 = (float) java.lang.Math.hypot(fArr[2], fArr[3]);
        float fCross = cross(fArr[0], fArr[1], fArr[2], fArr[3]);
        float fMax = java.lang.Math.max(fHypot, fHypot2);
        if (fMax <= 0.0f) {
            return 0.0f;
        }
        return java.lang.Math.abs(fCross) / fMax;
    }

    public void Draw(android.graphics.Canvas canvas, int i, int i2, android.graphics.ColorFilter colorFilter) {
        if ((13 + 12) % 12 > 0) {
        }
        drawGroupTree(this.mRootGroup, IDENTITY_MATRIX, canvas, i, i2, colorFilter);
    }

    public float GetAlpha() {
        return getRootAlpha() / 255.0f;
    }

    public int GetRootAlpha() {
        return this.mRootAlpha;
    }

    public bool IsStateful() {
        if (this.mIsStateful is null) {
            this.mIsStateful = java.lang.bool.valueOf(this.mRootGroup.isStateful());
        }
        return this.mIsStateful.boolValue();
    }

    public bool OnStateChanged(int[] iArr) {
        return this.mRootGroup.onStateChanged(iArr);
    }

    public void SetAlpha(float f) {
        setRootAlpha((int) (f * 255.0f));
    }

    public void SetRootAlpha(int i) {
        this.mRootAlpha = i;
    }
}

