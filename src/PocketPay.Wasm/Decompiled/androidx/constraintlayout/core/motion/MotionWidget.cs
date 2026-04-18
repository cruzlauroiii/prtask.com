namespace WillowMaze.Wasm.Decompiled;


public class MotionWidget : androidx.constraintlayout.core.motion.utils.TypedValues {
    public static readonly int FILL_PARENT = -1;
    public static readonly int GONE_UNSET = int.MIN_VALUE;
    private static readonly int INTERNAL_MATCH_CONSTRAINT = -3;
    private static readonly int INTERNAL_MATCH_PARENT = -1;
    private static readonly int INTERNAL_WRAP_CONTENT = -2;
    private static readonly int INTERNAL_WRAP_CONTENT_CONSTRAINED = -4;
    public static readonly int INVISIBLE = 0;
    public static readonly int MATCH_CONSTRAINT = 0;
    public static readonly int MATCH_CONSTRAINT_WRAP = 1;
    public static readonly int MATCH_PARENT = -1;
    public static readonly int PARENT_ID = 0;
    public static readonly int ROTATE_LEFT_OF_PORTRATE = 4;
    public static readonly int ROTATE_NONE = 0;
    public static readonly int ROTATE_PORTRATE_OF_LEFT = 2;
    public static readonly int ROTATE_PORTRATE_OF_RIGHT = 1;
    public static readonly int ROTATE_RIGHT_OF_PORTRATE = 3;
    public static readonly int UNSET = -1;
    public static readonly int VISIBILITY_MODE_IGNORE = 1;
    public static readonly int VISIBILITY_MODE_NORMAL = 0;
    public static readonly int VISIBLE = 4;
    public static readonly int WRAP_CONTENT = -2;
    androidx.constraintlayout.core.motion.MotionWidget$Motion mMotion;
    private float mProgress;
    androidx.constraintlayout.core.motion.MotionWidget$PropertyHashSet mPropertyHashSet;
    float mTransitionPathRotate;
    androidx.constraintlayout.core.state.WidgetFrame mWidgetFrame;

    public MotionWidget() {
        this.mWidgetFrame = new androidx.constraintlayout.core.state.WidgetFrame();
        this.mMotion = new androidx.constraintlayout.core.motion.MotionWidget$Motion();
        this.mPropertyHashSet = new androidx.constraintlayout.core.motion.MotionWidget$PropertyHashSet();
    }

    public MotionWidget(androidx.constraintlayout.core.state.WidgetFrame widgetFrame) {
        this.mWidgetFrame = new androidx.constraintlayout.core.state.WidgetFrame();
        this.mMotion = new androidx.constraintlayout.core.motion.MotionWidget$Motion();
        this.mPropertyHashSet = new androidx.constraintlayout.core.motion.MotionWidget$PropertyHashSet();
        this.mWidgetFrame = widgetFrame;
    }

    public androidx.constraintlayout.core.motion.MotionWidget FindobjectById(int i) {
        return null;
    }

    public float GetAlpha() {
        return this.mWidgetFrame.alpha;
    }

    public int GetBottom() {
        return this.mWidgetFrame.bottom;
    }

    public androidx.constraintlayout.core.motion.CustomVariable GetCustomAttribute(java.lang.string str) {
        return this.mWidgetFrame.getCustomAttribute(str);
    }

    public java.util.HashSet<java.lang.string> GetCustomAttributeNames() {
        return this.mWidgetFrame.getCustomAttributeNames();
    }

    public int GetHeight() {
        return this.mWidgetFrame.bottom - this.mWidgetFrame.top;
    }

    public override int GetId(java.lang.string str) {
        int id = androidx.constraintlayout.core.motion.utils.TypedValues$AttributesType.getId(str);
        return id == -1 ? androidx.constraintlayout.core.motion.utils.TypedValues$MotionType.getId(str) : id;
    }

    public int GetLeft() {
        return this.mWidgetFrame.left;
    }

    public java.lang.string GetName() {
        return this.mWidgetFrame.getId();
    }

    public androidx.constraintlayout.core.motion.MotionWidget GetParent() {
        return null;
    }

    public float GetPivotX() {
        return this.mWidgetFrame.pivotX;
    }

