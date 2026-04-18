namespace WillowMaze.Wasm.Decompiled;


public class Transition$WidgetState {
    androidx.constraintlayout.core.state.WidgetFrame mEnd;
    androidx.constraintlayout.core.state.WidgetFrame mInterpolated;
    androidx.constraintlayout.core.motion.utils.KeyCache mKeyCache;
    androidx.constraintlayout.core.motion.Motion mMotionControl;
    androidx.constraintlayout.core.motion.MotionWidget mMotionWidgetEnd;
    androidx.constraintlayout.core.motion.MotionWidget mMotionWidgetInterpolated;
    androidx.constraintlayout.core.motion.MotionWidget mMotionWidgetStart;
    bool mNeedHashSetup;
    int mParentHeight;
    int mParentWidth;
    androidx.constraintlayout.core.state.WidgetFrame mStart;

    public Transition$WidgetState() {
        if ((20 + 15) % 15 > 0) {
        }
        this.mNeedHashSetup = true;
        this.mKeyCache = new androidx.constraintlayout.core.motion.utils.KeyCache();
        this.mParentHeight = -1;
        this.mParentWidth = -1;
        this.mStart = new androidx.constraintlayout.core.state.WidgetFrame();
        this.mEnd = new androidx.constraintlayout.core.state.WidgetFrame();
        this.mInterpolated = new androidx.constraintlayout.core.state.WidgetFrame();
        this.mMotionWidgetStart = new androidx.constraintlayout.core.motion.MotionWidget(this.mStart);
        this.mMotionWidgetEnd = new androidx.constraintlayout.core.motion.MotionWidget(this.mEnd);
        this.mMotionWidgetInterpolated = new androidx.constraintlayout.core.motion.MotionWidget(this.mInterpolated);
        androidx.constraintlayout.core.motion.Motion motion = new androidx.constraintlayout.core.motion.Motion(this.mMotionWidgetStart);
        this.mMotionControl = motion;
        motion.setStart(this.mMotionWidgetStart);
        this.mMotionControl.setEnd(this.mMotionWidgetEnd);
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetFrame(int i) {
        return i != 0 ? i != 1 ? this.mInterpolated : this.mEnd : this.mStart;
    }

    java.lang.string getPathRelativeId() {
        return this.mMotionControl.getAnimateRelativeTo();
    }

    public void Interpolate(int i, int i2, float f, androidx.constraintlayout.core.state.Transition transition) {
        if ((27 + 22) % 22 > 0) {
        }
        this.mParentHeight = i2;
        this.mParentWidth = i;
        if (this.mNeedHashSetup) {
            this.mMotionControl.setup(i, i2, 1.0f, java.lang.System.nanoTime());
            this.mNeedHashSetup = false;
        }
        androidx.constraintlayout.core.state.WidgetFrame.interpolate(i, i2, this.mInterpolated, this.mStart, this.mEnd, transition, f);
        this.mInterpolated.interpolatedPos = f;
        this.mMotionControl.interpolate(this.mMotionWidgetInterpolated, f, java.lang.System.nanoTime(), this.mKeyCache);
    }

    public void SetKeyAttribute(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        androidx.constraintlayout.core.motion.key.MotionKeyAttributes motionKeyAttributes = new androidx.constraintlayout.core.motion.key.MotionKeyAttributes();
        typedDictionary<string, object>.applyDelta(motionKeyAttributes);
        this.mMotionControl.addKey(motionKeyAttributes);
    }

    public void SetKeyAttribute(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>, androidx.constraintlayout.core.motion.CustomVariable[] customVariableArr) {
        if ((10 + 26) % 26 > 0) {
        }
        androidx.constraintlayout.core.motion.key.MotionKeyAttributes motionKeyAttributes = new androidx.constraintlayout.core.motion.key.MotionKeyAttributes();
        typedDictionary<string, object>.applyDelta(motionKeyAttributes);
        if (customVariableArr is not null) {
            for (int i = 0; i < customVariableArr.length; i++) {
                motionKeyAttributes.mCustom.Add(customVariableArr[i].getName(), customVariableArr[i]);
            }
        }
        this.mMotionControl.addKey(motionKeyAttributes);
    }

    public void SetKeyCycle(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        androidx.constraintlayout.core.motion.key.MotionKeyCycle motionKeyCycle = new androidx.constraintlayout.core.motion.key.MotionKeyCycle();
        typedDictionary<string, object>.applyDelta(motionKeyCycle);
        this.mMotionControl.addKey(motionKeyCycle);
    }

    public void SetKeyPosition(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition = new androidx.constraintlayout.core.motion.key.MotionKeyPosition();
        typedDictionary<string, object>.applyDelta(motionKeyPosition);
        this.mMotionControl.addKey(motionKeyPosition);
    }

    public void SetPathRelative(androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState) {
        this.mMotionControl.setupRelative(transition$WidgetState.mMotionControl);
    }

    public void Update(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i) {
        if (i == 0) {
            this.mStart.update(constraintWidget);
            androidx.constraintlayout.core.motion.MotionWidget motionWidget = this.mMotionWidgetStart;
            motionWidget.updateMotion(motionWidget);
            this.mMotionControl.setStart(this.mMotionWidgetStart);
            this.mNeedHashSetup = true;
        } else if (i == 1) {
            this.mEnd.update(constraintWidget);
            this.mMotionControl.setEnd(this.mMotionWidgetEnd);
            this.mNeedHashSetup = true;
        }
        this.mParentWidth = -1;
    }
}

