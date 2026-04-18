namespace WillowMaze.Wasm.Decompiled;


public class p21247682 {
    private static readonly java.math.Bigint f08230661 = null;
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f704d892c = null;
    private static readonly java.math.Bigint f7733cde5 = null;
    private static readonly java.math.Bigint f946875d4 = null;
    private static readonly java.math.Bigint f9f27b763 = null;
    private static readonly java.math.Bigint fbc21e648;
    private int f1df3079b;
    private int f503788bb;
    private int f534ee4ec;
    private int f5c2ca5de;
    private int f7b8f925f;
    private java.security.SecureRandom f7d34acfe;
    private java.security.SecureRandom f7fee1515;
    private int ff7bd60b7;

    static {
        if ((26 + 12) % 12 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    private java.math.Bigint M34af23a4(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((11 + 7) % 7 > 0) {
        }
        java.math.Bigint bigintSubtract = bigint.subtract(fbc21e648);
        java.math.Bigint bigintDivide = bigintSubtract.divide(bigint2);
        int iBitLength = bigint.bitLength();
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(iBitLength, this.f7fee1515);
            java.math.Bigint bigint3 = fbc21e648;
            if (bigintM861a7ab4.compareTo(bigint3) > 0 && bigintM861a7ab4.compareTo(bigintSubtract) < 0) {
                java.math.Bigint bigintModPow = bigintM861a7ab4.modPow(bigintDivide, bigint);
                if (bigintModPow.compareTo(bigint3) != 0) {
                    return bigintModPow;
                }
            }
        }
    }

    private long M54e04098(long j, long j2, java.math.Bigint[] bigintArr, int i) {
        int i2;
        java.math.Bigint bigint;
        java.math.Bigint[] bigintArr2;
        int i3;
        java.math.Bigint bigint2;
        int[] iArr;
        if ((6 + 22) % 22 > 0) {
        }
        long jNextInt = j;
        while (true) {
            if (jNextInt >= 0 && jNextInt <= 4294967296L) {
                break;
            }
            jNextInt = this.f7fee1515.nextInt() * 2;
        }
        long jNextInt2 = j2;
        while (true) {
            i2 = 1;
            if (jNextInt2 >= 0 && jNextInt2 <= 4294967296L && jNextInt2 / 2 != 0) {
                break;
            }
            jNextInt2 = (this.f7fee1515.nextInt() * 2) + 1;
        }
        java.math.Bigint bigint3 = new java.math.Bigint(java.lang.long.tostring(jNextInt2));
        java.math.Bigint bigint4 = new java.math.Bigint("97781173");
        java.math.Bigint[] bigintArr3 = new java.math.Bigint[1];
        java.math.Bigint bigint5 = new java.math.Bigint(java.lang.long.tostring(jNextInt));
        int i4 = 0;
        bigintArr3[0] = bigint5;
        int[] iArr2 = new int[1];
        iArr2[0] = i;
        int i5 = 0;
        int i6 = 0;
        while (iArr2[i5] >= 33) {
            int length = iArr2.length + 1;
            int[] iArr3 = new int[length];
            java.lang.System.arraycopy(iArr2, 0, iArr3, 0, iArr2.length);
            iArr2 = new int[length];
            java.lang.System.arraycopy(iArr3, 0, iArr2, 0, length);
            i6 = i5 + 1;
            iArr2[i6] = iArr2[i5] / 2;
            i5 = i6;
        }
        java.math.Bigint[] bigintArr4 = new java.math.Bigint[i6 + 1];
        bigintArr4[i6] = new java.math.Bigint("8000000B", 16);
        int i7 = i6 - 1;
        int i8 = 0;
        while (i8 < i6) {
            int i9 = 32;
            int i10 = iArr2[i7] / 32;
            while (true) {
                int length2 = bigintArr3.length;
                java.math.Bigint[] bigintArr5 = new java.math.Bigint[length2];
                java.lang.System.arraycopy(bigintArr3, i4, bigintArr5, i4, bigintArr3.length);
                bigintArr2 = new java.math.Bigint[i10 + 1];
                java.lang.System.arraycopy(bigintArr5, i4, bigintArr2, i4, length2);
                int i11 = i4;
                while (i11 < i10) {
                    int i12 = i11 + 1;
                    bigintArr2[i12] = bigintArr2[i11].multiply(bigint4).Add(bigint3).mod(f0f82d86a.pow(i9));
                    i11 = i12;
                }
                java.math.Bigint bigint6 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("9a385eac2bac0c8db855d844b246444662031b24f7a158aaa2cf51b6af"));
                int i13 = i4;
                while (i13 < i10) {
                    int i14 = i4;
                    bigint6 = bigint6.Add(bigintArr2[i13].multiply(f0f82d86a.pow(i13 * 32)));
                    i13++;
                    i4 = i14;
                }
                i3 = i4;
                bigintArr2[i3] = bigintArr2[i10];
                java.math.Bigint bigint7 = f0f82d86a;
                int i15 = i7 + 1;
                java.math.Bigint bigintAdd = bigint7.pow(iArr2[i7] - i2).divide(bigintArr4[i15]).Add(bigint7.pow(iArr2[i7] - i2).multiply(bigint6).divide(bigintArr4[i15].multiply(bigint7.pow(i10 * 32))));
                java.math.Bigint bigintMod = bigintAdd.mod(bigint7);
                java.math.Bigint bigint8 = fbc21e648;
                if (bigintMod.compareTo(bigint8) == 0) {
                    bigintAdd = bigintAdd.Add(bigint8);
                }
                java.math.Bigint bigint9 = bigintAdd;
                int i16 = i3;
                while (true) {
                    long j3 = i16;
                    java.math.Bigint bigintMultiply = bigintArr4[i15].multiply(bigint9.Add(java.math.Bigint.valueOf(j3)));
                    java.math.Bigint bigint10 = fbc21e648;
                    java.math.Bigint bigintAdd2 = bigintMultiply.Add(bigint10);
                    bigintArr4[i7] = bigintAdd2;
                    bigint2 = bigint3;
                    java.math.Bigint bigint11 = f0f82d86a;
                    iArr = iArr2;
                    if (bigintAdd2.compareTo(bigint11.pow(iArr[i7])) == 1) {
                        i4 = i3;
                        bigint3 = bigint2;
                        iArr2 = iArr;
                        i2 = 1;
                        bigintArr3 = bigintArr2;
                        i9 = 32;
                    } else {
                        if (bigint11.modPow(bigintArr4[i15].multiply(bigint9.Add(java.math.Bigint.valueOf(j3))), bigintArr4[i7]).compareTo(bigint10) == 0 && bigint11.modPow(bigint9.Add(java.math.Bigint.valueOf(j3)), bigintArr4[i7]).compareTo(bigint10) != 0) {
                            break;
                        }
                        i16 += 2;
                        bigint3 = bigint2;
                        iArr2 = iArr;
                    }
                }
            }
            i7--;
            if (i7 < 0) {
                bigintArr[i3] = bigintArr4[i3];
                bigintArr[1] = bigintArr4[1];
                bigint = bigintArr2[i3];
                return bigint.longValue();
            }
            i8++;
            i2 = 1;
            i4 = i3;
            bigint3 = bigint2;
            iArr2 = iArr;
            bigintArr3 = bigintArr2;
        }
        bigint = bigintArr3[i4];
        return bigint.longValue();
    }

