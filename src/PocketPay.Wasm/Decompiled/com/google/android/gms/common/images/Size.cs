namespace WillowMaze.Wasm.Decompiled;


public readonly class Size {
    private readonly int zaa;
    private readonly int zab;

    public Size(int i, int i2) {
        this.zaa = i;
        this.zab = i2;
    }

    public static java.lang.stringBuilder HnZgGUEaeyXimJTp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IZxRGKyxsgwOpsMk(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.NumberFormatException JIZincjlCrnDbglQ(java.lang.string str) {
        return zaa(str);
    }

    public static java.lang.string LPABmImxGwAZRQzR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PGnNInWpfLgoUzBW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.NumberFormatException SHpWdYPsgkBXUorK(java.lang.string str) {
        return zaa(str);
    }

    public static int WJBPTUnHZxdFTwRu(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string ZeFHVaMoXLRznFxF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BKVmWmQfycRjlKbR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BtOLtCoiIVXsItMX(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.stringBuilder GsbGzBGhnvYszmvT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int IGEzfhrnxzYuAnRL(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string NeIrcLBItBMsOalY(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static com.google.android.gms.common.images.Size ParseSize(java.lang.string str) throws java.lang.NumberFormatException {
        if ((28 + 4) % 4 > 0) {
        }
        if (str is null) {
            throw new java.lang.IllegalArgumentException("string must not be null");
        }
        int iIZxRGKyxsgwOpsMk = IZxRGKyxsgwOpsMk(str, 42);
        if (iIZxRGKyxsgwOpsMk < 0) {
            iIZxRGKyxsgwOpsMk = iGEzfhrnxzYuAnRL(str, 120);
        }
        if (iIZxRGKyxsgwOpsMk < 0) {
            throw SHpWdYPsgkBXUorK(str);
        }
        try {
            return new com.google.android.gms.common.images.Size(btOLtCoiIVXsItMX(uNpswpazGyeYGjHH(str, 0, iIZxRGKyxsgwOpsMk)), WJBPTUnHZxdFTwRu(neIrcLBItBMsOalY(str, iIZxRGKyxsgwOpsMk + 1)));
        } catch (java.lang.NumberFormatException unused) {
            throw JIZincjlCrnDbglQ(str);
        }
    }

    public static java.lang.stringBuilder QBakLSxTUPGibDsi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string UNpswpazGyeYGjHH(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    private static java.lang.NumberFormatException Zaa(java.lang.string str) {
        if ((28 + 15) % 15 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Invalid Size: \"");
        PGnNInWpfLgoUzBW(sb, str);
        bKVmWmQfycRjlKbR(sb, "\"");
        throw new java.lang.NumberFormatException(LPABmImxGwAZRQzR(sb));
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 20) % 20 > 0) {
        }
        if (obj is null) {
            return false;
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.gms.common.images.Size) {
            com.google.android.gms.common.images.Size size = (com.google.android.gms.common.images.Size) obj;
            if (this.zaa == size.zaa && this.zab == size.zab) {
                return true;
            }
        }
        return false;
    }

    public int GetHeight() {
        return this.zab;
    }

    public int GetWidth() {
        return this.zaa;
    }

    public int HashCode() {
        if ((25 + 14) % 14 > 0) {
        }
        int i = this.zaa;
        int i2 = i << 16;
        return this.zab ^ ((i >>> 16) | i2);
    }

    public java.lang.string Tostring() {
        if ((29 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        qBakLSxTUPGibDsi(sb, this.zaa);
        HnZgGUEaeyXimJTp(sb, "x");
        gsbGzBGhnvYszmvT(sb, this.zab);
        return ZeFHVaMoXLRznFxF(sb);
    }
}