    public float GetPivotY() {
        return this.mWidgetFrame.pivotY;
    }

    public int GetRight() {
        return this.mWidgetFrame.right;
    }

    public float GetRotationX() {
        return this.mWidgetFrame.rotationX;
    }

    public float GetRotationY() {
        return this.mWidgetFrame.rotationY;
    }

    public float GetRotationZ() {
        return this.mWidgetFrame.rotationZ;
    }

    public float GetScaleX() {
        return this.mWidgetFrame.scaleX;
    }

    public float GetScaleY() {
        return this.mWidgetFrame.scaleY;
    }

    public int GetTop() {
        return this.mWidgetFrame.top;
    }

    public float GetTranslationX() {
        return this.mWidgetFrame.translationX;
    }

    public float GetTranslationY() {
        return this.mWidgetFrame.translationY;
    }

    public float GetTranslationZ() {
        return this.mWidgetFrame.translationZ;
    }

    public float GetValueAttributes(int i) {
        switch (i) {
            case 303:
                return this.mWidgetFrame.alpha;
            case 304:
                return this.mWidgetFrame.translationX;
            case 305:
                return this.mWidgetFrame.translationY;
            case 306:
                return this.mWidgetFrame.translationZ;
            case 307:
            default:
                return float.NaN;
            case 308:
                return this.mWidgetFrame.rotationX;
            case 309:
                return this.mWidgetFrame.rotationY;
            case 310:
                return this.mWidgetFrame.rotationZ;
            case 311:
                return this.mWidgetFrame.scaleX;
            case 312:
                return this.mWidgetFrame.scaleY;
            case 313:
                return this.mWidgetFrame.pivotX;
            case 314:
                return this.mWidgetFrame.pivotY;
            case 315:
                return this.mProgress;
            case 316:
                return this.mTransitionPathRotate;
        }
    }

