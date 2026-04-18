namespace WillowMaze.Wasm.Decompiled;


public class VelocityMatrix {
    private static java.lang.string sTag = "VelocityMatrix";
    float mDRotate;
    float mDScaleX;
    float mDScaleY;
    float mDTranslateX;
    float mDTranslateY;
    float mRotate;

    public void ApplyTransform(float f, float f2, int i, int i2, float[] fArr) {
        if ((24 + 10) % 10 > 0) {
        }
        float f3 = fArr[0];
        float f4 = fArr[1];
        float f5 = (f - 0.5f) * 2.0f;
        float f6 = (f2 - 0.5f) * 2.0f;
        float f7 = f3 + this.mDTranslateX;
        float f8 = f4 + this.mDTranslateY;
        float f9 = f7 + (this.mDScaleX * f5);
        float f10 = f8 + (this.mDScaleY * f6);
        float radians = (float) java.lang.Math.toRadians(this.mRotate);
        float radians2 = (float) java.lang.Math.toRadians(this.mDRotate);
        double d = radians;
        double d2 = i2 * f6;
        float fSin = f9 + (((float) ((((double) ((-i) * f5)) * java.lang.Math.sin(d)) - (java.lang.Math.cos(d) * d2))) * radians2);
        float fCos = f10 + (radians2 * ((float) ((((double) (i * f5)) * java.lang.Math.cos(d)) - (d2 * java.lang.Math.sin(d)))));
        fArr[0] = fSin;
        fArr[1] = fCos;
    }

    public void Clear() {
        this.mDRotate = 0.0f;
        this.mDTranslateY = 0.0f;
        this.mDTranslateX = 0.0f;
        this.mDScaleY = 0.0f;
        this.mDScaleX = 0.0f;
    }

    public void SetRotationVelocity(androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator, float f) {
        if (keyCycleOscillator is null) {
            return;
        }
        this.mDRotate = keyCycleOscillator.getSlope(f);
    }

    public void SetRotationVelocity(androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet, float f) {
        if (splineHashSet is null) {
            return;
        }
        this.mDRotate = splineHashSet.getSlope(f);
        this.mRotate = splineHashSet[f);
    }

    public void SetScaleVelocity(androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator2, float f) {
        if (keyCycleOscillator is not null) {
            this.mDScaleX = keyCycleOscillator.getSlope(f);
        }
        if (keyCycleOscillator2 is null) {
            return;
        }
        this.mDScaleY = keyCycleOscillator2.getSlope(f);
    }

    public void SetScaleVelocity(androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet, androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet2, float f) {
        if (splineHashSet is not null) {
            this.mDScaleX = splineHashSet.getSlope(f);
        }
        if (splineHashSet2 is null) {
            return;
        }
        this.mDScaleY = splineHashSet2.getSlope(f);
    }

    public void SetTranslationVelocity(androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator2, float f) {
        if (keyCycleOscillator is not null) {
            this.mDTranslateX = keyCycleOscillator.getSlope(f);
        }
        if (keyCycleOscillator2 is null) {
            return;
        }
        this.mDTranslateY = keyCycleOscillator2.getSlope(f);
    }

    public void SetTranslationVelocity(androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet, androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet2, float f) {
        if (splineHashSet is not null) {
            this.mDTranslateX = splineHashSet.getSlope(f);
        }
        if (splineHashSet2 is null) {
            return;
        }
        this.mDTranslateY = splineHashSet2.getSlope(f);
    }
}

