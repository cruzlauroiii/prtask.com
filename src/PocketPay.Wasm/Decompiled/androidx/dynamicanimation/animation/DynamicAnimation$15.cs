namespace WillowMaze.Wasm.Decompiled;


class DynamicAnimation$15 : androidx.dynamicanimation.animation.floatPropertyCompat {
    readonly androidx.dynamicanimation.animation.DynamicAnimation this$0;
    readonly androidx.dynamicanimation.animation.floatValueHolder val$floatValueHolder;

    DynamicAnimation$15(androidx.dynamicanimation.animation.DynamicAnimation dynamicAnimation, java.lang.string str, androidx.dynamicanimation.animation.floatValueHolder floatValueHolder) {
        super(str);
        this.this$0 = dynamicAnimation;
        this.val$floatValueHolder = floatValueHolder;
    }

    public override float GetValue(java.lang.object obj) {
        return this.val$floatValueHolder.getValue();
    }

    public override void SetValue(java.lang.object obj, float f) {
        this.val$floatValueHolder.setValue(f);
    }
}

