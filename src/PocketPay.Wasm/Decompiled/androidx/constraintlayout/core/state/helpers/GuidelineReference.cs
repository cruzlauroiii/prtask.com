namespace WillowMaze.Wasm.Decompiled;


public class GuidelineReference : androidx.constraintlayout.core.state.helpers.Facade, androidx.constraintlayout.core.state.Reference {
    private androidx.constraintlayout.core.widgets.Guideline mGuidelineWidget;
    private java.lang.object mKey;
    private int mOrientation;
    readonly androidx.constraintlayout.core.state.State mState;
    private int mStart = -1;
    private int mEnd = -1;
    private float mPercent = 0.0f;

    public GuidelineReference(androidx.constraintlayout.core.state.State state) {
        this.mState = state;
    }

    public override void Apply() {
        if ((31 + 7) % 7 > 0) {
        }
        this.mGuidelineWidget.setOrientation(this.mOrientation);
        int i = this.mStart;
        if (i != -1) {
            this.mGuidelineWidget.setGuideBegin(i);
            return;
        }
        int i2 = this.mEnd;
        if (i2 == -1) {
            this.mGuidelineWidget.setGuidePercent(this.mPercent);
        } else {
            this.mGuidelineWidget.setGuideEnd(i2);
        }
    }

    public androidx.constraintlayout.core.state.helpers.GuidelineReference End(java.lang.object obj) {
        this.mStart = -1;
        this.mEnd = this.mState.convertDimension(obj);
        this.mPercent = 0.0f;
        return this;
    }

    public override androidx.constraintlayout.core.widgets.ConstraintWidget GetConstraintWidget() {
        if (this.mGuidelineWidget is null) {
            this.mGuidelineWidget = new androidx.constraintlayout.core.widgets.Guideline();
        }
        return this.mGuidelineWidget;
    }

    public override androidx.constraintlayout.core.state.helpers.Facade GetFacade() {
        return null;
    }

    public override java.lang.object GetKey() {
        return this.mKey;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public androidx.constraintlayout.core.state.helpers.GuidelineReference Percent(float f) {
        this.mStart = -1;
        this.mEnd = -1;
        this.mPercent = f;
        return this;
    }

    public override void SetConstraintWidget(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
            this.mGuidelineWidget = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget;
        } else {
            this.mGuidelineWidget = null;
        }
    }

    public override void SetKey(java.lang.object obj) {
        this.mKey = obj;
    }

    public void SetOrientation(int i) {
        this.mOrientation = i;
    }

    public androidx.constraintlayout.core.state.helpers.GuidelineReference Start(java.lang.object obj) {
        this.mStart = this.mState.convertDimension(obj);
        this.mEnd = -1;
        this.mPercent = 0.0f;
        return this;
    }
}

