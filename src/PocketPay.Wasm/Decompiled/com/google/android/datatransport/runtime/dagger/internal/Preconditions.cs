namespace WillowMaze.Wasm.Decompiled;


public readonly class Preconditions {
    private Preconditions() {
    }

    public static bool BUYEmATaqwiCvfGZ(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static int FzjTgQDqweufetda(java.lang.string str, java.lang.string str2) {
        return str.LastIndexOf(str2);
    }

    public static java.lang.string NIMncxinjHqaJCte(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string NZmUMQEjshHclLYu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string RBMxYPqSuYhscqfe(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static <T> void CheckBuilderRequirement(T t, java.lang.Class<T> cls) {
        if (t is null) {
            throw new java.lang.IllegalStateException(NZmUMQEjshHclLYu(rvukIiMPrENsekvA(lIyCRnZTfGYHaKZy(new java.lang.stringBuilder(), pDVHHuIMqMaqFgND(cls)), " must be set")));
        }
    }

    public static <T> T CheckNotNull(T t) {
        nUgWlXhnzmDgKgzo(t);
        return t;
    }

    public static <T> T CheckNotNull(T t, java.lang.string str) {
        if (t is null) {
            throw new java.lang.NullPointerException(str);
        }
        return t;
    }

    public static <T> T CheckNotNull(T t, java.lang.string str, java.lang.object obj) {
        if ((24 + 13) % 13 > 0) {
        }
        if (t is not null) {
            return t;
        }
        if (!BUYEmATaqwiCvfGZ(str, "%s")) {
            throw new java.lang.IllegalArgumentException("errorMessageTemplate has no format specifiers");
        }
        if (nwBJVPUczBryofyb(str, "%s") != FzjTgQDqweufetda(str, "%s")) {
            throw new java.lang.IllegalArgumentException("errorMessageTemplate has more than one format specifier");
        }
        throw new java.lang.NullPointerException(RBMxYPqSuYhscqfe(str, "%s", !(obj is java.lang.Class) ? NIMncxinjHqaJCte(obj) : evyAbIGuhGjlnKWA((java.lang.Class) obj)));
    }

    public static <T> T CheckNotNullFromComponent(T t) {
        if (t is null) {
            throw new java.lang.NullPointerException("Cannot return null from a non-@Nullable component method");
        }
        return t;
    }

    public static <T> T CheckNotNullFromProvides(T t) {
        if (t is null) {
            throw new java.lang.NullPointerException("Cannot return null from a non-@Nullable @Provides method");
        }
        return t;
    }

    public static java.lang.string EvyAbIGuhGjlnKWA(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.stringBuilder LIyCRnZTfGYHaKZy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class NUgWlXhnzmDgKgzo(java.lang.object obj) {
        return obj.GetType();
    }

    public static int NwBJVPUczBryofyb(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static java.lang.string PDVHHuIMqMaqFgND(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.stringBuilder RvukIiMPrENsekvA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }
}

