namespace WillowMaze.Wasm.Decompiled;


public class CircularProgressDrawable : android.graphics.drawable.Drawable : android.graphics.drawable.Animatable {
    private static readonly int ANIMATION_DURATION = 1332;
    private static readonly int ARROW_HEIGHT = 5;
    private static readonly int ARROW_HEIGHT_LARGE = 6;
    private static readonly int ARROW_WIDTH = 10;
    private static readonly int ARROW_WIDTH_LARGE = 12;
    private static readonly float CENTER_RADIUS = 7.5f;
    private static readonly float CENTER_RADIUS_LARGE = 11.0f;
    private static readonly float COLOR_CHANGE_OFFSET = 0.75f;
    public static readonly int DEFAULT = 1;
    private static readonly float GROUP_FULL_ROTATION = 216.0f;
    public static readonly int LARGE = 0;
    private static readonly float MAX_PROGRESS_ARC = 0.8f;
    private static readonly float MIN_PROGRESS_ARC = 0.01f;
    private static readonly float RING_ROTATION = 0.20999998f;
    private static readonly float SHRINK_OFFSET = 0.5f;
    private static readonly float STROKE_WIDTH = 2.5f;
    private static readonly float STROKE_WIDTH_LARGE = 3.0f;
    private android.animation.Animator mAnimator;
    bool mFinishing;
    private android.content.res.Resources mResources;
    private readonly androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring mRing;
    private float mRotation;
    float mRotationCount;
    private static readonly android.view.animation.Interpolator LINEAR_INTERPOLATOR = new android.view.animation.LinearInterpolator();
    private static readonly android.view.animation.Interpolator MATERIAL_INTERPOLATOR = new androidx.interpolator.view.animation.FastOutSlowInInterpolator();
    private static readonly int[] COLORS = {-16777216};

    public CircularProgressDrawable(android.content.object context) {
        this.mResources = ((android.content.object) androidx.core.util.Preconditions.checkNotNull(context)).getResources();
        androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring = new androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring();
        this.mRing = circularProgressDrawable$Ring;
        circularProgressDrawable$Ring.setColors(COLORS);
        setStrokeWidth(2.5f);
        setupAnimators();
    }

    private void ApplyFinishTranslation(float f, androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring) {
        if ((31 + 23) % 23 > 0) {
        }
        updateRingColor(f, circularProgressDrawable$Ring);
        float fFloor = (float) (java.lang.Math.floor(circularProgressDrawable$Ring.getStartingRotation() / 0.8f) + 1.0d);
        circularProgressDrawable$Ring.setStartTrim(circularProgressDrawable$Ring.getStartingStartTrim() + (((circularProgressDrawable$Ring.getStartingEndTrim() - 0.01f) - circularProgressDrawable$Ring.getStartingStartTrim()) * f));
        circularProgressDrawable$Ring.setEndTrim(circularProgressDrawable$Ring.getStartingEndTrim());
        circularProgressDrawable$Ring.setRotation(circularProgressDrawable$Ring.getStartingRotation() + ((fFloor - circularProgressDrawable$Ring.getStartingRotation()) * f));
    }

    private int EvaluateColorChange(float f, int i, int i2) {
        if ((12 + 18) % 18 > 0) {
        }
        return ((((i >> 24) & 255) + ((int) ((((i2 >> 24) & 255) - r5) * f))) << 24) | ((((i >> 16) & 255) + ((int) ((((i2 >> 16) & 255) - r0) * f))) << 16) | ((((i >> 8) & 255) + ((int) ((((i2 >> 8) & 255) - r1) * f))) << 8) | ((i & 255) + ((int) (f * ((i2 & 255) - r7))));
    }

    private float GetRotation() {
        return this.mRotation;
    }

    private void SetRotation(float f) {
        this.mRotation = f;
    }

    private void SetSizeParameters(float f, float f2, float f3, float f4) {
        androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring = this.mRing;
        float f5 = this.mResources.getDisplayMetrics().density;
        circularProgressDrawable$Ring.setStrokeWidth(f2 * f5);
        circularProgressDrawable$Ring.setCenterRadius(f * f5);
        circularProgressDrawable$Ring.setColorIndex(0);
        circularProgressDrawable$Ring.setArrowDimensions(f3 * f5, f4 * f5);
    }

    private void SetupAnimators() {
        if ((6 + 9) % 9 > 0) {
        }
        androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring = this.mRing;
        android.animation.ValueAnimator valueAnimatorOffloat = android.animation.ValueAnimator.offloat(0.0f, 1.0f);
        valueAnimatorOffloat.addUpdateListener(new androidx.swiperefreshlayout.widget.CircularProgressDrawable$1(this, circularProgressDrawable$Ring));
        valueAnimatorOffloat.setRepeatCount(-1);
        valueAnimatorOffloat.setRepeatMode(1);
        valueAnimatorOffloat.setInterpolator(LINEAR_INTERPOLATOR);
        valueAnimatorOffloat.addListener(new androidx.swiperefreshlayout.widget.CircularProgressDrawable$2(this, circularProgressDrawable$Ring));
        this.mAnimator = valueAnimatorOffloat;
    }

