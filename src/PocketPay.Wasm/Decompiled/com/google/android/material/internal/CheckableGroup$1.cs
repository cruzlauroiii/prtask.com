namespace WillowMaze.Wasm.Decompiled;


class CheckableGroup$1<T> : com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener<T> {
    readonly com.google.android.material.internal.CheckableGroup this$0;

    CheckableGroup$1(com.google.android.material.internal.CheckableGroup checkableGroup) {
        this.this$0 = checkableGroup;
    }

    public static void MMVnPBsOeaUWGvIg(com.google.android.material.internal.CheckableGroup$1 checkableGroup$1, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z) {
        checkableGroup$1.onCheckedChanged(materialCheckable, z);
    }

    public static void MMVnPBsOeaUWGvIg(com.google.android.material.internal.CheckableGroup$1 checkableGroup$1, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z, char c, java.lang.string str, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MMVnPBsOeaUWGvIg(com.google.android.material.internal.CheckableGroup$1 checkableGroup$1, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z, int i, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MMVnPBsOeaUWGvIg(com.google.android.material.internal.CheckableGroup$1 checkableGroup$1, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z, java.lang.string str, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TJXBZHPMYJEzTSKF(com.google.android.material.internal.CheckableGroup checkableGroup, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TJXBZHPMYJEzTSKF(com.google.android.material.internal.CheckableGroup checkableGroup, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TJXBZHPMYJEzTSKF(com.google.android.material.internal.CheckableGroup checkableGroup, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TJXBZHPMYJEzTSKF(com.google.android.material.internal.CheckableGroup checkableGroup) {
        return com.google.android.material.internal.CheckableGroup.access$100(checkableGroup);
    }

    public static void TxlUiFNiEnCJprDB(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z, byte b, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxlUiFNiEnCJprDB(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z, float f, bool z2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TxlUiFNiEnCJprDB(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z, int i, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TxlUiFNiEnCJprDB(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable, bool z) {
        return com.google.android.material.internal.CheckableGroup.access$200(checkableGroup, materialCheckable, z);
    }

    public static void UZLSvAYYeyeyubQA(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UZLSvAYYeyeyubQA(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UZLSvAYYeyeyubQA(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool UZLSvAYYeyeyubQA(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.MaterialCheckable materialCheckable) {
        return com.google.android.material.internal.CheckableGroup.access$000(checkableGroup, materialCheckable);
    }

    public static void ClbrPSlfBRsHvwyC(com.google.android.material.internal.CheckableGroup checkableGroup) {
        com.google.android.material.internal.CheckableGroup.access$300(checkableGroup);
    }

    public static void ClbrPSlfBRsHvwyC(com.google.android.material.internal.CheckableGroup checkableGroup, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ClbrPSlfBRsHvwyC(com.google.android.material.internal.CheckableGroup checkableGroup, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ClbrPSlfBRsHvwyC(com.google.android.material.internal.CheckableGroup checkableGroup, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public void OnCheckedChanged(com.google.android.material.internal.MaterialCheckable materialCheckable, bool z) {
        if (!z) {
            com.google.android.material.internal.CheckableGroup checkableGroup = this.this$0;
            if (!TxlUiFNiEnCJprDB(checkableGroup, materialCheckable, TJXBZHPMYJEzTSKF(checkableGroup))) {
                return;
            }
        } else if (!UZLSvAYYeyeyubQA(this.this$0, materialCheckable)) {
            return;
        }
        clbrPSlfBRsHvwyC(this.this$0);
    }

    public override void OnCheckedChanged(java.lang.object obj, bool z) {
        MMVnPBsOeaUWGvIg(this, (com.google.android.material.internal.MaterialCheckable) obj, z);
    }
}

