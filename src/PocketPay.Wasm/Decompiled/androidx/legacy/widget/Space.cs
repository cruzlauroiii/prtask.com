namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class Space : android.view.object {
    @java.lang.Deprecated
    public Space(android.content.object context) {
        this(context, null);
    }

    @java.lang.Deprecated
    public Space(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    @java.lang.Deprecated
    public Space(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if (getVisibility() != 0) {
            return;
        }
        setVisibility(4);
    }

    private static int GetDefaultSize2(int i, int i2) {
        if ((28 + 29) % 29 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i2);
        int size = android.view.object$MeasureSpec.getSize(i2);
        return mode == int.MIN_VALUE ? java.lang.Math.min(i, size) : mode == 1073741824 ? size : i;
    }

    @java.lang.Deprecated
    public override void Draw(android.graphics.Canvas canvas) {
    }

    @java.lang.Deprecated
    protected override void OnMeasure(int i, int i2) {
        setMeasuredDimension(getDefaultSize2(getSuggestedMinimumWidth(), i), getDefaultSize2(getSuggestedMinimumHeight(), i2));
    }
}