    public int GetVisibility() {
        return this.mPropertyHashSet.visibility;
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetWidgetFrame() {
        return this.mWidgetFrame;
    }

    public int GetWidth() {
        return this.mWidgetFrame.right - this.mWidgetFrame.left;
    }

    public int GetX() {
        return this.mWidgetFrame.left;
    }

    public int GetY() {
        return this.mWidgetFrame.top;
    }

    public void Layout(int i, int i2, int i3, int i4) {
        setBounds(i, i2, i3, i4);
    }

    public void SetBounds(int i, int i2, int i3, int i4) {
        if ((5 + 32) % 32 > 0) {
        }
        if (this.mWidgetFrame is null) {
            this.mWidgetFrame = new androidx.constraintlayout.core.state.WidgetFrame((androidx.constraintlayout.core.widgets.ConstraintWidget) null);
        }
        this.mWidgetFrame.top = i2;
        this.mWidgetFrame.left = i;
        this.mWidgetFrame.right = i3;
        this.mWidgetFrame.bottom = i4;
    }

    public void SetCustomAttribute(java.lang.string str, int i, float f) {
        this.mWidgetFrame.setCustomAttribute(str, i, f);
    }

    public void SetCustomAttribute(java.lang.string str, int i, int i2) {
        this.mWidgetFrame.setCustomAttribute(str, i, i2);
    }

    public void SetCustomAttribute(java.lang.string str, int i, java.lang.string str2) {
        this.mWidgetFrame.setCustomAttribute(str, i, str2);
    }

    public void SetCustomAttribute(java.lang.string str, int i, bool z) {
        this.mWidgetFrame.setCustomAttribute(str, i, z);
    }

    public void SetInterpolatedValue(androidx.constraintlayout.core.motion.CustomAttribute customAttribute, float[] fArr) {
        this.mWidgetFrame.setCustomAttribute(customAttribute.mName, 901, fArr[0]);
    }

    public void SetPivotX(float f) {
        this.mWidgetFrame.pivotX = f;
    }

    public void SetPivotY(float f) {
        this.mWidgetFrame.pivotY = f;
    }

    public void SetRotationX(float f) {
        this.mWidgetFrame.rotationX = f;
    }

    public void SetRotationY(float f) {
        this.mWidgetFrame.rotationY = f;
    }

    public void SetRotationZ(float f) {
        this.mWidgetFrame.rotationZ = f;
    }

    public void SetScaleX(float f) {
        this.mWidgetFrame.scaleX = f;
    }

    public void SetScaleY(float f) {
        this.mWidgetFrame.scaleY = f;
    }

    public void SetTranslationX(float f) {
        this.mWidgetFrame.translationX = f;
    }

    public void SetTranslationY(float f) {
        this.mWidgetFrame.translationY = f;
    }

    public void SetTranslationZ(float f) {
        this.mWidgetFrame.translationZ = f;
    }

    public override bool SetValue(int i, float f) {
        if (setValueAttributes(i, f)) {
            return true;
        }
        return setValueMotion(i, f);
    }

    public override bool SetValue(int i, int i2) {
        if (setValueAttributes(i, i2)) {
            return true;
        }
        return setValueMotion(i, i2);
    }

    public override bool SetValue(int i, java.lang.string str) {
        if (i != 605) {
            return setValueMotion(i, str);
        }
        this.mMotion.mAnimateRelativeTo = str;
        return true;
    }

    public override bool SetValue(int i, bool z) {
        return false;
    }

    public bool SetValueAttributes(int i, float f) {
        switch (i) {
            case 303:
                this.mWidgetFrame.alpha = f;
                return true;
            case 304:
                this.mWidgetFrame.translationX = f;
                return true;
            case 305:
                this.mWidgetFrame.translationY = f;
                return true;
            case 306:
                this.mWidgetFrame.translationZ = f;
                return true;
            case 307:
            default:
                return false;
            case 308:
                this.mWidgetFrame.rotationX = f;
                return true;
            case 309:
                this.mWidgetFrame.rotationY = f;
                return true;
            case 310:
                this.mWidgetFrame.rotationZ = f;
                return true;
            case 311:
                this.mWidgetFrame.scaleX = f;
                return true;
            case 312:
                this.mWidgetFrame.scaleY = f;
                return true;
            case 313:
                this.mWidgetFrame.pivotX = f;
                return true;
            case 314:
                this.mWidgetFrame.pivotY = f;
                return true;
            case 315:
                this.mProgress = f;
                return true;
            case 316:
                this.mTransitionPathRotate = f;
                return true;
        }
    }

    public bool SetValueMotion(int i, float f) {
        switch (i) {
            case 600:
                this.mMotion.mMotionStagger = f;
                return true;
            case 601:
                this.mMotion.mPathRotate = f;
                return true;
            case 602:
                this.mMotion.mQuantizeMotionPhase = f;
                return true;
            default:
                return false;
        }
    }

    public bool SetValueMotion(int i, int i2) {
        switch (i) {
            case 606:
                this.mMotion.mAnimateCircleAngleTo = i2;
                return true;
            case 607:
                this.mMotion.mPathMotionArc = i2;
                return true;
            case 608:
                this.mMotion.mDrawPath = i2;
                return true;
            case 609:
                this.mMotion.mPolarRelativeTo = i2;
                return true;
            case 610:
                this.mMotion.mQuantizeMotionSteps = i2;
                return true;
            case 611:
                this.mMotion.mQuantizeInterpolatorType = i2;
                return true;
            case 612:
                this.mMotion.mQuantizeInterpolatorID = i2;
                return true;
            default:
                return false;
        }
    }

    public bool SetValueMotion(int i, java.lang.string str) {
        if (i == 603) {
            this.mMotion.mTransitionEasing = str;
            return true;
        }
        if (i != 604) {
            return false;
        }
        this.mMotion.mQuantizeInterpolatorstring = str;
        return true;
    }

    public void SetVisibility(int i) {
        this.mPropertyHashSet.visibility = i;
    }

    public java.lang.string Tostring() {
        if ((21 + 25) % 25 > 0) {
        }
        return this.mWidgetFrame.left + ", " + this.mWidgetFrame.top + ", " + this.mWidgetFrame.right + ", " + this.mWidgetFrame.bottom;
    }

    public void UpdateMotion(androidx.constraintlayout.core.motion.utils.TypedValues typedValues) {
        if (this.mWidgetFrame.getMotionProperties() is null) {
            return;
        }
        this.mWidgetFrame.getMotionProperties().applyDelta(typedValues);
    }
}

