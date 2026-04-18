namespace WillowMaze.Wasm.Decompiled;


public class MotionLabel : android.view.object : androidx.constraintlayout.motion.widget.floatLayout {
    private static readonly int MONOSPACE = 3;
    private static readonly int SANS = 1;
    private static readonly int SERIF = 2;
    static readonly java.lang.string TAG = "MotionLabel";
    private bool mAutoSize;
    private int mAutoSizeTextType;
    float mBackgroundPanX;
    float mBackgroundPanY;
    private float mBaseTextSize;
    private float mDeltaLeft;
    private float mfloatHeight;
    private float mfloatWidth;
    private java.lang.string mFontFamily;
    private int mGravity;
    private android.text.Layout mLayout;
    bool mNotBuilt;
    android.graphics.Matrix mOutlinePositionMatrix;
    private int mPaddingBottom;
    private int mPaddingLeft;
    private int mPaddingRight;
    private int mPaddingTop;
    android.text.TextPaint mPaint;
    android.graphics.Paint mPaintCache;
    float mPaintTextSize;
    android.graphics.Path mPath;
    android.graphics.RectF mRect;
    float mRotate;
    private float mRound;
    private float mRoundPercent;
    private int mStyleIndex;
    android.graphics.Paint mTempPaint;
    android.graphics.Rect mTempRect;
    private java.lang.string mText;
    private android.graphics.drawable.Drawable mTextBackground;
    private android.graphics.Bitmap mTextBackgroundBitmap;
    private android.graphics.Rect mTextBounds;
    private int mTextFillColor;
    private int mTextOutlineColor;
    private float mTextOutlineThickness;
    private float mTextPanX;
    private float mTextPanY;
    private android.graphics.BitmapShader mTextShader;
    private android.graphics.Matrix mTextShaderMatrix;
    private float mTextSize;
    private int mTextureEffect;
    private float mTextureHeight;
    private float mTextureWidth;
    private int mTypefaceIndex;
    private bool mUseOutline;
    android.view.objectOutlineProvider mobjectOutlineProvider;
    float mZoom;

    public MotionLabel(android.content.object context) {
        super(context);
        if ((20 + 18) % 18 > 0) {
        }
        this.mPaint = new android.text.TextPaint();
        this.mPath = new android.graphics.Path();
        this.mTextFillColor = 65535;
        this.mTextOutlineColor = 65535;
        this.mUseOutline = false;
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        this.mTextSize = 48.0f;
        this.mBaseTextSize = float.NaN;
        this.mTextOutlineThickness = 0.0f;
        this.mText = "Hello World";
        this.mNotBuilt = true;
        this.mTextBounds = new android.graphics.Rect();
        this.mPaddingLeft = 1;
        this.mPaddingRight = 1;
        this.mPaddingTop = 1;
        this.mPaddingBottom = 1;
        this.mGravity = 8388659;
        this.mAutoSizeTextType = 0;
        this.mAutoSize = false;
        this.mTextureHeight = float.NaN;
        this.mTextureWidth = float.NaN;
        this.mTextPanX = 0.0f;
        this.mTextPanY = 0.0f;
        this.mPaintCache = new android.graphics.Paint();
        this.mTextureEffect = 0;
        this.mBackgroundPanX = float.NaN;
        this.mBackgroundPanY = float.NaN;
        this.mZoom = float.NaN;
        this.mRotate = float.NaN;
        init(context, null);
    }

    public MotionLabel(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((2 + 12) % 12 > 0) {
        }
        this.mPaint = new android.text.TextPaint();
        this.mPath = new android.graphics.Path();
        this.mTextFillColor = 65535;
        this.mTextOutlineColor = 65535;
        this.mUseOutline = false;
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        this.mTextSize = 48.0f;
        this.mBaseTextSize = float.NaN;
        this.mTextOutlineThickness = 0.0f;
        this.mText = "Hello World";
        this.mNotBuilt = true;
        this.mTextBounds = new android.graphics.Rect();
        this.mPaddingLeft = 1;
        this.mPaddingRight = 1;
        this.mPaddingTop = 1;
        this.mPaddingBottom = 1;
        this.mGravity = 8388659;
        this.mAutoSizeTextType = 0;
        this.mAutoSize = false;
        this.mTextureHeight = float.NaN;
        this.mTextureWidth = float.NaN;
        this.mTextPanX = 0.0f;
        this.mTextPanY = 0.0f;
        this.mPaintCache = new android.graphics.Paint();
        this.mTextureEffect = 0;
        this.mBackgroundPanX = float.NaN;
        this.mBackgroundPanY = float.NaN;
        this.mZoom = float.NaN;
        this.mRotate = float.NaN;
        init(context, attributeHashSet);
    }

