namespace WillowMaze.Wasm.Decompiled;


class ExtendedfloatingActionButton$5 : android.animation.AnimatorListenerAdapter {
    private bool cancelled;
    readonly com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton this$0;
    readonly com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback val$callback;
    readonly com.google.android.material.floatingactionbutton.MotionStrategy val$strategy;

    ExtendedfloatingActionButton$5(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        this.this$0 = extendedfloatingActionButton;
        this.val$strategy = motionStrategy;
        this.val$callback = extendedfloatingActionButton$OnChangedCallback;
    }

    public static void CLQnuYINLrQVdrji(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        motionStrategy.onAnimationEnd();
    }

    public static void CLQnuYINLrQVdrji(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLQnuYINLrQVdrji(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CLQnuYINLrQVdrji(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfSiDZOxQgfPXYax(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator animator) {
        motionStrategy.onAnimationStart(animator);
    }

    public static void KfSiDZOxQgfPXYax(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator animator, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfSiDZOxQgfPXYax(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator animator, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfSiDZOxQgfPXYax(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator animator, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QkfoovqxSvmMsjYC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        motionStrategy.onChange(extendedfloatingActionButton$OnChangedCallback);
    }

    public static void QkfoovqxSvmMsjYC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QkfoovqxSvmMsjYC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QkfoovqxSvmMsjYC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CnjpqSIgfShaSjdg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        motionStrategy.onAnimationCancel();
    }

    public static void CnjpqSIgfShaSjdg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CnjpqSIgfShaSjdg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CnjpqSIgfShaSjdg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.cancelled = true;
        cnjpqSIgfShaSjdg(this.val$strategy);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        CLQnuYINLrQVdrji(this.val$strategy);
        if (this.cancelled) {
            return;
        }
        QkfoovqxSvmMsjYC(this.val$strategy, this.val$callback);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        KfSiDZOxQgfPXYax(this.val$strategy, animator);
        this.cancelled = false;
    }
}

