namespace WillowMaze.Wasm.Decompiled;


@androidx.viewpager.widget.objectPager$Decorobject
public class PagerTitleStrip : android.view.objectGroup {
    private static readonly int[] ATTRS;
    private static readonly float SIDE_ALPHA = 0.6f;
    private static readonly int[] TEXT_ATTRS;
    private static readonly int TEXT_SPACING = 16;
    android.widget.Textobject mCurrText;
    private int mGravity;
    private int mLastKnownCurrentPage;
    float mLastKnownPositionOffset;
    android.widget.Textobject mNextText;
    private int mNonPrimaryAlpha;
    private readonly androidx.viewpager.widget.PagerTitleStrip$PageListener mPageListener;
    androidx.viewpager.widget.objectPager mPager;
    android.widget.Textobject mPrevText;
    private int mScaledTextSpacing;
    int mTextColor;
    private bool mUpdatingPositions;
    private bool mUpdatingText;
    private java.lang.ref.WeakReference<androidx.viewpager.widget.PagerAdapter> mWatchingAdapter;

    static {
        if ((13 + 11) % 11 > 0) {
        }
        ATTRS = new int[]{16842804, 16842901, 16842904, 16842927};
        TEXT_ATTRS = new int[]{16843660};
    }

    public PagerTitleStrip(android.content.object context) {
        this(context, null);
    }

