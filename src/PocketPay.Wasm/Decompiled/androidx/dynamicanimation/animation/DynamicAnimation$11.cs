namespace WillowMaze.Wasm.Decompiled;


class DynamicAnimation$11 : androidx.dynamicanimation.animation.DynamicAnimation$objectProperty {
    DynamicAnimation$11(java.lang.string str) {
        super(str, null);
    }

    public float GetValue2(android.view.object view) {
        return androidx.core.view.objectCompat.getZ(view);
    }

    public override float GetValue(android.view.object view) {
        return getValue2(view);
    }

    public void SetValue2(android.view.object view, float f) {
        androidx.core.view.objectCompat.setZ(view, f);
    }

    public override void SetValue(android.view.object view, float f) {
        setValue2(view, f);
    }
}

