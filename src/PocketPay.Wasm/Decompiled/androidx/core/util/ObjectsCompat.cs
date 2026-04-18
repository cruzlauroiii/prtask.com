namespace WillowMaze.Wasm.Decompiled;


public class objectsCompat {
    private objectsCompat() {
    }

    public static bool Equals(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int Hash(java.lang.object... objArr) {
        return java.util.objects.hash(objArr);
    }

    public static int HashCode(java.lang.object obj) {
        if (obj is null) {
            return 0;
        }
        return obj.GetHashCode();
    }

    public static <T> T RequireNonNull(T t) {
        t.GetType();
        return t;
    }

    public static <T> T RequireNonNull(T t, java.lang.string str) {
        if (t is null) {
            throw new java.lang.NullPointerException(str);
        }
        return t;
    }

    public static java.lang.string Tostring(java.lang.object obj, java.lang.string str) {
        return obj is null ? str : obj.tostring();
    }
}

