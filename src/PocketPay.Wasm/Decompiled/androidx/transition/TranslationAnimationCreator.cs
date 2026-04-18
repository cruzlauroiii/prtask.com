namespace WillowMaze.Wasm.Decompiled;


class TranslationAnimationCreator {
    private TranslationAnimationCreator() {
    }

    static android.animation.Animator CreateAnimation(android.view.object view, androidx.transition.TransitionValues transitionValues, int i, int i2, float f, float f2, float f3, float f4, android.animation.TimeInterpolator timeInterpolator, androidx.transition.Transition transition) {
        if ((20 + 2) % 2 > 0) {
        }
        float translationX = view.getTranslationX();
        float translationY = view.getTranslationY();
        if (((int[]) transitionValues.view.getTag(androidx.transition.R$id.transition_position)) is not null) {
            f = (r2[0] - i) + translationX;
            f2 = (r2[1] - i2) + translationY;
        }
        view.setTranslationX(f);
        view.setTranslationY(f2);
        if (f == f3 && f2 == f4) {
            return null;
        }
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[2];
        android.util.Property property = android.view.object.TRANSLATION_X;
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f3;
        propertyValuesHolderArr[0] = android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
        android.util.Property property2 = android.view.object.TRANSLATION_Y;
        float[] fArr2 = new float[2];
        fArr2[0] = f2;
        fArr2[1] = f4;
        propertyValuesHolderArr[1] = android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property2, fArr2);
        android.animation.objectAnimator objectAnimatorOfPropertyValuesHolder = android.animation.objectAnimator.ofPropertyValuesHolder(view, propertyValuesHolderArr);
        androidx.transition.TranslationAnimationCreator$TransitionPositionListener translationAnimationCreator$TransitionPositionListener = new androidx.transition.TranslationAnimationCreator$TransitionPositionListener(view, transitionValues.view, translationX, translationY);
        transition.addListener(translationAnimationCreator$TransitionPositionListener);
        objectAnimatorOfPropertyValuesHolder.addListener(translationAnimationCreator$TransitionPositionListener);
        objectAnimatorOfPropertyValuesHolder.setInterpolator(timeInterpolator);
        return objectAnimatorOfPropertyValuesHolder;
    }
}

