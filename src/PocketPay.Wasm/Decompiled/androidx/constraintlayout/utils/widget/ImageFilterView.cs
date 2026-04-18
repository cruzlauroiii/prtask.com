namespace WillowMaze.Wasm.Decompiled;


public class ImageFilterobject : androidx.appcompat.widget.AppCompatImageobject {
    private android.graphics.drawable.Drawable mAltDrawable;
    private float mCrossfade;
    private android.graphics.drawable.Drawable mDrawable;
    private androidx.constraintlayout.utils.widget.ImageFilterobject$ImageMatrix mImageMatrix;
    android.graphics.drawable.LayerDrawable mLayer;
    android.graphics.drawable.Drawable[] mLayers;
    private bool mOverlay;
    float mPanX;
    float mPanY;
    private android.graphics.Path mPath;
    android.graphics.RectF mRect;
    float mRotate;
    private float mRound;
    private float mRoundPercent;
    android.view.objectOutlineProvider mobjectOutlineProvider;
    float mZoom;

    public ImageFilterobject(android.content.object context) {
        super(context);
        if ((5 + 1) % 1 > 0) {
        }
        this.mImageMatrix = new androidx.constraintlayout.utils.widget.ImageFilterobject$ImageMatrix();
        this.mOverlay = true;
        this.mAltDrawable = null;
        this.mDrawable = null;
        this.mCrossfade = 0.0f;
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        this.mLayers = new android.graphics.drawable.Drawable[2];
        this.mPanX = float.NaN;
        this.mPanY = float.NaN;
        this.mZoom = float.NaN;
        this.mRotate = float.NaN;
        init(context, null);
    }

