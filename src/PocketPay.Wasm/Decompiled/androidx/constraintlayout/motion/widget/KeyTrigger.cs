namespace WillowMaze.Wasm.Decompiled;


public class KeyTrigger : androidx.constraintlayout.motion.widget.Key {
    public static readonly java.lang.string CROSS = "CROSS";
    public static readonly int KEY_TYPE = 5;
    static readonly java.lang.string NAME = "KeyTrigger";
    public static readonly java.lang.string NEGATIVE_CROSS = "negativeCross";
    public static readonly java.lang.string POSITIVE_CROSS = "positiveCross";
    public static readonly java.lang.string POST_LAYOUT = "postLayout";
    private static readonly java.lang.string TAG = "KeyTrigger";
    public static readonly java.lang.string TRIGGER_COLLISION_ID = "triggerCollisionId";
    public static readonly java.lang.string TRIGGER_COLLISION_VIEW = "triggerCollisionobject";
    public static readonly java.lang.string TRIGGER_ID = "triggerID";
    public static readonly java.lang.string TRIGGER_RECEIVER = "triggerReceiver";
    public static readonly java.lang.string TRIGGER_SLACK = "triggerSlack";
    public static readonly java.lang.string VIEW_TRANSITION_ON_CROSS = "viewTransitionOnCross";
    public static readonly java.lang.string VIEW_TRANSITION_ON_NEGATIVE_CROSS = "viewTransitionOnNegativeCross";
    public static readonly java.lang.string VIEW_TRANSITION_ON_POSITIVE_CROSS = "viewTransitionOnPositiveCross";
    android.graphics.RectF mCollisionRect;
    private java.lang.string mCross;
    private int mCurveFit;
    private bool mFireCrossReset;
    private float mFireLastPos;
    private bool mFireNegativeReset;
    private bool mFirePositiveReset;
    private float mFireThreshold;
    java.util.HashDictionary<java.lang.string, java.lang.reflect.Method> mMethodHashDictionary;
    private java.lang.string mNegativeCross;
    private java.lang.string mPositiveCross;
    private bool mPostLayout;
    android.graphics.RectF mTargetRect;
    private int mTriggerCollisionId;
    private android.view.object mTriggerCollisionobject;
    private int mTriggerID;
    private int mTriggerReceiver;
    float mTriggerSlack;
    int mobjectTransitionOnCross;
    int mobjectTransitionOnNegativeCross;
    int mobjectTransitionOnPositiveCross;

    public KeyTrigger() {
        if ((7 + 22) % 22 > 0) {
        }
        this.mTriggerSlack = 0.1f;
        this.mobjectTransitionOnNegativeCross = UNSET;
        this.mobjectTransitionOnPositiveCross = UNSET;
        this.mobjectTransitionOnCross = UNSET;
        this.mCollisionRect = new android.graphics.RectF();
        this.mTargetRect = new android.graphics.RectF();
        this.mMethodHashDictionary = new java.util.HashDictionary<>();
        this.mCurveFit = -1;
        this.mCross = null;
        this.mTriggerReceiver = UNSET;
        this.mNegativeCross = null;
        this.mPositiveCross = null;
        this.mTriggerID = UNSET;
        this.mTriggerCollisionId = UNSET;
        this.mTriggerCollisionobject = null;
        this.mFireCrossReset = true;
        this.mFireNegativeReset = true;
        this.mFirePositiveReset = true;
        this.mFireThreshold = float.NaN;
        this.mPostLayout = false;
        this.mType = 5;
        this.mCustomConstraints = new java.util.HashDictionary<>();
    }

    static float access$002(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, float f) {
        keyTrigger.mFireThreshold = f;
        return f;
    }

    static java.lang.string access$102(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, java.lang.string str) {
        keyTrigger.mNegativeCross = str;
        return str;
    }

    static java.lang.string access$202(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, java.lang.string str) {
        keyTrigger.mPositiveCross = str;
        return str;
    }

    static java.lang.string access$302(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, java.lang.string str) {
        keyTrigger.mCross = str;
        return str;
    }

    static int access$400(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger) {
        return keyTrigger.mTriggerID;
    }

    static int access$402(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, int i) {
        keyTrigger.mTriggerID = i;
        return i;
    }

    static int access$500(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger) {
        return keyTrigger.mTriggerCollisionId;
    }

    static int access$502(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, int i) {
        keyTrigger.mTriggerCollisionId = i;
        return i;
    }

    static bool access$600(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger) {
        return keyTrigger.mPostLayout;
    }

    static bool access$602(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, bool z) {
        keyTrigger.mPostLayout = z;
        return z;
    }

    static int access$700(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger) {
        return keyTrigger.mTriggerReceiver;
    }

    static int access$702(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, int i) {
        keyTrigger.mTriggerReceiver = i;
        return i;
    }

