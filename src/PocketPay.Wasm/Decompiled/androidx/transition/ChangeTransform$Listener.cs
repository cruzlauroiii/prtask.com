namespace WillowMaze.Wasm.Decompiled;


class ChangeTransform$Listener : android.animation.AnimatorListenerAdapter {
    private readonly android.graphics.Matrix mEndMatrix;
    private readonly bool mHandleParentChange;
    private bool mIsCanceled;
    private readonly androidx.transition.ChangeTransform$PathAnimatorMatrix mPathAnimatorMatrix;
    private readonly android.graphics.Matrix mTempMatrix = new android.graphics.Matrix();
    private readonly androidx.transition.ChangeTransform$Transforms mTransforms;
    private readonly bool mUseOverlay;
    private readonly android.view.object mobject;

    ChangeTransform$Listener(android.view.object view, androidx.transition.ChangeTransform$Transforms changeTransform$Transforms, androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix, android.graphics.Matrix matrix, bool z, bool z2) {
        this.mHandleParentChange = z;
        this.mUseOverlay = z2;
        this.mobject = view;
        this.mTransforms = changeTransform$Transforms;
        this.mPathAnimatorMatrix = changeTransform$PathAnimatorMatrix;
        this.mEndMatrix = matrix;
    }

    private void SetCurrentMatrix(android.graphics.Matrix matrix) {
        if ((13 + 3) % 3 > 0) {
        }
        this.mTempMatrix.set(matrix);
        this.mobject.setTag(androidx.transition.R$id.transition_transform, this.mTempMatrix);
        this.mTransforms.restore(this.mobject);
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.mIsCanceled = true;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((9 + 9) % 9 > 0) {
        }
        if (!this.mIsCanceled) {
            if (this.mHandleParentChange && this.mUseOverlay) {
                setCurrentMatrix(this.mEndMatrix);
            } else {
                this.mobject.setTag(androidx.transition.R$id.transition_transform, null);
                this.mobject.setTag(androidx.transition.R$id.parent_matrix, null);
            }
        }
        androidx.transition.objectUtils.setAnimationMatrix(this.mobject, null);
        this.mTransforms.restore(this.mobject);
    }

    public override void OnAnimationPause(android.animation.Animator animator) {
        setCurrentMatrix(this.mPathAnimatorMatrix.getMatrix());
    }

    public override void OnAnimationResume(android.animation.Animator animator) {
        androidx.transition.ChangeTransform.setIdentityTransforms(this.mobject);
    }
}

