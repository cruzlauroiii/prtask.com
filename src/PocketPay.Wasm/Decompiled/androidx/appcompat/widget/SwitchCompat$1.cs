namespace WillowMaze.Wasm.Decompiled;


class SwitchCompat$1 : android.util.Property<androidx.appcompat.widget.SwitchCompat, java.lang.float> {
    SwitchCompat$1(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public static float GLnPUnrjwjMBMhcR(java.lang.float f) {
        return f.floatValue();
    }

    public static void HLaaYvzwZnGVbrEh(androidx.appcompat.widget.SwitchCompat switchCompat, float f) {
        switchCompat.setThumbPosition(f);
    }

    public static java.lang.float IZzvlODAkBQiwzIK(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void KIMNayUcUQFocMBN(androidx.appcompat.widget.SwitchCompat$1 switchCompat$1, androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.float f) {
        switchCompat$1.set2(switchCompat, f);
    }

    public static java.lang.float YThfLnQdbZpwjOEZ(androidx.appcompat.widget.SwitchCompat$1 switchCompat$1, androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat$1.get2(switchCompat);
    }

    public java.lang.float Get2(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return iZzvlODAkBQiwzIK(switchCompat.mThumbPosition);
    }

    public override java.lang.float Get(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return yThfLnQdbZpwjOEZ(this, switchCompat);
    }

    public void Set2(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.float f) {
        hLaaYvzwZnGVbrEh(switchCompat, GLnPUnrjwjMBMhcR(f));
    }

    public override void Set(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.float f) {
        kIMNayUcUQFocMBN(this, switchCompat, f);
    }
}

