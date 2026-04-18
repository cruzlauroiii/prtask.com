namespace WillowMaze.Wasm.Decompiled;


readonly class Base256Encoder : com.google.zxing.datamatrix.encoder.Encoder {
    Base256Encoder() {
    }

    public static int BAAQHoBmhDDchYXP(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static void CfirXVvRiIbyuZDE(java.lang.stringBuilder sb, int i, char c) {
        sb.setCharAt(i, c);
    }

    public static int CxkQxGCpMlWXBZda(com.google.zxing.datamatrix.encoder.Base256Encoder base256Encoder) {
        return base256Encoder.getEncodingMode();
    }

    public static void DDrfHGjuTZfCvIhc(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo DKqUfAbLxpNqgVRw(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getSymbolInfo();
    }

    public static java.lang.stringBuilder GcoCyVSJKOtgfPuS(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int HvGrWbQHovZRlEPR(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int LuJWZUKWNhgkcXWQ(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static int OKLfAInewTSMCUKp(com.google.zxing.datamatrix.encoder.Base256Encoder base256Encoder) {
        return base256Encoder.getEncodingMode();
    }

    public static void PcHBFjUNhaglrCFB(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.updateSymbolInfo(i);
    }

    public static java.lang.stringBuilder QRqiESWIOkaRvJVB(java.lang.stringBuilder sb, int i, char c) {
        return sb.insert(i, c);
    }

    public static java.lang.stringBuilder SToYdugRWAMsntSU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void USZWDIexGHBIaPKM(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static char VrZfLbEZmUZNYvpJ(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCurrentChar();
    }

    public static void YovdyNDzAajwIZfj(java.lang.stringBuilder sb, int i, char c) {
        sb.setCharAt(i, c);
    }

    public static int ARqwfsutzpzFOziA(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getDataCapacity();
    }

    public static int CDulVYCDzgYupPpQ(java.lang.CharSequence charSequence, int i, int i2) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.lookAheadTest(charSequence, i, i2);
    }

    public static java.lang.string JhSGnPQHpyvgdZmz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool KXEaKqYSIptcPMGj(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.hasMorechars();
    }

    public static char NOsvkVxQsRUqUIxJ(char c, int i) {
        return randomize255State(c, i);
    }

    public static int PjhXhpUpFHjsDyLB(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static bool RCIDEaiSuXfVvrmf(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.hasMorechars();
    }

    public static char RUcSEkqEkezDffce(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    private static char Randomize255State(char c, int i) {
        int i2 = c + ((i * 149) % 255) + 1;
        return i2 > 255 ? (char) (i2 - 256) : (char) i2;
    }

    public static java.lang.stringBuilder TRbNuOgCgKfpQdSe(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string UmQoNMMKIiLIbQVd(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getMessage();
    }

    public override void Encode(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        if ((2 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        tRbNuOgCgKfpQdSe(sb, (char) 0);
        while (kXEaKqYSIptcPMGj(encoderobject)) {
            GcoCyVSJKOtgfPuS(sb, VrZfLbEZmUZNYvpJ(encoderobject));
            encoderobject.pos++;
            if (cDulVYCDzgYupPpQ(umQoNMMKIiLIbQVd(encoderobject), encoderobject.pos, OKLfAInewTSMCUKp(this)) != CxkQxGCpMlWXBZda(this)) {
                DDrfHGjuTZfCvIhc(encoderobject, 0);
                break;
            }
        }
        int iPjhXhpUpFHjsDyLB = pjhXhpUpFHjsDyLB(sb) - 1;
        int iLuJWZUKWNhgkcXWQ = LuJWZUKWNhgkcXWQ(encoderobject) + iPjhXhpUpFHjsDyLB + 1;
        PcHBFjUNhaglrCFB(encoderobject, iLuJWZUKWNhgkcXWQ);
        bool z = aRqwfsutzpzFOziA(DKqUfAbLxpNqgVRw(encoderobject)) - iLuJWZUKWNhgkcXWQ > 0;
        if (rCIDEaiSuXfVvrmf(encoderobject) || z) {
            if (iPjhXhpUpFHjsDyLB <= 249) {
                YovdyNDzAajwIZfj(sb, 0, (char) iPjhXhpUpFHjsDyLB);
            } else {
                if (iPjhXhpUpFHjsDyLB > 1555) {
                    throw new java.lang.IllegalStateException(jhSGnPQHpyvgdZmz(SToYdugRWAMsntSU(new java.lang.stringBuilder("Message length not in valid ranges: "), iPjhXhpUpFHjsDyLB)));
                }
                CfirXVvRiIbyuZDE(sb, 0, (char) ((iPjhXhpUpFHjsDyLB / 250) + 249));
                QRqiESWIOkaRvJVB(sb, 1, (char) (iPjhXhpUpFHjsDyLB % 250));
            }
        }
        int iHvGrWbQHovZRlEPR = HvGrWbQHovZRlEPR(sb);
        for (int i = 0; i < iHvGrWbQHovZRlEPR; i++) {
            USZWDIexGHBIaPKM(encoderobject, nOsvkVxQsRUqUIxJ(rUcSEkqEkezDffce(sb, i), BAAQHoBmhDDchYXP(encoderobject) + 1));
        }
    }

    public override int GetEncodingMode() {
        return 5;
    }
}