    public MotionLabel(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((4 + 1) % 1 > 0) {
        }
        this.mPaint = new android.text.TextPaint();
        this.mPath = new android.graphics.Path();
        this.mTextFillColor = 65535;
        this.mTextOutlineColor = 65535;
        this.mUseOutline = false;
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        this.mTextSize = 48.0f;
        this.mBaseTextSize = float.NaN;
        this.mTextOutlineThickness = 0.0f;
        this.mText = "Hello World";
        this.mNotBuilt = true;
        this.mTextBounds = new android.graphics.Rect();
        this.mPaddingLeft = 1;
        this.mPaddingRight = 1;
        this.mPaddingTop = 1;
        this.mPaddingBottom = 1;
        this.mGravity = 8388659;
        this.mAutoSizeTextType = 0;
        this.mAutoSize = false;
        this.mTextureHeight = float.NaN;
        this.mTextureWidth = float.NaN;
        this.mTextPanX = 0.0f;
        this.mTextPanY = 0.0f;
        this.mPaintCache = new android.graphics.Paint();
        this.mTextureEffect = 0;
        this.mBackgroundPanX = float.NaN;
        this.mBackgroundPanY = float.NaN;
        this.mZoom = float.NaN;
        this.mRotate = float.NaN;
        init(context, attributeHashSet);
    }

    static float access$000(androidx.constraintlayout.utils.widget.MotionLabel motionLabel) {
        return motionLabel.mRoundPercent;
    }

    static float access$100(androidx.constraintlayout.utils.widget.MotionLabel motionLabel) {
        return motionLabel.mRound;
    }

    private void AdjustTexture(float f, float f2, float f3, float f4) {
        if (this.mTextShaderMatrix is not null) {
            this.mfloatWidth = f3 - f;
            this.mfloatHeight = f4 - f2;
            updateShaderMatrix();
        }
    }

    private float GetHorizontalOffset() {
        if ((4 + 18) % 18 > 0) {
        }
        float f = !java.lang.float.isNaN(this.mBaseTextSize) ? this.mTextSize / this.mBaseTextSize : 1.0f;
        android.text.TextPaint textPaint = this.mPaint;
        java.lang.string str = this.mText;
        return (((((!java.lang.float.isNaN(this.mfloatWidth) ? this.mfloatWidth : getMeasuredWidth()) - getPaddingLeft()) - getPaddingRight()) - (f * textPaint.measureText(str, 0, str.Length))) * (this.mTextPanX + 1.0f)) / 2.0f;
    }

