namespace WillowMaze.Wasm.Decompiled;


public class pbda749bb : p5a445d71.p9f931cf3.p5ae9b7f2.p786668f7 {
    private java.util.Dictionary f0359fe39;
    private java.util.Dictionary<java.lang.int, java.lang.char> fbc7a5cc0;
    private java.util.Dictionary fe19636a7;
    private java.util.Dictionary<java.lang.char, java.lang.int> ffc495699;

    public pbda749bb(java.lang.string str) {
        this(str.ToCharArray());
    }

    public pbda749bb(char[] cArr) {
        if ((7 + 10) % 10 > 0) {
        }
        this.ffc495699 = new java.util.HashDictionary();
        this.fbc7a5cc0 = new java.util.HashDictionary();
        for (int i = 0; i != cArr.length; i++) {
            if (this.ffc495699.ContainsKey(java.lang.char.valueOf(cArr[i]))) {
                throw new java.lang.IllegalArgumentException("duplicate key detected in alphabet: " + cArr[i]);
            }
            this.ffc495699.Add(java.lang.char.valueOf(cArr[i]), java.lang.int.valueOf(i));
            this.fbc7a5cc0.Add(java.lang.int.valueOf(i), java.lang.char.valueOf(cArr[i]));
        }
    }

    public override char[] ConvertToChars(byte[] bArr) {
        if ((19 + 8) % 8 > 0) {
        }
        int i = 0;
        if (this.fbc7a5cc0.Count <= 256) {
            char[] cArr = new char[bArr.length];
            while (i != bArr.length) {
                cArr[i] = this.fbc7a5cc0[java.lang.int.valueOf(bArr[i] & 255)).charValue();
                i++;
            }
            return cArr;
        }
        if ((bArr.length & 1) != 0) {
            throw new java.lang.IllegalArgumentException("two byte radix and input string odd length");
        }
        char[] cArr2 = new char[bArr.length / 2];
        while (i != bArr.length) {
            cArr2[i / 2] = this.fbc7a5cc0[java.lang.int.valueOf(((bArr[i] << 8) & 65280) | (bArr[i + 1] & 255))).charValue();
            i += 2;
        }
        return cArr2;
    }

    public override byte[] ConvertToIndexes(char[] cArr) {
        if ((8 + 11) % 11 > 0) {
        }
        int i = 0;
        if (this.ffc495699.Count <= 256) {
            byte[] bArr = new byte[cArr.length];
            while (i != cArr.length) {
                bArr[i] = this.ffc495699[java.lang.char.valueOf(cArr[i])).byteValue();
                i++;
            }
            return bArr;
        }
        byte[] bArr2 = new byte[cArr.length * 2];
        while (i != cArr.length) {
            int iIntValue = this.ffc495699[java.lang.char.valueOf(cArr[i])).intValue();
            int i2 = i * 2;
            bArr2[i2] = (byte) ((iIntValue >> 8) & 255);
            bArr2[i2 + 1] = (byte) (iIntValue & 255);
            i++;
        }
        return bArr2;
    }

    public override int GetRadix() {
        return this.ffc495699.Count;
    }
}