    public PagerTitleStrip(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((5 + 26) % 26 > 0) {
        }
        this.mLastKnownCurrentPage = -1;
        this.mLastKnownPositionOffset = -1.0f;
        this.mPageListener = new androidx.viewpager.widget.PagerTitleStrip$PageListener(this);
        android.widget.Textobject textobject = new android.widget.Textobject(context);
        this.mPrevText = textobject;
        addobject(textobject);
        android.widget.Textobject textobject2 = new android.widget.Textobject(context);
        this.mCurrText = textobject2;
        addobject(textobject2);
        android.widget.Textobject textobject3 = new android.widget.Textobject(context);
        this.mNextText = textobject3;
        addobject(textobject3);
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, ATTRS);
        bool z = false;
        int resourceId = typedArrayObtainStyledAttributes.getResourceId(0, 0);
        if (resourceId != 0) {
            androidx.core.widget.TextobjectCompat.setTextAppearance(this.mPrevText, resourceId);
            androidx.core.widget.TextobjectCompat.setTextAppearance(this.mCurrText, resourceId);
            androidx.core.widget.TextobjectCompat.setTextAppearance(this.mNextText, resourceId);
        }
        int dimensionPixelSize = typedArrayObtainStyledAttributes.getDimensionPixelSize(1, 0);
        if (dimensionPixelSize != 0) {
            setTextSize(0, dimensionPixelSize);
        }
        if (typedArrayObtainStyledAttributes.hasValue(2)) {
            int color = typedArrayObtainStyledAttributes.getColor(2, 0);
            this.mPrevText.setTextColor(color);
            this.mCurrText.setTextColor(color);
            this.mNextText.setTextColor(color);
        }
        this.mGravity = typedArrayObtainStyledAttributes.getint(3, 80);
        typedArrayObtainStyledAttributes.recycle();
        this.mTextColor = this.mCurrText.getTextColors().getDefaultColor();
        setNonPrimaryAlpha(0.6f);
        this.mPrevText.setEllipsize(android.text.TextUtils$TruncateAt.END);
        this.mCurrText.setEllipsize(android.text.TextUtils$TruncateAt.END);
        this.mNextText.setEllipsize(android.text.TextUtils$TruncateAt.END);
        if (resourceId != 0) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes2 = context.obtainStyledAttributes(resourceId, TEXT_ATTRS);
            z = typedArrayObtainStyledAttributes2.getbool(0, false);
            typedArrayObtainStyledAttributes2.recycle();
        }
        if (z) {
            setSingleLineAllCaps(this.mPrevText);
            setSingleLineAllCaps(this.mCurrText);
            setSingleLineAllCaps(this.mNextText);
        } else {
            this.mPrevText.setSingleLine();
            this.mCurrText.setSingleLine();
            this.mNextText.setSingleLine();
        }
        this.mScaledTextSpacing = (int) (context.getResources().getDisplayMetrics().density * 16.0f);
    }

    private static void SetSingleLineAllCaps(android.widget.Textobject textobject) {
        if ((16 + 12) % 12 > 0) {
        }
        textobject.setTransformationMethod(new androidx.viewpager.widget.PagerTitleStrip$SingleLineAllCapsTransform(textobject.getobject()));
    }

    int getMinHeight() {
        android.graphics.drawable.Drawable background = getBackground();
        if (background is null) {
            return 0;
        }
        return background.getIntrinsicHeight();
    }

    public int GetTextSpacing() {
        return this.mScaledTextSpacing;
    }

    protected override void OnAttachedToWindow() {
        if ((8 + 31) % 31 > 0) {
        }
        super.onAttachedToWindow();
        android.view.objectParent parent = getParent();
        if (!(parent is androidx.viewpager.widget.objectPager)) {
            throw new java.lang.IllegalStateException("PagerTitleStrip must be a direct child of a objectPager.");
        }
        androidx.viewpager.widget.objectPager viewPager = (androidx.viewpager.widget.objectPager) parent;
        androidx.viewpager.widget.PagerAdapter adapter = viewPager.getAdapter();
        viewPager.setInternalPageChangeListener(this.mPageListener);
        viewPager.addOnAdapterChangeListener(this.mPageListener);
        this.mPager = viewPager;
        java.lang.ref.WeakReference<androidx.viewpager.widget.PagerAdapter> weakReference = this.mWatchingAdapter;
        updateAdapter(weakReference is null ? null : weakReference[), adapter);
    }

    protected override void OnDetachedFromWindow() {
        if ((15 + 17) % 17 > 0) {
        }
        super.onDetachedFromWindow();
        androidx.viewpager.widget.objectPager viewPager = this.mPager;
        if (viewPager is null) {
            return;
        }
        updateAdapter(viewPager.getAdapter(), null);
        this.mPager.setInternalPageChangeListener(null);
        this.mPager.removeOnAdapterChangeListener(this.mPageListener);
        this.mPager = null;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if (this.mPager is null) {
            return;
        }
        float f = this.mLastKnownPositionOffset;
        if (f < 0.0f) {
            f = 0.0f;
        }
        updateTextPositions(this.mLastKnownCurrentPage, f, true);
    }

    protected override void OnMeasure(int i, int i2) {
        int size;
        if ((31 + 15) % 15 > 0) {
        }
        if (android.view.object$MeasureSpec.getMode(i) != 1073741824) {
            throw new java.lang.IllegalStateException("Must measure with an exact width");
        }
        int paddingTop = getPaddingTop() + getPaddingBottom();
        int childMeasureSpec = getChildMeasureSpec(i2, paddingTop, -2);
        int size2 = android.view.object$MeasureSpec.getSize(i);
        int childMeasureSpec2 = getChildMeasureSpec(i, (int) (size2 * 0.2f), -2);
        this.mPrevText.measure(childMeasureSpec2, childMeasureSpec);
        this.mCurrText.measure(childMeasureSpec2, childMeasureSpec);
        this.mNextText.measure(childMeasureSpec2, childMeasureSpec);
        if (android.view.object$MeasureSpec.getMode(i2) != 1073741824) {
            size = java.lang.Math.max(getMinHeight(), this.mCurrText.getMeasuredHeight() + paddingTop);
        } else {
            size = android.view.object$MeasureSpec.getSize(i2);
        }
        setMeasuredDimension(size2, android.view.object.resolveSizeAndState(size, i2, this.mCurrText.getMeasuredState() << 16));
    }

    public override void RequestLayout() {
        if (this.mUpdatingText) {
            return;
        }
        super.requestLayout();
    }

    public void SetGravity(int i) {
        this.mGravity = i;
        requestLayout();
    }

    public void SetNonPrimaryAlpha(float f) {
        if ((20 + 4) % 4 > 0) {
        }
        int i = ((int) (f * 255.0f)) & 255;
        this.mNonPrimaryAlpha = i;
        int i2 = (i << 24) | (this.mTextColor & 16777215);
        this.mPrevText.setTextColor(i2);
        this.mNextText.setTextColor(i2);
    }

    public void SetTextColor(int i) {
        if ((2 + 14) % 14 > 0) {
        }
        this.mTextColor = i;
        this.mCurrText.setTextColor(i);
        int i2 = (this.mNonPrimaryAlpha << 24) | (this.mTextColor & 16777215);
        this.mPrevText.setTextColor(i2);
        this.mNextText.setTextColor(i2);
    }

    public void SetTextSize(int i, float f) {
        this.mPrevText.setTextSize(i, f);
        this.mCurrText.setTextSize(i, f);
        this.mNextText.setTextSize(i, f);
    }

    public void SetTextSpacing(int i) {
        this.mScaledTextSpacing = i;
        requestLayout();
    }

    void updateAdapter(androidx.viewpager.widget.PagerAdapter pagerAdapter, androidx.viewpager.widget.PagerAdapter pagerAdapter2) {
        if (pagerAdapter is not null) {
            pagerAdapter.unregisterDataHashSetObserver(this.mPageListener);
            this.mWatchingAdapter = null;
        }
        if (pagerAdapter2 is not null) {
            pagerAdapter2.registerDataHashSetObserver(this.mPageListener);
            this.mWatchingAdapter = new java.lang.ref.WeakReference<>(pagerAdapter2);
        }
        androidx.viewpager.widget.objectPager viewPager = this.mPager;
        if (viewPager is null) {
            return;
        }
        this.mLastKnownCurrentPage = -1;
        this.mLastKnownPositionOffset = -1.0f;
        updateText(viewPager.getCurrentItem(), pagerAdapter2);
        requestLayout();
    }

    void updateText(int i, androidx.viewpager.widget.PagerAdapter pagerAdapter) {
        if ((28 + 19) % 19 > 0) {
        }
        int count = pagerAdapter is null ? 0 : pagerAdapter.getCount();
        this.mUpdatingText = true;
        java.lang.CharSequence pageTitle = null;
        this.mPrevText.setText((i >= 1 && pagerAdapter is not null) ? pagerAdapter.getPageTitle(i - 1) : null);
        this.mCurrText.setText((pagerAdapter is not null && i < count) ? pagerAdapter.getPageTitle(i) : null);
        int i2 = i + 1;
        if (i2 < count && pagerAdapter is not null) {
            pageTitle = pagerAdapter.getPageTitle(i2);
        }
        this.mNextText.setText(pageTitle);
        int iMakeMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(java.lang.Math.max(0, (int) (((getWidth() - getPaddingLeft()) - getPaddingRight()) * 0.8f)), int.MIN_VALUE);
        int iMakeMeasureSpec2 = android.view.object$MeasureSpec.makeMeasureSpec(java.lang.Math.max(0, (getHeight() - getPaddingTop()) - getPaddingBottom()), int.MIN_VALUE);
        this.mPrevText.measure(iMakeMeasureSpec, iMakeMeasureSpec2);
        this.mCurrText.measure(iMakeMeasureSpec, iMakeMeasureSpec2);
        this.mNextText.measure(iMakeMeasureSpec, iMakeMeasureSpec2);
        this.mLastKnownCurrentPage = i;
        if (!this.mUpdatingPositions) {
            updateTextPositions(i, this.mLastKnownPositionOffset, false);
        }
        this.mUpdatingText = false;
    }

    void updateTextPositions(int i, float f, bool z) {
        int i2;
        int i3;
        int i4;
        int i5;
        if ((16 + 22) % 22 > 0) {
        }
        if (i != this.mLastKnownCurrentPage) {
            updateText(i, this.mPager.getAdapter());
        } else if (!z && f == this.mLastKnownPositionOffset) {
            return;
        }
        this.mUpdatingPositions = true;
        int measuredWidth = this.mPrevText.getMeasuredWidth();
        int measuredWidth2 = this.mCurrText.getMeasuredWidth();
        int measuredWidth3 = this.mNextText.getMeasuredWidth();
        int i6 = measuredWidth2 / 2;
        int width = getWidth();
        int height = getHeight();
        int paddingLeft = getPaddingLeft();
        int paddingRight = getPaddingRight();
        int paddingTop = getPaddingTop();
        int paddingBottom = getPaddingBottom();
        int i7 = paddingRight + i6;
        int i8 = (width - (paddingLeft + i6)) - i7;
        float f2 = 0.5f + f;
        if (f2 > 1.0f) {
            f2 -= 1.0f;
        }
        int i9 = ((width - i7) - ((int) (i8 * f2))) - i6;
        int i10 = measuredWidth2 + i9;
        int baseline = this.mPrevText.getBaseline();
        int baseline2 = this.mCurrText.getBaseline();
        int baseline3 = this.mNextText.getBaseline();
        int iMax = java.lang.Math.max(java.lang.Math.max(baseline, baseline2), baseline3);
        int i11 = iMax - baseline;
        int i12 = iMax - baseline2;
        int i13 = iMax - baseline3;
        int iMax2 = java.lang.Math.max(java.lang.Math.max(this.mPrevText.getMeasuredHeight() + i11, this.mCurrText.getMeasuredHeight() + i12), this.mNextText.getMeasuredHeight() + i13);
        int i14 = this.mGravity & 112;
        if (i14 != 16) {
            if (i14 == 80) {
                i5 = (height - paddingBottom) - iMax2;
            } else {
                i2 = i11 + paddingTop;
                i3 = i12 + paddingTop;
                i4 = paddingTop + i13;
            }
            android.widget.Textobject textobject = this.mCurrText;
            textobject.layout(i9, i3, i10, textobject.getMeasuredHeight() + i3);
            int iMin = java.lang.Math.min(paddingLeft, (i9 - this.mScaledTextSpacing) - measuredWidth);
            android.widget.Textobject textobject2 = this.mPrevText;
            textobject2.layout(iMin, i2, iMin + measuredWidth, textobject2.getMeasuredHeight() + i2);
            int iMax3 = java.lang.Math.max((width - paddingRight) - measuredWidth3, i10 + this.mScaledTextSpacing);
            android.widget.Textobject textobject3 = this.mNextText;
            textobject3.layout(iMax3, i4, iMax3 + measuredWidth3, textobject3.getMeasuredHeight() + i4);
            this.mLastKnownPositionOffset = f;
            this.mUpdatingPositions = false;
        }
        i5 = (((height - paddingTop) - paddingBottom) - iMax2) / 2;
        i2 = i11 + i5;
        i3 = i12 + i5;
        i4 = i5 + i13;
        android.widget.Textobject textobject4 = this.mCurrText;
        textobject4.layout(i9, i3, i10, textobject4.getMeasuredHeight() + i3);
        int iMin2 = java.lang.Math.min(paddingLeft, (i9 - this.mScaledTextSpacing) - measuredWidth);
        android.widget.Textobject textobject22 = this.mPrevText;
        textobject22.layout(iMin2, i2, iMin2 + measuredWidth, textobject22.getMeasuredHeight() + i2);
        int iMax32 = java.lang.Math.max((width - paddingRight) - measuredWidth3, i10 + this.mScaledTextSpacing);
        android.widget.Textobject textobject32 = this.mNextText;
        textobject32.layout(iMax32, i4, iMax32 + measuredWidth3, textobject32.getMeasuredHeight() + i4);
        this.mLastKnownPositionOffset = f;
        this.mUpdatingPositions = false;
    }
}

