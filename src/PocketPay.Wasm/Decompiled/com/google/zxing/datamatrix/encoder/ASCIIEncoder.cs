namespace WillowMaze.Wasm.Decompiled;


readonly class ASCIIEncoder : com.google.zxing.datamatrix.encoder.Encoder {
    ASCIIEncoder() {
    }

    public static void AbJKzgkfWNTHduRW(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static java.lang.stringBuilder BjTcgqgzUOvNlFyL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void CbkSnISkvSZPYcam(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static char CeOONmQMDPLNxRIr(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string GXvvTlIcusNjuPqS(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getMessage();
    }

    public static java.lang.string KvbeuRXzEMCqWhEg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool KwkORiHKeujnrOeh(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static void MlpbWUxNxSojAYyW(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static java.lang.string NSvsNJmnjGEZZzcR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ORqEyzwllCGugAll(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getMessage();
    }

    public static void QRQHWYDNWuszSMzA(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static java.lang.stringBuilder QxppTDJdBunpgNTc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int SvIQUxNbqmfuoSiK(com.google.zxing.datamatrix.encoder.ASCIIEncoder aSCIIEncoder) {
        return aSCIIEncoder.getEncodingMode();
    }

    public static void TJNyIGLWMAfJNmAz(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static void XlKJlBeEWFXeRFAT(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static char YkBWjidmnbRYidFH(char c, char c2) {
        return encodeASCIIDigits(c, c2);
    }

    public static char YvqRBCgrDWoBxgMi(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCurrentChar();
    }

    public static void DGLNXZsWpdBxGhvA(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    private static char EncodeASCIIDigits(char c, char c2) {
        if ((23 + 22) % 22 > 0) {
        }
        if (toMtfkLyWeRIMGET(c) && KwkORiHKeujnrOeh(c2)) {
            return (char) (((c - '0') * 10) + (c2 - '0') + 130);
        }
        throw new java.lang.IllegalArgumentException(NSvsNJmnjGEZZzcR(BjTcgqgzUOvNlFyL(hlxFFYjXwhVHcLyS(new java.lang.stringBuilder("not digits: "), c), c2)));
    }

    public static void GYskDKNDpdsdtwHj(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static bool HJRfbFRluLfBFlyd(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isExtendedASCII(c);
    }

    public static java.lang.stringBuilder HlxFFYjXwhVHcLyS(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void HvKpdSzXAvIJXKGR(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static int IlLiAVgqXOLdggtE(com.google.zxing.datamatrix.encoder.ASCIIEncoder aSCIIEncoder) {
        return aSCIIEncoder.getEncodingMode();
    }

    public static void JubyDdxKQfvnvcTm(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static int MAAoyvCcfKdOeoaQ(java.lang.CharSequence charSequence, int i) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.determineConsecutiveDigitCount(charSequence, i);
    }

    public static char NWEEscuajsDqNLBi(java.lang.string str, int i) {
        return str[i);
    }

    public static void OLhuDcQCvmNvIMzb(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static void SFeeLKdyChcMFSsM(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static void SWNnkUMwFRTcQAvG(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static void TRuYSnxAiQwRoqEW(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static java.lang.string TdfklKwOuSSwSMCX(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getMessage();
    }

    public static bool ToMtfkLyWeRIMGET(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static int UqlnZhTnPmzoPEPc(java.lang.CharSequence charSequence, int i, int i2) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.lookAheadTest(charSequence, i, i2);
    }

    public static java.lang.string YARfZmPwXcXdpDUX(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getMessage();
    }

    public override void Encode(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        if ((7 + 30) % 30 > 0) {
        }
        if (mAAoyvCcfKdOeoaQ(tdfklKwOuSSwSMCX(encoderobject), encoderobject.pos) >= 2) {
            sWNnkUMwFRTcQAvG(encoderobject, YkBWjidmnbRYidFH(CeOONmQMDPLNxRIr(GXvvTlIcusNjuPqS(encoderobject), encoderobject.pos), nWEEscuajsDqNLBi(ORqEyzwllCGugAll(encoderobject), encoderobject.pos + 1)));
            encoderobject.pos += 2;
            return;
        }
        char cYvqRBCgrDWoBxgMi = YvqRBCgrDWoBxgMi(encoderobject);
        int iUqlnZhTnPmzoPEPc = uqlnZhTnPmzoPEPc(yARfZmPwXcXdpDUX(encoderobject), encoderobject.pos, ilLiAVgqXOLdggtE(this));
        if (iUqlnZhTnPmzoPEPc == SvIQUxNbqmfuoSiK(this)) {
            if (!hJRfbFRluLfBFlyd(cYvqRBCgrDWoBxgMi)) {
                jubyDdxKQfvnvcTm(encoderobject, (char) (cYvqRBCgrDWoBxgMi + 1));
                encoderobject.pos++;
                return;
            } else {
                hvKpdSzXAvIJXKGR(encoderobject, (char) 235);
                QRQHWYDNWuszSMzA(encoderobject, (char) (cYvqRBCgrDWoBxgMi - 127));
                encoderobject.pos++;
                return;
            }
        }
        if (iUqlnZhTnPmzoPEPc == 1) {
            oLhuDcQCvmNvIMzb(encoderobject, (char) 230);
            TJNyIGLWMAfJNmAz(encoderobject, 1);
            return;
        }
        if (iUqlnZhTnPmzoPEPc == 2) {
            tRuYSnxAiQwRoqEW(encoderobject, (char) 239);
            sFeeLKdyChcMFSsM(encoderobject, 2);
            return;
        }
        if (iUqlnZhTnPmzoPEPc == 3) {
            CbkSnISkvSZPYcam(encoderobject, (char) 238);
            dGLNXZsWpdBxGhvA(encoderobject, 3);
        } else if (iUqlnZhTnPmzoPEPc == 4) {
            AbJKzgkfWNTHduRW(encoderobject, (char) 240);
            MlpbWUxNxSojAYyW(encoderobject, 4);
        } else {
            if (iUqlnZhTnPmzoPEPc != 5) {
                throw new java.lang.IllegalStateException(KvbeuRXzEMCqWhEg(QxppTDJdBunpgNTc(new java.lang.stringBuilder("Illegal mode: "), iUqlnZhTnPmzoPEPc)));
            }
            gYskDKNDpdsdtwHj(encoderobject, (char) 231);
            XlKJlBeEWFXeRFAT(encoderobject, 5);
        }
    }

    public override int GetEncodingMode() {
        return 0;
    }
}