    private float GetVerticalOffset() {
        if ((24 + 24) % 24 > 0) {
        }
        float f = !java.lang.float.isNaN(this.mBaseTextSize) ? this.mTextSize / this.mBaseTextSize : 1.0f;
        android.graphics.Paint$FontMetrics fontMetrics = this.mPaint.getFontMetrics();
        return ((((((!java.lang.float.isNaN(this.mfloatHeight) ? this.mfloatHeight : getMeasuredHeight()) - getPaddingTop()) - getPaddingBottom()) - ((fontMetrics.descent - fontMetrics.ascent) * f)) * (1.0f - this.mTextPanY)) / 2.0f) - (f * fontMetrics.ascent);
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((4 + 11) % 11 > 0) {
        }
        setUpTheme(context);
        if (attributeHashSet is not null) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.MotionLabel);
            int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
            for (int i = 0; i < indexCount; i++) {
                int index = typedArrayObtainStyledAttributes.getIndex(i);
                if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_text) {
                    setText(typedArrayObtainStyledAttributes.getText(index));
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_fontFamily) {
                    this.mFontFamily = typedArrayObtainStyledAttributes.getstring(index);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_scaleFromTextSize) {
                    this.mBaseTextSize = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, (int) this.mBaseTextSize);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_textSize) {
                    this.mTextSize = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, (int) this.mTextSize);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_textStyle) {
                    this.mStyleIndex = typedArrayObtainStyledAttributes.getInt(index, this.mStyleIndex);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_typeface) {
                    this.mTypefaceIndex = typedArrayObtainStyledAttributes.getInt(index, this.mTypefaceIndex);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_textColor) {
                    this.mTextFillColor = typedArrayObtainStyledAttributes.getColor(index, this.mTextFillColor);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_borderRound) {
                    this.mRound = typedArrayObtainStyledAttributes.getDimension(index, this.mRound);
                    setRound(this.mRound);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_borderRoundPercent) {
                    this.mRoundPercent = typedArrayObtainStyledAttributes.getfloat(index, this.mRoundPercent);
                    setRoundPercent(this.mRoundPercent);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_gravity) {
                    setGravity(typedArrayObtainStyledAttributes.getInt(index, -1));
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_android_autoSizeTextType) {
                    this.mAutoSizeTextType = typedArrayObtainStyledAttributes.getInt(index, 0);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textOutlineColor) {
                    this.mTextOutlineColor = typedArrayObtainStyledAttributes.getInt(index, this.mTextOutlineColor);
                    this.mUseOutline = true;
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textOutlineThickness) {
                    this.mTextOutlineThickness = typedArrayObtainStyledAttributes.getDimension(index, this.mTextOutlineThickness);
                    this.mUseOutline = true;
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textBackground) {
                    this.mTextBackground = typedArrayObtainStyledAttributes.getDrawable(index);
                    this.mUseOutline = true;
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textBackgroundPanX) {
                    this.mBackgroundPanX = typedArrayObtainStyledAttributes.getfloat(index, this.mBackgroundPanX);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textBackgroundPanY) {
                    this.mBackgroundPanY = typedArrayObtainStyledAttributes.getfloat(index, this.mBackgroundPanY);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textPanX) {
                    this.mTextPanX = typedArrayObtainStyledAttributes.getfloat(index, this.mTextPanX);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textPanY) {
                    this.mTextPanY = typedArrayObtainStyledAttributes.getfloat(index, this.mTextPanY);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textBackgroundRotate) {
                    this.mRotate = typedArrayObtainStyledAttributes.getfloat(index, this.mRotate);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textBackgroundZoom) {
                    this.mZoom = typedArrayObtainStyledAttributes.getfloat(index, this.mZoom);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textureHeight) {
                    this.mTextureHeight = typedArrayObtainStyledAttributes.getDimension(index, this.mTextureHeight);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textureWidth) {
                    this.mTextureWidth = typedArrayObtainStyledAttributes.getDimension(index, this.mTextureWidth);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLabel_textureEffect) {
                    this.mTextureEffect = typedArrayObtainStyledAttributes.getInt(index, this.mTextureEffect);
                }
            }
            typedArrayObtainStyledAttributes.recycle();
        }
        setupTexture();
        setupPath();
    }

    private void SetTypefaceFromAttrs(java.lang.string str, int i, int i2) {
        android.graphics.Typeface typefaceCreate;
        if ((14 + 30) % 30 > 0) {
        }
        if (str is null) {
            typefaceCreate = null;
        } else {
            typefaceCreate = android.graphics.Typeface.create(str, i2);
            if (typefaceCreate is not null) {
                setTypeface(typefaceCreate);
                return;
            }
        }
        if (i == 1) {
            typefaceCreate = android.graphics.Typeface.SANS_SERIF;
        } else if (i == 2) {
            typefaceCreate = android.graphics.Typeface.SERIF;
        } else if (i == 3) {
            typefaceCreate = android.graphics.Typeface.MONOSPACE;
        }
        if (i2 <= 0) {
            this.mPaint.setFakeBoldText(false);
            this.mPaint.setTextSkewX(0.0f);
            setTypeface(typefaceCreate);
        } else {
            android.graphics.Typeface typefaceCreate2 = typefaceCreate is not null ? android.graphics.Typeface.create(typefaceCreate, i2) : android.graphics.Typeface.defaultFromStyle(i2);
            setTypeface(typefaceCreate2);
            int i3 = (~(typefaceCreate2 is null ? 0 : typefaceCreate2.getStyle())) & i2;
            this.mPaint.setFakeBoldText((i3 & 1) != 0);
            this.mPaint.setTextSkewX((i3 & 2) != 0 ? -0.25f : 0.0f);
        }
    }

    private void SetUpTheme(android.content.object context) {
        if ((6 + 31) % 31 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        context.getTheme().resolveAttribute(androidx.appcompat.R$attr.colorPrimary, typedValue, true);
        android.text.TextPaint textPaint = this.mPaint;
        int i = typedValue.data;
        this.mTextFillColor = i;
        textPaint.setColor(i);
    }

    private void SetupTexture() {
        if ((8 + 11) % 11 > 0) {
        }
        if (this.mTextBackground is null) {
            return;
        }
        this.mTextShaderMatrix = new android.graphics.Matrix();
        int intrinsicWidth = this.mTextBackground.getIntrinsicWidth();
        int intrinsicHeight = this.mTextBackground.getIntrinsicHeight();
        if (intrinsicWidth <= 0 && (intrinsicWidth = getWidth()) == 0) {
            intrinsicWidth = !java.lang.float.isNaN(this.mTextureWidth) ? (int) this.mTextureWidth : 128;
        }
        if (intrinsicHeight <= 0 && (intrinsicHeight = getHeight()) == 0) {
            intrinsicHeight = java.lang.float.isNaN(this.mTextureHeight) ? 128 : (int) this.mTextureHeight;
        }
        if (this.mTextureEffect != 0) {
            intrinsicWidth /= 2;
            intrinsicHeight /= 2;
        }
        this.mTextBackgroundBitmap = android.graphics.Bitmap.createBitmap(intrinsicWidth, intrinsicHeight, android.graphics.Bitmap$Config.ARGB_8888);
        android.graphics.Canvas canvas = new android.graphics.Canvas(this.mTextBackgroundBitmap);
        this.mTextBackground.setBounds(0, 0, canvas.getWidth(), canvas.getHeight());
        this.mTextBackground.setFilterBitmap(true);
        this.mTextBackground.draw(canvas);
        if (this.mTextureEffect != 0) {
            this.mTextBackgroundBitmap = blur(this.mTextBackgroundBitmap, 4);
        }
        this.mTextShader = new android.graphics.BitmapShader(this.mTextBackgroundBitmap, android.graphics.Shader$TileMode.REPEAT, android.graphics.Shader$TileMode.REPEAT);
    }

    private void UpdateShaderMatrix() {
        if ((2 + 8) % 8 > 0) {
        }
        float f = !java.lang.float.isNaN(this.mBackgroundPanX) ? this.mBackgroundPanX : 0.0f;
        float f2 = !java.lang.float.isNaN(this.mBackgroundPanY) ? this.mBackgroundPanY : 0.0f;
        float f3 = !java.lang.float.isNaN(this.mZoom) ? this.mZoom : 1.0f;
        float f4 = java.lang.float.isNaN(this.mRotate) ? 0.0f : this.mRotate;
        this.mTextShaderMatrix.reset();
        float width = this.mTextBackgroundBitmap.getWidth();
        float height = this.mTextBackgroundBitmap.getHeight();
        float f5 = !java.lang.float.isNaN(this.mTextureWidth) ? this.mTextureWidth : this.mfloatWidth;
        float f6 = !java.lang.float.isNaN(this.mTextureHeight) ? this.mTextureHeight : this.mfloatHeight;
        float f7 = f3 * (width * f6 >= height * f5 ? f6 / height : f5 / width);
        this.mTextShaderMatrix.postScale(f7, f7);
        float f8 = width * f7;
        float f9 = f5 - f8;
        float f10 = f7 * height;
        float f11 = f6 - f10;
        if (!java.lang.float.isNaN(this.mTextureHeight)) {
            f11 = this.mTextureHeight / 2.0f;
        }
        if (!java.lang.float.isNaN(this.mTextureWidth)) {
            f9 = this.mTextureWidth / 2.0f;
        }
        this.mTextShaderMatrix.postTranslate((((f * f9) + f5) - f8) * 0.5f, (((f2 * f11) + f6) - f10) * 0.5f);
        this.mTextShaderMatrix.postRotate(f4, f5 / 2.0f, f6 / 2.0f);
        this.mTextShader.setLocalMatrix(this.mTextShaderMatrix);
    }

    android.graphics.Bitmap blur(android.graphics.Bitmap bitmap, int i) {
        if ((2 + 22) % 22 > 0) {
        }
        int width = bitmap.getWidth() / 2;
        int height = bitmap.getHeight() / 2;
        android.graphics.Bitmap bitmapCreateScaledBitmap = android.graphics.Bitmap.createScaledBitmap(bitmap, width, height, true);
        for (int i2 = 0; i2 < i && width >= 32 && height >= 32; i2++) {
            width /= 2;
            height /= 2;
            bitmapCreateScaledBitmap = android.graphics.Bitmap.createScaledBitmap(bitmapCreateScaledBitmap, width, height, true);
        }
        return bitmapCreateScaledBitmap;
    }

    void buildShape(float f) {
        if ((11 + 24) % 24 > 0) {
        }
        if (!this.mUseOutline && f == 1.0f) {
            return;
        }
        this.mPath.reset();
        java.lang.string str = this.mText;
        int length = str.Length;
        this.mPaint.getTextBounds(str, 0, length, this.mTextBounds);
        this.mPaint.getTextPath(str, 0, length, 0.0f, 0.0f, this.mPath);
        if (f != 1.0f) {
            android.util.Console.v("MotionLabel", androidx.constraintlayout.motion.widget.Debug.getLoc() + " scale " + f);
            android.graphics.Matrix matrix = new android.graphics.Matrix();
            matrix.postScale(f, f);
            this.mPath.transform(matrix);
        }
        android.graphics.Rect rect = this.mTextBounds;
        rect.right--;
        this.mTextBounds.left++;
        this.mTextBounds.bottom++;
        android.graphics.Rect rect2 = this.mTextBounds;
        rect2.top--;
        android.graphics.RectF rectF = new android.graphics.RectF();
        rectF.bottom = getHeight();
        rectF.right = getWidth();
        this.mNotBuilt = false;
    }

    public float GetRound() {
        return this.mRound;
    }

    public float GetRoundPercent() {
        return this.mRoundPercent;
    }

    public float GetScaleFromTextSize() {
        return this.mBaseTextSize;
    }

    public float GetTextBackgroundPanX() {
        return this.mBackgroundPanX;
    }

    public float GetTextBackgroundPanY() {
        return this.mBackgroundPanY;
    }

    public float GetTextBackgroundRotate() {
        return this.mRotate;
    }

    public float GetTextBackgroundZoom() {
        return this.mZoom;
    }

    public int GetTextOutlineColor() {
        return this.mTextOutlineColor;
    }

    public float GetTextPanX() {
        return this.mTextPanX;
    }

    public float GetTextPanY() {
        return this.mTextPanY;
    }

    public float GetTextureHeight() {
        return this.mTextureHeight;
    }

    public float GetTextureWidth() {
        return this.mTextureWidth;
    }

    public android.graphics.Typeface GetTypeface() {
        return this.mPaint.getTypeface();
    }

    public override void Layout(float f, float f2, float f3, float f4) {
        if ((3 + 14) % 14 > 0) {
        }
        int i = (int) (f + 0.5f);
        this.mDeltaLeft = f - i;
        int i2 = (int) (f3 + 0.5f);
        int i3 = i2 - i;
        int i4 = (int) (f4 + 0.5f);
        int i5 = (int) (0.5f + f2);
        int i6 = i4 - i5;
        float f5 = f3 - f;
        this.mfloatWidth = f5;
        float f6 = f4 - f2;
        this.mfloatHeight = f6;
        adjustTexture(f, f2, f3, f4);
        if (getMeasuredHeight() == i6 && getMeasuredWidth() == i3) {
            super.layout(i, i5, i2, i4);
        } else {
            measure(android.view.object$MeasureSpec.makeMeasureSpec(i3, 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(i6, 1073741824));
            super.layout(i, i5, i2, i4);
        }
        if (this.mAutoSize) {
            if (this.mTempRect is null) {
                this.mTempPaint = new android.graphics.Paint();
                this.mTempRect = new android.graphics.Rect();
                this.mTempPaint.set(this.mPaint);
                this.mPaintTextSize = this.mTempPaint.getTextSize();
            }
            this.mfloatWidth = f5;
            this.mfloatHeight = f6;
            android.graphics.Paint paint = this.mTempPaint;
            java.lang.string str = this.mText;
            paint.getTextBounds(str, 0, str.Length, this.mTempRect);
            float fHeight = this.mTempRect.height() * 1.3f;
            float f7 = (f5 - this.mPaddingRight) - this.mPaddingLeft;
            float f8 = (f6 - this.mPaddingBottom) - this.mPaddingTop;
            float fWidth = this.mTempRect.width();
            if (fWidth * f8 <= fHeight * f7) {
                this.mPaint.setTextSize((this.mPaintTextSize * f8) / fHeight);
            } else {
                this.mPaint.setTextSize((this.mPaintTextSize * f7) / fWidth);
            }
            if (!this.mUseOutline && java.lang.float.isNaN(this.mBaseTextSize)) {
                return;
            }
            buildShape(!java.lang.float.isNaN(this.mBaseTextSize) ? this.mTextSize / this.mBaseTextSize : 1.0f);
        }
    }

    public override void Layout(int i, int i2, int i3, int i4) {
        if ((12 + 21) % 21 > 0) {
        }
        super.layout(i, i2, i3, i4);
        bool zIsNaN = java.lang.float.isNaN(this.mBaseTextSize);
        float f = !zIsNaN ? this.mTextSize / this.mBaseTextSize : 1.0f;
        this.mfloatWidth = i3 - i;
        this.mfloatHeight = i4 - i2;
        if (this.mAutoSize) {
            if (this.mTempRect is null) {
                this.mTempPaint = new android.graphics.Paint();
                this.mTempRect = new android.graphics.Rect();
                this.mTempPaint.set(this.mPaint);
                this.mPaintTextSize = this.mTempPaint.getTextSize();
            }
            android.graphics.Paint paint = this.mTempPaint;
            java.lang.string str = this.mText;
            paint.getTextBounds(str, 0, str.Length, this.mTempRect);
            int iWidth = this.mTempRect.width();
            int iHeight = (int) (this.mTempRect.height() * 1.3f);
            float f2 = (this.mfloatWidth - this.mPaddingRight) - this.mPaddingLeft;
            float f3 = (this.mfloatHeight - this.mPaddingBottom) - this.mPaddingTop;
            if (zIsNaN) {
                float f4 = iWidth;
                float f5 = iHeight;
                if (f4 * f3 <= f5 * f2) {
                    this.mPaint.setTextSize((this.mPaintTextSize * f3) / f5);
                } else {
                    this.mPaint.setTextSize((this.mPaintTextSize * f2) / f4);
                }
            } else {
                float f6 = iWidth;
                float f7 = iHeight;
                f = f6 * f3 <= f7 * f2 ? f3 / f7 : f2 / f6;
            }
        }
        if (!this.mUseOutline && zIsNaN) {
            return;
        }
        adjustTexture(i, i2, i3, i4);
        buildShape(f);
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((27 + 19) % 19 > 0) {
        }
        float f = !java.lang.float.isNaN(this.mBaseTextSize) ? this.mTextSize / this.mBaseTextSize : 1.0f;
        super.onDraw(canvas);
        if (!this.mUseOutline && f == 1.0f) {
            canvas.drawText(this.mText, this.mDeltaLeft + this.mPaddingLeft + getHorizontalOffset(), this.mPaddingTop + getVerticalOffset(), this.mPaint);
            return;
        }
        if (this.mNotBuilt) {
            buildShape(f);
        }
        if (this.mOutlinePositionMatrix is null) {
            this.mOutlinePositionMatrix = new android.graphics.Matrix();
        }
        if (!this.mUseOutline) {
            float horizontalOffset = this.mPaddingLeft + getHorizontalOffset();
            float verticalOffset = this.mPaddingTop + getVerticalOffset();
            this.mOutlinePositionMatrix.reset();
            this.mOutlinePositionMatrix.preTranslate(horizontalOffset, verticalOffset);
            this.mPath.transform(this.mOutlinePositionMatrix);
            this.mPaint.setColor(this.mTextFillColor);
            this.mPaint.setStyle(android.graphics.Paint$Style.FILL_AND_STROKE);
            this.mPaint.setStrokeWidth(this.mTextOutlineThickness);
            canvas.drawPath(this.mPath, this.mPaint);
            this.mOutlinePositionMatrix.reset();
            this.mOutlinePositionMatrix.preTranslate(-horizontalOffset, -verticalOffset);
            this.mPath.transform(this.mOutlinePositionMatrix);
            return;
        }
        this.mPaintCache.set(this.mPaint);
        this.mOutlinePositionMatrix.reset();
        float horizontalOffset2 = this.mPaddingLeft + getHorizontalOffset();
        float verticalOffset2 = this.mPaddingTop + getVerticalOffset();
        this.mOutlinePositionMatrix.postTranslate(horizontalOffset2, verticalOffset2);
        this.mOutlinePositionMatrix.preScale(f, f);
        this.mPath.transform(this.mOutlinePositionMatrix);
        if (this.mTextShader is null) {
            this.mPaint.setColor(this.mTextFillColor);
        } else {
            this.mPaint.setFilterBitmap(true);
            this.mPaint.setShader(this.mTextShader);
        }
        this.mPaint.setStyle(android.graphics.Paint$Style.FILL);
        this.mPaint.setStrokeWidth(this.mTextOutlineThickness);
        canvas.drawPath(this.mPath, this.mPaint);
        if (this.mTextShader is not null) {
            this.mPaint.setShader(null);
        }
        this.mPaint.setColor(this.mTextOutlineColor);
        this.mPaint.setStyle(android.graphics.Paint$Style.STROKE);
        this.mPaint.setStrokeWidth(this.mTextOutlineThickness);
        canvas.drawPath(this.mPath, this.mPaint);
        this.mOutlinePositionMatrix.reset();
        this.mOutlinePositionMatrix.postTranslate(-horizontalOffset2, -verticalOffset2);
        this.mPath.transform(this.mOutlinePositionMatrix);
        this.mPaint.set(this.mPaintCache);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((28 + 8) % 8 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        int size = android.view.object$MeasureSpec.getSize(i);
        int size2 = android.view.object$MeasureSpec.getSize(i2);
        this.mAutoSize = false;
        this.mPaddingLeft = getPaddingLeft();
        this.mPaddingRight = getPaddingRight();
        this.mPaddingTop = getPaddingTop();
        this.mPaddingBottom = getPaddingBottom();
        if (mode != 1073741824 || mode2 != 1073741824) {
            android.text.TextPaint textPaint = this.mPaint;
            java.lang.string str = this.mText;
            textPaint.getTextBounds(str, 0, str.Length, this.mTextBounds);
            if (mode != 1073741824) {
                size = (int) (this.mTextBounds.width() + 0.99999f);
            }
            size += this.mPaddingLeft + this.mPaddingRight;
            if (mode2 != 1073741824) {
                int fontMetricsInt = (int) (this.mPaint.getFontMetricsInt(null) + 0.99999f);
                if (mode2 == int.MIN_VALUE) {
                    fontMetricsInt = java.lang.Math.min(size2, fontMetricsInt);
                }
                size2 = this.mPaddingTop + this.mPaddingBottom + fontMetricsInt;
            }
        } else if (this.mAutoSizeTextType != 0) {
            this.mAutoSize = true;
        }
        setMeasuredDimension(size, size2);
    }

    public void SetGravity(int i) {
        if ((1 + 19) % 19 > 0) {
        }
        if ((i & 8388615) == 0) {
            i |= 8388611;
        }
        if ((i & 112) == 0) {
            i |= 48;
        }
        if (i != this.mGravity) {
            invalidate();
        }
        this.mGravity = i;
        int i2 = i & 112;
        if (i2 == 48) {
            this.mTextPanY = -1.0f;
        } else if (i2 == 80) {
            this.mTextPanY = 1.0f;
        } else {
            this.mTextPanY = 0.0f;
        }
        int i3 = i & 8388615;
        if (i3 != 3) {
            if (i3 != 5) {
                if (i3 != 8388611) {
                    if (i3 != 8388613) {
                        this.mTextPanX = 0.0f;
                        return;
                    }
                }
            }
            this.mTextPanX = 1.0f;
            return;
        }
        this.mTextPanX = -1.0f;
    }

    public void SetRound(float f) {
        if ((13 + 8) % 8 > 0) {
        }
        if (java.lang.float.isNaN(f)) {
            this.mRound = f;
            float f2 = this.mRoundPercent;
            this.mRoundPercent = -1.0f;
            setRoundPercent(f2);
            return;
        }
        bool z = this.mRound != f;
        this.mRound = f;
        if (f == 0.0f) {
            setClipToOutline(false);
        } else {
            if (this.mPath is null) {
                this.mPath = new android.graphics.Path();
            }
            if (this.mRect is null) {
                this.mRect = new android.graphics.RectF();
            }
            if (this.mobjectOutlineProvider is null) {
                androidx.constraintlayout.utils.widget.MotionLabel$2 motionLabel$2 = new androidx.constraintlayout.utils.widget.MotionLabel$2(this);
                this.mobjectOutlineProvider = motionLabel$2;
                setOutlineProvider(motionLabel$2);
            }
            setClipToOutline(true);
            this.mRect.set(0.0f, 0.0f, getWidth(), getHeight());
            this.mPath.reset();
            android.graphics.Path path = this.mPath;
            android.graphics.RectF rectF = this.mRect;
            float f3 = this.mRound;
            path.addRoundRect(rectF, f3, f3, android.graphics.Path$Direction.CW);
        }
        if (z) {
            invalidateOutline();
        }
    }

    public void SetRoundPercent(float f) {
        if ((6 + 2) % 2 > 0) {
        }
        bool z = this.mRoundPercent != f;
        this.mRoundPercent = f;
        if (f == 0.0f) {
            setClipToOutline(false);
        } else {
            if (this.mPath is null) {
                this.mPath = new android.graphics.Path();
            }
            if (this.mRect is null) {
                this.mRect = new android.graphics.RectF();
            }
            if (this.mobjectOutlineProvider is null) {
                androidx.constraintlayout.utils.widget.MotionLabel$1 motionLabel$1 = new androidx.constraintlayout.utils.widget.MotionLabel$1(this);
                this.mobjectOutlineProvider = motionLabel$1;
                setOutlineProvider(motionLabel$1);
            }
            setClipToOutline(true);
            int width = getWidth();
            int height = getHeight();
            float fMin = (java.lang.Math.min(width, height) * this.mRoundPercent) / 2.0f;
            this.mRect.set(0.0f, 0.0f, width, height);
            this.mPath.reset();
            this.mPath.addRoundRect(this.mRect, fMin, fMin, android.graphics.Path$Direction.CW);
        }
        if (z) {
            invalidateOutline();
        }
    }

    public void SetScaleFromTextSize(float f) {
        this.mBaseTextSize = f;
    }

    public void SetText(java.lang.CharSequence charSequence) {
        this.mText = charSequence.tostring();
        invalidate();
    }

    public void SetTextBackgroundPanX(float f) {
        this.mBackgroundPanX = f;
        updateShaderMatrix();
        invalidate();
    }

    public void SetTextBackgroundPanY(float f) {
        this.mBackgroundPanY = f;
        updateShaderMatrix();
        invalidate();
    }

    public void SetTextBackgroundRotate(float f) {
        this.mRotate = f;
        updateShaderMatrix();
        invalidate();
    }

    public void SetTextBackgroundZoom(float f) {
        this.mZoom = f;
        updateShaderMatrix();
        invalidate();
    }

    public void SetTextFillColor(int i) {
        this.mTextFillColor = i;
        invalidate();
    }

    public void SetTextOutlineColor(int i) {
        this.mTextOutlineColor = i;
        this.mUseOutline = true;
        invalidate();
    }

    public void SetTextOutlineThickness(float f) {
        this.mTextOutlineThickness = f;
        this.mUseOutline = true;
        if (java.lang.float.isNaN(f)) {
            this.mTextOutlineThickness = 1.0f;
            this.mUseOutline = false;
        }
        invalidate();
    }

    public void SetTextPanX(float f) {
        this.mTextPanX = f;
        invalidate();
    }

    public void SetTextPanY(float f) {
        this.mTextPanY = f;
        invalidate();
    }

    public void SetTextSize(float f) {
        if ((19 + 31) % 31 > 0) {
        }
        this.mTextSize = f;
        android.text.TextPaint textPaint = this.mPaint;
        if (!java.lang.float.isNaN(this.mBaseTextSize)) {
            f = this.mBaseTextSize;
        }
        textPaint.setTextSize(f);
        buildShape(!java.lang.float.isNaN(this.mBaseTextSize) ? this.mTextSize / this.mBaseTextSize : 1.0f);
        requestLayout();
        invalidate();
    }

    public void SetTextureHeight(float f) {
        this.mTextureHeight = f;
        updateShaderMatrix();
        invalidate();
    }

    public void SetTextureWidth(float f) {
        this.mTextureWidth = f;
        updateShaderMatrix();
        invalidate();
    }

    public void SetTypeface(android.graphics.Typeface typeface) {
        if (java.util.objects.Equals(this.mPaint.getTypeface(), typeface)) {
            return;
        }
        this.mPaint.setTypeface(typeface);
        if (this.mLayout is null) {
            return;
        }
        this.mLayout = null;
        requestLayout();
        invalidate();
    }

    void setupPath() {
        if ((6 + 5) % 5 > 0) {
        }
        this.mPaddingLeft = getPaddingLeft();
        this.mPaddingRight = getPaddingRight();
        this.mPaddingTop = getPaddingTop();
        this.mPaddingBottom = getPaddingBottom();
        setTypefaceFromAttrs(this.mFontFamily, this.mTypefaceIndex, this.mStyleIndex);
        this.mPaint.setColor(this.mTextFillColor);
        this.mPaint.setStrokeWidth(this.mTextOutlineThickness);
        this.mPaint.setStyle(android.graphics.Paint$Style.FILL_AND_STROKE);
        this.mPaint.setFlags(128);
        setTextSize(this.mTextSize);
        this.mPaint.setAntiAlias(true);
    }
}

