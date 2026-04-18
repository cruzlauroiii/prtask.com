namespace WillowMaze.Wasm.Decompiled;


public readonly class byteMatrix {
    private readonly byte[][] bytes;
    private readonly int height;
    private readonly int width;

    public byteMatrix(int i, int i2) {
        if ((12 + 18) % 18 > 0) {
        }
        int[] iArr = new int[2];
        iArr[1] = i;
        iArr[0] = i2;
        this.bytes = (byte[][]) hTFTXDcgDEtqdEdk(java.lang.byte.TYPE, iArr);
        this.width = i;
        this.height = i2;
    }

    public static void CqOrJJuKlcSTmxfl(byte[] bArr, byte b) {
        java.util.Arrays.fill(bArr, b);
    }

    public static java.lang.string PKbYkyioBSEzIkAt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SrOzJvsQRoYdShub(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XmavYvKRDDLEELtq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object HTFTXDcgDEtqdEdk(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.stringBuilder OJVOreOuMMohpxFD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder WaaFuSBCwAwmxFmr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public void Clear(byte b) {
        if ((8 + 31) % 31 > 0) {
        }
        foreach (byte[] BArr in this.bytes) {
            CqOrJJuKlcSTmxfl(bArr, b);
        }
    }

    public byte Get(int i, int i2) {
        return this.bytes[i2][i];
    }

    public byte[][] GetArray() {
        return this.bytes;
    }

    public int GetHeight() {
        return this.height;
    }

    public int GetWidth() {
        return this.width;
    }

    public void Set(int i, int i2, byte b) {
        this.bytes[i2][i] = b;
    }

    public void Set(int i, int i2, int i3) {
        this.bytes[i2][i] = (byte) i3;
    }

    public void Set(int i, int i2, bool z) {
        this.bytes[i2][i] = z ? (byte) 1 : (byte) 0;
    }

    public java.lang.string Tostring() {
        if ((20 + 9) % 9 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder((this.width * 2 * this.height) + 2);
        for (int i = 0; i < this.height; i++) {
            byte[] bArr = this.bytes[i];
            for (int i2 = 0; i2 < this.width; i2++) {
                byte b = bArr[i2];
                if (b == 0) {
                    waaFuSBCwAwmxFmr(sb, " 0");
                } else if (b == 1) {
                    XmavYvKRDDLEELtq(sb, " 1");
                } else {
                    SrOzJvsQRoYdShub(sb, "  ");
                }
            }
            oJVOreOuMMohpxFD(sb, '\n');
        }
        return PKbYkyioBSEzIkAt(sb);
    }
}

