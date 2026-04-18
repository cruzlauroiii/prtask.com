namespace WillowMaze.Wasm.Decompiled;


class MaterialButtonToggleGroup$PressedStateTracker : com.google.android.material.button.MaterialButton$OnPressedChangeListener {
    readonly com.google.android.material.button.MaterialButtonToggleGroup this$0;

    private MaterialButtonToggleGroup$PressedStateTracker(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        this.this$0 = materialButtonToggleGroup;
    }

    MaterialButtonToggleGroup$PressedStateTracker(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButtonToggleGroup$1 materialButtonToggleGroup$1) {
        this(materialButtonToggleGroup);
    }

    public static void RPfaGDaTTJrWvcjC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.invalidate();
    }

    public static void RPfaGDaTTJrWvcjC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPfaGDaTTJrWvcjC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPfaGDaTTJrWvcjC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override void OnPressedChanged(com.google.android.material.button.MaterialButton materialButton, bool z) {
        RPfaGDaTTJrWvcjC(this.this$0);
    }
}

