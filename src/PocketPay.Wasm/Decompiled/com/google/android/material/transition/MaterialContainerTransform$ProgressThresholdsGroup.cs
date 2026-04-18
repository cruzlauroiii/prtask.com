namespace WillowMaze.Wasm.Decompiled;


class MaterialContainerTransform$ProgressThresholdsGroup {
    private readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds fade;
    private readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds scale;
    private readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds scaleMask;
    private readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds shapeMask;

    private MaterialContainerTransform$ProgressThresholdsGroup(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds2, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds3, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds4) {
        this.fade = materialContainerTransform$ProgressThresholds;
        this.scale = materialContainerTransform$ProgressThresholds2;
        this.scaleMask = materialContainerTransform$ProgressThresholds3;
        this.shapeMask = materialContainerTransform$ProgressThresholds4;
    }

    MaterialContainerTransform$ProgressThresholdsGroup(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds2, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds3, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds4, com.google.android.material.transition.MaterialContainerTransform$1 materialContainerTransform$1) {
        this(materialContainerTransform$ProgressThresholds, materialContainerTransform$ProgressThresholds2, materialContainerTransform$ProgressThresholds3, materialContainerTransform$ProgressThresholds4);
    }

    static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds access$400(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return materialContainerTransform$ProgressThresholdsGroup.fade;
    }

    static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds access$500(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return materialContainerTransform$ProgressThresholdsGroup.scale;
    }

    static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds access$600(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return materialContainerTransform$ProgressThresholdsGroup.scaleMask;
    }

    static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds access$700(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return materialContainerTransform$ProgressThresholdsGroup.shapeMask;
    }
}

