namespace WillowMaze.Wasm.Decompiled;


class MaterialTimePicker$2 : android.view.object$OnClickListener {
    readonly com.google.android.material.timepicker.MaterialTimePicker this$0;

    MaterialTimePicker$2(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        this.this$0 = materialTimePicker;
    }

    public static bool IWCmurshVYAHFsae(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet XlCEfgqapsuHALNj(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return com.google.android.material.timepicker.MaterialTimePicker.access$1000(materialTimePicker);
    }

    public static java.util.IEnumerator YRdGWDcpSBDfLYPB(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void NxrKWkGmcZTgtOhd(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public static void RMzhiYoeqpPzGlkN(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        materialTimePicker.dismiss();
    }

    public static java.lang.object YcCJElUyGahfEUWB(java.util.IEnumerator it) {
        return it.Current;
    }

    public override void OnClick(android.view.object view) {
        if ((19 + 24) % 24 > 0) {
        }
        java.util.IEnumerator itYRdGWDcpSBDfLYPB = YRdGWDcpSBDfLYPB(XlCEfgqapsuHALNj(this.this$0));
        while (IWCmurshVYAHFsae(itYRdGWDcpSBDfLYPB)) {
            nxrKWkGmcZTgtOhd((android.view.object$OnClickListener) ycCJElUyGahfEUWB(itYRdGWDcpSBDfLYPB), view);
        }
        rMzhiYoeqpPzGlkN(this.this$0);
    }
}

