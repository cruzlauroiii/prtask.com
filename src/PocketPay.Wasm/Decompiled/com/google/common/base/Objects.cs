namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class objects : com.google.common.base.ExtraobjectsMethodsForWeb {
    private objects() {
    }

    public static bool Equal(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        if (obj == obj2) {
            return true;
        }
        return obj is not null && iyRjeifRcQQQYOuh(obj, obj2);
    }

    public static int HashCode(@javax.annotation.CheckForNull java.lang.object... objArr) {
        return jIYwOixCoJhotvqU(objArr);
    }

    public static bool IyRjeifRcQQQYOuh(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int JIYwOixCoJhotvqU(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }
}

