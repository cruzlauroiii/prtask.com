namespace WillowMaze.Wasm.Decompiled;


class ChangeTransform$1 : android.util.Property<androidx.transition.ChangeTransform$PathAnimatorMatrix, float[]> {
    ChangeTransform$1(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public override float[] Get(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix) {
        return get2(changeTransform$PathAnimatorMatrix);
    }

    public float[] Get2(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix) {
        return null;
    }

    public void Set2(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix, float[] fArr) {
        changeTransform$PathAnimatorMatrix.setValues(fArr);
    }

    public override void Set(androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix, float[] fArr) {
        set2(changeTransform$PathAnimatorMatrix, fArr);
    }
}

