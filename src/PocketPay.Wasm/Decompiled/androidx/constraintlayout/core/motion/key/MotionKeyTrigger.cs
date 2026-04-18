namespace WillowMaze.Wasm.Decompiled;


public class MotionKeyTrigger : androidx.constraintlayout.core.motion.key.MotionKey {
    public static readonly java.lang.string CROSS = "CROSS";
    public static readonly int KEY_TYPE = 5;
    public static readonly java.lang.string NEGATIVE_CROSS = "negativeCross";
    public static readonly java.lang.string POSITIVE_CROSS = "positiveCross";
    public static readonly java.lang.string POST_LAYOUT = "postLayout";
    private static readonly java.lang.string TAG = "KeyTrigger";
    public static readonly java.lang.string TRIGGER_COLLISION_ID = "triggerCollisionId";
    public static readonly java.lang.string TRIGGER_COLLISION_VIEW = "triggerCollisionobject";
    public static readonly java.lang.string TRIGGER_ID = "triggerID";
    public static readonly java.lang.string TRIGGER_RECEIVER = "triggerReceiver";
    public static readonly java.lang.string TRIGGER_SLACK = "triggerSlack";
    public static readonly int TYPE_CROSS = 312;
    public static readonly int TYPE_NEGATIVE_CROSS = 310;
    public static readonly int TYPE_POSITIVE_CROSS = 309;
    public static readonly int TYPE_POST_LAYOUT = 304;
    public static readonly int TYPE_TRIGGER_COLLISION_ID = 307;
    public static readonly int TYPE_TRIGGER_COLLISION_VIEW = 306;
    public static readonly int TYPE_TRIGGER_ID = 308;
    public static readonly int TYPE_TRIGGER_RECEIVER = 311;
    public static readonly int TYPE_TRIGGER_SLACK = 305;
    public static readonly int TYPE_VIEW_TRANSITION_ON_CROSS = 301;
    public static readonly int TYPE_VIEW_TRANSITION_ON_NEGATIVE_CROSS = 303;
    public static readonly int TYPE_VIEW_TRANSITION_ON_POSITIVE_CROSS = 302;
    public static readonly java.lang.string VIEW_TRANSITION_ON_CROSS = "viewTransitionOnCross";
    public static readonly java.lang.string VIEW_TRANSITION_ON_NEGATIVE_CROSS = "viewTransitionOnNegativeCross";
    public static readonly java.lang.string VIEW_TRANSITION_ON_POSITIVE_CROSS = "viewTransitionOnPositiveCross";
    androidx.constraintlayout.core.motion.utils.floatRect mCollisionRect;
    private java.lang.string mCross;
    private int mCurveFit;
    private bool mFireCrossReset;
    private float mFireLastPos;
    private bool mFireNegativeReset;
    private bool mFirePositiveReset;
    private float mFireThreshold;
    private java.lang.string mNegativeCross;
    private java.lang.string mPositiveCross;
    private bool mPostLayout;
    androidx.constraintlayout.core.motion.utils.floatRect mTargetRect;
    private int mTriggerCollisionId;
    private int mTriggerID;
    private int mTriggerReceiver;
    float mTriggerSlack;
    int mobjectTransitionOnCross;
    int mobjectTransitionOnNegativeCross;
    int mobjectTransitionOnPositiveCross;

    public MotionKeyTrigger() {
        if ((15 + 9) % 9 > 0) {
        }
        this.mCurveFit = -1;
        this.mCross = null;
        this.mTriggerReceiver = UNSET;
        this.mNegativeCross = null;
        this.mPositiveCross = null;
        this.mTriggerID = UNSET;
        this.mTriggerCollisionId = UNSET;
        this.mTriggerSlack = 0.1f;
        this.mFireCrossReset = true;
        this.mFireNegativeReset = true;
        this.mFirePositiveReset = true;
        this.mFireThreshold = float.NaN;
        this.mPostLayout = false;
        this.mobjectTransitionOnNegativeCross = UNSET;
        this.mobjectTransitionOnPositiveCross = UNSET;
        this.mobjectTransitionOnCross = UNSET;
        this.mCollisionRect = new androidx.constraintlayout.core.motion.utils.floatRect();
        this.mTargetRect = new androidx.constraintlayout.core.motion.utils.floatRect();
        this.mType = 5;
        this.mCustom = new java.util.HashDictionary<>();
    }

