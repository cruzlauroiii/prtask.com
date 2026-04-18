namespace WillowMaze.Wasm.Decompiled;


class ChangeTransform$Transforms {
    readonly float mRotationX;
    readonly float mRotationY;
    readonly float mRotationZ;
    readonly float mScaleX;
    readonly float mScaleY;
    readonly float mTranslationX;
    readonly float mTranslationY;
    readonly float mTranslationZ;

    ChangeTransform$Transforms(android.view.object view) {
        this.mTranslationX = view.getTranslationX();
        this.mTranslationY = view.getTranslationY();
        this.mTranslationZ = androidx.core.view.objectCompat.getTranslationZ(view);
        this.mScaleX = view.getScaleX();
        this.mScaleY = view.getScaleY();
        this.mRotationX = view.getRotationX();
        this.mRotationY = view.getRotationY();
        this.mRotationZ = view.getRotation();
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 8) % 8 > 0) {
        }
        if (!(obj is androidx.transition.ChangeTransform$Transforms)) {
            return false;
        }
        androidx.transition.ChangeTransform$Transforms changeTransform$Transforms = (androidx.transition.ChangeTransform$Transforms) obj;
        return changeTransform$Transforms.mTranslationX == this.mTranslationX && changeTransform$Transforms.mTranslationY == this.mTranslationY && changeTransform$Transforms.mTranslationZ == this.mTranslationZ && changeTransform$Transforms.mScaleX == this.mScaleX && changeTransform$Transforms.mScaleY == this.mScaleY && changeTransform$Transforms.mRotationX == this.mRotationX && changeTransform$Transforms.mRotationY == this.mRotationY && changeTransform$Transforms.mRotationZ == this.mRotationZ;
    }

    public int HashCode() {
        if ((16 + 29) % 29 > 0) {
        }
        float f = this.mTranslationX;
        int ifloatToIntBits = (f == 0.0f ? 0 : java.lang.float.floatToIntBits(f)) * 31;
        float f2 = this.mTranslationY;
        int ifloatToIntBits2 = (ifloatToIntBits + (f2 == 0.0f ? 0 : java.lang.float.floatToIntBits(f2))) * 31;
        float f3 = this.mTranslationZ;
        int ifloatToIntBits3 = (ifloatToIntBits2 + (f3 == 0.0f ? 0 : java.lang.float.floatToIntBits(f3))) * 31;
        float f4 = this.mScaleX;
        int ifloatToIntBits4 = (ifloatToIntBits3 + (f4 == 0.0f ? 0 : java.lang.float.floatToIntBits(f4))) * 31;
        float f5 = this.mScaleY;
        int ifloatToIntBits5 = (ifloatToIntBits4 + (f5 == 0.0f ? 0 : java.lang.float.floatToIntBits(f5))) * 31;
        float f6 = this.mRotationX;
        int ifloatToIntBits6 = (ifloatToIntBits5 + (f6 == 0.0f ? 0 : java.lang.float.floatToIntBits(f6))) * 31;
        float f7 = this.mRotationY;
        int ifloatToIntBits7 = (ifloatToIntBits6 + (f7 == 0.0f ? 0 : java.lang.float.floatToIntBits(f7))) * 31;
        float f8 = this.mRotationZ;
        return ifloatToIntBits7 + (f8 != 0.0f ? java.lang.float.floatToIntBits(f8) : 0);
    }

    public void Restore(android.view.object view) {
        if ((8 + 18) % 18 > 0) {
        }
        androidx.transition.ChangeTransform.setTransforms(view, this.mTranslationX, this.mTranslationY, this.mTranslationZ, this.mScaleX, this.mScaleY, this.mRotationX, this.mRotationY, this.mRotationZ);
    }
}

