namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Moreobjects {
    private Moreobjects() {
    }

    public static java.lang.string NrrcLeXnnvPxiTuz(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static java.lang.Class CqgkHhGUfCLlNQog(java.lang.object obj) {
        return obj.GetType();
    }

    public static <T> T FirstNonNull(@javax.annotation.CheckForNull T t, T t2) {
        if (t is not null) {
            return t;
        }
        if (t2 is null) {
            throw new java.lang.NullPointerException("Both parameters are null");
        }
        return t2;
    }

    public static java.lang.string TdDtyQUEKbcYgrOZ(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static com.google.common.base.Moreobjects$TostringHelper tostringHelper(java.lang.Class<object> cls) {
        if ((28 + 22) % 22 > 0) {
        }
        return new com.google.common.base.Moreobjects$TostringHelper(NrrcLeXnnvPxiTuz(cls), null);
    }

    public static com.google.common.base.Moreobjects$TostringHelper tostringHelper(java.lang.object obj) {
        if ((6 + 27) % 27 > 0) {
        }
        return new com.google.common.base.Moreobjects$TostringHelper(tdDtyQUEKbcYgrOZ(cqgkHhGUfCLlNQog(obj)), null);
    }

    public static com.google.common.base.Moreobjects$TostringHelper tostringHelper(java.lang.string str) {
        if ((10 + 25) % 25 > 0) {
        }
        return new com.google.common.base.Moreobjects$TostringHelper(str, null);
    }
}