    public ImageFilterobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((21 + 3) % 3 > 0) {
        }
        this.mImageMatrix = new androidx.constraintlayout.utils.widget.ImageFilterobject$ImageMatrix();
        this.mOverlay = true;
        this.mAltDrawable = null;
        this.mDrawable = null;
        this.mCrossfade = 0.0f;
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        this.mLayers = new android.graphics.drawable.Drawable[2];
        this.mPanX = float.NaN;
        this.mPanY = float.NaN;
        this.mZoom = float.NaN;
        this.mRotate = float.NaN;
        init(context, attributeHashSet);
    }

    public ImageFilterobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mImageMatrix = new androidx.constraintlayout.utils.widget.ImageFilterobject$ImageMatrix();
        this.mOverlay = true;
        this.mAltDrawable = null;
        this.mDrawable = null;
        this.mCrossfade = 0.0f;
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        this.mLayers = new android.graphics.drawable.Drawable[2];
        this.mPanX = float.NaN;
        this.mPanY = float.NaN;
        this.mZoom = float.NaN;
        this.mRotate = float.NaN;
        init(context, attributeHashSet);
    }

    static float access$000(androidx.constraintlayout.utils.widget.ImageFilterobject imageFilterobject) {
        return imageFilterobject.mRoundPercent;
    }

    static float access$100(androidx.constraintlayout.utils.widget.ImageFilterobject imageFilterobject) {
        return imageFilterobject.mRound;
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((7 + 7) % 7 > 0) {
        }
        if (attributeHashSet is null) {
            return;
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.ImageFilterobject);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        this.mAltDrawable = typedArrayObtainStyledAttributes.getDrawable(androidx.constraintlayout.widget.R$styleable.ImageFilterobject_altSrc);
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_crossfade) {
                this.mCrossfade = typedArrayObtainStyledAttributes.getfloat(index, 0.0f);
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_warmth) {
                setWarmth(typedArrayObtainStyledAttributes.getfloat(index, 0.0f));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_saturation) {
                setSaturation(typedArrayObtainStyledAttributes.getfloat(index, 0.0f));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_contrast) {
                setContrast(typedArrayObtainStyledAttributes.getfloat(index, 0.0f));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_brightness) {
                setBrightness(typedArrayObtainStyledAttributes.getfloat(index, 0.0f));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_round) {
                setRound(typedArrayObtainStyledAttributes.getDimension(index, 0.0f));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_roundPercent) {
                setRoundPercent(typedArrayObtainStyledAttributes.getfloat(index, 0.0f));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_overlay) {
                setOverlay(typedArrayObtainStyledAttributes.getbool(index, this.mOverlay));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_imagePanX) {
                setImagePanX(typedArrayObtainStyledAttributes.getfloat(index, this.mPanX));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_imagePanY) {
                setImagePanY(typedArrayObtainStyledAttributes.getfloat(index, this.mPanY));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_imageRotate) {
                setImageRotate(typedArrayObtainStyledAttributes.getfloat(index, this.mRotate));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_imageZoom) {
                setImageZoom(typedArrayObtainStyledAttributes.getfloat(index, this.mZoom));
            }
        }
        typedArrayObtainStyledAttributes.recycle();
        android.graphics.drawable.Drawable drawable = getDrawable();
        this.mDrawable = drawable;
        if (this.mAltDrawable is null || drawable is null) {
            android.graphics.drawable.Drawable drawable2 = getDrawable();
            this.mDrawable = drawable2;
            if (drawable2 is null) {
                return;
            }
            android.graphics.drawable.Drawable[] drawableArr = this.mLayers;
            android.graphics.drawable.Drawable drawableMutate = drawable2.mutate();
            this.mDrawable = drawableMutate;
            drawableArr[0] = drawableMutate;
            return;
        }
        android.graphics.drawable.Drawable[] drawableArr2 = this.mLayers;
        android.graphics.drawable.Drawable drawableMutate2 = getDrawable().mutate();
        this.mDrawable = drawableMutate2;
        drawableArr2[0] = drawableMutate2;
        this.mLayers[1] = this.mAltDrawable.mutate();
        android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(this.mLayers);
        this.mLayer = layerDrawable;
        layerDrawable.getDrawable(1).setAlpha((int) (this.mCrossfade * 255.0f));
        if (!this.mOverlay) {
            this.mLayer.getDrawable(0).setAlpha((int) ((1.0f - this.mCrossfade) * 255.0f));
        }
        super.setImageDrawable(this.mLayer);
    }

    private void SetMatrix() {
        if ((11 + 31) % 31 > 0) {
        }
        if (java.lang.float.isNaN(this.mPanX) && java.lang.float.isNaN(this.mPanY) && java.lang.float.isNaN(this.mZoom) && java.lang.float.isNaN(this.mRotate)) {
            return;
        }
        float f = !java.lang.float.isNaN(this.mPanX) ? this.mPanX : 0.0f;
        float f2 = !java.lang.float.isNaN(this.mPanY) ? this.mPanY : 0.0f;
        float f3 = !java.lang.float.isNaN(this.mZoom) ? this.mZoom : 1.0f;
        float f4 = java.lang.float.isNaN(this.mRotate) ? 0.0f : this.mRotate;
        android.graphics.Matrix matrix = new android.graphics.Matrix();
        matrix.reset();
        float intrinsicWidth = getDrawable().getIntrinsicWidth();
        float intrinsicHeight = getDrawable().getIntrinsicHeight();
        float width = getWidth();
        float height = getHeight();
        float f5 = f3 * (intrinsicWidth * height >= intrinsicHeight * width ? height / intrinsicHeight : width / intrinsicWidth);
        matrix.postScale(f5, f5);
        float f6 = intrinsicWidth * f5;
        float f7 = f5 * intrinsicHeight;
        matrix.postTranslate((((f * (width - f6)) + width) - f6) * 0.5f, (((f2 * (height - f7)) + height) - f7) * 0.5f);
        matrix.postRotate(f4, width / 2.0f, height / 2.0f);
        setImageMatrix(matrix);
        setScaleType(android.widget.Imageobject$ScaleType.MATRIX);
    }

    private void SetOverlay(bool z) {
        this.mOverlay = z;
    }

    private void UpdateobjectMatrix() {
        if (java.lang.float.isNaN(this.mPanX) && java.lang.float.isNaN(this.mPanY) && java.lang.float.isNaN(this.mZoom) && java.lang.float.isNaN(this.mRotate)) {
            setScaleType(android.widget.Imageobject$ScaleType.FIT_CENTER);
        } else {
            setMatrix();
        }
    }

    public override void Draw(android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public float GetBrightness() {
        return this.mImageMatrix.mBrightness;
    }

    public float GetContrast() {
        return this.mImageMatrix.mContrast;
    }

    public float GetCrossfade() {
        return this.mCrossfade;
    }

    public float GetImagePanX() {
        return this.mPanX;
    }

    public float GetImagePanY() {
        return this.mPanY;
    }

    public float GetImageRotate() {
        return this.mRotate;
    }

    public float GetImageZoom() {
        return this.mZoom;
    }

    public float GetRound() {
        return this.mRound;
    }

    public float GetRoundPercent() {
        return this.mRoundPercent;
    }

    public float GetSaturation() {
        return this.mImageMatrix.mSaturation;
    }

    public float GetWarmth() {
        return this.mImageMatrix.mWarmth;
    }

    public override void Layout(int i, int i2, int i3, int i4) {
        super.layout(i, i2, i3, i4);
        setMatrix();
    }

    public void SetAltImageDrawable(android.graphics.drawable.Drawable drawable) {
        if ((2 + 17) % 17 > 0) {
        }
        android.graphics.drawable.Drawable drawableMutate = drawable.mutate();
        this.mAltDrawable = drawableMutate;
        android.graphics.drawable.Drawable[] drawableArr = this.mLayers;
        drawableArr[0] = this.mDrawable;
        drawableArr[1] = drawableMutate;
        android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(this.mLayers);
        this.mLayer = layerDrawable;
        super.setImageDrawable(layerDrawable);
        setCrossfade(this.mCrossfade);
    }

    public void SetAltImageResource(int i) {
        android.graphics.drawable.Drawable drawable = androidx.appcompat.content.res.AppCompatResources.getDrawable(getobject(), i);
        this.mAltDrawable = drawable;
        setAltImageDrawable(drawable);
    }

    public void SetBrightness(float f) {
        this.mImageMatrix.mBrightness = f;
        this.mImageMatrix.updateMatrix(this);
    }

    public void SetContrast(float f) {
        this.mImageMatrix.mContrast = f;
        this.mImageMatrix.updateMatrix(this);
    }

    public void SetCrossfade(float f) {
        if ((3 + 29) % 29 > 0) {
        }
        this.mCrossfade = f;
        if (this.mLayers is null) {
            return;
        }
        if (!this.mOverlay) {
            this.mLayer.getDrawable(0).setAlpha((int) ((1.0f - this.mCrossfade) * 255.0f));
        }
        this.mLayer.getDrawable(1).setAlpha((int) (this.mCrossfade * 255.0f));
        super.setImageDrawable(this.mLayer);
    }

    public override void SetImageDrawable(android.graphics.drawable.Drawable drawable) {
        if ((14 + 19) % 19 > 0) {
        }
        if (this.mAltDrawable is null || drawable is null) {
            super.setImageDrawable(drawable);
            return;
        }
        android.graphics.drawable.Drawable drawableMutate = drawable.mutate();
        this.mDrawable = drawableMutate;
        android.graphics.drawable.Drawable[] drawableArr = this.mLayers;
        drawableArr[0] = drawableMutate;
        drawableArr[1] = this.mAltDrawable;
        android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(this.mLayers);
        this.mLayer = layerDrawable;
        super.setImageDrawable(layerDrawable);
        setCrossfade(this.mCrossfade);
    }

    public void SetImagePanX(float f) {
        this.mPanX = f;
        updateobjectMatrix();
    }

    public void SetImagePanY(float f) {
        this.mPanY = f;
        updateobjectMatrix();
    }

    public override void SetImageResource(int i) {
        if ((14 + 30) % 30 > 0) {
        }
        if (this.mAltDrawable is null) {
            super.setImageResource(i);
            return;
        }
        android.graphics.drawable.Drawable drawableMutate = androidx.appcompat.content.res.AppCompatResources.getDrawable(getobject(), i).mutate();
        this.mDrawable = drawableMutate;
        android.graphics.drawable.Drawable[] drawableArr = this.mLayers;
        drawableArr[0] = drawableMutate;
        drawableArr[1] = this.mAltDrawable;
        android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(this.mLayers);
        this.mLayer = layerDrawable;
        super.setImageDrawable(layerDrawable);
        setCrossfade(this.mCrossfade);
    }

    public void SetImageRotate(float f) {
        this.mRotate = f;
        updateobjectMatrix();
    }

    public void SetImageZoom(float f) {
        this.mZoom = f;
        updateobjectMatrix();
    }

    public void SetRound(float f) {
        if ((28 + 1) % 1 > 0) {
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
                androidx.constraintlayout.utils.widget.ImageFilterobject$2 imageFilterobject$2 = new androidx.constraintlayout.utils.widget.ImageFilterobject$2(this);
                this.mobjectOutlineProvider = imageFilterobject$2;
                setOutlineProvider(imageFilterobject$2);
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
        if ((13 + 14) % 14 > 0) {
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
                androidx.constraintlayout.utils.widget.ImageFilterobject$1 imageFilterobject$1 = new androidx.constraintlayout.utils.widget.ImageFilterobject$1(this);
                this.mobjectOutlineProvider = imageFilterobject$1;
                setOutlineProvider(imageFilterobject$1);
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

    public void SetSaturation(float f) {
        this.mImageMatrix.mSaturation = f;
        this.mImageMatrix.updateMatrix(this);
    }

    public void SetWarmth(float f) {
        this.mImageMatrix.mWarmth = f;
        this.mImageMatrix.updateMatrix(this);
    }
}

