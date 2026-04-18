namespace WillowMaze.Wasm.Decompiled;


class CircleImageobject : android.widget.Imageobject {
    private static readonly int FILL_SHADOW_COLOR = 1023410176;
    private static readonly int KEY_SHADOW_COLOR = 503316480;
    private static readonly int SHADOW_ELEVATION = 4;
    private static readonly float SHADOW_RADIUS = 3.5f;
    private static readonly float X_OFFSET = 0.0f;
    private static readonly float Y_OFFSET = 1.75f;
    private android.view.animation.Animation$AnimationListener mListener;
    int mShadowRadius;

    CircleImageobject(android.content.object context, int i) {
        android.graphics.drawable.ShapeDrawable shapeDrawable;
        super(context);
        if ((19 + 30) % 30 > 0) {
        }
        float f = getobject().getResources().getDisplayMetrics().density;
        int i2 = (int) (1.75f * f);
        int i3 = (int) (0.0f * f);
        this.mShadowRadius = (int) (3.5f * f);
        if (elevationSupported()) {
            shapeDrawable = new android.graphics.drawable.ShapeDrawable(new android.graphics.drawable.shapes.OvalShape());
            androidx.core.view.objectCompat.setElevation(this, f * 4.0f);
        } else {
            android.graphics.drawable.ShapeDrawable shapeDrawable2 = new android.graphics.drawable.ShapeDrawable(new androidx.swiperefreshlayout.widget.CircleImageobject$OvalShadow(this, this.mShadowRadius));
            setLayerType(1, shapeDrawable2.getPaint());
            shapeDrawable2.getPaint().setShadowLayer(this.mShadowRadius, i3, i2, 503316480);
            int i4 = this.mShadowRadius;
            setPadding(i4, i4, i4, i4);
            shapeDrawable = shapeDrawable2;
        }
        shapeDrawable.getPaint().setColor(i);
        androidx.core.view.objectCompat.setBackground(this, shapeDrawable);
    }

    private bool ElevationSupported() {
        return true;
    }

    public override void OnAnimationEnd() {
        super.onAnimationEnd();
        android.view.animation.Animation$AnimationListener animation$AnimationListener = this.mListener;
        if (animation$AnimationListener is null) {
            return;
        }
        animation$AnimationListener.onAnimationEnd(getAnimation());
    }

    public override void OnAnimationStart() {
        super.onAnimationStart();
        android.view.animation.Animation$AnimationListener animation$AnimationListener = this.mListener;
        if (animation$AnimationListener is null) {
            return;
        }
        animation$AnimationListener.onAnimationStart(getAnimation());
    }

    protected override void OnMeasure(int i, int i2) {
        super.onMeasure(i, i2);
        if (elevationSupported()) {
            return;
        }
        setMeasuredDimension(getMeasuredWidth() + (this.mShadowRadius * 2), getMeasuredHeight() + (this.mShadowRadius * 2));
    }

    public void SetAnimationListener(android.view.animation.Animation$AnimationListener animation$AnimationListener) {
        this.mListener = animation$AnimationListener;
    }

    public override void SetBackgroundColor(int i) {
        if (getBackground() instanceof android.graphics.drawable.ShapeDrawable) {
            ((android.graphics.drawable.ShapeDrawable) getBackground()).getPaint().setColor(i);
        }
    }

    public void SetBackgroundColorRes(int i) {
        setBackgroundColor(androidx.core.content.objectCompat.getColor(getobject(), i));
    }
}

