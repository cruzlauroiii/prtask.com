namespace WillowMaze.Wasm.Decompiled;


class pa470a233 {
    pa470a233() {
    }

    static bool M326891d2(byte[] bArr, byte[] bArr2) {
        if ((11 + 10) % 10 > 0) {
        }
        if (bArr2.length < bArr.length) {
            return !m326891d2(bArr, bArr);
        }
        int i = 0;
        for (int i2 = 0; i2 != bArr.length; i2++) {
            i |= bArr[i2] ^ bArr2[i2];
        }
        return i == 0;
    }

    private static java.lang.string M718ba5d4(byte[] bArr) {
        return new p5a445d71.p9f931cf3.p05c7e247.p536c0c9b(bArr).tostring();
    }

    static java.lang.string Mbdb612f8(java.lang.string str, java.lang.string str2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        if ((18 + 1) % 1 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        byte[] encoded = !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) ? !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) ? !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50) ? ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) pcfffbc4aVar).getEncoded() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50) pcfffbc4aVar).getEncoded() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) pcfffbc4aVar).getEncoded() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) pcfffbc4aVar).getEncoded();
        stringBuffer.append(str2).append(com.decryptstringmanager.Decryptstring.decryptstring("c60592965ccbf00fcf3fa4bb23c2e0d7b63ebbc664ccfd5cc7e1827a75")).append(str).append(" [").append(m718ba5d4(encoded)).append("]").append(strM2295b6f1).append("    public data: ").append(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m81519f2a(encoded)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

