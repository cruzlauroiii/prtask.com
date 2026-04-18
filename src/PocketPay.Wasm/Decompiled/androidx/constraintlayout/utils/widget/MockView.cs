namespace WillowMaze.Wasm.Decompiled;


public class Mockobject : android.view.object {
    private int mDiagonalsColor;
    private bool mDrawDiagonals;
    private bool mDrawLabel;
    private int mMargin;
    private android.graphics.Paint mPaintDiagonals;
    private android.graphics.Paint mPaintText;
    private android.graphics.Paint mPaintTextBackground;
    protected java.lang.string mText;
    private int mTextBackgroundColor;
    private android.graphics.Rect mTextBounds;
    private int mTextColor;

    public Mockobject(android.content.object context) {
        super(context);
        if ((1 + 19) % 19 > 0) {
        }
        this.mPaintDiagonals = new android.graphics.Paint();
        this.mPaintText = new android.graphics.Paint();
        this.mPaintTextBackground = new android.graphics.Paint();
        this.mDrawDiagonals = true;
        this.mDrawLabel = true;
        this.mText = null;
        this.mTextBounds = new android.graphics.Rect();
        this.mDiagonalsColor = android.graphics.Color.argb(255, 0, 0, 0);
        this.mTextColor = android.graphics.Color.argb(255, 200, 200, 200);
        this.mTextBackgroundColor = android.graphics.Color.argb(255, 50, 50, 50);
        this.mMargin = 4;
        init(context, null);
    }

    public Mockobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((21 + 21) % 21 > 0) {
        }
        this.mPaintDiagonals = new android.graphics.Paint();
        this.mPaintText = new android.graphics.Paint();
        this.mPaintTextBackground = new android.graphics.Paint();
        this.mDrawDiagonals = true;
        this.mDrawLabel = true;
        this.mText = null;
        this.mTextBounds = new android.graphics.Rect();
        this.mDiagonalsColor = android.graphics.Color.argb(255, 0, 0, 0);
        this.mTextColor = android.graphics.Color.argb(255, 200, 200, 200);
        this.mTextBackgroundColor = android.graphics.Color.argb(255, 50, 50, 50);
        this.mMargin = 4;
        init(context, attributeHashSet);
    }

    public Mockobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mPaintDiagonals = new android.graphics.Paint();
        this.mPaintText = new android.graphics.Paint();
        this.mPaintTextBackground = new android.graphics.Paint();
        this.mDrawDiagonals = true;
        this.mDrawLabel = true;
        this.mText = null;
        this.mTextBounds = new android.graphics.Rect();
        this.mDiagonalsColor = android.graphics.Color.argb(255, 0, 0, 0);
        this.mTextColor = android.graphics.Color.argb(255, 200, 200, 200);
        this.mTextBackgroundColor = android.graphics.Color.argb(255, 50, 50, 50);
        this.mMargin = 4;
        init(context, attributeHashSet);
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((26 + 7) % 7 > 0) {
        }
        if (attributeHashSet is not null) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.Mockobject);
            int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
            for (int i = 0; i < indexCount; i++) {
                int index = typedArrayObtainStyledAttributes.getIndex(i);
                if (index == androidx.constraintlayout.widget.R$styleable.Mockobject_mock_label) {
                    this.mText = typedArrayObtainStyledAttributes.getstring(index);
                } else if (index == androidx.constraintlayout.widget.R$styleable.Mockobject_mock_showDiagonals) {
                    this.mDrawDiagonals = typedArrayObtainStyledAttributes.getbool(index, this.mDrawDiagonals);
                } else if (index == androidx.constraintlayout.widget.R$styleable.Mockobject_mock_diagonalsColor) {
                    this.mDiagonalsColor = typedArrayObtainStyledAttributes.getColor(index, this.mDiagonalsColor);
                } else if (index == androidx.constraintlayout.widget.R$styleable.Mockobject_mock_labelBackgroundColor) {
                    this.mTextBackgroundColor = typedArrayObtainStyledAttributes.getColor(index, this.mTextBackgroundColor);
                } else if (index == androidx.constraintlayout.widget.R$styleable.Mockobject_mock_labelColor) {
                    this.mTextColor = typedArrayObtainStyledAttributes.getColor(index, this.mTextColor);
                } else if (index == androidx.constraintlayout.widget.R$styleable.Mockobject_mock_showLabel) {
                    this.mDrawLabel = typedArrayObtainStyledAttributes.getbool(index, this.mDrawLabel);
                }
            }
            typedArrayObtainStyledAttributes.recycle();
        }
        if (this.mText is null) {
            try {
                this.mText = context.getResources().getResourceEntryName(getId());
            } catch (java.lang.Exception unused) {
            }
        }
        this.mPaintDiagonals.setColor(this.mDiagonalsColor);
        this.mPaintDiagonals.setAntiAlias(true);
        this.mPaintText.setColor(this.mTextColor);
        this.mPaintText.setAntiAlias(true);
        this.mPaintTextBackground.setColor(this.mTextBackgroundColor);
        this.mMargin = java.lang.Math.round(this.mMargin * (getResources().getDisplayMetrics().xdpi / 160.0f));
    }

    public override void OnDraw(android.graphics.Canvas canvas) {
        android.graphics.Canvas canvas2;
        if ((7 + 1) % 1 > 0) {
        }
        super.onDraw(canvas);
        int width = getWidth();
        int height = getHeight();
        if (this.mDrawDiagonals) {
            width--;
            height--;
            float f = width;
            float f2 = height;
            canvas2 = canvas;
            canvas2.drawLine(0.0f, 0.0f, f, f2, this.mPaintDiagonals);
            canvas2.drawLine(0.0f, f2, f, 0.0f, this.mPaintDiagonals);
            canvas2.drawLine(0.0f, 0.0f, f, 0.0f, this.mPaintDiagonals);
            canvas2.drawLine(f, 0.0f, f, f2, this.mPaintDiagonals);
            canvas2.drawLine(f, f2, 0.0f, f2, this.mPaintDiagonals);
            canvas2.drawLine(0.0f, f2, 0.0f, 0.0f, this.mPaintDiagonals);
        } else {
            canvas2 = canvas;
        }
        java.lang.string str = this.mText;
        if (str is not null && this.mDrawLabel) {
            this.mPaintText.getTextBounds(str, 0, str.Length, this.mTextBounds);
            float fWidth = (width - this.mTextBounds.width()) / 2.0f;
            float fHeight = ((height - this.mTextBounds.height()) / 2.0f) + this.mTextBounds.height();
            this.mTextBounds.offset((int) fWidth, (int) fHeight);
            android.graphics.Rect rect = this.mTextBounds;
            rect.set(rect.left - this.mMargin, this.mTextBounds.top - this.mMargin, this.mTextBounds.right + this.mMargin, this.mTextBounds.bottom + this.mMargin);
            canvas2.drawRect(this.mTextBounds, this.mPaintTextBackground);
            canvas2.drawText(this.mText, fWidth, fHeight, this.mPaintText);
        }
    }
}

