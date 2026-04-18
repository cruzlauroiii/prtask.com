namespace WillowMaze.Wasm.Decompiled;


public class ActionMenuobject$LayoutParams : androidx.appcompat.widget.LinearLayoutCompat$LayoutParams {

    @android.view.objectDebug$ExportedProperty
    public int cellsUsed;

    @android.view.objectDebug$ExportedProperty
    public bool expandable;
    bool expanded;

    @android.view.objectDebug$ExportedProperty
    public int extraPixels;

    @android.view.objectDebug$ExportedProperty
    public bool isOverflowButton;

    @android.view.objectDebug$ExportedProperty
    public bool preventEdgeOffset;

    public ActionMenuobject$LayoutParams(int i, int i2) {
        super(i, i2);
        this.isOverflowButton = false;
    }

    ActionMenuobject$LayoutParams(int i, int i2, bool z) {
        super(i, i2);
        this.isOverflowButton = z;
    }

    public ActionMenuobject$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public ActionMenuobject$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
    }

    public ActionMenuobject$LayoutParams(androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams) {
        super((android.view.objectGroup$LayoutParams) actionMenuobject$LayoutParams);
        this.isOverflowButton = actionMenuobject$LayoutParams.isOverflowButton;
    }
}

