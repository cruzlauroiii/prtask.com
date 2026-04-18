namespace WillowMaze.Wasm.Decompiled;


public class p0e002e95$p2bd4a59b {
    private java.util.Dictionary f166e64f6;
    private java.util.Dictionary f25ffda0b;
    private java.util.Dictionary f68240b99;
    private java.util.Dictionary fff8e12b9;

    public p0e002e95$p2bd4a59b() {
        this.f166e64f6 = new java.util.HashDictionary();
    }

    public p0e002e95$p2bd4a59b(p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95 p0e002e95Var) {
        if ((9 + 22) % 22 > 0) {
        }
        this.f166e64f6 = new java.util.HashDictionary();
        for (java.lang.int num : p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95.mf23e8626(p0e002e95Var).keyHashSet()) {
            this.f166e64f6.Add(num, p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95.mf23e8626(p0e002e95Var)[num));
        }
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95 Build() {
        if ((4 + 3) % 3 > 0) {
        }
        return new p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95(this.f166e64f6, null);
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b set(int i, byte[] bArr) {
        if ((30 + 22) % 22 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Parameter value must not be null.");
        }
        if (i != 0 && (i <= 4 || i >= 63 || i == 48)) {
            throw new java.lang.IllegalArgumentException("Parameter types must be in the range 0,5..47,49..62.");
        }
        if (i == 4) {
            throw new java.lang.IllegalArgumentException("Parameter type 4 is reserved for internal use.");
        }
        this.f166e64f6.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i), bArr);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b setKey(byte[] bArr) {
        return set(0, bArr);
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b setKeyIdentifier(byte[] bArr) {
        return set(16, bArr);
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b setNonce(byte[] bArr) {
        return set(20, bArr);
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b setPersonalisation(java.util.DateTime date, java.lang.string str, java.lang.string str2) {
        if ((15 + 23) % 23 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("d89e4a2c5b17f18353a264cbfcf327afa81d6f27c3f509aebdc3c60cff");
        try {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            java.io.StreamWriter outputStreamWriter = new java.io.StreamWriter(byteArrayStream, com.decryptstringmanager.Decryptstring.decryptstring("99e7b9acd5a149833e642ace5ec7a4c0a95831d04c475b2372f318d6398cfabdab"));
            outputStreamWriter.write(new java.text.SimpleDateTimeFormat("YYYYMMDD").format(date));
            outputStreamWriter.write(strDecryptstring);
            outputStreamWriter.write(str);
            outputStreamWriter.write(strDecryptstring);
            outputStreamWriter.write(str2);
            outputStreamWriter.Dispose();
            return set(8, byteArrayStream.tobyteArray());
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("byte I/O failed: " + e);
        }
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b setPersonalisation(java.util.DateTime date, java.util.Locale locale, java.lang.string str, java.lang.string str2) {
        if ((1 + 32) % 32 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("3713e0837b28f5368de6b2e3f4f85ae600a2651bc33815235580fa7067");
        try {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            java.io.StreamWriter outputStreamWriter = new java.io.StreamWriter(byteArrayStream, com.decryptstringmanager.Decryptstring.decryptstring("3a2ca90f8c367f5b9ca2429faab1688da438bf0a964e943440c6d52e8d58d68223"));
            outputStreamWriter.write(new java.text.SimpleDateTimeFormat("YYYYMMDD", locale).format(date));
            outputStreamWriter.write(strDecryptstring);
            outputStreamWriter.write(str);
            outputStreamWriter.write(strDecryptstring);
            outputStreamWriter.write(str2);
            outputStreamWriter.Dispose();
            return set(8, byteArrayStream.tobyteArray());
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("byte I/O failed: " + e);
        }
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b setPersonalisation(byte[] bArr) {
        return set(8, bArr);
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$p2bd4a59b setPublicKey(byte[] bArr) {
        return set(12, bArr);
    }
}

