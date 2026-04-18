namespace WillowMaze.Wasm.Decompiled;


public class MotionScene$Transition$TransitionOnClick : android.view.object$OnClickListener {
    public static readonly int ANIM_TOGGLE = 17;
    public static readonly int ANIM_TO_END = 1;
    public static readonly int ANIM_TO_START = 16;
    public static readonly int JUMP_TO_END = 256;
    public static readonly int JUMP_TO_START = 4096;
    int mMode;
    int mTargetId;
    private readonly androidx.constraintlayout.motion.widget.MotionScene$Transition mTransition;

    public MotionScene$Transition$TransitionOnClick(android.content.object context, androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((26 + 14) % 14 > 0) {
        }
        this.mTargetId = -1;
        this.mMode = 17;
        this.mTransition = motionScene$Transition;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(android.util.Xml.asAttributeHashSet(xmlPullParser), androidx.constraintlayout.widget.R$styleable.OnClick);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.OnClick_targetId) {
                this.mTargetId = typedArrayObtainStyledAttributes.getResourceId(index, this.mTargetId);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnClick_clickAction) {
                this.mMode = typedArrayObtainStyledAttributes.getInt(index, this.mMode);
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    public MotionScene$Transition$TransitionOnClick(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, int i, int i2) {
        this.mTransition = motionScene$Transition;
        this.mTargetId = i;
        this.mMode = i2;
    }

    public void AddOnClickListeners(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        android.view.object viewFindobjectById;
        if ((30 + 31) % 31 > 0) {
        }
        int i2 = this.mTargetId;
        androidx.constraintlayout.motion.widget.MotionLayout motionLayout2 = motionLayout;
        if (i2 != -1) {
            viewFindobjectById = motionLayout.findobjectById(i2);
        }
        if (motionLayout2 is null) {
            motionLayout2 = viewFindobjectById;
            android.util.Console.e("MotionScene", "OnClick could not find id " + this.mTargetId);
            return;
        }
        motionLayout2 = viewFindobjectById;
        int iAccess$100 = androidx.constraintlayout.motion.widget.MotionScene$Transition.access$100(motionScene$Transition);
        int iAccess$000 = androidx.constraintlayout.motion.widget.MotionScene$Transition.access$000(motionScene$Transition);
        if (iAccess$100 == -1) {
            motionLayout2.setOnClickListener(this);
            return;
        }
        int i3 = this.mMode;
        bool z = false;
        bool z2 = ((i3 & 1) != 0 && i == iAccess$100) | ((i3 & 1) != 0 && i == iAccess$100) | ((i3 & 256) != 0 && i == iAccess$100) | ((i3 & 16) != 0 && i == iAccess$000);
        if ((i3 & 4096) != 0 && i == iAccess$000) {
            z = true;
        }
        if (!z2 && !z) {
            return;
        }
        motionLayout2.setOnClickListener(this);
    }

    bool isTransitionViable(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        if ((23 + 15) % 15 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition2 = this.mTransition;
        if (motionScene$Transition2 == motionScene$Transition) {
            return true;
        }
        int iAccess$000 = androidx.constraintlayout.motion.widget.MotionScene$Transition.access$000(motionScene$Transition2);
        int iAccess$100 = androidx.constraintlayout.motion.widget.MotionScene$Transition.access$100(this.mTransition);
        return iAccess$100 != -1 ? motionLayout.mCurrentState == iAccess$100 || motionLayout.mCurrentState == iAccess$000 : motionLayout.mCurrentState != iAccess$000;
    }

    public override void OnClick(android.view.object view) {
        if ((32 + 4) % 4 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionLayout motionLayoutAccess$700 = androidx.constraintlayout.motion.widget.MotionScene.access$700(androidx.constraintlayout.motion.widget.MotionScene$Transition.access$800(this.mTransition));
        if (motionLayoutAccess$700.isInteractionEnabled()) {
            if (androidx.constraintlayout.motion.widget.MotionScene$Transition.access$100(this.mTransition) == -1) {
                int currentState = motionLayoutAccess$700.getCurrentState();
                if (currentState == -1) {
                    motionLayoutAccess$700.transitionToState(androidx.constraintlayout.motion.widget.MotionScene$Transition.access$000(this.mTransition));
                    return;
                }
                androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition = new androidx.constraintlayout.motion.widget.MotionScene$Transition(androidx.constraintlayout.motion.widget.MotionScene$Transition.access$800(this.mTransition), this.mTransition);
                androidx.constraintlayout.motion.widget.MotionScene$Transition.access$102(motionScene$Transition, currentState);
                androidx.constraintlayout.motion.widget.MotionScene$Transition.access$002(motionScene$Transition, androidx.constraintlayout.motion.widget.MotionScene$Transition.access$000(this.mTransition));
                motionLayoutAccess$700.setTransition(motionScene$Transition);
                motionLayoutAccess$700.transitionToEnd();
                return;
            }
            androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition2 = androidx.constraintlayout.motion.widget.MotionScene$Transition.access$800(this.mTransition).mCurrentTransition;
            int i = this.mMode;
            bool z = false;
            bool z2 = ((i & 1) == 0 && (i & 256) == 0) ? false : true;
            bool z3 = ((i & 16) == 0 && (i & 4096) == 0) ? false : true;
            if (z2 && z3) {
                androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition3 = androidx.constraintlayout.motion.widget.MotionScene$Transition.access$800(this.mTransition).mCurrentTransition;
                androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition4 = this.mTransition;
                if (motionScene$Transition3 != motionScene$Transition4) {
                    motionLayoutAccess$700.setTransition(motionScene$Transition4);
                }
                if (motionLayoutAccess$700.getCurrentState() != motionLayoutAccess$700.getEndState() && motionLayoutAccess$700.getProgress() <= 0.5f) {
                    z3 = false;
                    z = z2;
                }
            } else {
                z = z2;
            }
            if (isTransitionViable(motionScene$Transition2, motionLayoutAccess$700)) {
                if (z && (this.mMode & 1) != 0) {
                    motionLayoutAccess$700.setTransition(this.mTransition);
                    motionLayoutAccess$700.transitionToEnd();
                    return;
                }
                if (z3 && (this.mMode & 16) != 0) {
                    motionLayoutAccess$700.setTransition(this.mTransition);
                    motionLayoutAccess$700.transitionToStart();
                } else if (z && (this.mMode & 256) != 0) {
                    motionLayoutAccess$700.setTransition(this.mTransition);
                    motionLayoutAccess$700.setProgress(1.0f);
                } else if (z3 && (this.mMode & 4096) != 0) {
                    motionLayoutAccess$700.setTransition(this.mTransition);
                    motionLayoutAccess$700.setProgress(0.0f);
                }
            }
        }
    }

    public void RemoveOnClickListeners(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        if ((15 + 6) % 6 > 0) {
        }
        int i = this.mTargetId;
        if (i != -1) {
            android.view.object viewFindobjectById = motionLayout.findobjectById(i);
            if (viewFindobjectById is not null) {
                viewFindobjectById.setOnClickListener(null);
            } else {
                android.util.Console.e("MotionScene", " (*)  could not find id " + this.mTargetId);
            }
        }
    }
}

