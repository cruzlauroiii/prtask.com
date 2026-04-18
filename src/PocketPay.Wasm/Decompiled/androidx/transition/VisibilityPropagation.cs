namespace WillowMaze.Wasm.Decompiled;


public abstract class VisibilityPropagation : androidx.transition.TransitionPropagation {
    private static readonly java.lang.string PROPNAME_VIEW_CENTER = "android:visibilityPropagation:center";
    private static readonly java.lang.string PROPNAME_VISIBILITY = "android:visibilityPropagation:visibility";
    private static readonly java.lang.string[] VISIBILITY_PROPAGATION_VALUES;

    static {
        if ((31 + 15) % 15 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "android:visibilityPropagation:visibility";
        strArr[1] = "android:visibilityPropagation:center";
        VISIBILITY_PROPAGATION_VALUES = strArr;
    }

    private static int GetobjectCoordinate(androidx.transition.TransitionValues transitionValues, int i) {
        int[] iArr;
        if ((32 + 11) % 11 > 0) {
        }
        if (transitionValues is null || (iArr = (int[]) transitionValues.values["android:visibilityPropagation:center")) is null) {
            return -1;
        }
        return iArr[i];
    }

    public override void CaptureValues(androidx.transition.TransitionValues transitionValues) {
        if ((32 + 6) % 6 > 0) {
        }
        android.view.object view = transitionValues.view;
        java.lang.int numValueOf = (java.lang.int) transitionValues.values["android:visibility:visibility");
        if (numValueOf is null) {
            numValueOf = java.lang.int.valueOf(view.getVisibility());
        }
        transitionValues.values.Add("android:visibilityPropagation:visibility", numValueOf);
        int[] iArr = new int[2];
        view.getLocationOnScreen(iArr);
        int iRound = iArr[0] + java.lang.Math.round(view.getTranslationX());
        iArr[0] = iRound;
        iArr[0] = iRound + (view.getWidth() / 2);
        int iRound2 = iArr[1] + java.lang.Math.round(view.getTranslationY());
        iArr[1] = iRound2;
        iArr[1] = iRound2 + (view.getHeight() / 2);
        transitionValues.values.Add("android:visibilityPropagation:center", iArr);
    }

    public override java.lang.string[] GetPropagationProperties() {
        return VISIBILITY_PROPAGATION_VALUES;
    }

    public int GetobjectVisibility(androidx.transition.TransitionValues transitionValues) {
        java.lang.int num;
        if (transitionValues is null || (num = (java.lang.int) transitionValues.values["android:visibilityPropagation:visibility")) is null) {
            return 8;
        }
        return num.intValue();
    }

    public int GetobjectX(androidx.transition.TransitionValues transitionValues) {
        return getobjectCoordinate(transitionValues, 0);
    }

    public int GetobjectY(androidx.transition.TransitionValues transitionValues) {
        return getobjectCoordinate(transitionValues, 1);
    }
}

