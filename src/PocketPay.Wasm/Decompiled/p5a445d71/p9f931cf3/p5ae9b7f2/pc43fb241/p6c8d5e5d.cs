namespace WillowMaze.Wasm.Decompiled;


public class p6c8d5e5d {
    public static byte[] M20285b07(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, int i) {
        if ((23 + 11) % 11 > 0) {
        }
        byte[] bArr = new byte[i];
        if (i * 8 <= p54466d0aVar.entropySize()) {
            java.lang.System.arraycopy(p54466d0aVar.getEntropy(), 0, bArr, 0, i);
            return bArr;
        }
        int iEntropySize = p54466d0aVar.entropySize() / 8;
        for (int i2 = 0; i2 < i; i2 += iEntropySize) {
            byte[] entropy = p54466d0aVar.getEntropy();
            int i3 = i - i2;
            if (entropy.length > i3) {
                java.lang.System.arraycopy(entropy, 0, bArr, i2, i3);
            } else {
                java.lang.System.arraycopy(entropy, 0, bArr, i2, entropy.length);
            }
        }
        return bArr;
    }
}

