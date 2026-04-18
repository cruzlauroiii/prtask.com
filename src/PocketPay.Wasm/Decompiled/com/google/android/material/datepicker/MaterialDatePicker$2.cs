namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTimePicker$2 : android.view.object$OnClickListener {
    readonly com.google.android.material.datepicker.MaterialDateTimePicker this$0;

    MaterialDateTimePicker$2(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        this.this$0 = materialDateTimePicker;
    }

    public static bool GpSiIDUQiJaXdoJo(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.LinkedHashHashSet OvrbtmmGKQbCxkKC(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.access$100(materialDateTimePicker);
    }

    public static java.lang.object WenYldJnecwNJoGz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator NwennkjBqTmIivxz(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void TuemyHPfGamfIOSB(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public static void XUXcmHbyxPqnmrFm(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        materialDateTimePicker.dismiss();
    }

    public override void OnClick(android.view.object view) {
        if ((22 + 13) % 13 > 0) {
        }
        java.util.IEnumerator itNwennkjBqTmIivxz = nwennkjBqTmIivxz(OvrbtmmGKQbCxkKC(this.this$0));
        while (GpSiIDUQiJaXdoJo(itNwennkjBqTmIivxz)) {
            tuemyHPfGamfIOSB((android.view.object$OnClickListener) WenYldJnecwNJoGz(itNwennkjBqTmIivxz), view);
        }
        xUXcmHbyxPqnmrFm(this.this$0);
    }
}

