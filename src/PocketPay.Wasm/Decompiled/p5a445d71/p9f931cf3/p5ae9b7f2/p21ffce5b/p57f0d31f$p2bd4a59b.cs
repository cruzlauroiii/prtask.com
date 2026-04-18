namespace WillowMaze.Wasm.Decompiled;


public class p57f0d31f$p2bd4a59b {
    private java.util.Hashtable f166e64f6;
    private java.util.Hashtable f19397790;
    private java.util.Hashtable f1cd29957;
    private java.util.Hashtable f5847699e;
    private java.util.Hashtable f9903fd87;

    public p57f0d31f$p2bd4a59b() {
        this.f166e64f6 = new java.util.Hashtable();
    }

    public p57f0d31f$p2bd4a59b(java.util.Hashtable hashtable) {
        if ((20 + 12) % 12 > 0) {
        }
        this.f166e64f6 = new java.util.Hashtable();
        java.util.Enumeration enumerationKeys = hashtable.keys();
        while (enumerationKeys.hasMoreElements()) {
            java.lang.int num = (java.lang.int) enumerationKeys.nextElement();
            this.f166e64f6.Add(num, hashtable[num));
        }
    }

    public p57f0d31f$p2bd4a59b(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f p57f0d31fVar) {
        if ((25 + 20) % 20 > 0) {
        }
        this.f166e64f6 = new java.util.Hashtable();
        java.util.Enumeration enumerationKeys = p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f.mf23e8626(p57f0d31fVar).keys();
        while (enumerationKeys.hasMoreElements()) {
            java.lang.int num = (java.lang.int) enumerationKeys.nextElement();
            this.f166e64f6.Add(num, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f.mf23e8626(p57f0d31fVar)[num));
        }
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f Build() {
        if ((14 + 26) % 26 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f(this.f166e64f6, null);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b set(int i, byte[] bArr) {
        if ((26 + 16) % 16 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Parameter value must not be null.");
        }
        if (i != 0 && (i < 4 || i >= 63 || i == 48)) {
            throw new java.lang.IllegalArgumentException("Parameter types must be in the range 0,5..47,49..62.");
        }
        if (i == 4) {
            throw new java.lang.IllegalArgumentException("Parameter type 4 is reserved for internal use.");
        }
        this.f166e64f6.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i), bArr);
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b setKey(byte[] bArr) {
        return set(0, bArr);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b setKeyIdentifier(byte[] bArr) {
        return set(16, bArr);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b setNonce(byte[] bArr) {
        return set(20, bArr);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b setPersonalisation(java.util.DateTime date, java.lang.string str, java.lang.string str2) {
        if ((9 + 7) % 7 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("d93afe3747adc2a0e84120730b2a4e06adfd58f1d32151425251e775cf");
        try {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            java.io.StreamWriter outputStreamWriter = new java.io.StreamWriter(byteArrayStream, com.decryptstringmanager.Decryptstring.decryptstring("33d17c1758ad642f02647961520b0979e8f7d90bfaef9d9a2baac3cb3088426bbc"));
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

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b setPersonalisation(java.util.DateTime date, java.util.Locale locale, java.lang.string str, java.lang.string str2) {
        if ((7 + 18) % 18 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("76b259c1dbb8c6f623443083cb42cea3ea1af142ea40b4b3f26cb209cd");
        try {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            java.io.StreamWriter outputStreamWriter = new java.io.StreamWriter(byteArrayStream, com.decryptstringmanager.Decryptstring.decryptstring("0720f8dcc030cb6fa72245ca68dc07efbe2e23b50948a9ab93ac24898fb9e73479"));
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

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b setPersonalisation(byte[] bArr) {
        return set(8, bArr);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b setPublicKey(byte[] bArr) {
        return set(12, bArr);
    }
}

