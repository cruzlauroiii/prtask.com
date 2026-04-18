namespace WillowMaze.Wasm.Decompiled;


class MaterialTextInputPicker$1<S> : com.google.android.material.datepicker.OnSelectionChangedListener<S> {
    readonly com.google.android.material.datepicker.MaterialTextInputPicker this$0;

    MaterialTextInputPicker$1(com.google.android.material.datepicker.MaterialTextInputPicker materialTextInputPicker) {
        this.this$0 = materialTextInputPicker;
    }

    public static java.lang.object CkFbpjEsFhKicAVW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object KcApjMKGGvSSWsus(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void MMNKzNKuRmNtBatz(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        onSelectionChangedListener.onIncompleteSelectionChanged();
    }

    public static java.util.IEnumerator NBhoYzTCpWzZzlMb(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void VytfIFngpYLKyrRH(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener, java.lang.object obj) {
        onSelectionChangedListener.onSelectionChanged(obj);
    }

    public static bool BSVKhswwXxKjUchx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool PbLvCXAjfBSZbnzs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator ZXSKFYLKCPiYklad(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public override void OnIncompleteSelectionChanged() {
        java.util.IEnumerator itNBhoYzTCpWzZzlMb = NBhoYzTCpWzZzlMb(this.this$0.onSelectionChangedListeners);
        while (bSVKhswwXxKjUchx(itNBhoYzTCpWzZzlMb)) {
            MMNKzNKuRmNtBatz((com.google.android.material.datepicker.OnSelectionChangedListener) KcApjMKGGvSSWsus(itNBhoYzTCpWzZzlMb));
        }
    }

    public override void OnSelectionChanged(S s) {
        java.util.IEnumerator itZXSKFYLKCPiYklad = zXSKFYLKCPiYklad(this.this$0.onSelectionChangedListeners);
        while (pbLvCXAjfBSZbnzs(itZXSKFYLKCPiYklad)) {
            VytfIFngpYLKyrRH((com.google.android.material.datepicker.OnSelectionChangedListener) CkFbpjEsFhKicAVW(itZXSKFYLKCPiYklad), s);
        }
    }
}