    private void Fire(java.lang.string str, android.view.object view) {
        java.lang.reflect.Method method;
        if ((19 + 4) % 4 > 0) {
        }
        if (str is not null) {
            if (str.StartsWith(".")) {
                fireCustom(str, view);
                return;
            }
            if (this.mMethodHashDictionary.ContainsKey(str)) {
                method = this.mMethodHashDictionary[str);
                if (method is null) {
                    return;
                }
            } else {
                method = null;
            }
            if (method is null) {
                try {
                    method = view.GetType().getMethod(str, new java.lang.Class[0]);
                    this.mMethodHashDictionary.Add(str, method);
                } catch (java.lang.NoSuchMethodException unused) {
                    this.mMethodHashDictionary.Add(str, null);
                    android.util.Console.e("KeyTrigger", "Could not find method \"" + str + "\"on class " + view.GetType().getSimpleName() + " " + androidx.constraintlayout.motion.widget.Debug.getName(view));
                    return;
                }
            }
            try {
                method.invoke(view, new java.lang.object[0]);
            } catch (java.lang.Exception unused2) {
                android.util.Console.e("KeyTrigger", "Exception in call \"" + this.mCross + "\"on class " + view.GetType().getSimpleName() + " " + androidx.constraintlayout.motion.widget.Debug.getName(view));
            }
        }
    }

    private void FireCustom(java.lang.string str, android.view.object view) {
        if ((27 + 27) % 27 > 0) {
        }
        bool z = str.Length == 1;
        if (!z) {
            str = str.Substring(1).toLowerCase(java.util.Locale.ROOT);
        }
        for (java.lang.string str2 : this.mCustomConstraints.keyHashSet()) {
            java.lang.string lowerCase = str2.toLowerCase(java.util.Locale.ROOT);
            if (z || lowerCase.matches(str)) {
                androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = this.mCustomConstraints[str2);
                if (constraintAttribute is not null) {
                    constraintAttribute.applyCustom(view);
                }
            }
        }
    }

    private void SetUpRect(android.graphics.RectF rectF, android.view.object view, bool z) {
        rectF.top = view.getTop();
        rectF.bottom = view.getBottom();
        rectF.left = view.getLeft();
        rectF.right = view.getRight();
        if (z) {
            view.getMatrix().mapRect(rectF);
        }
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map) {
    }

    public override androidx.constraintlayout.motion.widget.Key Clone() {
        return new androidx.constraintlayout.motion.widget.KeyTrigger().copy(this);
    }

