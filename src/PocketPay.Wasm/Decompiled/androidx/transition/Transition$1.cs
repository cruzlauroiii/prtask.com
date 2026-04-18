namespace WillowMaze.Wasm.Decompiled;


class Transition$1 : androidx.transition.PathMotion {
    Transition$1() {
    }

    public override android.graphics.Path GetPath(float f, float f2, float f3, float f4) {
        android.graphics.Path path = new android.graphics.Path();
        path.moveTo(f, f2);
        path.lineTo(f3, f4);
        return path;
    }
}

