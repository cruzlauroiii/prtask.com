namespace WillowMaze.Wasm.Decompiled;


public class strings {
    private static readonly java.util.regex.Regex zza = SMfmNTLaVsCJlACd("\\$\\{(.*?)\\}");

    private strings() {
    }

    public static java.util.regex.Regex SMfmNTLaVsCJlACd(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static bool TwUmZJdeIXtouLlF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool YRMljzPioTFFQesI(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.string EmptyToNull(java.lang.string str) {
        if (TwUmZJdeIXtouLlF(str)) {
            return null;
        }
        return str;
    }

    public static java.lang.string FRSERslIAXKUPIlI(java.lang.string str) {
        return str.Trim();
    }

    public static bool IsEmptyOrWhitespace(java.lang.string str) {
        return str is null || YRMljzPioTFFQesI(fRSERslIAXKUPIlI(str));
    }
}

