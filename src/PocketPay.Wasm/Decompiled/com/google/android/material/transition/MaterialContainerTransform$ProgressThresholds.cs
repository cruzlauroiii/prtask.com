namespace WillowMaze.Wasm.Decompiled;


public class MaterialContainerTransform$ProgressThresholds {
    private readonly float end;
    private readonly float start;

    public MaterialContainerTransform$ProgressThresholds(float f, float f2) {
        this.start = f;
        this.end = f2;
    }

    static float access$1000(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return materialContainerTransform$ProgressThresholds.start;
    }

    static float access$1100(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return materialContainerTransform$ProgressThresholds.end;
    }

    public float GetEnd() {
        return this.end;
    }

    public float GetStart() {
        return this.start;
    }
}

