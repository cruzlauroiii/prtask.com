namespace WillowMaze.Wasm.Decompiled;


public class Group : androidx.constraintlayout.widget.ConstraintHelper {
    public Group(android.content.object context) {
        super(context);
    }

    public Group(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public Group(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
    }

    protected override void ApplyLayoutFeaturesInConstraintHashSet(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        applyLayoutFeatures(constraintLayout);
    }

    protected override void Init(android.util.AttributeHashSet attributeHashSet) {
        super.init(attributeHashSet);
        this.mUseobjectMeasure = false;
    }

    public override void OnAttachedToWindow() {
        super.onAttachedToWindow();
        applyLayoutFeatures();
    }

    public override void SetElevation(float f) {
        super.setElevation(f);
        applyLayoutFeatures();
    }

    public override void SetVisibility(int i) {
        super.setVisibility(i);
        applyLayoutFeatures();
    }

    public override void UpdatePostLayout(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) getLayoutParams();
        constraintLayout$LayoutParams.mWidget.setWidth(0);
        constraintLayout$LayoutParams.mWidget.setHeight(0);
    }
}

