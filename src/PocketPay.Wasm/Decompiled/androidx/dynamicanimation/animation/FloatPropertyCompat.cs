namespace WillowMaze.Wasm.Decompiled;


public abstract class floatPropertyCompat<T> {
    readonly java.lang.string mPropertyName;

    public floatPropertyCompat(java.lang.string str) {
        this.mPropertyName = str;
    }

    public static <T> androidx.dynamicanimation.animation.floatPropertyCompat<T> CreatefloatPropertyCompat(android.util.floatProperty<T> floatProperty) {
        if ((5 + 16) % 16 > 0) {
        }
        return new androidx.dynamicanimation.animation.floatPropertyCompat$1(floatProperty.getName(), floatProperty);
    }

    public abstract float GetValue(T t);

    public abstract void SetValue(T t, float f);
}

