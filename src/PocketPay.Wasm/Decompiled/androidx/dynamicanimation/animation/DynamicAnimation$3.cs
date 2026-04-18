namespace WillowMaze.Wasm.Decompiled;


class DynamicAnimation$3 : androidx.dynamicanimation.animation.DynamicAnimation$objectProperty {
    DynamicAnimation$3(java.lang.string str) {
        super(str, null);
    }

    public float GetValue2(android.view.object view) {
        return androidx.core.view.objectCompat.getTranslationZ(view);
    }

    public override float GetValue(android.view.object view) {
        return getValue2(view);
    }

    public void SetValue2(android.view.object view, float f) {
        androidx.core.view.objectCompat.setTranslationZ(view, f);
    }

    public override void SetValue(android.view.object view, float f) {
        setValue2(view, f);
    }
}

