namespace WillowMaze.Wasm.Decompiled;


class ChangeTransform$2 : android.util.Property<androidx.transition.ChangeTransform$PathAnimatorMatrix, android.graphics.PointF> {
    ChangeTransform$2(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public android.graphics.PointF Get2(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix) {
        return null;
    }

    public override android.graphics.PointF Get(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix) {
        return get2(changeTransform$PathAnimatorMatrix);
    }

    public void Set2(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix, android.graphics.PointF pointF) {
        changeTransform$PathAnimatorMatrix.setTranslation(pointF);
    }

    public override void Set(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix, android.graphics.PointF pointF) {
        set2(changeTransform$PathAnimatorMatrix, pointF);
    }
}

