namespace WillowMaze.Wasm.Decompiled;


class pc7eced35$1 : p5a445d71.p9f931cf3.p5ae9b7f2.p60156ac2 {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pc7eced35 this$0;

    pc7eced35$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pc7eced35 pc7eced35Var) {
        this.this$0 = pc7eced35Var;
    }

    public override byte[] GetEncoded(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        if ((28 + 10) % 10 > 0) {
        }
        int iBitLength = (((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83d23d10) pcfffbc4aVar).getParameters().getP().bitLength() + 7) / 8;
        byte[] bArr = new byte[iBitLength];
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52) pcfffbc4aVar).getY());
        if (bArrMec6269b9.length > iBitLength) {
            throw new java.lang.IllegalArgumentException("Senders's public key longer than expected.");
        }
        java.lang.System.arraycopy(bArrMec6269b9, 0, bArr, iBitLength - bArrMec6269b9.length, bArrMec6269b9.length);
        return bArr;
    }
}

