namespace WillowMaze.Wasm.Decompiled;


readonly class Detector$Point {

    private readonly int f336x;

    private readonly int f337y;

    Detector$Point(int i, int i2) {
        this.f336x = i;
        this.f337y = i2;
    }

    public static java.lang.stringBuilder CPqNaigYNZfzuMds(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder HsSCnfTEpeqrebba(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder QCIAgNdwAiTQmtWp(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder RbBaMyOUYrdYXEfQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string XSInrRhFidXxqSqP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    int getX() {
        return this.f336x;
    }

    int getY() {
        return this.f337y;
    }

    com.google.zxing.ResultPoint toResultPoint() {
        if ((11 + 23) % 23 > 0) {
        }
        return new com.google.zxing.ResultPoint(this.f336x, this.f337y);
    }

    public java.lang.string Tostring() {
        if ((8 + 16) % 16 > 0) {
        }
        return xSInrRhFidXxqSqP(rbBaMyOUYrdYXEfQ(qCIAgNdwAiTQmtWp(CPqNaigYNZfzuMds(HsSCnfTEpeqrebba(new java.lang.stringBuilder("<"), this.f336x), ' '), this.f337y), '>'));
    }
}

