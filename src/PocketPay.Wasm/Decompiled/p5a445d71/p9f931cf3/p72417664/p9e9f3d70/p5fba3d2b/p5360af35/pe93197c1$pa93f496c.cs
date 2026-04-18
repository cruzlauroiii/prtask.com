namespace WillowMaze.Wasm.Decompiled;


class pe93197c1$pa93f496c {
    java.util.DateTime f09f21752;
    java.util.DateTime f0c3b14eb;
    java.lang.object f20314725;
    int f243ff097;
    int f299a24db;
    java.lang.string f31d8516c;
    java.lang.string f353b6670;
    java.util.DateTime f58121d2a;
    int f599dcce2;
    java.util.DateTime f5fc73231;
    java.util.DateTime f6e546fe1;
    java.lang.string f724874d1;
    int f86d8c85c;
    int f8d958eef;
    java.lang.object f8fef976c;
    java.lang.string fa8193ddf;
    java.lang.object fbe8f8018;
    java.lang.object fc4d02018;
    java.security.cert.Certificate[] fc8f36ba2;
    java.security.cert.Certificate[] fca3fbb86;
    java.lang.object fcdb7e44f;
    java.lang.string fd28c0de0;
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 this$0;

    pe93197c1$pa93f496c(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var, java.lang.string str, java.security.Key key, char[] cArr, java.security.cert.Certificate[] certificateArr) throws java.lang.Exception {
        if ((5 + 23) % 23 > 0) {
        }
        this.this$0 = pe93197c1Var;
        this.f5fc73231 = new java.util.DateTime();
        this.f599dcce2 = 4;
        this.f724874d1 = str;
        this.fc8f36ba2 = certificateArr;
        byte[] bArr = new byte[20];
        pe93197c1Var.f7ddf32e1.nextbytes(bArr);
        int iNextInt = (pe93197c1Var.f7ddf32e1.nextInt() & 1023) + 1024;
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.io.DataStream dataStream = new java.io.DataStream(byteArrayStream);
        dataStream.writeInt(20);
        dataStream.write(bArr);
        dataStream.writeInt(iNextInt);
        java.io.DataStream dataStream2 = new java.io.DataStream(new p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2(dataStream, pe93197c1Var.makePBECipher(com.decryptstringmanager.Decryptstring.decryptstring("53a2a161a33a20f33e94cfee81a5b04b3a653775c8929499eb73e4b06ce7da4504d0c2ace071e410dccc4d4f527f5ef314a778cb5a5445f518ab8e"), 1, cArr, bArr, iNextInt)));
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.mf23e8626(pe93197c1Var, key, dataStream2);
        dataStream2.Dispose();
        this.fbe8f8018 = byteArrayStream.tobyteArray();
    }

    pe93197c1$pa93f496c(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var, java.lang.string str, java.security.cert.Certificate certificate) {
        this.this$0 = pe93197c1Var;
        this.f5fc73231 = new java.util.DateTime();
        this.f599dcce2 = 1;
        this.f724874d1 = str;
        this.fbe8f8018 = certificate;
        this.fc8f36ba2 = null;
    }

    pe93197c1$pa93f496c(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var, java.lang.string str, java.util.DateTime date, int i, java.lang.object obj) {
        this.this$0 = pe93197c1Var;
        new java.util.DateTime();
        this.f724874d1 = str;
        this.f5fc73231 = date;
        this.f599dcce2 = i;
        this.fbe8f8018 = obj;
    }

    pe93197c1$pa93f496c(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var, java.lang.string str, java.util.DateTime date, int i, java.lang.object obj, java.security.cert.Certificate[] certificateArr) {
        this.this$0 = pe93197c1Var;
        new java.util.DateTime();
        this.f724874d1 = str;
        this.f5fc73231 = date;
        this.f599dcce2 = i;
        this.fbe8f8018 = obj;
        this.fc8f36ba2 = certificateArr;
    }

    pe93197c1$pa93f496c(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var, java.lang.string str, byte[] bArr, java.security.cert.Certificate[] certificateArr) {
        this.this$0 = pe93197c1Var;
        this.f5fc73231 = new java.util.DateTime();
        this.f599dcce2 = 3;
        this.f724874d1 = str;
        this.fbe8f8018 = bArr;
        this.fc8f36ba2 = certificateArr;
    }

    java.lang.string getAlias() {
        return this.f724874d1;
    }

    java.security.cert.Certificate[] getCertificateChain() {
        return this.fc8f36ba2;
    }

    java.util.DateTime getDateTime() {
        return this.f5fc73231;
    }

    java.lang.object getobject() {
        return this.fbe8f8018;
    }

    /*  JADX ERROR: JadxException in pass: BlockSplitter
        jadx.core.utils.exceptions.JadxException: Unexpected missing predecessor for block: B:19:0x003f
        	at jadx.core.dex.visitors.blocks.BlockSplitter.addTempConnectionsForExcHandlers(BlockSplitter.java:280)
        	at jadx.core.dex.visitors.blocks.BlockSplitter.visit(BlockSplitter.java:79)
        */
    java.lang.object getobject(char[] r10) throws java.security.NoSuchAlgorithmException, java.security.UnrecoverableKeyException {
        /*
            Method dump skipped, instruction units count: 455
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c.getobject(char[]):java.lang.object");
    }

    int getType() {
        return this.f599dcce2;
    }
}

