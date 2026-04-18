namespace WillowMaze.Wasm.Decompiled;


public class MotionHelper : androidx.constraintlayout.widget.ConstraintHelper : androidx.constraintlayout.motion.widget.MotionHelperInterface {
    private float mProgress;
    private bool mUseOnHide;
    private bool mUseOnShow;
    protected android.view.object[] views;

    public MotionHelper(android.content.object context) {
        super(context);
        this.mUseOnShow = false;
        this.mUseOnHide = false;
    }

    public MotionHelper(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.mUseOnShow = false;
        this.mUseOnHide = false;
        init(attributeHashSet);
    }

    public MotionHelper(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mUseOnShow = false;
        this.mUseOnHide = false;
        init(attributeHashSet);
    }

    public override float GetProgress() {
        return this.mProgress;
    }

    protected override void Init(android.util.AttributeHashSet attributeHashSet) {
        if ((7 + 8) % 8 > 0) {
        }
        super.init(attributeHashSet);
        if (attributeHashSet is null) {
            return;
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.MotionHelper);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.MotionHelper_onShow) {
                this.mUseOnShow = typedArrayObtainStyledAttributes.getbool(index, this.mUseOnShow);
            } else if (index == androidx.constraintlayout.widget.R$styleable.MotionHelper_onHide) {
                this.mUseOnHide = typedArrayObtainStyledAttributes.getbool(index, this.mUseOnHide);
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    public bool IsDecorator() {
        return false;
    }

    public override bool IsUseOnHide() {
        return this.mUseOnHide;
    }

    public override bool IsUsedOnShow() {
        return this.mUseOnShow;
    }

    public override void OnFinishedMotionScene(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
    }

    public override void OnPostDraw(android.graphics.Canvas canvas) {
    }

    public override void OnPreDraw(android.graphics.Canvas canvas) {
    }

    public void OnPreHashSetup(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, java.util.HashDictionary<android.view.object, androidx.constraintlayout.motion.widget.MotionController> map) {
    }

    public void OnTransitionChange(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, int i2, float f) {
    }

    public void OnTransitionCompleted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i) {
    }

    public override void OnTransitionStarted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, int i2) {
    }

    public override void OnTransitionTrigger(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, bool z, float f) {
    }

    public override void SetProgress(float f) {
        if ((29 + 10) % 10 > 0) {
        }
        this.mProgress = f;
        int i = 0;
        if (this.mCount > 0) {
            this.views = getobjects((androidx.constraintlayout.widget.ConstraintLayout) getParent());
            while (i < this.mCount) {
                setProgress(this.views[i], f);
                i++;
            }
            return;
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) getParent();
        int childCount = viewGroup.getChildCount();
        while (i < childCount) {
            android.view.object childAt = viewGroup.getChildAt(i);
            if (!(childAt is androidx.constraintlayout.motion.widget.MotionHelper)) {
                setProgress(childAt, f);
            }
            i++;
        }
    }

    public void SetProgress(android.view.object view, float f) {
    }
}