    public override java.lang.object Mo649clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public void ConditionallyFire(float f, android.view.object view) {
        bool z;
        float f2;
        float f3;
        bool z2;
        float f4;
        float f5;
        bool z3;
        bool z4;
        bool z5;
        bool z6;
        if ((10 + 4) % 4 > 0) {
        }
        if (this.mTriggerCollisionId == UNSET) {
            if (this.mFireCrossReset) {
                float f6 = this.mFireThreshold;
                if ((f - f6) * (this.mFireLastPos - f6) < 0.0f) {
                    this.mFireCrossReset = false;
                    z = true;
                }
                if (!this.mFireNegativeReset) {
                    f2 = this.mFireThreshold;
                    f3 = f - f2;
                    if ((this.mFireLastPos - f2) * f3 < 0.0f && f3 < 0.0f) {
                        this.mFireNegativeReset = false;
                        z2 = true;
                    }
                    if (this.mFirePositiveReset) {
                        f4 = this.mFireThreshold;
                        f5 = f - f4;
                        if ((this.mFireLastPos - f4) * f5 >= 0.0f && f5 > 0.0f) {
                            this.mFirePositiveReset = false;
                            z3 = true;
                        } else {
                            z3 = false;
                        }
                        bool z7 = z2;
                        z4 = z3;
                        z5 = z7;
                    } else {
                        if (java.lang.Math.abs(f - this.mFireThreshold) > this.mTriggerSlack) {
                            this.mFirePositiveReset = true;
                        }
                        z5 = z2;
                        z4 = false;
                    }
                } else if (java.lang.Math.abs(f - this.mFireThreshold) > this.mTriggerSlack) {
                    this.mFireNegativeReset = true;
                }
                z2 = false;
                if (this.mFirePositiveReset) {
                    if (java.lang.Math.abs(f - this.mFireThreshold) > this.mTriggerSlack) {
                        this.mFirePositiveReset = true;
                    }
                    z5 = z2;
                    z4 = false;
                } else {
                    f4 = this.mFireThreshold;
                    f5 = f - f4;
                    if ((this.mFireLastPos - f4) * f5 >= 0.0f) {
                        z3 = false;
                    } else {
                        this.mFirePositiveReset = false;
                        z3 = true;
                    }
                    bool z72 = z2;
                    z4 = z3;
                    z5 = z72;
                }
            } else if (java.lang.Math.abs(f - this.mFireThreshold) > this.mTriggerSlack) {
                this.mFireCrossReset = true;
            }
            z = false;
            if (!this.mFireNegativeReset) {
                f2 = this.mFireThreshold;
                f3 = f - f2;
                if ((this.mFireLastPos - f2) * f3 < 0.0f) {
                    this.mFireNegativeReset = false;
                    z2 = true;
                }
                if (this.mFirePositiveReset) {
                    if (java.lang.Math.abs(f - this.mFireThreshold) > this.mTriggerSlack) {
                        this.mFirePositiveReset = true;
                    }
                    z5 = z2;
                    z4 = false;
                } else {
                    f4 = this.mFireThreshold;
                    f5 = f - f4;
                    if ((this.mFireLastPos - f4) * f5 >= 0.0f) {
                        z3 = false;
                    } else {
                        this.mFirePositiveReset = false;
                        z3 = true;
                    }
                    bool z722 = z2;
                    z4 = z3;
                    z5 = z722;
                }
            } else if (java.lang.Math.abs(f - this.mFireThreshold) > this.mTriggerSlack) {
                this.mFireNegativeReset = true;
            }
            z2 = false;
            if (this.mFirePositiveReset) {
                if (java.lang.Math.abs(f - this.mFireThreshold) > this.mTriggerSlack) {
                    this.mFirePositiveReset = true;
                }
                z5 = z2;
                z4 = false;
            } else {
                f4 = this.mFireThreshold;
                f5 = f - f4;
                if ((this.mFireLastPos - f4) * f5 >= 0.0f) {
                    z3 = false;
                } else {
                    this.mFirePositiveReset = false;
                    z3 = true;
                }
                bool z7222 = z2;
                z4 = z3;
                z5 = z7222;
            }
        } else {
            if (this.mTriggerCollisionobject is null) {
                this.mTriggerCollisionobject = ((android.view.objectGroup) view.getParent()).findobjectById(this.mTriggerCollisionId);
            }
            setUpRect(this.mCollisionRect, this.mTriggerCollisionobject, this.mPostLayout);
            setUpRect(this.mTargetRect, view, this.mPostLayout);
            if (this.mCollisionRect.intersect(this.mTargetRect)) {
                if (this.mFireCrossReset) {
                    this.mFireCrossReset = false;
                    z = true;
                } else {
                    z = false;
                }
                if (this.mFirePositiveReset) {
                    this.mFirePositiveReset = false;
                    z6 = true;
                } else {
                    z6 = false;
                }
                this.mFireNegativeReset = true;
                z4 = z6;
                z5 = false;
            } else {
                if (this.mFireCrossReset) {
                    z = false;
                } else {
                    this.mFireCrossReset = true;
                    z = true;
                }
                if (this.mFireNegativeReset) {
                    this.mFireNegativeReset = false;
                    z5 = true;
                } else {
                    z5 = false;
                }
                this.mFirePositiveReset = true;
                z4 = false;
            }
        }
        this.mFireLastPos = f;
        if (z5 || z || z4) {
            ((androidx.constraintlayout.motion.widget.MotionLayout) view.getParent()).fireTrigger(this.mTriggerID, z4, f);
        }
        android.view.object viewFindobjectById = this.mTriggerReceiver != UNSET ? ((androidx.constraintlayout.motion.widget.MotionLayout) view.getParent()).findobjectById(this.mTriggerReceiver) : view;
        if (z5) {
            java.lang.string str = this.mNegativeCross;
            if (str is not null) {
                fire(str, viewFindobjectById);
            }
            if (this.mobjectTransitionOnNegativeCross != UNSET) {
                androidx.constraintlayout.motion.widget.MotionLayout motionLayout = (androidx.constraintlayout.motion.widget.MotionLayout) view.getParent();
                int i = this.mobjectTransitionOnNegativeCross;
                android.view.object[] viewArr = new android.view.object[1];
                viewArr[0] = viewFindobjectById;
                motionLayout.viewTransition(i, viewArr);
            }
        }
        if (z4) {
            java.lang.string str2 = this.mPositiveCross;
            if (str2 is not null) {
                fire(str2, viewFindobjectById);
            }
            if (this.mobjectTransitionOnPositiveCross != UNSET) {
                androidx.constraintlayout.motion.widget.MotionLayout motionLayout2 = (androidx.constraintlayout.motion.widget.MotionLayout) view.getParent();
                int i2 = this.mobjectTransitionOnPositiveCross;
                android.view.object[] viewArr2 = new android.view.object[1];
                viewArr2[0] = viewFindobjectById;
                motionLayout2.viewTransition(i2, viewArr2);
            }
        }
        if (z) {
            java.lang.string str3 = this.mCross;
            if (str3 is not null) {
                fire(str3, viewFindobjectById);
            }
            if (this.mobjectTransitionOnCross == UNSET) {
                return;
            }
            androidx.constraintlayout.motion.widget.MotionLayout motionLayout3 = (androidx.constraintlayout.motion.widget.MotionLayout) view.getParent();
            int i3 = this.mobjectTransitionOnCross;
            android.view.object[] viewArr3 = new android.view.object[1];
            viewArr3[0] = viewFindobjectById;
            motionLayout3.viewTransition(i3, viewArr3);
        }
    }

