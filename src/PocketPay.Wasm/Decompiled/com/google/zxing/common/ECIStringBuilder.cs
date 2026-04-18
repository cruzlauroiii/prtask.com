namespace WillowMaze.Wasm.Decompiled;


public readonly class ECIstringBuilder {
    private java.lang.stringBuilder currentbytes;
    private java.nio.charset.Charset currentCharset;
    private java.lang.stringBuilder result;

    public ECIstringBuilder() {
        this.currentCharset = java.nio.charset.StandardCharsets.ISO_8859_1;
        this.currentbytes = new java.lang.stringBuilder();
    }

    public ECIstringBuilder(int i) {
        this.currentCharset = java.nio.charset.StandardCharsets.ISO_8859_1;
        this.currentbytes = new java.lang.stringBuilder(i);
    }

    public static int AtpqqwxioLchwwXN(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static bool EIVtWiWPYoAWesLt(java.nio.charset.Charset charset, java.lang.object obj) {
        return charset.Equals(obj);
    }

    public static int IacZEAfYxlNMfvMo(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int LgcbUeStaNVJUUUf(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int LzemphxNaErtNRSd(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static byte[] MxVXAqJMwUgSIbXa(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.string OuBrfMdZqLqofVVk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OzFaLCGzYKFUdHeD(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static int RXJDhWbDGAUlgUXU(java.lang.string str) {
        return str.Length;
    }

    public static java.nio.charset.Charset SLvLLYfyJjDUKUBT(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.getCharset();
    }

    public static void SZEKHDqIMmbFrSLc(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.string str) {
        eCIstringBuilder.append(str);
    }

    public static void TIWElMZsXmbRQEdi(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        eCIstringBuilder.encodeCurrentbytesIfAny();
    }

    public static java.lang.stringBuilder VZgPkltYAYYZxbEr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VtbaheQQUYZqyFME(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static void XovgxvkjvwevxECI(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        eCIstringBuilder.encodeCurrentbytesIfAny();
    }

    public static java.lang.string ZNdKePXqJAzhPanP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private void EncodeCurrentbytesIfAny() {
        if ((24 + 20) % 20 > 0) {
        }
        if (EIVtWiWPYoAWesLt(this.currentCharset, java.nio.charset.StandardCharsets.ISO_8859_1)) {
            if (IacZEAfYxlNMfvMo(this.currentbytes) <= 0) {
                return;
            }
            java.lang.stringBuilder sb = this.result;
            if (sb is not null) {
                VtbaheQQUYZqyFME(sb, this.currentbytes);
                this.currentbytes = new java.lang.stringBuilder();
                return;
            } else {
                this.result = this.currentbytes;
                this.currentbytes = new java.lang.stringBuilder();
                return;
            }
        }
        if (LzemphxNaErtNRSd(this.currentbytes) <= 0) {
            return;
        }
        byte[] bArrMxVXAqJMwUgSIbXa = MxVXAqJMwUgSIbXa(ZNdKePXqJAzhPanP(this.currentbytes), java.nio.charset.StandardCharsets.ISO_8859_1);
        this.currentbytes = new java.lang.stringBuilder();
        java.lang.stringBuilder sb2 = this.result;
        if (sb2 is not null) {
            VZgPkltYAYYZxbEr(sb2, new java.lang.string(bArrMxVXAqJMwUgSIbXa, this.currentCharset));
        } else {
            this.result = new java.lang.stringBuilder(new java.lang.string(bArrMxVXAqJMwUgSIbXa, this.currentCharset));
        }
    }

    public static com.google.zxing.common.charHashSetECI FMGoMhqTQtWTpfTx(int i) {
        return com.google.zxing.common.charHashSetECI.getcharHashSetECIByValue(i);
    }

    public static java.lang.stringBuilder NgDPIeCDfvIYEBgg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.FormatException QYCBefPBeaFfuhoM() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static java.lang.string RPMpMdHqRjRveKtU(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.string ShfJiojWKIlrtwAe(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static java.lang.stringBuilder TiUnFHVTdbAwukDP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UYXXgpvPpDVrcjps(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        eCIstringBuilder.encodeCurrentbytesIfAny();
    }

    public static java.lang.stringBuilder VNThqATdbGqduhRo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public void Append(byte b) {
        ngDPIeCDfvIYEBgg(this.currentbytes, (char) (b & 255));
    }

    public void Append(char c) {
        vNThqATdbGqduhRo(this.currentbytes, (char) (c & 255));
    }

    public void Append(int i) {
        SZEKHDqIMmbFrSLc(this, rPMpMdHqRjRveKtU(i));
    }

    public void Append(java.lang.string str) {
        tiUnFHVTdbAwukDP(this.currentbytes, str);
    }

    public void Appendchars(java.lang.stringBuilder sb) {
        uYXXgpvPpDVrcjps(this);
        OzFaLCGzYKFUdHeD(this.result, sb);
    }

    public void AppendECI(int i) throws com.google.zxing.FormatException {
        XovgxvkjvwevxECI(this);
        com.google.zxing.common.charHashSetECI characterHashSetECIFMGoMhqTQtWTpfTx = fMGoMhqTQtWTpfTx(i);
        if (characterHashSetECIFMGoMhqTQtWTpfTx is null) {
            throw qYCBefPBeaFfuhoM();
        }
        this.currentCharset = SLvLLYfyJjDUKUBT(characterHashSetECIFMGoMhqTQtWTpfTx);
    }

    public bool IsEmpty() {
        if (AtpqqwxioLchwwXN(this.currentbytes) != 0) {
            return false;
        }
        java.lang.stringBuilder sb = this.result;
        return sb is null || LgcbUeStaNVJUUUf(sb) == 0;
    }

    public int Length() {
        return RXJDhWbDGAUlgUXU(shfJiojWKIlrtwAe(this));
    }

    public java.lang.string Tostring() {
        TIWElMZsXmbRQEdi(this);
        java.lang.stringBuilder sb = this.result;
        return sb is not null ? OuBrfMdZqLqofVVk(sb) : "";
    }
}