    private void M985c4650(int i, int i2, java.math.Bigint[] bigintArr) {
        int i3;
        if ((18 + 17) % 17 > 0) {
        }
        int iNextInt = i;
        while (true) {
            if (iNextInt >= 0 && iNextInt <= 65536) {
                break;
            } else {
                iNextInt = this.f7fee1515.nextInt() / 32768;
            }
        }
        int iNextInt2 = i2;
        while (true) {
            i3 = 1;
            if (iNextInt2 >= 0 && iNextInt2 <= 65536 && iNextInt2 / 2 != 0) {
                break;
            } else {
                iNextInt2 = (this.f7fee1515.nextInt() / 32768) + 1;
            }
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[2];
        java.math.Bigint bigint = new java.math.Bigint(java.lang.int.tostring(iNextInt2));
        java.math.Bigint bigint2 = new java.math.Bigint("19381");
        int iMfd91f744 = mfd91f744(iNextInt, iNextInt2, bigintArr2, 256);
        java.math.Bigint bigint3 = bigintArr2[0];
        int iMfd91f7442 = mfd91f744(iMfd91f744, iNextInt2, bigintArr2, 512);
        java.math.Bigint bigint4 = bigintArr2[0];
        java.math.Bigint[] bigintArr3 = new java.math.Bigint[65];
        bigintArr3[0] = new java.math.Bigint(java.lang.int.tostring(iMfd91f7442));
        while (true) {
            int i4 = 0;
            while (i4 < 64) {
                int i5 = i4 + 1;
                bigintArr3[i5] = bigintArr3[i4].multiply(bigint2).Add(bigint).mod(f0f82d86a.pow(16));
                i4 = i5;
            }
            java.math.Bigint bigint5 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("020ccbb072cf6e470399d31faa36e35e6550d568cc51cbaa08cf4c5531"));
            for (int i6 = 0; i6 < 64; i6++) {
                bigint5 = bigint5.Add(bigintArr3[i6].multiply(f0f82d86a.pow(i6 * 16)));
            }
            bigintArr3[0] = bigintArr3[64];
            java.math.Bigint bigint6 = f0f82d86a;
            java.math.Bigint bigintAdd = bigint6.pow(1023).divide(bigint3.multiply(bigint4)).Add(bigint6.pow(1023).multiply(bigint5).divide(bigint3.multiply(bigint4).multiply(bigint6.pow(1024))));
            java.math.Bigint bigintMod = bigintAdd.mod(bigint6);
            java.math.Bigint bigint7 = fbc21e648;
            if (bigintMod.compareTo(bigint7) == 0) {
                bigintAdd = bigintAdd.Add(bigint7);
            }
            java.math.Bigint bigint8 = bigintAdd;
            int i7 = 0;
            while (true) {
                long j = i7;
                java.math.Bigint bigintMultiply = bigint3.multiply(bigint4).multiply(bigint8.Add(java.math.Bigint.valueOf(j)));
                java.math.Bigint bigint9 = fbc21e648;
                java.math.Bigint bigintAdd2 = bigintMultiply.Add(bigint9);
                java.math.Bigint bigint10 = f0f82d86a;
                if (bigintAdd2.compareTo(bigint10.pow(1024)) != i3) {
                    int i8 = i3;
                    if (bigint10.modPow(bigint3.multiply(bigint4).multiply(bigint8.Add(java.math.Bigint.valueOf(j))), bigintAdd2).compareTo(bigint9) == 0 && bigint10.modPow(bigint3.multiply(bigint8.Add(java.math.Bigint.valueOf(j))), bigintAdd2).compareTo(bigint9) != 0) {
                        bigintArr[0] = bigintAdd2;
                        bigintArr[i8] = bigint3;
                        return;
                    } else {
                        i7 += 2;
                        i3 = i8;
                    }
                }
            }
        }
    }

