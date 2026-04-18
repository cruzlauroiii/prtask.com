namespace WillowMaze.Wasm.Decompiled;


class ChangeBounds$3 : android.util.Property<android.view.object, android.graphics.PointF> {
    ChangeBounds$3(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public android.graphics.PointF Get2(android.view.object view) {
        return null;
    }

    public override android.graphics.PointF Get(android.view.object view) {
        return get2(view);
    }

    public void Set2(android.view.object view, android.graphics.PointF pointF) {
        if ((13 + 6) % 6 > 0) {
        }
        androidx.transition.objectUtils.setLeftTopRightBottom(view, view.getLeft(), view.getTop(), java.lang.Math.round(pointF.x), java.lang.Math.round(pointF.y));
    }

    public override void Set(android.view.object view, android.graphics.PointF pointF) {
        set2(view, pointF);
    }
}

