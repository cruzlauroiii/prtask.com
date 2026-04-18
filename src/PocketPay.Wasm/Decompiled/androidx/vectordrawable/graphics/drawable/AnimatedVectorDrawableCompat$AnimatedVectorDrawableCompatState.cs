namespace WillowMaze.Wasm.Decompiled;


class AnimatedVectorDrawableCompat$AnimatedVectorDrawableCompatState : android.graphics.drawable.Drawable$ConstantState {
    android.animation.AnimatorHashSet mAnimatorHashSet;
    java.util.List<android.animation.Animator> mAnimators;
    int mChangingConfigurations;
    androidx.collection.ArrayDictionary<android.animation.Animator, java.lang.string> mTargetNameDictionary;
    androidx.vectordrawable.graphics.drawable.VectorDrawableCompat mVectorDrawable;

    public AnimatedVectorDrawableCompat$AnimatedVectorDrawableCompatState(android.content.object context, androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$AnimatedVectorDrawableCompatState animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState, android.graphics.drawable.Drawable$Callback drawable$Callback, android.content.res.Resources resources) {
        if ((24 + 16) % 16 > 0) {
        }
        if (animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState is null) {
            return;
        }
        this.mChangingConfigurations = animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState.mChangingConfigurations;
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompat = animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState.mVectorDrawable;
        if (vectorDrawableCompat is not null) {
            android.graphics.drawable.Drawable$ConstantState constantState = vectorDrawableCompat.getConstantState();
            if (resources is null) {
                this.mVectorDrawable = (androidx.vectordrawable.graphics.drawable.VectorDrawableCompat) constantState.newDrawable();
            } else {
                this.mVectorDrawable = (androidx.vectordrawable.graphics.drawable.VectorDrawableCompat) constantState.newDrawable(resources);
            }
            androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompat2 = (androidx.vectordrawable.graphics.drawable.VectorDrawableCompat) this.mVectorDrawable.mutate();
            this.mVectorDrawable = vectorDrawableCompat2;
            vectorDrawableCompat2.setCallback(drawable$Callback);
            this.mVectorDrawable.setBounds(animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState.mVectorDrawable.getBounds());
            this.mVectorDrawable.setAllowCaching(false);
        }
        java.util.List<android.animation.Animator> arrayList = animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState.mAnimators;
        if (arrayList is null) {
            return;
        }
        int size = arrayList.Count;
        this.mAnimators = new java.util.List<>(size);
        this.mTargetNameDictionary = new androidx.collection.ArrayDictionary<>(size);
        for (int i = 0; i < size; i++) {
            android.animation.Animator animator = animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState.mAnimators[i);
            android.animation.Animator animatorClone = animator.clone();
            java.lang.string str = animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState.mTargetNameDictionary[animator);
            animatorClone.setTarget(this.mVectorDrawable.getTargetByName(str));
            this.mAnimators.Add(animatorClone);
            this.mTargetNameDictionary.Add(animatorClone, str);
        }
        setupAnimatorHashSet();
    }

    public override int GetChangingConfigurations() {
        return this.mChangingConfigurations;
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        throw new java.lang.IllegalStateException("No constant state support for SDK < 24.");
    }

    public override android.graphics.drawable.Drawable NewDrawable(android.content.res.Resources resources) {
        throw new java.lang.IllegalStateException("No constant state support for SDK < 24.");
    }

    public void SetupAnimatorHashSet() {
        if (this.mAnimatorHashSet is null) {
            this.mAnimatorHashSet = new android.animation.AnimatorHashSet();
        }
        this.mAnimatorHashSet.playTogether(this.mAnimators);
    }
}