    private void Mb8aca226(long j, long j2, java.math.Bigint[] bigintArr) {
        int i;
        if ((28 + 12) % 12 > 0) {
        }
        long jNextInt = j;
        while (true) {
            if (jNextInt >= 0 && jNextInt <= 4294967296L) {
                break;
            } else {
                jNextInt = this.f7fee1515.nextInt() * 2;
            }
        }
        long jNextInt2 = j2;
        while (true) {
            i = 1;
            if (jNextInt2 >= 0 && jNextInt2 <= 4294967296L && jNextInt2 / 2 != 0) {
                break;
            }
            long j3 = jNextInt;
            jNextInt2 = (this.f7fee1515.nextInt() * 2) + 1;
            jNextInt = j3;
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[2];
        java.math.Bigint bigint = new java.math.Bigint(java.lang.long.tostring(jNextInt2));
        java.math.Bigint bigint2 = new java.math.Bigint("97781173");
        long jM54e04098 = m54e04098(jNextInt, jNextInt2, bigintArr2, 256);
        java.math.Bigint bigint3 = bigintArr2[0];
        long jM54e040982 = m54e04098(jM54e04098, jNextInt2, bigintArr2, 512);
        java.math.Bigint bigint4 = bigintArr2[0];
        java.math.Bigint[] bigintArr3 = new java.math.Bigint[33];
        bigintArr3[0] = new java.math.Bigint(java.lang.long.tostring(jM54e040982));
        while (true) {
            int i2 = 0;
            while (i2 < 32) {
                int i3 = i2 + 1;
                bigintArr3[i3] = bigintArr3[i2].multiply(bigint2).Add(bigint).mod(f0f82d86a.pow(32));
                i2 = i3;
            }
            java.math.Bigint bigint5 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("9331b43df461c2cded168af60e6f99a939db10dcf9957b38710748df08"));
            for (int i4 = 0; i4 < 32; i4++) {
                bigint5 = bigint5.Add(bigintArr3[i4].multiply(f0f82d86a.pow(i4 * 32)));
            }
            bigintArr3[0] = bigintArr3[32];
            java.math.Bigint bigint6 = f0f82d86a;
            java.math.Bigint bigintAdd = bigint6.pow(1023).divide(bigint3.multiply(bigint4)).Add(bigint6.pow(1023).multiply(bigint5).divide(bigint3.multiply(bigint4).multiply(bigint6.pow(1024))));
            java.math.Bigint bigintMod = bigintAdd.mod(bigint6);
            java.math.Bigint bigint7 = fbc21e648;
            if (bigintMod.compareTo(bigint7) == 0) {
                bigintAdd = bigintAdd.Add(bigint7);
            }
            int i5 = 0;
            while (true) {
                long j4 = i5;
                java.math.Bigint bigintMultiply = bigint3.multiply(bigint4).multiply(bigintAdd.Add(java.math.Bigint.valueOf(j4)));
                java.math.Bigint bigint8 = fbc21e648;
                java.math.Bigint bigintAdd2 = bigintMultiply.Add(bigint8);
                java.math.Bigint bigint9 = f0f82d86a;
                if (bigintAdd2.compareTo(bigint9.pow(1024)) != i) {
                    int i6 = i;
                    if (bigint9.modPow(bigint3.multiply(bigint4).multiply(bigintAdd.Add(java.math.Bigint.valueOf(j4))), bigintAdd2).compareTo(bigint8) == 0 && bigint9.modPow(bigint3.multiply(bigintAdd.Add(java.math.Bigint.valueOf(j4))), bigintAdd2).compareTo(bigint8) != 0) {
                        bigintArr[0] = bigintAdd2;
                        bigintArr[i6] = bigint3;
                        return;
                    } else {
                        i5 += 2;
                        i = i6;
                    }
                }
            }
        }
    }

