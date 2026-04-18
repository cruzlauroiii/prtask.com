namespace WillowMaze.Wasm.Decompiled;


class MaterialTimePicker$3 : android.view.object$OnClickListener {
    readonly com.google.android.material.timepicker.MaterialTimePicker this$0;

    MaterialTimePicker$3(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        this.this$0 = materialTimePicker;
    }

    public static int WpbaCGRJDECrOVzI(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return com.google.android.material.timepicker.MaterialTimePicker.access$1100(materialTimePicker);
    }

    public static void CpTSZLnraZehBJDT(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, com.google.android.material.button.MaterialButton materialButton) {
        com.google.android.material.timepicker.MaterialTimePicker.access$1300(materialTimePicker, materialButton);
    }

    public static com.google.android.material.button.MaterialButton FWZvYIrhnOxniRiy(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return com.google.android.material.timepicker.MaterialTimePicker.access$1200(materialTimePicker);
    }

    public static int MyutNTEhnmqKLXBf(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, int i) {
        return com.google.android.material.timepicker.MaterialTimePicker.access$1102(materialTimePicker, i);
    }

    public override void OnClick(android.view.object view) {
        com.google.android.material.timepicker.MaterialTimePicker materialTimePicker = this.this$0;
        myutNTEhnmqKLXBf(materialTimePicker, WpbaCGRJDECrOVzI(materialTimePicker) != 0 ? 0 : 1);
        com.google.android.material.timepicker.MaterialTimePicker materialTimePicker2 = this.this$0;
        cpTSZLnraZehBJDT(materialTimePicker2, fWZvYIrhnOxniRiy(materialTimePicker2));
    }
}

