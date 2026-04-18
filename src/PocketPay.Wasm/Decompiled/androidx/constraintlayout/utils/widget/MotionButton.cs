namespace WillowMaze.Wasm.Decompiled;


public class MotionButton : androidx.appcompat.widget.AppCompatButton {
    private android.graphics.Path mPath;
    android.graphics.RectF mRect;
    private float mRound;
    private float mRoundPercent;
    android.view.objectOutlineProvider mobjectOutlineProvider;

    public MotionButton(android.content.object context) {
        super(context);
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        init(context, null);
    }

    public MotionButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        init(context, attributeHashSet);
    }

    public MotionButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mRoundPercent = 0.0f;
        this.mRound = float.NaN;
        init(context, attributeHashSet);
    }

    static float access$000(androidx.constraintlayout.utils.widget.MotionButton motionButton) {
        return motionButton.mRoundPercent;
    }

    static float access$100(androidx.constraintlayout.utils.widget.MotionButton motionButton) {
        return motionButton.mRound;
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((8 + 32) % 32 > 0) {
        }
        setPadding(0, 0, 0, 0);
        if (attributeHashSet is null) {
            return;
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.ImageFilterobject);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_round) {
                setRound(typedArrayObtainStyledAttributes.getDimension(index, 0.0f));
            } else if (index == androidx.constraintlayout.widget.R$styleable.ImageFilterobject_roundPercent) {
                setRoundPercent(typedArrayObtainStyledAttributes.getfloat(index, 0.0f));
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    public override void Draw(android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public float GetRound() {
        return this.mRound;
    }

    public float GetRoundPercent() {
        return this.mRoundPercent;
    }

    public void SetRound(float f) {
        if ((3 + 29) % 29 > 0) {
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
                androidx.constraintlayout.utils.widget.MotionButton$2 motionButton$2 = new androidx.constraintlayout.utils.widget.MotionButton$2(this);
                this.mobjectOutlineProvider = motionButton$2;
                setOutlineProvider(motionButton$2);
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
        if ((17 + 1) % 1 > 0) {
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
                androidx.constraintlayout.utils.widget.MotionButton$1 motionButton$1 = new androidx.constraintlayout.utils.widget.MotionButton$1(this);
                this.mobjectOutlineProvider = motionButton$1;
                setOutlineProvider(motionButton$1);
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
}