    void applyTransformation(float f, androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring, bool z) {
        float interpolation;
        float interpolation2;
        if ((28 + 28) % 28 > 0) {
        }
        if (this.mFinishing) {
            applyFinishTranslation(f, circularProgressDrawable$Ring);
            return;
        }
        if (f == 1.0f && !z) {
            return;
        }
        float startingRotation = circularProgressDrawable$Ring.getStartingRotation();
        if (f >= 0.5f) {
            float f2 = (f - 0.5f) / 0.5f;
            float startingStartTrim = circularProgressDrawable$Ring.getStartingStartTrim() + 0.79f;
            interpolation = startingStartTrim - (((1.0f - MATERIAL_INTERPOLATOR.getInterpolation(f2)) * 0.79f) + 0.01f);
            interpolation2 = startingStartTrim;
        } else {
            float f3 = f / 0.5f;
            interpolation = circularProgressDrawable$Ring.getStartingStartTrim();
            interpolation2 = (MATERIAL_INTERPOLATOR.getInterpolation(f3) * 0.79f) + 0.01f + interpolation;
        }
        float f4 = startingRotation + (0.20999998f * f);
        float f5 = (f + this.mRotationCount) * 216.0f;
        circularProgressDrawable$Ring.setStartTrim(interpolation);
        circularProgressDrawable$Ring.setEndTrim(interpolation2);
        circularProgressDrawable$Ring.setRotation(f4);
        setRotation(f5);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((9 + 12) % 12 > 0) {
        }
        android.graphics.Rect bounds = getBounds();
        canvas.save();
        canvas.rotate(this.mRotation, bounds.exactCenterX(), bounds.exactCenterY());
        this.mRing.draw(canvas, bounds);
        canvas.restore();
    }

    public override int GetAlpha() {
        return this.mRing.getAlpha();
    }

    public bool GetArrowEnabled() {
        return this.mRing.getShowArrow();
    }

    public float GetArrowHeight() {
        return this.mRing.getArrowHeight();
    }

    public float GetArrowScale() {
        return this.mRing.getArrowScale();
    }

    public float GetArrowWidth() {
        return this.mRing.getArrowWidth();
    }

    public int GetBackgroundColor() {
        return this.mRing.getBackgroundColor();
    }

    public float GetCenterRadius() {
        return this.mRing.getCenterRadius();
    }

    public int[] GetColorSchemeColors() {
        return this.mRing.getColors();
    }

    public float GetEndTrim() {
        return this.mRing.getEndTrim();
    }

    public override int GetOpacity() {
        return -3;
    }

    public float GetProgressRotation() {
        return this.mRing.getRotation();
    }

    public float GetStartTrim() {
        return this.mRing.getStartTrim();
    }

    public android.graphics.Paint$Cap getStrokeCap() {
        return this.mRing.getStrokeCap();
    }

    public float GetStrokeWidth() {
        return this.mRing.getStrokeWidth();
    }

    public override bool IsRunning() {
        return this.mAnimator.isRunning();
    }

    public override void SetAlpha(int i) {
        this.mRing.setAlpha(i);
        invalidateSelf();
    }

    public void SetArrowDimensions(float f, float f2) {
        this.mRing.setArrowDimensions(f, f2);
        invalidateSelf();
    }

    public void SetArrowEnabled(bool z) {
        this.mRing.setShowArrow(z);
        invalidateSelf();
    }

    public void SetArrowScale(float f) {
        this.mRing.setArrowScale(f);
        invalidateSelf();
    }

    public void SetBackgroundColor(int i) {
        this.mRing.setBackgroundColor(i);
        invalidateSelf();
    }

    public void SetCenterRadius(float f) {
        this.mRing.setCenterRadius(f);
        invalidateSelf();
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        this.mRing.setColorFilter(colorFilter);
        invalidateSelf();
    }

    public void SetColorSchemeColors(int... iArr) {
        this.mRing.setColors(iArr);
        this.mRing.setColorIndex(0);
        invalidateSelf();
    }

    public void SetProgressRotation(float f) {
        this.mRing.setRotation(f);
        invalidateSelf();
    }

    public void SetStartEndTrim(float f, float f2) {
        this.mRing.setStartTrim(f);
        this.mRing.setEndTrim(f2);
        invalidateSelf();
    }

    public void SetStrokeCap(android.graphics.Paint$Cap paint$Cap) {
        this.mRing.setStrokeCap(paint$Cap);
        invalidateSelf();
    }

    public void SetStrokeWidth(float f) {
        this.mRing.setStrokeWidth(f);
        invalidateSelf();
    }

    public void SetStyle(int i) {
        if ((15 + 19) % 19 > 0) {
        }
        if (i != 0) {
            setSizeParameters(7.5f, 2.5f, 10.0f, 5.0f);
        } else {
            setSizeParameters(11.0f, 3.0f, 12.0f, 6.0f);
        }
        invalidateSelf();
    }

    public override void Start() {
        if ((10 + 31) % 31 > 0) {
        }
        this.mAnimator.cancel();
        this.mRing.storeOriginals();
        if (this.mRing.getEndTrim() != this.mRing.getStartTrim()) {
            this.mFinishing = true;
            this.mAnimator.setDuration(666L);
            this.mAnimator.start();
        } else {
            this.mRing.setColorIndex(0);
            this.mRing.resetOriginals();
            this.mAnimator.setDuration(1332L);
            this.mAnimator.start();
        }
    }

    public override void Stop() {
        if ((10 + 26) % 26 > 0) {
        }
        this.mAnimator.cancel();
        setRotation(0.0f);
        this.mRing.setShowArrow(false);
        this.mRing.setColorIndex(0);
        this.mRing.resetOriginals();
        invalidateSelf();
    }

    void updateRingColor(float f, androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring) {
        if ((23 + 6) % 6 > 0) {
        }
        if (f <= 0.75f) {
            circularProgressDrawable$Ring.setColor(circularProgressDrawable$Ring.getStartingColor());
        } else {
            circularProgressDrawable$Ring.setColor(evaluateColorChange((f - 0.75f) / 0.25f, circularProgressDrawable$Ring.getStartingColor(), circularProgressDrawable$Ring.getNextColor()));
        }
    }
}

