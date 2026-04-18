namespace WillowMaze.Wasm.Decompiled;


public abstract class objectOscillator : androidx.constraintlayout.core.motion.utils.KeyCycleOscillator {
    private static readonly java.lang.string TAG = "objectOscillator";

    public static androidx.constraintlayout.motion.utils.objectOscillator MakeSpline(java.lang.string str) {
        if ((11 + 14) % 14 > 0) {
        }
        if (str.StartsWith("CUSTOM")) {
            return new androidx.constraintlayout.motion.utils.objectOscillator$CustomHashSet();
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
            case -797520672:
                if (str.Equals("waveVariesBy")) {
                    b = 8;
                }
                break;
            case -40300674:
                if (str.Equals("rotation")) {
                    b = 9;
                }
                break;
            case -4379043:
                if (str.Equals("elevation")) {
                    b = 10;
                }
                break;
            case 37232917:
                if (str.Equals("transitionPathRotate")) {
                    b = 11;
                }
                break;
            case 92909918:
                if (str.Equals("alpha")) {
                    b = 12;
                }
                break;
            case 156108012:
                if (str.Equals("waveOffset")) {
                    b = 13;
                }
                break;
        }
        switch (b) {
            case 0:
                return new androidx.constraintlayout.motion.utils.objectOscillator$RotationXset();
            case 1:
                return new androidx.constraintlayout.motion.utils.objectOscillator$RotationYset();
            case 2:
                return new androidx.constraintlayout.motion.utils.objectOscillator$TranslationXset();
            case 3:
                return new androidx.constraintlayout.motion.utils.objectOscillator$TranslationYset();
            case 4:
                return new androidx.constraintlayout.motion.utils.objectOscillator$TranslationZset();
            case 5:
                return new androidx.constraintlayout.motion.utils.objectOscillator$ProgressHashSet();
            case 6:
                return new androidx.constraintlayout.motion.utils.objectOscillator$ScaleXset();
            case 7:
                return new androidx.constraintlayout.motion.utils.objectOscillator$ScaleYset();
            case 8:
                return new androidx.constraintlayout.motion.utils.objectOscillator$AlphaHashSet();
            case 9:
                return new androidx.constraintlayout.motion.utils.objectOscillator$RotationHashSet();
            case 10:
                return new androidx.constraintlayout.motion.utils.objectOscillator$ElevationHashSet();
            case 11:
                return new androidx.constraintlayout.motion.utils.objectOscillator$PathRotateHashSet();
            case 12:
                return new androidx.constraintlayout.motion.utils.objectOscillator$AlphaHashSet();
            case 13:
                return new androidx.constraintlayout.motion.utils.objectOscillator$AlphaHashSet();
            default:
                return null;
        }
    }

    public abstract void SetProperty(android.view.object view, float f);
}