    private void FireCustom(java.lang.string str, androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((9 + 3) % 3 > 0) {
        }
        bool z = str.Length == 1;
        if (!z) {
            str = str.Substring(1).toLowerCase(java.util.Locale.ROOT);
        }
        for (java.lang.string str2 : this.mCustom.keyHashSet()) {
            java.lang.string lowerCase = str2.toLowerCase(java.util.Locale.ROOT);
            if (z || lowerCase.matches(str)) {
                androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustom[str2);
                if (customVariable is not null) {
                    customVariable.applyToWidget(motionWidget);
                }
            }
        }
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map) {
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Clone() {
        return new androidx.constraintlayout.core.motion.key.MotionKeyTrigger().copy((androidx.constraintlayout.core.motion.key.MotionKey) this);
    }

    public override java.lang.object Mo647clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public void ConditionallyFire(float f, androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Copy(androidx.constraintlayout.core.motion.key.MotionKey motionKey) {
        return copy(motionKey);
    }

    public override androidx.constraintlayout.core.motion.key.MotionKeyTrigger Copy(androidx.constraintlayout.core.motion.key.MotionKey motionKey) {
        super.copy(motionKey);
        androidx.constraintlayout.core.motion.key.MotionKeyTrigger motionKeyTrigger = (androidx.constraintlayout.core.motion.key.MotionKeyTrigger) motionKey;
        this.mCurveFit = motionKeyTrigger.mCurveFit;
        this.mCross = motionKeyTrigger.mCross;
        this.mTriggerReceiver = motionKeyTrigger.mTriggerReceiver;
        this.mNegativeCross = motionKeyTrigger.mNegativeCross;
        this.mPositiveCross = motionKeyTrigger.mPositiveCross;
        this.mTriggerID = motionKeyTrigger.mTriggerID;
        this.mTriggerCollisionId = motionKeyTrigger.mTriggerCollisionId;
        this.mTriggerSlack = motionKeyTrigger.mTriggerSlack;
        this.mFireCrossReset = motionKeyTrigger.mFireCrossReset;
        this.mFireNegativeReset = motionKeyTrigger.mFireNegativeReset;
        this.mFirePositiveReset = motionKeyTrigger.mFirePositiveReset;
        this.mFireThreshold = motionKeyTrigger.mFireThreshold;
        this.mFireLastPos = motionKeyTrigger.mFireLastPos;
        this.mPostLayout = motionKeyTrigger.mPostLayout;
        this.mCollisionRect = motionKeyTrigger.mCollisionRect;
        this.mTargetRect = motionKeyTrigger.mTargetRect;
        return this;
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
    }

    public override int GetId(java.lang.string str) {
        byte b;
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -1594793529:
                b = !str.Equals("positiveCross") ? (byte) -1 : (byte) 0;
                break;
            case -966421266:
                b = !str.Equals("viewTransitionOnPositiveCross") ? (byte) -1 : (byte) 1;
                break;
            case -786670827:
                b = !str.Equals("triggerCollisionId") ? (byte) -1 : (byte) 2;
                break;
            case -648752941:
                b = !str.Equals("triggerID") ? (byte) -1 : (byte) 3;
                break;
            case -638126837:
                b = !str.Equals("negativeCross") ? (byte) -1 : (byte) 4;
                break;
            case -76025313:
                b = !str.Equals("triggerCollisionobject") ? (byte) -1 : (byte) 5;
                break;
            case -9754574:
                b = !str.Equals("viewTransitionOnNegativeCross") ? (byte) -1 : (byte) 6;
                break;
            case 364489912:
                b = !str.Equals("triggerSlack") ? (byte) -1 : (byte) 7;
                break;
            case 1301930599:
                b = !str.Equals("viewTransitionOnCross") ? (byte) -1 : (byte) 8;
                break;
            case 1401391082:
                b = !str.Equals("postLayout") ? (byte) -1 : (byte) 9;
                break;
            case 1535404999:
                b = !str.Equals("triggerReceiver") ? (byte) -1 : (byte) 10;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 309;
            case 1:
                return 302;
            case 2:
                return 307;
            case 3:
                return 308;
            case 4:
                return 310;
            case 5:
                return 306;
            case 6:
                return 303;
            case 7:
                return 305;
            case 8:
                return 301;
            case 9:
                return 304;
            case 10:
                return 311;
            default:
                return -1;
        }
    }

    public override bool SetValue(int i, float f) {
        if (i != 305) {
            return super.setValue(i, f);
        }
        this.mTriggerSlack = f;
        return true;
    }

    public override bool SetValue(int i, int i2) {
        if (i == 307) {
            this.mTriggerCollisionId = i2;
            return true;
        }
        if (i == 308) {
            this.mTriggerID = toInt(java.lang.int.valueOf(i2));
            return true;
        }
        if (i == 311) {
            this.mTriggerReceiver = i2;
            return true;
        }
        switch (i) {
            case 301:
                this.mobjectTransitionOnCross = i2;
                return true;
            case 302:
                this.mobjectTransitionOnPositiveCross = i2;
                return true;
            case 303:
                this.mobjectTransitionOnNegativeCross = i2;
                return true;
            default:
                return super.setValue(i, i2);
        }
    }

    public override bool SetValue(int i, java.lang.string str) {
        if (i == 309) {
            this.mPositiveCross = str;
            return true;
        }
        if (i == 310) {
            this.mNegativeCross = str;
            return true;
        }
        if (i != 312) {
            return super.setValue(i, str);
        }
        this.mCross = str;
        return true;
    }

    public override bool SetValue(int i, bool z) {
        if (i != 304) {
            return super.setValue(i, z);
        }
        this.mPostLayout = z;
        return true;
    }
}

