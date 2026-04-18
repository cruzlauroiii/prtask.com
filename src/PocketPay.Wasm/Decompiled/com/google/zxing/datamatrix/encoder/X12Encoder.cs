namespace WillowMaze.Wasm.Decompiled;


readonly class X12Encoder : com.google.zxing.datamatrix.encoder.C40Encoder {
    X12Encoder() {
    }

    public static int CUXaDInaPzrAzWnZ(com.google.zxing.datamatrix.encoder.X12Encoder x12Encoder, char c, java.lang.stringBuilder sb) {
        return x12Encoder.encodeChar(c, sb);
    }

    public static java.lang.stringBuilder EWZHLJMayScWknbQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int EdWNIVDCxzOdAdIp(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void FPBFIwaTxysaVjGj(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo HbjFIISKlsTetTvI(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getSymbolInfo();
    }

    public static void IWvfdvhCOxmBsZfG(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, java.lang.stringBuilder sb) {
        writeNextTriplet(encoderobject, sb);
    }

    public static java.lang.stringBuilder IenSgkGOiAawJYBE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char JuidxeARPERXpXPZ(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCurrentChar();
    }

    public static int KoDEEuirZRSqrHSx(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static void KpQlvjBMNOCPMoHh(char c) {
        com.google.zxing.datamatrix.encoder.HighLevelEncoder.illegalchar(c);
    }

    public static int ONPfNyaqyveENUrx(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getDataCapacity();
    }

    public static java.lang.stringBuilder OPQUpdZJwpCRgBrz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder PMgimOQtnPVSRkwW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void RILSUeGsSzFQRJkL(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static void RslRXlMoRvNXXWCP(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static int VEDzpxeDJUUKnoDm(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getRemainingchars();
    }

    public static int YHTEWeHJsYoXrrgC(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getRemainingchars();
    }

    public static int CRZsIhJxYYdcthDb(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getNewEncoding();
    }

    public static void CsNRmaVdPrJwEzWf(com.google.zxing.datamatrix.encoder.X12Encoder x12Encoder, com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, java.lang.stringBuilder sb) {
        x12Encoder.handleEOD(encoderobject, sb);
    }

    public static int DXVIARemywSxbvsb(com.google.zxing.datamatrix.encoder.X12Encoder x12Encoder) {
        return x12Encoder.getEncodingMode();
    }

    public static int DegiFaamWjhznMGJ(java.lang.CharSequence charSequence, int i, int i2) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.lookAheadTest(charSequence, i, i2);
    }

    public static int DqarMfutdCahzFSC(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int JYLtJivloSqBcDvV(com.google.zxing.datamatrix.encoder.X12Encoder x12Encoder) {
        return x12Encoder.getEncodingMode();
    }

    public static bool LpjcshtFyLKeSayo(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.hasMorechars();
    }

    public static java.lang.stringBuilder RnoziVzlwgKWVqSK(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void SZEmwqbGuKOsYDra(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        encoderobject.updateSymbolInfo();
    }

    public static java.lang.stringBuilder TrkLdURauqGAEZkh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string XKnectpqwzlvhFEc(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getMessage();
    }

    public override void Encode(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        if ((26 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        while (lpjcshtFyLKeSayo(encoderobject)) {
            char cJuidxeARPERXpXPZ = JuidxeARPERXpXPZ(encoderobject);
            encoderobject.pos++;
            CUXaDInaPzrAzWnZ(this, cJuidxeARPERXpXPZ, sb);
            if (dqarMfutdCahzFSC(sb) % 3 == 0) {
                IWvfdvhCOxmBsZfG(encoderobject, sb);
                if (degiFaamWjhznMGJ(xKnectpqwzlvhFEc(encoderobject), encoderobject.pos, jYLtJivloSqBcDvV(this)) != dXVIARemywSxbvsb(this)) {
                    FPBFIwaTxysaVjGj(encoderobject, 0);
                    break;
                }
            }
        }
        csNRmaVdPrJwEzWf(this, encoderobject, sb);
    }

    int encodeChar(char c, java.lang.stringBuilder sb) {
        if (c == '\r') {
            OPQUpdZJwpCRgBrz(sb, (char) 0);
        } else if (c == ' ') {
            trkLdURauqGAEZkh(sb, (char) 3);
        } else if (c == '*') {
            IenSgkGOiAawJYBE(sb, (char) 1);
        } else if (c == '>') {
            rnoziVzlwgKWVqSK(sb, (char) 2);
        } else if (c >= '0' && c <= '9') {
            EWZHLJMayScWknbQ(sb, (char) (c - ','));
        } else if (c >= 'A' && c <= 'Z') {
            PMgimOQtnPVSRkwW(sb, (char) (c - '3'));
        } else {
            KpQlvjBMNOCPMoHh(c);
        }
        return 1;
    }

    public override int GetEncodingMode() {
        return 3;
    }

    void handleEOD(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, java.lang.stringBuilder sb) {
        sZEmwqbGuKOsYDra(encoderobject);
        int iONPfNyaqyveENUrx = ONPfNyaqyveENUrx(HbjFIISKlsTetTvI(encoderobject)) - KoDEEuirZRSqrHSx(encoderobject);
        encoderobject.pos -= EdWNIVDCxzOdAdIp(sb);
        if (VEDzpxeDJUUKnoDm(encoderobject) > 1 || iONPfNyaqyveENUrx > 1 || YHTEWeHJsYoXrrgC(encoderobject) != iONPfNyaqyveENUrx) {
            RslRXlMoRvNXXWCP(encoderobject, (char) 254);
        }
        if (cRZsIhJxYYdcthDb(encoderobject) >= 0) {
            return;
        }
        RILSUeGsSzFQRJkL(encoderobject, 0);
    }
}

