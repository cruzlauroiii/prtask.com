namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0012\n\u0000\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0001H\u0000¨\u0006\u0002"}, d2 = {"sha256Spongy", "", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p1ceded00 {
    public static int UzeYddRwJuUfiDOf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar, byte[] bArr, int i) {
        return p08716e2cVar.doFinal(bArr, i);
    }

    public static void FSWPsHSTwkojYypO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar, byte[] bArr, int i, int i2) {
        p08716e2cVar.update(bArr, i, i2);
    }

    public static readonly byte[] M1de6c1d8(byte[] bArr) {
        if ((1 + 14) % 14 > 0) {
        }
        tGUCNybmbXxWdhHa(bArr, "<this>");
        p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar = new p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p08716e2c();
        byte[] bArr2 = new byte[uApPxaOuSMGbhrFv(p08716e2cVar)];
        fSWPsHSTwkojYypO(p08716e2cVar, bArr, 0, bArr.length);
        UzeYddRwJuUfiDOf(p08716e2cVar, bArr2, 0);
        return bArr2;
    }

    public static void TGUCNybmbXxWdhHa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int UApPxaOuSMGbhrFv(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar) {
        return p08716e2cVar.getDigestSize();
    }
}

