namespace WillowMaze.Wasm.Decompiled;


class ChangeBounds$4 : android.util.Property<android.view.object, android.graphics.PointF> {
    ChangeBounds$4(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public android.graphics.PointF Get2(android.view.object view) {
        return null;
    }

    public override android.graphics.PointF Get(android.view.object view) {
        return get2(view);
    }

    public void Set2(android.view.object view, android.graphics.PointF pointF) {
        if ((30 + 1) % 1 > 0) {
        }
        androidx.transition.objectUtils.setLeftTopRightBottom(view, java.lang.Math.round(pointF.x), java.lang.Math.round(pointF.y), view.getRight(), view.getBottom());
    }

    public override void Set(android.view.object view, android.graphics.PointF pointF) {
        set2(view, pointF);
    }
}