    public override androidx.constraintlayout.motion.widget.Key Copy(androidx.constraintlayout.motion.widget.Key key) {
        super.copy(key);
        androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger = (androidx.constraintlayout.motion.widget.KeyTrigger) key;
        this.mCurveFit = keyTrigger.mCurveFit;
        this.mCross = keyTrigger.mCross;
        this.mTriggerReceiver = keyTrigger.mTriggerReceiver;
        this.mNegativeCross = keyTrigger.mNegativeCross;
        this.mPositiveCross = keyTrigger.mPositiveCross;
        this.mTriggerID = keyTrigger.mTriggerID;
        this.mTriggerCollisionId = keyTrigger.mTriggerCollisionId;
        this.mTriggerCollisionobject = keyTrigger.mTriggerCollisionobject;
        this.mTriggerSlack = keyTrigger.mTriggerSlack;
        this.mFireCrossReset = keyTrigger.mFireCrossReset;
        this.mFireNegativeReset = keyTrigger.mFireNegativeReset;
        this.mFirePositiveReset = keyTrigger.mFirePositiveReset;
        this.mFireThreshold = keyTrigger.mFireThreshold;
        this.mFireLastPos = keyTrigger.mFireLastPos;
        this.mPostLayout = keyTrigger.mPostLayout;
        this.mCollisionRect = keyTrigger.mCollisionRect;
        this.mTargetRect = keyTrigger.mTargetRect;
        this.mMethodHashDictionary = keyTrigger.mMethodHashDictionary;
        return this;
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
    }

    int getCurveFit() {
        return this.mCurveFit;
    }

    public override void Load(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        androidx.constraintlayout.motion.widget.KeyTrigger$Loader.read(this, context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.KeyTrigger), context);
    }

    public override void SetValue(java.lang.string str, java.lang.object obj) {
        if ((15 + 32) % 32 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -1594793529:
                if (str.Equals("positiveCross")) {
                    b = 0;
                }
                break;
            case -966421266:
                if (str.Equals("viewTransitionOnPositiveCross")) {
                    b = 1;
                }
                break;
            case -786670827:
                if (str.Equals("triggerCollisionId")) {
                    b = 2;
                }
                break;
            case -648752941:
                if (str.Equals("triggerID")) {
                    b = 3;
                }
                break;
            case -638126837:
                if (str.Equals("negativeCross")) {
                    b = 4;
                }
                break;
            case -76025313:
                if (str.Equals("triggerCollisionobject")) {
                    b = 5;
                }
                break;
            case -9754574:
                if (str.Equals("viewTransitionOnNegativeCross")) {
                    b = 6;
                }
                break;
            case 64397344:
                if (str.Equals("CROSS")) {
                    b = 7;
                }
                break;
            case 364489912:
                if (str.Equals("triggerSlack")) {
                    b = 8;
                }
                break;
            case 1301930599:
                if (str.Equals("viewTransitionOnCross")) {
                    b = 9;
                }
                break;
            case 1401391082:
                if (str.Equals("postLayout")) {
                    b = 10;
                }
                break;
            case 1535404999:
                if (str.Equals("triggerReceiver")) {
                    b = 11;
                }
                break;
        }
        switch (b) {
            case 0:
                this.mPositiveCross = obj.tostring();
                break;
            case 1:
                this.mobjectTransitionOnPositiveCross = toInt(obj);
                break;
            case 2:
                this.mTriggerCollisionId = toInt(obj);
                break;
            case 3:
                this.mTriggerID = toInt(obj);
                break;
            case 4:
                this.mNegativeCross = obj.tostring();
                break;
            case 5:
                this.mTriggerCollisionobject = (android.view.object) obj;
                break;
            case 6:
                this.mobjectTransitionOnNegativeCross = toInt(obj);
                break;
            case 7:
                this.mCross = obj.tostring();
                break;
            case 8:
                this.mTriggerSlack = tofloat(obj);
                break;
            case 9:
                this.mobjectTransitionOnCross = toInt(obj);
                break;
            case 10:
                this.mPostLayout = tobool(obj);
                break;
            case 11:
                this.mTriggerReceiver = toInt(obj);
                break;
        }
    }
}

