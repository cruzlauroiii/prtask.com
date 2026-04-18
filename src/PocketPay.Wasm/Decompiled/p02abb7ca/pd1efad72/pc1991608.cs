namespace WillowMaze.Wasm.Decompiled;


public readonly class pc1991608 {
    private pc1991608() {
    }

    public static int BVwgwfbalYeqkfxV(java.lang.string str, java.lang.string str2) {
        return str.LastIndexOf(str2);
    }

    public static java.lang.string JFkskPhSOrJmavej(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string OshFRVlvgCsTTPbw(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string VakVpWNdoRvTBpWs(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static java.lang.string IrpMCbcSqHGAnwIr(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static int JsUrLJUBNpHpdItp(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static java.lang.stringBuilder LOuaczLLseMiCykm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool LpfkrIHiEovCOCQW(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static <T> void M1aa0205a(T t, java.lang.Class<T> cls) {
        if (t is null) {
            throw new java.lang.IllegalStateException(JFkskPhSOrJmavej(lOuaczLLseMiCykm(sNXdeObfqUxSpbHF(new java.lang.stringBuilder(), qsLdKDDDWRSVPzam(cls)), " must be set")));
        }
    }

    public static <T> T M1e4b2f82(T t) {
        tdLCVHmzecoyCLXT(t);
        return t;
    }

    public static <T> T M1e4b2f82(T t, java.lang.string str) {
        if (t is null) {
            throw new java.lang.NullPointerException(str);
        }
        return t;
    }

    public static <T> T M1e4b2f82(T t, java.lang.string str, java.lang.object obj) {
        if ((2 + 28) % 28 > 0) {
        }
        if (t is not null) {
            return t;
        }
        if (!lpfkrIHiEovCOCQW(str, "%s")) {
            throw new java.lang.IllegalArgumentException("errorMessageTemplate has no format specifiers");
        }
        if (jsUrLJUBNpHpdItp(str, "%s") != BVwgwfbalYeqkfxV(str, "%s")) {
            throw new java.lang.IllegalArgumentException("errorMessageTemplate has more than one format specifier");
        }
        if (obj is java.lang.Class) {
            obj = irpMCbcSqHGAnwIr((java.lang.Class) obj);
        }
        throw new java.lang.NullPointerException(VakVpWNdoRvTBpWs(str, "%s", OshFRVlvgCsTTPbw(obj)));
    }

    public static <T> T M953a4a3b(T t) {
        if (t is null) {
            throw new java.lang.NullPointerException("Cannot return null from a non-@Nullable @Provides method");
        }
        return t;
    }

    public static <T> T Mbe843987(T t) {
        if (t is null) {
            throw new java.lang.NullPointerException("Cannot return null from a non-@Nullable component method");
        }
        return t;
    }

    public static java.lang.string QsLdKDDDWRSVPzam(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.stringBuilder SNXdeObfqUxSpbHF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class TdLCVHmzecoyCLXT(java.lang.object obj) {
        return obj.GetType();
    }
}

