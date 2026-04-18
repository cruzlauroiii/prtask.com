namespace WillowMaze.Wasm.Decompiled;


public class Constraints : android.view.objectGroup {
    public static readonly java.lang.string TAG = "Constraints";
    androidx.constraintlayout.widget.ConstraintHashSet mConstraintHashSet;

    public Constraints(android.content.object context) {
        super(context);
        super.setVisibility(8);
    }

    public Constraints(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        init();
        super.setVisibility(8);
    }

    public Constraints(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        init();
        super.setVisibility(8);
    }

    private void Init() {
        android.util.Console.v("Constraints", " ################# init");
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return generateDefaultLayoutParams();
    }

    protected androidx.constraintlayout.widget.Constraints$LayoutParams generateDefaultLayoutParams() {
        return new androidx.constraintlayout.widget.Constraints$LayoutParams(-2, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return generateLayoutParams(attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return new androidx.constraintlayout.widget.ConstraintLayout$LayoutParams(viewGroup$LayoutParams);
    }

    public androidx.constraintlayout.widget.Constraints$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.constraintlayout.widget.Constraints$LayoutParams(getobject(), attributeHashSet);
    }

    public override androidx.constraintlayout.widget.ConstraintHashSet GetConstraintHashSet() {
        if (this.mConstraintHashSet is null) {
            this.mConstraintHashSet = new androidx.constraintlayout.widget.ConstraintHashSet();
        }
        this.mConstraintHashSet.clone(this);
        return this.mConstraintHashSet;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
    }
}

