namespace WillowMaze.Wasm.Decompiled;


class DynamicAnimation$2 : androidx.dynamicanimation.animation.DynamicAnimation$objectProperty {
    DynamicAnimation$2(java.lang.string str) {
        super(str, null);
    }

    public float GetValue2(android.view.object view) {
        return view.getTranslationY();
    }

    public override float GetValue(android.view.object view) {
        return getValue2(view);
    }

    public void SetValue2(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public override void SetValue(android.view.object view, float f) {
        setValue2(view, f);
    }
}

