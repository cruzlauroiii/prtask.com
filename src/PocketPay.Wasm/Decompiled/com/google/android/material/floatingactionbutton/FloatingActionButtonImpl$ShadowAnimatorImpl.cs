namespace WillowMaze.Wasm.Decompiled;


abstract class floatingActionButtonImpl$ShadowAnimatorImpl : android.animation.AnimatorListenerAdapter : android.animation.ValueAnimator$AnimatorUpdateListener {
    private float shadowSizeEnd;
    private float shadowSizeStart;
    readonly com.google.android.material.floatingactionbutton.floatingActionButtonImpl this$0;
    private bool validValues;

    private floatingActionButtonImpl$ShadowAnimatorImpl(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        this.this$0 = floatingActionButtonImpl;
    }

    floatingActionButtonImpl$ShadowAnimatorImpl(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$1 floatingActionButtonImpl$1) {
        this(floatingActionButtonImpl);
    }

    public static float DebhQdTDjPwMJCOb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl$ShadowAnimatorImpl floatingActionButtonImpl$ShadowAnimatorImpl) {
        return floatingActionButtonImpl$ShadowAnimatorImpl.getTargetShadowSize();
    }

    public static void DebhQdTDjPwMJCOb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl$ShadowAnimatorImpl floatingActionButtonImpl$ShadowAnimatorImpl, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DebhQdTDjPwMJCOb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl$ShadowAnimatorImpl floatingActionButtonImpl$ShadowAnimatorImpl, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DebhQdTDjPwMJCOb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl$ShadowAnimatorImpl floatingActionButtonImpl$ShadowAnimatorImpl, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float JbmewTJaqnSQZaIg(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedFraction();
    }

    public static void JbmewTJaqnSQZaIg(android.animation.ValueAnimator valueAnimator, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JbmewTJaqnSQZaIg(android.animation.ValueAnimator valueAnimator, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JbmewTJaqnSQZaIg(android.animation.ValueAnimator valueAnimator, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float OGWUHdYvUOornAQt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getElevation();
    }

    public static void OGWUHdYvUOornAQt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OGWUHdYvUOornAQt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OGWUHdYvUOornAQt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SbIiWmevFbfLzGEs(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.updateShapeElevation(f);
    }

    public static void SbIiWmevFbfLzGEs(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SbIiWmevFbfLzGEs(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SbIiWmevFbfLzGEs(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GIhgMOOviCPRJIdX(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.updateShapeElevation(f);
    }

    public static void GIhgMOOviCPRJIdX(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, float f2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GIhgMOOviCPRJIdX(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, short s, java.lang.string str, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void GIhgMOOviCPRJIdX(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, bool z, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    protected abstract float GetTargetShadowSize();

    public override void OnAnimationEnd(android.animation.Animator animator) {
        gIhgMOOviCPRJIdX(this.this$0, (int) this.shadowSizeEnd);
        this.validValues = false;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((31 + 14) % 14 > 0) {
        }
        if (!this.validValues) {
            this.shadowSizeStart = this.this$0.shapeDrawable is not null ? OGWUHdYvUOornAQt(this.this$0.shapeDrawable) : 0.0f;
            this.shadowSizeEnd = DebhQdTDjPwMJCOb(this);
            this.validValues = true;
        }
        com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl = this.this$0;
        float f = this.shadowSizeStart;
        SbIiWmevFbfLzGEs(floatingActionButtonImpl, (int) (f + ((this.shadowSizeEnd - f) * JbmewTJaqnSQZaIg(valueAnimator))));
    }
}

