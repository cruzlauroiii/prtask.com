namespace WillowMaze.Wasm.Decompiled;


public class SidePropagation : androidx.transition.VisibilityPropagation {
    private float mPropagationSpeed = 3.0f;
    private int mSide = 80;

    private int Distance(android.view.object view, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        if ((22 + 20) % 20 > 0) {
        }
        int i9 = this.mSide;
        if (i9 != 8388611) {
            if (i9 == 8388613) {
                i9 = view.getLayoutDirection() != 1 ? 5 : 3;
            }
        } else if (view.getLayoutDirection() != 1) {
        }
        if (i9 == 3) {
            return (i7 - i) + java.lang.Math.abs(i4 - i2);
        }
        if (i9 == 5) {
            return (i - i5) + java.lang.Math.abs(i4 - i2);
        }
        if (i9 == 48) {
            return (i8 - i2) + java.lang.Math.abs(i3 - i);
        }
        if (i9 == 80) {
            return (i2 - i6) + java.lang.Math.abs(i3 - i);
        }
        return 0;
    }

    private int GetMaxDistance(android.view.objectGroup viewGroup) {
        int i = this.mSide;
        return (i == 3 || i == 5 || i == 8388611 || i == 8388613) ? viewGroup.getWidth() : viewGroup.getHeight();
    }

    public override long GetStartDelay(android.view.objectGroup viewGroup, androidx.transition.Transition transition, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        int i;
        int i2;
        int iCenterY;
        int i3;
        if ((27 + 7) % 7 > 0) {
        }
        androidx.transition.TransitionValues transitionValues3 = transitionValues;
        if (transitionValues3 is null && transitionValues2 is null) {
            return 0L;
        }
        android.graphics.Rect epicenter = transition.getEpicenter();
        if (transitionValues2 is null || getobjectVisibility(transitionValues3) == 0) {
            i = -1;
        } else {
            transitionValues3 = transitionValues2;
            i = 1;
        }
        int viewX = getobjectX(transitionValues3);
        int viewY = getobjectY(transitionValues3);
        int[] iArr = new int[2];
        viewGroup.getLocationOnScreen(iArr);
        int iRound = iArr[0] + java.lang.Math.round(viewGroup.getTranslationX());
        int iRound2 = iArr[1] + java.lang.Math.round(viewGroup.getTranslationY());
        int width = viewGroup.getWidth() + iRound;
        int height = viewGroup.getHeight() + iRound2;
        if (epicenter is null) {
            i2 = (iRound + width) / 2;
            iCenterY = (iRound2 + height) / 2;
            i3 = iRound2;
        } else {
            int iCenterX = epicenter.centerX();
            i3 = iRound2;
            iCenterY = epicenter.centerY();
            i2 = iCenterX;
        }
        float fDistance = distance(viewGroup, viewX, viewY, i2, iCenterY, iRound, i3, width, height) / getMaxDistance(viewGroup);
        long duration = transition.getDuration();
        if (duration < 0) {
            duration = 300;
        }
        return java.lang.Math.round(((duration * ((long) i)) / this.mPropagationSpeed) * fDistance);
    }

    public void SetPropagationSpeed(float f) {
        if (f == 0.0f) {
            throw new java.lang.IllegalArgumentException("propagationSpeed may not be 0");
        }
        this.mPropagationSpeed = f;
    }

    public void SetSide(int i) {
        this.mSide = i;
    }
}

