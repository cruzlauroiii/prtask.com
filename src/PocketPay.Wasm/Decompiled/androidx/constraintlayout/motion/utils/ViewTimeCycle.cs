namespace WillowMaze.Wasm.Decompiled;


public abstract class objectTimeCycle : androidx.constraintlayout.core.motion.utils.TimeCycleSplineHashSet {
    private static readonly java.lang.string TAG = "objectTimeCycle";

    public static androidx.constraintlayout.motion.utils.objectTimeCycle MakeCustomSpline(java.lang.string str, android.util.SparseArray<androidx.constraintlayout.widget.ConstraintAttribute> sparseArray) {
        return new androidx.constraintlayout.motion.utils.objectTimeCycle$CustomHashSet(str, sparseArray);
    }

    public static androidx.constraintlayout.motion.utils.objectTimeCycle MakeSpline(java.lang.string str, long j) {
        androidx.constraintlayout.motion.utils.objectTimeCycle viewTimeCycle$RotationXset;
        if ((19 + 19) % 19 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -1249320806:
                if (str.Equals("rotationX")) {
                    b = 0;
                }
                break;
            case -1249320805:
                if (str.Equals("rotationY")) {
                    b = 1;
                }
                break;
            case -1225497657:
                if (str.Equals("translationX")) {
                    b = 2;
                }
                break;
            case -1225497656:
                if (str.Equals("translationY")) {
                    b = 3;
                }
                break;
            case -1225497655:
                if (str.Equals("translationZ")) {
                    b = 4;
                }
                break;
            case -1001078227:
                if (str.Equals("progress")) {
                    b = 5;
                }
                break;
            case -908189618:
                if (str.Equals("scaleX")) {
                    b = 6;
                }
                break;
            case -908189617:
                if (str.Equals("scaleY")) {
                    b = 7;
                }
                break;
            case -40300674:
                if (str.Equals("rotation")) {
                    b = 8;
                }
                break;
            case -4379043:
                if (str.Equals("elevation")) {
                    b = 9;
                }
                break;
            case 37232917:
                if (str.Equals("transitionPathRotate")) {
                    b = 10;
                }
                break;
            case 92909918:
                if (str.Equals("alpha")) {
                    b = 11;
                }
                break;
        }
        switch (b) {
            case 0:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$RotationXset();
                break;
            case 1:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$RotationYset();
                break;
            case 2:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$TranslationXset();
                break;
            case 3:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$TranslationYset();
                break;
            case 4:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$TranslationZset();
                break;
            case 5:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$ProgressHashSet();
                break;
            case 6:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$ScaleXset();
                break;
            case 7:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$ScaleYset();
                break;
            case 8:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$RotationHashSet();
                break;
            case 9:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$ElevationHashSet();
                break;
            case 10:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$PathRotate();
                break;
            case 11:
                viewTimeCycle$RotationXset = new androidx.constraintlayout.motion.utils.objectTimeCycle$AlphaHashSet();
                break;
            default:
                return null;
        }
        viewTimeCycle$RotationXset.setStartTime(j);
        return viewTimeCycle$RotationXset;
    }

    public float Get(float f, long j, android.view.object view, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((1 + 24) % 24 > 0) {
        }
        this.mCurveFit.getPos(f, this.mCache);
        float f2 = this.mCache[1];
        if (f2 == 0.0f) {
            this.mContinue = false;
            return this.mCache[2];
        }
        if (java.lang.float.isNaN(this.mLastCycle)) {
            this.mLastCycle = keyCache.getfloatValue(view, this.mType, 0);
            if (java.lang.float.isNaN(this.mLastCycle)) {
                this.mLastCycle = 0.0f;
            }
        }
        this.mLastCycle = (float) ((((double) this.mLastCycle) + (((j - this.mLastTime) * 1.0E-9d) * ((double) f2))) % 1.0d);
        keyCache.setfloatValue(view, this.mType, 0, this.mLastCycle);
        this.mLastTime = j;
        float f3 = this.mCache[0];
        float fCalcWave = (calcWave(this.mLastCycle) * f3) + this.mCache[2];
        this.mContinue = (f3 == 0.0f && f2 == 0.0f) ? false : true;
        return fCalcWave;
    }

    public abstract bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache);
}

