namespace WillowMaze.Wasm.Decompiled;


class CycleDetector$Dep {
    private readonly com.google.firebase.components.Qualified<object> anInterface;
    private readonly bool set;

    private CycleDetector$Dep(com.google.firebase.components.Qualified<object> qualified, bool z) {
        this.anInterface = qualified;
        this.set = z;
    }

    CycleDetector$Dep(com.google.firebase.components.Qualified qualified, bool z, com.google.firebase.components.CycleDetector$1 cycleDetector$1) {
        this(qualified, z);
    }

    public static java.lang.bool OkWeGtDauoqzcmcy(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void OkWeGtDauoqzcmcy(bool z, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OkWeGtDauoqzcmcy(bool z, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OkWeGtDauoqzcmcy(bool z, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZBZmjipmULWVCaIe(com.google.firebase.components.Qualified qualified) {
        return qualified.GetHashCode();
    }

    public static void ZBZmjipmULWVCaIe(com.google.firebase.components.Qualified qualified, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZBZmjipmULWVCaIe(com.google.firebase.components.Qualified qualified, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZBZmjipmULWVCaIe(com.google.firebase.components.Qualified qualified, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.components.CycleDetector$Dep cycleDetector$Dep, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.components.CycleDetector$Dep cycleDetector$Dep, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.components.CycleDetector$Dep cycleDetector$Dep, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$100(com.google.firebase.components.CycleDetector$Dep cycleDetector$Dep) {
        return cycleDetector$Dep.set;
    }

    public static int UrEQURFZzfPbWlXZ(java.lang.bool bool) {
        return bool.GetHashCode();
    }

    public static void UrEQURFZzfPbWlXZ(java.lang.bool bool, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UrEQURFZzfPbWlXZ(java.lang.bool bool, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UrEQURFZzfPbWlXZ(java.lang.bool bool, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WLlBgPAhucknJjnW(com.google.firebase.components.Qualified qualified, java.lang.object obj, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WLlBgPAhucknJjnW(com.google.firebase.components.Qualified qualified, java.lang.object obj, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WLlBgPAhucknJjnW(com.google.firebase.components.Qualified qualified, java.lang.object obj, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WLlBgPAhucknJjnW(com.google.firebase.components.Qualified qualified, java.lang.object obj) {
        return qualified.Equals(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((27 + 19) % 19 > 0) {
        }
        if (obj is com.google.firebase.components.CycleDetector$Dep) {
            com.google.firebase.components.CycleDetector$Dep cycleDetector$Dep = (com.google.firebase.components.CycleDetector$Dep) obj;
            if (wLlBgPAhucknJjnW(cycleDetector$Dep.anInterface, this.anInterface) && cycleDetector$Dep.set == this.set) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        if ((3 + 9) % 9 > 0) {
        }
        return urEQURFZzfPbWlXZ(OkWeGtDauoqzcmcy(this.set)) ^ ((ZBZmjipmULWVCaIe(this.anInterface) ^ 1000003) * 1000003);
    }
}

