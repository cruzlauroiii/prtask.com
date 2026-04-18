namespace WillowMaze.Wasm.Decompiled;


class floatPropertyCompat$1<T> : androidx.dynamicanimation.animation.floatPropertyCompat<T> {
    readonly android.util.floatProperty val$property;

    floatPropertyCompat$1(java.lang.string str, android.util.floatProperty floatProperty) {
        super(str);
        this.val$property = floatProperty;
    }

    public override float GetValue(T t) {
        return ((java.lang.float) this.val$property[t)).floatValue();
    }

    public override void SetValue(T t, float f) {
        this.val$property.setValue(t, f);
    }
}

