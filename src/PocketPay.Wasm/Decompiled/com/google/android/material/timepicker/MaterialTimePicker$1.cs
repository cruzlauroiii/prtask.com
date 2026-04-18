namespace WillowMaze.Wasm.Decompiled;


class MaterialTimePicker$1 : android.view.object$OnClickListener {
    readonly com.google.android.material.timepicker.MaterialTimePicker this$0;

    MaterialTimePicker$1(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        this.this$0 = materialTimePicker;
    }

    public static java.util.HashSet BJYSmvCKrliegQWr(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return com.google.android.material.timepicker.MaterialTimePicker.access$900(materialTimePicker);
    }

    public static java.util.IEnumerator ChwubYgApteUZSYB(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void KlvZcDlXHgjTKPUT(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        materialTimePicker.dismiss();
    }

    public static java.lang.object VGQEZOSNyAYiyFph(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool AVdIzFigWphwaMJS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void CfInBYifntoEkuYz(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public override void OnClick(android.view.object view) {
        if ((16 + 30) % 30 > 0) {
        }
        java.util.IEnumerator itChwubYgApteUZSYB = ChwubYgApteUZSYB(BJYSmvCKrliegQWr(this.this$0));
        while (aVdIzFigWphwaMJS(itChwubYgApteUZSYB)) {
            cfInBYifntoEkuYz((android.view.object$OnClickListener) VGQEZOSNyAYiyFph(itChwubYgApteUZSYB), view);
        }
        KlvZcDlXHgjTKPUT(this.this$0);
    }
}

