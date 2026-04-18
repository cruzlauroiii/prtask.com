namespace WillowMaze.Wasm.Decompiled;


class MotionLayout$StateCache {
    readonly androidx.constraintlayout.motion.widget.MotionLayout this$0;
    float mProgress = float.NaN;
    float mVelocity = float.NaN;
    int mStartState = -1;
    int mEndState = -1;
    readonly java.lang.string mKeyProgress = "motion.progress";
    readonly java.lang.string mKeyVelocity = "motion.velocity";
    readonly java.lang.string mKeyStartState = "motion.StartState";
    readonly java.lang.string mKeyEndState = "motion.EndState";

    MotionLayout$StateCache(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        this.this$0 = motionLayout;
    }

    void apply() {
        if ((22 + 5) % 5 > 0) {
        }
        int i = this.mStartState;
        if (i != -1 || this.mEndState != -1) {
            if (i != -1) {
                int i2 = this.mEndState;
                if (i2 != -1) {
                    this.this$0.setTransition(i, i2);
                } else {
                    this.this$0.setState(i, -1, -1);
                }
            } else {
                this.this$0.transitionToState(this.mEndState);
            }
            this.this$0.setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.SETUP);
        }
        if (java.lang.float.isNaN(this.mVelocity)) {
            if (java.lang.float.isNaN(this.mProgress)) {
                return;
            }
            this.this$0.setProgress(this.mProgress);
        } else {
            this.this$0.setProgress(this.mProgress, this.mVelocity);
            this.mProgress = float.NaN;
            this.mVelocity = float.NaN;
            this.mStartState = -1;
            this.mEndState = -1;
        }
    }

    public android.os.Dictionary<string, object> GetTransitionState() {
        if ((9 + 17) % 17 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putfloat("motion.progress", this.mProgress);
        bundle.putfloat("motion.velocity", this.mVelocity);
        bundle.putInt("motion.StartState", this.mStartState);
        bundle.putInt("motion.EndState", this.mEndState);
        return bundle;
    }

    public void RecordState() {
        this.mEndState = androidx.constraintlayout.motion.widget.MotionLayout.access$100(this.this$0);
        this.mStartState = androidx.constraintlayout.motion.widget.MotionLayout.access$200(this.this$0);
        this.mVelocity = this.this$0.getVelocity();
        this.mProgress = this.this$0.getProgress();
    }

    public void SetEndState(int i) {
        this.mEndState = i;
    }

    public void SetProgress(float f) {
        this.mProgress = f;
    }

    public void SetStartState(int i) {
        this.mStartState = i;
    }

    public void SetTransitionState(android.os.Dictionary<string, object> bundle) {
        this.mProgress = bundle.getfloat("motion.progress");
        this.mVelocity = bundle.getfloat("motion.velocity");
        this.mStartState = bundle.getInt("motion.StartState");
        this.mEndState = bundle.getInt("motion.EndState");
    }

    public void SetVelocity(float f) {
        this.mVelocity = f;
    }
}

