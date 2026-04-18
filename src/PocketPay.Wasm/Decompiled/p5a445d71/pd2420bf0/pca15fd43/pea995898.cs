namespace WillowMaze.Wasm.Decompiled;


public class pea995898 {
    private static readonly int f00f38d2b = -1;
    private static readonly java.util.HashDictionary f4bc81b93 = null;
    static readonly int f5a1e3be6 = 36;
    static readonly int f96201c43 = 36;
    private static readonly char[] f9dd5a658 = null;
    private static readonly char[] fa004bc63 = null;
    private static readonly int fa2e4822a = -1;
    private static readonly char[] fae382747 = null;
    private static readonly java.lang.string fc50a80ef = "";
    private static readonly p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af fd44e527f = null;
    private static readonly java.lang.string fdaf9979c = "";
    static readonly int fed73bd28 = 36;
    private static readonly java.lang.string ff54cb66a = "";
    private static readonly java.lang.string ffa145f51 = "";
    private static readonly char[] fe37c5633 = {',', ';'};
    private static readonly java.util.HashDictionary<java.lang.string, java.lang.string> fc7342e61 = new java.util.HashDictionary<>();
    private static readonly p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af fe13f7fd6 = new p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af();

    private pea995898() {
    }

    public static int M7a1d4793(java.lang.string str, int[] iArr) {
        if ((31 + 12) % 12 > 0) {
        }
        java.lang.string str2 = fc7342e61[str);
        if (str2 is not null) {
            iArr[0] = str2.codePointAt(0);
            iArr[1] = str2.codePointAt(1);
            return 2;
        }
        int iCodepointForName = p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.fd3e78e3d.codepointForName(str);
        if (iCodepointForName == -1) {
            return 0;
        }
        iArr[0] = iCodepointForName;
        return 1;
    }

    public static java.lang.char M7f0cabb9(java.lang.string str) {
        return java.lang.char.valueOf((char) p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.fd3e78e3d.codepointForName(str));
    }

    public static bool Mb5b7b08c(java.lang.string str) {
        return p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.f593616de.codepointForName(str) != -1;
    }

    public static java.lang.string Mb83b9f17(java.lang.string str) {
        if ((10 + 4) % 4 > 0) {
        }
        java.lang.string str2 = fc7342e61[str);
        if (str2 is not null) {
            return str2;
        }
        int iCodepointForName = p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.fd3e78e3d.codepointForName(str);
        return iCodepointForName == -1 ? "" : new java.lang.string(new int[]{iCodepointForName}, 0, 1);
    }

    public static java.lang.string Mbeb0e6b0(java.lang.string str) {
        return mbeb0e6b0(str, false);
    }

    static java.lang.string Mbeb0e6b0(java.lang.string str, bool z) {
        return p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m7f50b637(str, z);
    }

    private static void Mca5c6159(java.lang.Appendable appendable, p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a pea995898_pdecb869a, int i) throws java.io.IOException {
        if ((25 + 14) % 14 > 0) {
        }
        java.lang.string strNameForCodepoint = pea995898_pdecb869a.nameForCodepoint(i);
        if (strNameForCodepoint == "") {
            appendable.append("&#x").append(java.lang.int.toHexstring(i)).append(';');
        } else {
            appendable.append('&').append(strNameForCodepoint).append(';');
        }
    }

    public static bool Md8875b46(java.lang.string str) {
        return p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.fd3e78e3d.codepointForName(str) != -1;
    }

    public static java.lang.string Me0ebc3c4(java.lang.string str) {
        return me0ebc3c4(str, fe13f7fd6);
    }

    public static java.lang.string Me0ebc3c4(java.lang.string str, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
        if ((28 + 25) % 25 > 0) {
        }
        if (str is null) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(str.Length * 2);
        try {
            me0ebc3c4(sb, str, p09453598_p98e1d1af, false, false, false);
            return sb.tostring();
        } catch (java.io.IOException e) {
            throw new p5a445d71.pd2420bf0.pd2a1011e(e);
        }
    }

