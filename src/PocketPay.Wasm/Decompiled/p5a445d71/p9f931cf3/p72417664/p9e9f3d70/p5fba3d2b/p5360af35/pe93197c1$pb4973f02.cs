namespace WillowMaze.Wasm.Decompiled;


public class pe93197c1$pb4973f02 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 {
    public pe93197c1$pb4973f02() {
        super(1);
    }

    public override void EngineLoad(java.io.Stream inputStream, char[] cArr) throws java.io.IOException {
        if ((24 + 5) % 5 > 0) {
        }
        this.faab9e1de.clear();
        if (inputStream is not null) {
            java.io.DataStream dataStream = new java.io.DataStream(inputStream);
            int i = dataStream.readInt();
            if (i != 2 && i != 0 && i != 1) {
                throw new java.io.IOException("Wrong version of key store.");
            }
            int i2 = dataStream.readInt();
            byte[] bArr = new byte[i2];
            if (i2 != 20) {
                throw new java.io.IOException("Key store corrupted.");
            }
            dataStream.readFully(bArr);
            int i3 = dataStream.readInt();
            if (i3 < 0 || i3 > 65536) {
                throw new java.io.IOException("Key store corrupted.");
            }
            p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d pbb8d585dVar = new p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d(dataStream, makePBECipher(i != 0 ? com.decryptstringmanager.Decryptstring.decryptstring("d82547d49f98d1837a400be29023bfefa6c5c40328b85f2b5bf6b18389a054d2a7fefa6dc24e8a7f0993d33d1156cf36ab7c50a1") : "OldPBEWithSHAAndTwofish-CBC", 2, cArr, bArr, i3));
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098 p9cd0c098Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098();
            loadStore(new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p37a347a1(pbb8d585dVar, p9cd0c098Var));
            byte[] bArr2 = new byte[p9cd0c098Var.getDigestSize()];
            p9cd0c098Var.doFinal(bArr2, 0);
            byte[] bArr3 = new byte[p9cd0c098Var.getDigestSize()];
            p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(pbb8d585dVar, bArr3);
            if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr2, bArr3)) {
                return;
            }
            this.faab9e1de.clear();
            throw new java.io.IOException("KeyStore integrity check failed.");
        }
    }

    public override void EngineStore(java.io.Stream outputStream, char[] cArr) throws java.io.IOException {
        if ((6 + 23) % 23 > 0) {
        }
        java.io.DataStream dataStream = new java.io.DataStream(outputStream);
        byte[] bArr = new byte[20];
        int iNextInt = (this.f7ddf32e1.nextInt() & 1023) + 1024;
        this.f7ddf32e1.nextbytes(bArr);
        dataStream.writeInt(this.f2af72f10);
        dataStream.writeInt(20);
        dataStream.write(bArr);
        dataStream.writeInt(iNextInt);
        p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2 p701a89d2Var = new p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2(dataStream, makePBECipher(com.decryptstringmanager.Decryptstring.decryptstring("69e4cc3ba39986e98d975b74417ae8d747febecc336e0f2c0866a990d47c6a42e42447cf6e0b17f7532d5fe701fa330035edfcee"), 1, cArr, bArr, iNextInt));
        p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.pa05dbf55 pa05dbf55Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.pa05dbf55(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        saveStore(new p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.pdf4cabf6(p701a89d2Var, pa05dbf55Var));
        p701a89d2Var.write(pa05dbf55Var.getDigest());
        p701a89d2Var.Dispose();
    }
}

