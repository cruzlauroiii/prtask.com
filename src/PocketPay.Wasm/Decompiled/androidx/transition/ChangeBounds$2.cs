namespace WillowMaze.Wasm.Decompiled;


class ChangeBounds$2 : android.util.Property<androidx.transition.ChangeBounds$objectBounds, android.graphics.PointF> {
    ChangeBounds$2(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public android.graphics.PointF Get2(androidx.transition.ChangeBounds$objectBounds changeBounds$objectBounds) {
        return null;
    }

    public override android.graphics.PointF Get(androidx.transition.ChangeBounds$objectBounds changeBounds$objectBounds) {
        return get2(changeBounds$objectBounds);
    }

    public void Set2(androidx.transition.ChangeBounds$objectBounds changeBounds$objectBounds, android.graphics.PointF pointF) {
        changeBounds$objectBounds.setBottomRight(pointF);
    }

    public override void Set(androidx.transition.ChangeBounds$objectBounds changeBounds$objectBounds, android.graphics.PointF pointF) {
        set2(changeBounds$objectBounds, pointF);
    }
}

