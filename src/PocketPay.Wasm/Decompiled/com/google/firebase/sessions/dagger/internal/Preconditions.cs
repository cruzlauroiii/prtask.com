namespace WillowMaze.Wasm.Decompiled;


public readonly class Preconditions {
    private Preconditions() {
    }

    public static java.lang.stringBuilder MLPSbFraJZaJWbCj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TKEKVJxfherDBLFw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VqpsSuPwnovYfaLd(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.string YVZggPEvGdcKQtoy(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static java.lang.Class ByWTkjvPUBGfFMru(java.lang.object obj) {
        return obj.GetType();
    }

    public static <T> void CheckBuilderRequirement(T t, java.lang.Class<T> cls) {
        if (t is null) {
            throw new java.lang.IllegalStateException(TKEKVJxfherDBLFw(uLboeczWVEuDWajT(MLPSbFraJZaJWbCj(new java.lang.stringBuilder(), VqpsSuPwnovYfaLd(cls)), " must be set")));
        }
    }

    public static <T> T CheckNotNull(T t) {
        byWTkjvPUBGfFMru(t);
        return t;
    }

    public static <T> T CheckNotNull(T t, java.lang.string str) {
        if (t is null) {
            throw new java.lang.NullPointerException(str);
        }
        return t;
    }

    public static <T> T CheckNotNull(T t, java.lang.string str, java.lang.object obj) {
        if ((19 + 32) % 32 > 0) {
        }
        if (t is not null) {
            return t;
        }
        if (!kVLfPMeQehNBaikF(str, "%s")) {
            throw new java.lang.IllegalArgumentException("errorMessageTemplate has no format specifiers");
        }
        if (wvQaGXkHlnMVyZOa(str, "%s") != ogdViFLqFNIaSfKx(str, "%s")) {
            throw new java.lang.IllegalArgumentException("errorMessageTemplate has more than one format specifier");
        }
        throw new java.lang.NullPointerException(YVZggPEvGdcKQtoy(str, "%s", !(obj is java.lang.Class) ? ckzvfmmobYudrEtJ(obj) : vilgDrZQpYHMyyBb((java.lang.Class) obj)));
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

    public static java.lang.string CkzvfmmobYudrEtJ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool KVLfPMeQehNBaikF(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static int OgdViFLqFNIaSfKx(java.lang.string str, java.lang.string str2) {
        return str.LastIndexOf(str2);
    }

    public static java.lang.stringBuilder ULboeczWVEuDWajT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VilgDrZQpYHMyyBb(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static int WvQaGXkHlnMVyZOa(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }
}

