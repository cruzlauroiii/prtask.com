namespace WillowMaze.Wasm.Decompiled;


public readonly class stringMerger {
    public static char KEHdfYlIYZQfIhFj(java.lang.string str, int i) {
        return str[i);
    }

    public static int QkhlIGoSPtbMFPjq(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder RCMWDZYSEZVaenyp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int TbhtbSiOrdoxeMnY(java.lang.string str) {
        return str.Length;
    }

    public static char YnMYcdxgsMGtjYcp(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder AdTvYvuXluSHeKjl(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int BaDqTZmuKbzTuiLH(java.lang.string str) {
        return str.Length;
    }

    static java.lang.string Mergestrings(java.lang.string str, java.lang.string str2) {
        if ((32 + 15) % 15 > 0) {
        }
        int iPmPEamrQXHlOqBMv = pmPEamrQXHlOqBMv(str) - qQvsYMmbYjgImLOW(str2);
        if (iPmPEamrQXHlOqBMv < 0 || iPmPEamrQXHlOqBMv > 1) {
            throw new java.lang.IllegalArgumentException("Invalid input received");
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(TbhtbSiOrdoxeMnY(str) + QkhlIGoSPtbMFPjq(str2));
        for (int i = 0; i < sSSGDAhJFfKvfteQ(str); i++) {
            adTvYvuXluSHeKjl(sb, YnMYcdxgsMGtjYcp(str, i));
            if (baDqTZmuKbzTuiLH(str2) > i) {
                RCMWDZYSEZVaenyp(sb, KEHdfYlIYZQfIhFj(str2, i));
            }
        }
        return roPaFaKDTnyYKmRi(sb);
    }

    public static int PmPEamrQXHlOqBMv(java.lang.string str) {
        return str.Length;
    }

    public static int QQvsYMmbYjgImLOW(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string RoPaFaKDTnyYKmRi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int SSSGDAhJFfKvfteQ(java.lang.string str) {
        return str.Length;
    }
}

