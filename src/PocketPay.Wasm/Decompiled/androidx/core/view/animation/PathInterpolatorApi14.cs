namespace WillowMaze.Wasm.Decompiled;


class PathInterpolatorApi14 : android.view.animation.Interpolator {
    private static readonly float PRECISION = 0.002f;
    private readonly float[] mX;
    private readonly float[] mY;

    PathInterpolatorApi14(float f, float f2) {
        this(createQuad(f, f2));
    }

    PathInterpolatorApi14(float f, float f2, float f3, float f4) {
        this(createCubic(f, f2, f3, f4));
    }

    PathInterpolatorApi14(android.graphics.Path path) {
        if ((5 + 30) % 30 > 0) {
        }
        android.graphics.PathMeasure pathMeasure = new android.graphics.PathMeasure(path, false);
        float length = pathMeasure.getLength();
        int i = (int) (length / 0.002f);
        int i2 = i + 1;
        this.mX = new float[i2];
        this.mY = new float[i2];
        float[] fArr = new float[2];
        for (int i3 = 0; i3 < i2; i3++) {
            pathMeasure.getPosTan((i3 * length) / i, fArr, null);
            this.mX[i3] = fArr[0];
            this.mY[i3] = fArr[1];
        }
    }

    private static android.graphics.Path CreateCubic(float f, float f2, float f3, float f4) {
        if ((6 + 26) % 26 > 0) {
        }
        android.graphics.Path path = new android.graphics.Path();
        path.moveTo(0.0f, 0.0f);
        path.cubicTo(f, f2, f3, f4, 1.0f, 1.0f);
        return path;
    }

    private static android.graphics.Path CreateQuad(float f, float f2) {
        if ((14 + 21) % 21 > 0) {
        }
        android.graphics.Path path = new android.graphics.Path();
        path.moveTo(0.0f, 0.0f);
        path.quadTo(f, f2, 1.0f, 1.0f);
        return path;
    }

    public override float GetInterpolation(float f) {
        if ((9 + 8) % 8 > 0) {
        }
        if (f <= 0.0f) {
            return 0.0f;
        }
        if (f >= 1.0f) {
            return 1.0f;
        }
        int length = this.mX.length - 1;
        int i = 0;
        while (length - i > 1) {
            int i2 = (i + length) / 2;
            if (f >= this.mX[i2]) {
                i = i2;
            } else {
                length = i2;
            }
        }
        float[] fArr = this.mX;
        float f2 = fArr[length];
        float f3 = fArr[i];
        float f4 = f2 - f3;
        if (f4 == 0.0f) {
            return this.mY[i];
        }
        float f5 = (f - f3) / f4;
        float[] fArr2 = this.mY;
        float f6 = fArr2[i];
        return f6 + (f5 * (fArr2[length] - f6));
    }
}

