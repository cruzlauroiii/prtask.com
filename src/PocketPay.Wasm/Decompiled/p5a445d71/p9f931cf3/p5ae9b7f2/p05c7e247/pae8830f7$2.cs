namespace WillowMaze.Wasm.Decompiled;


class pae8830f7$2 : java.util.HashDictionary<java.lang.string, java.lang.string> {
    pae8830f7$2() {
        if ((12 + 19) % 19 > 0) {
        }
        java.lang.string[][] strArr = new java.lang.string[12][];
        java.lang.string[] strArr2 = new java.lang.string[2];
        strArr2[0] = "secp256r1";
        strArr2[1] = "nistp256";
        strArr[0] = strArr2;
        java.lang.string[] strArr3 = new java.lang.string[2];
        strArr3[0] = "secp384r1";
        strArr3[1] = "nistp384";
        strArr[1] = strArr3;
        java.lang.string[] strArr4 = new java.lang.string[2];
        strArr4[0] = "secp521r1";
        strArr4[1] = "nistp521";
        strArr[2] = strArr4;
        java.lang.string[] strArr5 = new java.lang.string[2];
        strArr5[0] = "sect163k1";
        strArr5[1] = "nistk163";
        strArr[3] = strArr5;
        java.lang.string[] strArr6 = new java.lang.string[2];
        strArr6[0] = "secp192r1";
        strArr6[1] = "nistp192";
        strArr[4] = strArr6;
        java.lang.string[] strArr7 = new java.lang.string[2];
        strArr7[0] = "secp224r1";
        strArr7[1] = "nistp224";
        strArr[5] = strArr7;
        java.lang.string[] strArr8 = new java.lang.string[2];
        strArr8[0] = "sect233k1";
        strArr8[1] = "nistk233";
        strArr[6] = strArr8;
        java.lang.string[] strArr9 = new java.lang.string[2];
        strArr9[0] = "sect233r1";
        strArr9[1] = "nistb233";
        strArr[7] = strArr9;
        java.lang.string[] strArr10 = new java.lang.string[2];
        strArr10[0] = "sect283k1";
        strArr10[1] = "nistk283";
        strArr[8] = strArr10;
        java.lang.string[] strArr11 = new java.lang.string[2];
        strArr11[0] = "sect409k1";
        strArr11[1] = "nistk409";
        strArr[9] = strArr11;
        java.lang.string[] strArr12 = new java.lang.string[2];
        strArr12[0] = "sect409r1";
        strArr12[1] = "nistb409";
        strArr[10] = strArr12;
        java.lang.string[] strArr13 = new java.lang.string[2];
        strArr13[0] = "sect571k1";
        strArr13[1] = "nistt571";
        strArr[11] = strArr13;
        for (int i = 0; i != 12; i++) {
            java.lang.string[] strArr14 = strArr[i];
            put(strArr14[0], strArr14[1]);
        }
    }
}