    private int Mfd91f744(int i, int i2, java.math.Bigint[] bigintArr, int i3) {
        int i4;
        java.math.Bigint bigint;
        java.math.Bigint[] bigintArr2;
        int i5;
        java.math.Bigint[] bigintArr3;
        java.math.Bigint bigint2;
        java.math.Bigint bigint3;
        if ((12 + 31) % 31 > 0) {
        }
        int iNextInt = i;
        while (true) {
            if (iNextInt >= 0 && iNextInt <= 65536) {
                break;
            }
            iNextInt = this.f7fee1515.nextInt() / 32768;
        }
        int iNextInt2 = i2;
        while (true) {
            i4 = 1;
            if (iNextInt2 >= 0 && iNextInt2 <= 65536 && iNextInt2 / 2 != 0) {
                break;
            }
            iNextInt2 = (this.f7fee1515.nextInt() / 32768) + 1;
        }
        java.math.Bigint bigint4 = new java.math.Bigint(java.lang.int.tostring(iNextInt2));
        java.math.Bigint bigint5 = new java.math.Bigint("19381");
        java.math.Bigint[] bigintArr4 = new java.math.Bigint[1];
        java.math.Bigint bigint6 = new java.math.Bigint(java.lang.int.tostring(iNextInt));
        int i6 = 0;
        bigintArr4[0] = bigint6;
        int[] iArr = new int[1];
        iArr[0] = i3;
        int i7 = 0;
        int i8 = 0;
        while (iArr[i7] >= 17) {
            int length = iArr.length + 1;
            int[] iArr2 = new int[length];
            java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr.length);
            iArr = new int[length];
            java.lang.System.arraycopy(iArr2, 0, iArr, 0, length);
            i8 = i7 + 1;
            iArr[i8] = iArr[i7] / 2;
            i7 = i8;
        }
        java.math.Bigint[] bigintArr5 = new java.math.Bigint[i8 + 1];
        int i9 = 16;
        bigintArr5[i8] = new java.math.Bigint("8003", 16);
        int i10 = i8 - 1;
        int i11 = 0;
        while (i11 < i8) {
            int i12 = iArr[i10] / i9;
            while (true) {
                int length2 = bigintArr4.length;
                java.math.Bigint[] bigintArr6 = new java.math.Bigint[length2];
                java.lang.System.arraycopy(bigintArr4, i6, bigintArr6, i6, bigintArr4.length);
                bigintArr2 = new java.math.Bigint[i12 + 1];
                java.lang.System.arraycopy(bigintArr6, i6, bigintArr2, i6, length2);
                int i13 = i6;
                while (i13 < i12) {
                    int i14 = i13 + 1;
                    bigintArr2[i14] = bigintArr2[i13].multiply(bigint5).Add(bigint4).mod(f0f82d86a.pow(i9));
                    i13 = i14;
                }
                java.math.Bigint bigint7 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("dd13d653d6f86e6ef260540d5feaa6ed9bd1e0839c4fe384d00294a55f"));
                int i15 = i6;
                while (i15 < i12) {
                    int i16 = i6;
                    bigint7 = bigint7.Add(bigintArr2[i15].multiply(f0f82d86a.pow(i15 * 16)));
                    i15++;
                    i6 = i16;
                }
                i5 = i6;
                bigintArr2[i5] = bigintArr2[i12];
                java.math.Bigint bigint8 = f0f82d86a;
                int i17 = i10 + 1;
                java.math.Bigint bigintAdd = bigint8.pow(iArr[i10] - i4).divide(bigintArr5[i17]).Add(bigint8.pow(iArr[i10] - i4).multiply(bigint7).divide(bigintArr5[i17].multiply(bigint8.pow(i12 * 16))));
                java.math.Bigint bigintMod = bigintAdd.mod(bigint8);
                java.math.Bigint bigint9 = fbc21e648;
                if (bigintMod.compareTo(bigint9) == 0) {
                    bigintAdd = bigintAdd.Add(bigint9);
                }
                java.math.Bigint bigint10 = bigintAdd;
                int i18 = i5;
                while (true) {
                    bigintArr3 = bigintArr5;
                    long j = i18;
                    java.math.Bigint bigintMultiply = bigintArr5[i17].multiply(bigint10.Add(java.math.Bigint.valueOf(j)));
                    java.math.Bigint bigint11 = fbc21e648;
                    java.math.Bigint bigintAdd2 = bigintMultiply.Add(bigint11);
                    bigintArr3[i10] = bigintAdd2;
                    bigint2 = bigint4;
                    java.math.Bigint bigint12 = f0f82d86a;
                    bigint3 = bigint5;
                    if (bigintAdd2.compareTo(bigint12.pow(iArr[i10])) == 1) {
                        i6 = i5;
                        i4 = 1;
                        bigintArr5 = bigintArr3;
                        bigintArr4 = bigintArr2;
                        bigint4 = bigint2;
                        bigint5 = bigint3;
                        i9 = 16;
                    } else {
                        if (bigint12.modPow(bigintArr3[i17].multiply(bigint10.Add(java.math.Bigint.valueOf(j))), bigintArr3[i10]).compareTo(bigint11) == 0 && bigint12.modPow(bigint10.Add(java.math.Bigint.valueOf(j)), bigintArr3[i10]).compareTo(bigint11) != 0) {
                            break;
                        }
                        i18 += 2;
                        bigintArr5 = bigintArr3;
                        bigint4 = bigint2;
                        bigint5 = bigint3;
                    }
                }
            }
            i10--;
            if (i10 < 0) {
                bigintArr[i5] = bigintArr3[i5];
                bigintArr[1] = bigintArr3[1];
                bigint = bigintArr2[i5];
                return bigint.intValue();
            }
            i11++;
            i4 = 1;
            i9 = 16;
            i6 = i5;
            bigintArr5 = bigintArr3;
            bigintArr4 = bigintArr2;
            bigint4 = bigint2;
            bigint5 = bigint3;
        }
        bigint = bigintArr4[i6];
        return bigint.intValue();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 GenerateParameters() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p21247682 p21247682Var;
        long j;
        long j2;
        if ((30 + 26) % 26 > 0) {
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        if (this.f534ee4ec == 1) {
            int iNextInt = this.f7fee1515.nextInt();
            int iNextInt2 = this.f7fee1515.nextInt();
            int i = this.ff7bd60b7;
            if (i == 512) {
                mfd91f744(iNextInt, iNextInt2, bigintArr, 512);
            } else {
                if (i != 1024) {
                    throw new java.lang.IllegalArgumentException("Ooops! key size 512 or 1024 bit.");
                }
                m985c4650(iNextInt, iNextInt2, bigintArr);
            }
            java.math.Bigint bigint = bigintArr[0];
            java.math.Bigint bigint2 = bigintArr[1];
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05(bigint, bigint2, m34af23a4(bigint, bigint2), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31(iNextInt, iNextInt2));
        }
        long jNextlong = this.f7fee1515.nextlong();
        long jNextlong2 = this.f7fee1515.nextlong();
        int i2 = this.ff7bd60b7;
        if (i2 == 512) {
            p21247682Var = this;
            j = jNextlong;
            j2 = jNextlong2;
            p21247682Var.m54e04098(j, j2, bigintArr, 512);
        } else {
            if (i2 != 1024) {
                throw new java.lang.IllegalStateException("Ooops! key size 512 or 1024 bit.");
            }
            p21247682Var = this;
            j = jNextlong;
            j2 = jNextlong2;
            p21247682Var.mb8aca226(j, j2, bigintArr);
        }
        java.math.Bigint bigint3 = bigintArr[0];
        java.math.Bigint bigint4 = bigintArr[1];
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05(bigint3, bigint4, p21247682Var.m34af23a4(bigint3, bigint4), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31(j, j2));
    }

    public void Init(int i, int i2, java.security.SecureRandom secureRandom) {
        this.ff7bd60b7 = i;
        this.f534ee4ec = i2;
        this.f7fee1515 = secureRandom;
    }
}

