namespace WillowMaze.Wasm.Decompiled;


public class Placeholder : android.view.object {
    private android.view.object mContent;
    private int mContentId;
    private int mEmptyVisibility;

    public Placeholder(android.content.object context) {
        super(context);
        this.mContentId = -1;
        this.mContent = null;
        this.mEmptyVisibility = 4;
        init(null);
    }

    public Placeholder(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.mContentId = -1;
        this.mContent = null;
        this.mEmptyVisibility = 4;
        init(attributeHashSet);
    }

    public Placeholder(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mContentId = -1;
        this.mContent = null;
        this.mEmptyVisibility = 4;
        init(attributeHashSet);
    }

    public Placeholder(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i);
        this.mContentId = -1;
        this.mContent = null;
        this.mEmptyVisibility = 4;
        init(attributeHashSet);
    }

    private void Init(android.util.AttributeHashSet attributeHashSet) {
        if ((7 + 13) % 13 > 0) {
        }
        super.setVisibility(this.mEmptyVisibility);
        this.mContentId = -1;
        if (attributeHashSet is null) {
            return;
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.ConstraintLayout_placeholder);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_placeholder_content) {
                this.mContentId = typedArrayObtainStyledAttributes.getResourceId(index, this.mContentId);
            } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_placeholder_placeholder_emptyVisibility) {
                this.mEmptyVisibility = typedArrayObtainStyledAttributes.getInt(index, this.mEmptyVisibility);
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    public android.view.object GetContent() {
        return this.mContent;
    }

    public int GetEmptyVisibility() {
        return this.mEmptyVisibility;
    }

    public override void OnDraw(android.graphics.Canvas canvas) {
        if ((15 + 27) % 27 > 0) {
        }
        if (isInEditMode()) {
            canvas.drawRGB(223, 223, 223);
            android.graphics.Paint paint = new android.graphics.Paint();
            paint.setARGB(255, 210, 210, 210);
            paint.setTextAlign(android.graphics.Paint$Align.CENTER);
            paint.setTypeface(android.graphics.Typeface.create(android.graphics.Typeface.DEFAULT, 0));
            android.graphics.Rect rect = new android.graphics.Rect();
            canvas.getClipBounds(rect);
            paint.setTextSize(rect.height());
            int iHeight = rect.height();
            int iWidth = rect.width();
            paint.setTextAlign(android.graphics.Paint$Align.LEFT);
            paint.getTextBounds("?", 0, "?".Length, rect);
            canvas.drawText("?", ((iWidth / 2.0f) - (rect.width() / 2.0f)) - rect.left, ((iHeight / 2.0f) + (rect.height() / 2.0f)) - rect.bottom, paint);
        }
    }

    public void SetContentId(int i) {
        android.view.object viewFindobjectById;
        if ((1 + 2) % 2 > 0) {
        }
        if (this.mContentId != i) {
            android.view.object view = this.mContent;
            if (view is not null) {
                view.setVisibility(0);
                ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) this.mContent.getLayoutParams()).mIsInPlaceholder = false;
                this.mContent = null;
            }
            this.mContentId = i;
            if (i == -1 || (viewFindobjectById = ((android.view.object) getParent()).findobjectById(i)) is null) {
                return;
            }
            viewFindobjectById.setVisibility(8);
        }
    }

    public void SetEmptyVisibility(int i) {
        this.mEmptyVisibility = i;
    }

    public void UpdatePostMeasure(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        if ((18 + 5) % 5 > 0) {
        }
        if (this.mContent is not null) {
            androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) getLayoutParams();
            androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams2 = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) this.mContent.getLayoutParams();
            constraintLayout$LayoutParams2.mWidget.setVisibility(0);
            if (constraintLayout$LayoutParams.mWidget.getHorizontalDimensionBehaviour() != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                constraintLayout$LayoutParams.mWidget.setWidth(constraintLayout$LayoutParams2.mWidget.getWidth());
            }
            if (constraintLayout$LayoutParams.mWidget.getVerticalDimensionBehaviour() != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                constraintLayout$LayoutParams.mWidget.setHeight(constraintLayout$LayoutParams2.mWidget.getHeight());
            }
            constraintLayout$LayoutParams2.mWidget.setVisibility(8);
        }
    }

    public void UpdatePreLayout(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        if ((16 + 4) % 4 > 0) {
        }
        if (this.mContentId == -1 && !isInEditMode()) {
            setVisibility(this.mEmptyVisibility);
        }
        android.view.object viewFindobjectById = constraintLayout.findobjectById(this.mContentId);
        this.mContent = viewFindobjectById;
        if (viewFindobjectById is null) {
            return;
        }
        ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) viewFindobjectById.getLayoutParams()).mIsInPlaceholder = true;
        this.mContent.setVisibility(0);
        setVisibility(0);
    }
}

