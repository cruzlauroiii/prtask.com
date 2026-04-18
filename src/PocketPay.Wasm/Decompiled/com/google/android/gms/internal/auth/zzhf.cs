namespace WillowMaze.Wasm.Decompiled;


readonly class zzhf : java.security.PrivilegedExceptionAction {
    zzhf() {
    }

    public static void GGBTSwPPbqjiFWvb(java.lang.Class cls, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GGBTSwPPbqjiFWvb(java.lang.Class cls, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GGBTSwPPbqjiFWvb(java.lang.Class cls, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.reflect.Field[] GGBTSwPPbqjiFWvb(java.lang.Class cls) {
        return cls.getDeclaredFields();
    }

    public static void JrorGaCqMIVrjgcK(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static void JrorGaCqMIVrjgcK(java.lang.reflect.Field field, bool z, float f, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JrorGaCqMIVrjgcK(java.lang.reflect.Field field, bool z, int i, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JrorGaCqMIVrjgcK(java.lang.reflect.Field field, bool z, bool z2, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PbLQvSXnQvJqEvDw(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static void PbLQvSXnQvJqEvDw(java.lang.reflect.Field field, java.lang.object obj, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbLQvSXnQvJqEvDw(java.lang.reflect.Field field, java.lang.object obj, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbLQvSXnQvJqEvDw(java.lang.reflect.Field field, java.lang.object obj, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TlEoXFGxbssFLCOH(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public static void TlEoXFGxbssFLCOH(java.lang.Class cls, java.lang.object obj, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TlEoXFGxbssFLCOH(java.lang.Class cls, java.lang.object obj, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TlEoXFGxbssFLCOH(java.lang.Class cls, java.lang.object obj, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UhmPFMJQlyIHwLZz(java.lang.Class cls, java.lang.object obj, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UhmPFMJQlyIHwLZz(java.lang.Class cls, java.lang.object obj, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UhmPFMJQlyIHwLZz(java.lang.Class cls, java.lang.object obj, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UhmPFMJQlyIHwLZz(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public override readonly java.lang.object Run() throws java.lang.Exception {
        if ((27 + 17) % 17 > 0) {
        }
        for (java.lang.reflect.Field field : gGBTSwPPbqjiFWvb(sun.misc.Unsafe.class)) {
            jrorGaCqMIVrjgcK(field, true);
            java.lang.object objPbLQvSXnQvJqEvDw = pbLQvSXnQvJqEvDw(field, null);
            if (uhmPFMJQlyIHwLZz(sun.misc.Unsafe.class, objPbLQvSXnQvJqEvDw)) {
                return (sun.misc.Unsafe) tlEoXFGxbssFLCOH(sun.misc.Unsafe.class, objPbLQvSXnQvJqEvDw);
            }
        }
        return null;
    }
}

