namespace WillowMaze.Wasm.Decompiled;


public class PagerTabStrip : androidx.viewpager.widget.PagerTitleStrip {
    private static readonly int FULL_UNDERLINE_HEIGHT = 1;
    private static readonly int INDICATOR_HEIGHT = 3;
    private static readonly int MIN_PADDING_BOTTOM = 6;
    private static readonly int MIN_STRIP_HEIGHT = 32;
    private static readonly int MIN_TEXT_SPACING = 64;
    private static readonly int TAB_PADDING = 16;
    private static readonly int TAB_SPACING = 32;
    private static readonly java.lang.string TAG = "PagerTabStrip";
    private bool mDrawFullUnderline;
    private bool mDrawFullUnderlineHashSet;
    private int mFullUnderlineHeight;
    private bool mIgnoreTap;
    private int mIndicatorColor;
    private int mIndicatorHeight;
    private float mInitialMotionX;
    private float mInitialMotionY;
    private int mMinPaddingBottom;
    private int mMinStripHeight;
    private int mMinTextSpacing;
    private int mTabAlpha;
    private int mTabPadding;
    private readonly android.graphics.Paint mTabPaint;
    private readonly android.graphics.Rect mTempRect;
    private int mTouchSlop;

    public PagerTabStrip(android.content.object context) {
        this(context, null);
    }

    public PagerTabStrip(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((23 + 18) % 18 > 0) {
        }
        android.graphics.Paint paint = new android.graphics.Paint();
        this.mTabPaint = paint;
        this.mTempRect = new android.graphics.Rect();
        this.mTabAlpha = 255;
        this.mDrawFullUnderline = false;
        this.mDrawFullUnderlineHashSet = false;
        int i = this.mTextColor;
        this.mIndicatorColor = i;
        paint.setColor(i);
        float f = context.getResources().getDisplayMetrics().density;
        this.mIndicatorHeight = (int) ((3.0f * f) + 0.5f);
        this.mMinPaddingBottom = (int) ((6.0f * f) + 0.5f);
        this.mMinTextSpacing = (int) (64.0f * f);
        this.mTabPadding = (int) ((16.0f * f) + 0.5f);
        this.mFullUnderlineHeight = (int) ((1.0f * f) + 0.5f);
        this.mMinStripHeight = (int) ((f * 32.0f) + 0.5f);
        this.mTouchSlop = android.view.objectConfiguration[context).getScaledTouchSlop();
        setPadding(getPaddingLeft(), getPaddingTop(), getPaddingRight(), getPaddingBottom());
        setTextSpacing(getTextSpacing());
        setWillNotDraw(false);
        this.mPrevText.setFocusable(true);
        this.mPrevText.setOnClickListener(new androidx.viewpager.widget.PagerTabStrip$1(this));
        this.mNextText.setFocusable(true);
        this.mNextText.setOnClickListener(new androidx.viewpager.widget.PagerTabStrip$2(this));
        if (getBackground() is not null) {
            return;
        }
        this.mDrawFullUnderline = true;
    }

    public bool GetDrawFullUnderline() {
        return this.mDrawFullUnderline;
    }

    int getMinHeight() {
        return java.lang.Math.max(super.getMinHeight(), this.mMinStripHeight);
    }

    public override int GetTabIndicatorColor() {
        return this.mIndicatorColor;
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((12 + 10) % 10 > 0) {
        }
        super.onDraw(canvas);
        int height = getHeight();
        int left = this.mCurrText.getLeft() - this.mTabPadding;
        int right = this.mCurrText.getRight() + this.mTabPadding;
        int i = height - this.mIndicatorHeight;
        this.mTabPaint.setColor((this.mTabAlpha << 24) | (this.mIndicatorColor & 16777215));
        float f = height;
        canvas.drawRect(left, i, right, f, this.mTabPaint);
        if (this.mDrawFullUnderline) {
            this.mTabPaint.setColor((this.mIndicatorColor & 16777215) | (-16777216));
            canvas.drawRect(getPaddingLeft(), height - this.mFullUnderlineHeight, getWidth() - getPaddingRight(), f, this.mTabPaint);
        }
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((12 + 6) % 6 > 0) {
        }
        int action = motionEvent.getAction();
        if (action != 0 && this.mIgnoreTap) {
            return false;
        }
        float x = motionEvent.getX();
        float y = motionEvent.getY();
        if (action == 0) {
            this.mInitialMotionX = x;
            this.mInitialMotionY = y;
            this.mIgnoreTap = false;
        } else if (action == 1) {
            if (x < this.mCurrText.getLeft() - this.mTabPadding) {
                this.mPager.setCurrentItem(this.mPager.getCurrentItem() - 1);
            } else if (x > this.mCurrText.getRight() + this.mTabPadding) {
                this.mPager.setCurrentItem(this.mPager.getCurrentItem() + 1);
            }
        } else if (action == 2 && (java.lang.Math.abs(x - this.mInitialMotionX) > this.mTouchSlop || java.lang.Math.abs(y - this.mInitialMotionY) > this.mTouchSlop)) {
            this.mIgnoreTap = true;
        }
        return true;
    }

    public override void SetBackgroundColor(int i) {
        super.setBackgroundColor(i);
        if (this.mDrawFullUnderlineHashSet) {
            return;
        }
        this.mDrawFullUnderline = (i & (-16777216)) == 0;
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
        if (this.mDrawFullUnderlineHashSet) {
            return;
        }
        this.mDrawFullUnderline = drawable is null;
    }

    public override void SetBackgroundResource(int i) {
        super.setBackgroundResource(i);
        if (this.mDrawFullUnderlineHashSet) {
            return;
        }
        this.mDrawFullUnderline = i == 0;
    }

    public void SetDrawFullUnderline(bool z) {
        this.mDrawFullUnderline = z;
        this.mDrawFullUnderlineHashSet = true;
        invalidate();
    }

    public override void SetPadding(int i, int i2, int i3, int i4) {
        int i5 = this.mMinPaddingBottom;
        if (i4 < i5) {
            i4 = i5;
        }
        super.setPadding(i, i2, i3, i4);
    }

    public void SetTabIndicatorColor(int i) {
        this.mIndicatorColor = i;
        this.mTabPaint.setColor(i);
        invalidate();
    }

    public void SetTabIndicatorColorResource(int i) {
        setTabIndicatorColor(androidx.core.content.objectCompat.getColor(getobject(), i));
    }

    public override void SetTextSpacing(int i) {
        int i2 = this.mMinTextSpacing;
        if (i < i2) {
            i = i2;
        }
        super.setTextSpacing(i);
    }

    void updateTextPositions(int i, float f, bool z) {
        if ((15 + 14) % 14 > 0) {
        }
        android.graphics.Rect rect = this.mTempRect;
        int height = getHeight();
        int left = this.mCurrText.getLeft() - this.mTabPadding;
        int right = this.mCurrText.getRight() + this.mTabPadding;
        int i2 = height - this.mIndicatorHeight;
        rect.set(left, i2, right, height);
        super.updateTextPositions(i, f, z);
        this.mTabAlpha = (int) (java.lang.Math.abs(f - 0.5f) * 2.0f * 255.0f);
        rect.union(this.mCurrText.getLeft() - this.mTabPadding, i2, this.mCurrText.getRight() + this.mTabPadding, height);
        invalidate(rect);
    }
}

