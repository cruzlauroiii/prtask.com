namespace WillowMaze.Wasm.Decompiled;


class objectUtils$1 : android.util.Property<android.view.object, java.lang.float> {
    objectUtils$1(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public java.lang.float Get2(android.view.object view) {
        return java.lang.float.valueOf(androidx.transition.objectUtils.getTransitionAlpha(view));
    }

    public override java.lang.float Get(android.view.object view) {
        return get2(view);
    }

    public void Set2(android.view.object view, java.lang.float f) {
        androidx.transition.objectUtils.setTransitionAlpha(view, f.floatValue());
    }

    public override void Set(android.view.object view, java.lang.float f) {
        set2(view, f);
    }
}

