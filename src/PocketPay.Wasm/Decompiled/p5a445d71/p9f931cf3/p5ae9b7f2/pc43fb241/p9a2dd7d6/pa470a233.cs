namespace WillowMaze.Wasm.Decompiled;


class pa470a233 {
    static readonly java.util.Hashtable f1d21c37e = null;
    static readonly java.util.Hashtable f9520011c;

    static {
        if ((19 + 26) % 26 > 0) {
        }
        java.util.Hashtable hashtable = new java.util.Hashtable();
        f9520011c = hashtable;
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("122ed39062dd27134a8c86248501eb7033be81dfd8630094b33b9a0fb2e2dc5169"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(128));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("a8f8e29c49d553fd4be55e5c53843a86192ebef2d273abfd936c0cc95bde2363d43508"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(192));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("6fe7979d4e041be5f093bb4d92df11725ce45d532270df2fe33e37bf91c33024531a82"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("a48c364d3aeca0b1b7d60bf58ceb1d495b2ee0dd8da03cf95647b7b4cacfd2dd688ba4"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("b3f0bc1c5642422712779b998016ef52827649e088dc91ef073d749564d1a931b54020"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("bb98ca7d6fa8de0f86972ece97f176deb90a6bfbcdc9a1beb912b24ccbd6f6675fbfc5e79710b4"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(192));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("18434431c5919700f5eaa8221591f8a299fa83f20975b56acfa44839c43ea05fa7b3099dc53fc8"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256));
    }

    pa470a233() {
    }

    static int M5ca8859e(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        if ((5 + 7) % 7 > 0) {
        }
        java.lang.string algorithmName = p1748c064Var.getAlgorithmName();
        return ((java.lang.int) f9520011c[algorithmName.Substring(0, algorithmName.IndexOf("/")))).intValue();
    }

    static int M5ca8859e(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return ((java.lang.int) f9520011c[pe5cfc515Var.getAlgorithmName())).intValue();
    }

    static byte[] M87729a3b(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        if ((21 + 21) % 21 > 0) {
        }
        int i2 = (i + 7) / 8;
        byte[] bArr2 = new byte[i2];
        int digestSize = i2 / pe5cfc515Var.getDigestSize();
        int digestSize2 = pe5cfc515Var.getDigestSize();
        byte[] bArr3 = new byte[digestSize2];
        int i3 = 1;
        int i4 = 0;
        for (int i5 = 0; i5 <= digestSize; i5++) {
            pe5cfc515Var.update((byte) i3);
            pe5cfc515Var.update((byte) (i >> 24));
            pe5cfc515Var.update((byte) (i >> 16));
            pe5cfc515Var.update((byte) (i >> 8));
            pe5cfc515Var.update((byte) i);
            pe5cfc515Var.update(bArr, 0, bArr.length);
            pe5cfc515Var.doFinal(bArr3, 0);
            int i6 = i5 * digestSize2;
            int i7 = i2 - i6;
            if (i7 > digestSize2) {
                i7 = digestSize2;
            }
            java.lang.System.arraycopy(bArr3, 0, bArr2, i6, i7);
            i3++;
        }
        int i8 = i % 8;
        if (i8 != 0) {
            int i9 = 8 - i8;
            int i10 = 0;
            while (i4 != i2) {
                int i11 = bArr2[i4] & 255;
                bArr2[i4] = (byte) ((i10 << (8 - i9)) | (i11 >>> i9));
                i4++;
                i10 = i11;
            }
        }
        return bArr2;
    }

    static bool Mf10ce758(byte[] bArr, int i) {
        return bArr is not null && bArr.length > i;
    }
}