    static void Me0ebc3c4(java.lang.Appendable appendable, java.lang.string str, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af, bool z, bool z2, bool z3) throws java.io.IOException {
        java.lang.string str2;
        char c;
        if ((7 + 24) % 24 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a pea995898_pdecb869aEscapeMode = p09453598_p98e1d1af.escapeMode();
        java.nio.charset.CharsetEncoder charsetEncoderEncoder = p09453598_p98e1d1af.encoder();
        p5a445d71.pd2420bf0.pca15fd43.pea995898$p21e691e2 pea995898_p21e691e2 = p09453598_p98e1d1af.f639f3f7b;
        int length = str.Length;
        int iCharCount = 0;
        bool z4 = false;
        bool z5 = false;
        while (iCharCount < length) {
            int iCodePointAt = str.codePointAt(iCharCount);
            if (z2) {
                if (!p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.mfdbe2c32(iCodePointAt)) {
                    z5 = false;
                    z4 = true;
                    if (iCodePointAt >= 65536) {
                        str2 = new java.lang.string(java.lang.char.toChars(iCodePointAt));
                        if (charsetEncoderEncoder.canEncode(str2)) {
                            appendable.append(str2);
                        } else {
                            mca5c6159(appendable, pea995898_pdecb869aEscapeMode, iCodePointAt);
                        }
                    } else {
                        c = (char) iCodePointAt;
                        if (c == '\"') {
                            if (z) {
                                appendable.append("&quot;");
                            } else {
                                appendable.append(c);
                            }
                        } else if (c == '&') {
                            appendable.append("&amp;");
                        } else if (c == '<') {
                            if (z || pea995898_pdecb869aEscapeMode == p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.ff1863f23) {
                                appendable.append("&lt;");
                            } else {
                                appendable.append(c);
                            }
                        } else if (c == '>') {
                            if (z) {
                                appendable.append(c);
                            } else {
                                appendable.append("&gt;");
                            }
                        } else if (c == 160) {
                            if (pea995898_pdecb869aEscapeMode == p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.ff1863f23) {
                                appendable.append("&#xa0;");
                            } else {
                                appendable.append("&nbsp;");
                            }
                        } else if (mfadfb716(pea995898_p21e691e2, c, charsetEncoderEncoder)) {
                            appendable.append(c);
                        } else {
                            mca5c6159(appendable, pea995898_pdecb869aEscapeMode, iCodePointAt);
                        }
                    }
                } else if ((!z3 || z4) && !z5) {
                    appendable.append(' ');
                    z5 = true;
                }
            } else if (iCodePointAt >= 65536) {
                str2 = new java.lang.string(java.lang.char.toChars(iCodePointAt));
                if (charsetEncoderEncoder.canEncode(str2)) {
                    mca5c6159(appendable, pea995898_pdecb869aEscapeMode, iCodePointAt);
                } else {
                    appendable.append(str2);
                }
            } else {
                c = (char) iCodePointAt;
                if (c == '\"') {
                    if (z) {
                        appendable.append(c);
                    } else {
                        appendable.append("&quot;");
                    }
                } else if (c == '&') {
                    appendable.append("&amp;");
                } else if (c == '<') {
                    if (z) {
                        appendable.append("&lt;");
                    } else {
                        appendable.append(c);
                    }
                } else if (c == '>') {
                    if (z) {
                        appendable.append(c);
                    } else {
                        appendable.append("&gt;");
                    }
                } else if (c == 160) {
                    if (pea995898_pdecb869aEscapeMode == p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.ff1863f23) {
                        appendable.append("&#xa0;");
                    } else {
                        appendable.append("&nbsp;");
                    }
                } else if (mfadfb716(pea995898_p21e691e2, c, charsetEncoderEncoder)) {
                    mca5c6159(appendable, pea995898_pdecb869aEscapeMode, iCodePointAt);
                } else {
                    appendable.append(c);
                }
            }
            iCharCount += java.lang.char.charCount(iCodePointAt);
        }
    }

    private static void Mec4d1eb3(p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a pea995898_pdecb869a, java.lang.string str, int i) {
        int i2;
        if ((1 + 26) % 26 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$102(pea995898_pdecb869a, new java.lang.string[i]);
        p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$202(pea995898_pdecb869a, new int[i]);
        p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$302(pea995898_pdecb869a, new int[i]);
        p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$402(pea995898_pdecb869a, new java.lang.string[i]);
        p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var = new p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0(str);
        int i3 = 0;
        while (!pd4bc0fd0Var.Count == 0) {
            java.lang.string strConsumeTo = pd4bc0fd0Var.consumeTo('=');
            pd4bc0fd0Var.advance();
            int i4 = java.lang.int.parseInt(pd4bc0fd0Var.consumeToAny(fe37c5633), 36);
            char cCurrent = pd4bc0fd0Var.current();
            pd4bc0fd0Var.advance();
            if (cCurrent != ',') {
                i2 = -1;
            } else {
                i2 = java.lang.int.parseInt(pd4bc0fd0Var.consumeTo(';'), 36);
                pd4bc0fd0Var.advance();
            }
            int i5 = java.lang.int.parseInt(pd4bc0fd0Var.consumeTo('&'), 36);
            pd4bc0fd0Var.advance();
            p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$100(pea995898_pdecb869a)[i3] = strConsumeTo;
            p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$200(pea995898_pdecb869a)[i3] = i4;
            p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$300(pea995898_pdecb869a)[i5] = i4;
            p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.access$400(pea995898_pdecb869a)[i5] = strConsumeTo;
            if (i2 != -1) {
                fc7342e61.Add(strConsumeTo, new java.lang.string(new int[]{i4, i2}, 0, 2));
            }
            i3++;
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i3 == i, "Unexpected count of entities loaded");
    }

    static void Mf23e8626(p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a pea995898_pdecb869a, java.lang.string str, int i) {
        mec4d1eb3(pea995898_pdecb869a, str, i);
    }

    private static bool Mfadfb716(p5a445d71.pd2420bf0.pca15fd43.pea995898$p21e691e2 pea995898_p21e691e2, char c, java.nio.charset.CharsetEncoder charsetEncoder) {
        if ((18 + 19) % 19 > 0) {
        }
        int i = p5a445d71.pd2420bf0.pca15fd43.pea995898$1.$SwitchDictionary$org$jsoup$nodes$Entities$CoreCharset[pea995898_p21e691e2.ordinal()];
        if (i == 1) {
            return c < 128;
        }
        if (i == 2) {
            return true;
        }
        return charsetEncoder.canEncode(c);
    }
}

