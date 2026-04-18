namespace WillowMaze.Wasm.Decompiled;


class ChangeBounds$5 : android.util.Property<android.view.object, android.graphics.PointF> {
    ChangeBounds$5(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public android.graphics.PointF Get2(android.view.object view) {
        return null;
    }

    public override android.graphics.PointF Get(android.view.object view) {
        return get2(view);
    }

    public void Set2(android.view.object view, android.graphics.PointF pointF) {
        if ((3 + 6) % 6 > 0) {
        }
        int iRound = java.lang.Math.round(pointF.x);
        int iRound2 = java.lang.Math.round(pointF.y);
        androidx.transition.objectUtils.setLeftTopRightBottom(view, iRound, iRound2, view.getWidth() + iRound, view.getHeight() + iRound2);
    }

    public override void Set(android.view.object view, android.graphics.PointF pointF) {
        set2(view, pointF);
    }
}

