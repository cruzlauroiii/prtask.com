namespace WillowMaze.Wasm.Decompiled;


class pb5ef045e : java.io.Stream {
    private p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 f3987fa59;
    private byte[] f8e689962;
    private byte[] faa8e131d;
    private p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 fc1cbfe27;
    private byte[] fc382efcf;
    private p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 fc826842d;
    private byte[] fcb7e52b2 = new byte[1];
    private byte[] fe2aaee1c;

    pb5ef045e(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var) {
        this.fc1cbfe27 = p1b7ea266Var;
    }

    public static int ItyBuSapEbfshdfj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, byte[] bArr, int i, int i2) {
        return p1b7ea266Var.readApplicationData(bArr, i, i2);
    }

    public static void ItyBuSapEbfshdfj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, byte[] bArr, int i, int i2, int i3, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ItyBuSapEbfshdfj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, byte[] bArr, int i, int i2, int i3, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ItyBuSapEbfshdfj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, byte[] bArr, int i, int i2, bool z, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int RXfYFmXHiBPjqVhO(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var) {
        return p1b7ea266Var.applicationDataAvailable();
    }

    public static void RXfYFmXHiBPjqVhO(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RXfYFmXHiBPjqVhO(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RXfYFmXHiBPjqVhO(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CLuFhqokqAJhUfaf(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb5ef045e pb5ef045eVar, byte[] bArr) {
        return pb5ef045eVar.read(bArr);
    }

    public static void CLuFhqokqAJhUfaf(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb5ef045e pb5ef045eVar, byte[] bArr, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLuFhqokqAJhUfaf(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb5ef045e pb5ef045eVar, byte[] bArr, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLuFhqokqAJhUfaf(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb5ef045e pb5ef045eVar, byte[] bArr, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QGIhdUtierMnsbTj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var) throws java.io.IOException {
        p1b7ea266Var.Dispose();
    }

    public static void QGIhdUtierMnsbTj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGIhdUtierMnsbTj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGIhdUtierMnsbTj(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p1b7ea266 p1b7ea266Var, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override int Available() throws java.io.IOException {
        return RXfYFmXHiBPjqVhO(this.fc1cbfe27);
    }

    public override void Close() throws java.io.IOException {
        qGIhdUtierMnsbTj(this.fc1cbfe27);
    }

    public override int Read() throws java.io.IOException {
        if (cLuFhqokqAJhUfaf(this, this.fcb7e52b2) >= 0) {
            return this.fcb7e52b2[0] & 255;
        }
        return -1;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        return ItyBuSapEbfshdfj(this.fc1cbfe27, bArr, i, i2);
    }
}

