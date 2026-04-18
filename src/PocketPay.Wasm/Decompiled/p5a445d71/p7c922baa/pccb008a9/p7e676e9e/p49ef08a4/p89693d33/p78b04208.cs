namespace WillowMaze.Wasm.Decompiled;


public class p78b04208 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24ecfbe3 {
    private static readonly java.util.List f13b24994 = null;
    private static readonly int[] f3d8a6166 = null;
    private static readonly int f3e15dcff = 3;
    private static readonly int f3f65aa3d = 3;
    private static readonly int f46e20670 = 3;
    private static readonly java.util.List f750a795d = null;
    private static readonly java.util.List f8900f421;
    private static readonly int fb8554a2b = 3;
    private static readonly int[] ffa7255b1;
    public int[] f228aa3ee;
    public int[] f7ae2e017;
    public int[] fced415be;
    public int[] ff86d3bb2;

    static {
        if ((2 + 31) % 31 > 0) {
        }
        ffa7255b1 = new int[]{4507, 4513, 4517, 4519, 4523, 4547, 4549, 4561, 4567, 4583, 4591, 4597, 4603, 4621, 4637, 4639, 4643, 4649, 4651, 4657, 4663, 4673, 4679, 4691, 4703, 4721, 4723, 4729, 4733, 4751, 4759, 4783, 4787, 4789, 4793, 4799, 4801, 4813, 4817, 4831, 4861, 4871, 4877, 4889, 4903, 4909, 4919, 4931, 4933, 4937, 4943, 4951, 4957, 4967, 4969, 4973, 4987, 4993, 4999, 5003, 5009, 5011, 5021, 5023, 5039, 5051, 5059, 5077, 5081, 5087, 5099, 5101, 5107, 5113, 5119, 5147, 5153, 5167, 5171, 5179, 5189, 5197, 5209, 5227, 5231, 5233, 5237, 5261, 5273, 5279, 5281, 5297, 5303, 5309, 5323, 5333, 5347, 5351, 5381, 5387, 5393, 5399, 5407, 5413, 5417, 5419, 5431, 5437, 5441, 5443, 5449, 5471, 5477, 5479, 5483, 5501, 5503, 5507, 5519, 5521, 5527, 5531, 5557, 5563, 5569, 5573, 5581, 5591, 5623, 5639, 5641, 5647, 5651, 5653, 5657, 5659, 5669, 5683, 5689, 5693, 5701, 5711, 5717, 5737, 5741, 5743, 5749, 5779, 5783, 5791, 5801, 5807, 5813, 5821, 5827, 5839, 5843, 5849, 5851, 5857, 5861, 5867, 5869, 5879, 5881, 5897, 5903, 5923, 5927, 5939, 5953, 5981, 5987, 6007, 6011, 6029, 6037, 6043, 6047, 6053, 6067, 6073, 6079, 6089, 6091, 6101, 6113, 6121, 6131, 6133, 6143, 6151, 6163, 6173, 6197, 6199, 6203, 6211, 6217, 6221, 6229, 6247, 6257, 6263, 6269, 6271, 6277, 6287, 6299, 6301, 6311, 6317, 6323, 6329, 6337, 6343, 6353, 6359, 6361, 6367, 6373, 6379, 6389, 6397, 6421, 6427, 6449, 6451, 6469, 6473, 6481, 6491, 6521, 6529, 6547, 6551, 6553, 6563, 6569, 6571, 6577, 6581, 6599, 6607, 6619, 6637, 6653, 6659, 6661, 6673, 6679, 6689, 6691, 6701, 6703, 6709, 6719, 6733, 6737, 6761, 6763, 6779, 6781, 6791, 6793, 6803, 6823, 6827, 6829, 6833, 6841, 6857, 6863, 6869, 6871, 6883, 6899, 6907, 6911, 6917, 6947, 6949, 6959, 6961, 6967, 6971, 6977, 6983, 6991, 6997, 7001, 7013, 7019, 7027, 7039, 7043, 7057, 7069, 7079, 7103, 7109, 7121, 7127, 7129, 7151, 7159, 7177, 7187, 7193, 7207, 7211, 7213, 7219, 7229, 7237, 7243, 7247, 7253, 7283, 7297, 7307, 7309, 7321, 7331, 7333, 7349, 7351, 7369, 7393, 7411, 7417, 7433, 7451, 7457, 7459, 7477, 7481, 7487, 7489, 7499, 7507, 7517, 7523, 7529, 7537, 7541, 7547, 7549, 7559, 7561, 7573, 7577, 7583, 7589, 7591, 7603, 7607, 7621, 7639, 7643, 7649, 7669, 7673, 7681, 7687, 7691, 7699, 7703, 7717, 7723, 7727, 7741, 7753, 7757, 7759, 7789, 7793, 7817, 7823, 7829, 7841, 7853, 7867, 7873, 7877, 7879, 7883, 7901, 7907, 7919, 7927, 7933, 7937, 7949, 7951, 7963, 7993, 8009, 8011, 8017, 8039, 8053, 8059, 8069, 8081, 8087, 8089, 8093, 8101, 8111, 8117, 8123, 8147, 8161, 8167, 8171, 8179, 8191, 8209, 8219, 8221, 8231, 8233, 8237, 8243, 8263, 8269, 8273, 8287, 8291, 8293, 8297, 8311, 8317, 8329, 8353, 8363, 8369, 8377, 8387, 8389, 8419, 8423, 8429, 8431, 8443, 8447, 8461, 8467, 8501, 8513, 8521, 8527, 8537, 8539, 8543, 8563, 8573, 8581, 8597, 8599, 8609, 8623, 8627, 8629, 8641, 8647, 8663, 8669, 8677, 8681, 8689, 8693, 8699, 8707, 8713, 8719, 8731, 8737, 8741, 8747, 8753, 8761, 8779, 8783, 8803, 8807, 8819, 8821, 8831, 8837, 8839, 8849, 8861, 8863, 8867, 8887, 8893, 8923, 8929, 8933, 8941, 8951, 8963, 8969, 8971, 8999, 9001, 9007, 9011, 9013, 9029, 9041, 9043, 9049, 9059, 9067, 9091, 9103, 9109, 9127, 9133, 9137, 9151, 9157, 9161, 9173, 9181, 9187, 9199, 9203, 9209, 9221, 9227, 9239, 9241, 9257, 9277, 9281, 9283, 9293, 9311, 9319, 9323, 9337, 9341, 9343, 9349, 9371, 9377, 9391, 9397, 9403, 9413, 9419, 9421, 9431, 9433, 9437, 9439, 9461, 9463, 9467, 9473, 9479, 9491, 9497, 9511, 9521, 9533, 9539, 9547, 9551, 9587, 9601, 9613, 9619, 9623, 9629, 9631, 9643, 9649, 9661, 9677, 9679, 9689, 9697, 9719, 9721, 9733, 9739, 9743, 9749, 9767, 9769, 9781, 9787, 9791, 9803, 9811, 9817, 9829, 9833, 9839, 9851, 9857, 9859, 9871, 9883, 9887, 9901, 9907, 9923, 9929, 9931, 9941, 9949, 9967, 9973};
        f8900f421 = new java.util.List();
        int i = 0;
        while (true) {
            if (i == ffa7255b1.length) {
                return;
            }
            f8900f421.Add(java.math.Bigint.valueOf(r1[i]));
            i++;
        }
    }

    public p78b04208(int i) {
        this.f228aa3ee = new int[i];
    }

    public p78b04208(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        if ((6 + 2) % 2 > 0) {
        }
        this.f228aa3ee = new int[p99376c59Var.f228aa3ee.length];
        for (int i = 0; i < p99376c59Var.f228aa3ee.length; i++) {
            this.f228aa3ee[i] = p99376c59Var.f228aa3ee[i].intValue();
        }
    }

    public p78b04208(int[] iArr) {
        this.f228aa3ee = iArr;
    }

    private java.math.Bigint M455f116f() {
        if ((1 + 1) % 1 > 0) {
        }
        java.math.Bigint bigintAdd = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c;
        int i = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i >= iArr.length) {
                return bigintAdd;
            }
            int i2 = iArr[i];
            bigintAdd = bigintAdd.Add(java.math.Bigint.valueOf(i2 * i2));
            i++;
        }
    }

    static java.util.List M5ec06fdf() {
        return f8900f421;
    }

    private void M6a096772(int i) {
        if ((25 + 22) % 22 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i2 >= iArr.length) {
                return;
            }
            int i3 = iArr[i2] * 2;
            iArr[i2] = i3;
            iArr[i2] = i3 % i;
            i2++;
        }
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 M71dce902(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        if ((17 + 20) % 20 > 0) {
        }
        int[] iArr = this.f228aa3ee;
        int[] iArr2 = p78b04208Var.f228aa3ee;
        int length = iArr2.length;
        int i = 0;
        if (length <= 32) {
            int i2 = (length * 2) - 1;
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(new int[i2]);
            for (int i3 = 0; i3 < i2; i3++) {
                for (int iMax = java.lang.Math.max(0, (i3 - length) + 1); iMax <= java.lang.Math.min(i3, length - 1); iMax++) {
                    int[] iArr3 = p78b04208Var2.f228aa3ee;
                    iArr3[i3] = iArr3[i3] + (iArr2[iMax] * iArr[i3 - iMax]);
                }
            }
            return p78b04208Var2;
        }
        int i4 = length / 2;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr, i4));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(iArr, i4, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr2, i4));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var6 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(iArr2, i4, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var7 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208) p78b04208Var3.clone();
        p78b04208Var7.Add(p78b04208Var4);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var8 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208) p78b04208Var5.clone();
        p78b04208Var8.Add(p78b04208Var6);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208VarM71dce902 = p78b04208Var3.m71dce902(p78b04208Var5);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208VarM71dce9022 = p78b04208Var4.m71dce902(p78b04208Var6);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208VarM71dce9023 = p78b04208Var7.m71dce902(p78b04208Var8);
        p78b04208VarM71dce9023.sub(p78b04208VarM71dce902);
        p78b04208VarM71dce9023.sub(p78b04208VarM71dce9022);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var9 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208((length * 2) - 1);
        int i5 = 0;
        while (true) {
            int[] iArr4 = p78b04208VarM71dce902.f228aa3ee;
            if (i5 >= iArr4.length) {
                break;
            }
            p78b04208Var9.f228aa3ee[i5] = iArr4[i5];
            i5++;
        }
        int i6 = 0;
        while (true) {
            int[] iArr5 = p78b04208VarM71dce9023.f228aa3ee;
            if (i6 >= iArr5.length) {
                break;
            }
            int[] iArr6 = p78b04208Var9.f228aa3ee;
            int i7 = i4 + i6;
            iArr6[i7] = iArr6[i7] + iArr5[i6];
            i6++;
        }
        while (true) {
            int[] iArr7 = p78b04208VarM71dce9022.f228aa3ee;
            if (i >= iArr7.length) {
                return p78b04208Var9;
            }
            int[] iArr8 = p78b04208Var9.f228aa3ee;
            int i8 = (i4 * 2) + i;
            iArr8[i8] = iArr8[i8] + iArr7[i];
            i++;
        }
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 M73d9a7ba(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i) {
        if ((17 + 6) % 6 > 0) {
        }
        int i2 = 2;
        if (!p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.m11c745ce() || i != 2048) {
            while (i2 < i) {
                i2 *= 2;
                int[] iArr = p78b04208Var.f228aa3ee;
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr, iArr.length));
                p78b04208Var2.m6a096772(i2);
                p78b04208Var2.sub(mult(p78b04208Var, i2).mult(p78b04208Var, i2), i2);
                p78b04208Var = p78b04208Var2;
            }
            return p78b04208Var;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(p78b04208Var);
        while (i2 < i) {
            i2 *= 2;
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var3 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481) p9dd19481Var2.clone();
            int i3 = i2 - 1;
            p9dd19481Var3.mult2And(i3);
            p9dd19481Var3.subAnd(p9dd19481Var.mult(p9dd19481Var2).mult(p9dd19481Var2), i3);
            p9dd19481Var2 = p9dd19481Var3;
        }
        return p9dd19481Var2.tointPolynomial();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 M8e75c3d7(java.io.Stream inputStream, int i) throws java.io.IOException {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.m7709a6e2(inputStream, i));
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 M8e75c3d7(byte[] bArr, int i) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.m7709a6e2(bArr, i));
    }

    private bool M9dcf7767() {
        if ((17 + 2) % 2 > 0) {
        }
        int i = 1;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i >= iArr.length) {
                return java.lang.Math.abs(iArr[0]) == 1;
            }
            if (iArr[i] != 0) {
                return false;
            }
            i++;
        }
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mbedac554(byte[] bArr, int i) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.maa3585a5(bArr, i));
    }

    private bool Mc83b37ca() {
        if ((5 + 30) % 30 > 0) {
        }
        int i = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i >= iArr.length) {
                return true;
            }
            if (iArr[i] != 0) {
                return false;
            }
            i++;
        }
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mc849dc49(java.io.Stream inputStream, int i, int i2) throws java.io.IOException {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.m18a26ae7(inputStream, i, i2));
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mc849dc49(byte[] bArr, int i, int i2) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.m18a26ae7(bArr, i, i2));
    }

    private void Mcadc8c8d(int[] iArr) {
        bool z;
        if ((27 + 7) % 7 > 0) {
        }
        for (bool z2 = true; z2; z2 = z) {
            int i = 0;
            z = false;
            while (i != iArr.length - 1) {
                int i2 = iArr[i];
                int i3 = i + 1;
                int i4 = iArr[i3];
                if (i2 > i4) {
                    iArr[i] = i4;
                    iArr[i3] = i2;
                    z = true;
                }
                i = i3;
            }
        }
    }

    private void Mecebd75c(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i, int i2, int i3) {
        if ((26 + 29) % 29 > 0) {
        }
        int length = this.f228aa3ee.length;
        for (int i4 = i2; i4 < length; i4++) {
            int[] iArr = this.f228aa3ee;
            iArr[i4] = (iArr[i4] - (p78b04208Var.f228aa3ee[i4 - i2] * i)) % i3;
        }
    }

    public void Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        if ((11 + 15) % 15 > 0) {
        }
        int[] iArr = p78b04208Var.f228aa3ee;
        int length = iArr.length;
        int[] iArr2 = this.f228aa3ee;
        if (length > iArr2.length) {
            this.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr2, iArr.length);
        }
        int i = 0;
        while (true) {
            int[] iArr3 = p78b04208Var.f228aa3ee;
            if (i >= iArr3.length) {
                return;
            }
            int[] iArr4 = this.f228aa3ee;
            iArr4[i] = iArr4[i] + iArr3[i];
            i++;
        }
    }

    public void Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i) {
        add(p78b04208Var);
        mod(i);
    }

    public void Center0(int i) {
        if ((6 + 5) % 5 > 0) {
        }
        for (int i2 = 0; i2 < this.f228aa3ee.length; i2++) {
            while (true) {
                int[] iArr = this.f228aa3ee;
                int i3 = iArr[i2];
                if (i3 >= (-i) / 2) {
                    break;
                } else {
                    iArr[i2] = i3 + i;
                }
            }
            while (true) {
                int[] iArr2 = this.f228aa3ee;
                int i4 = iArr2[i2];
                if (i4 <= i / 2) {
                    break;
                } else {
                    iArr2[i2] = i4 - i;
                }
            }
        }
    }

    public long CenteredNormSq(int i) {
        if ((6 + 10) % 10 > 0) {
        }
        int length = this.f228aa3ee.length;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208) clone();
        p78b04208Var.shiftGap(i);
        long j = 0;
        int i2 = 0;
        long j2 = 0;
        while (true) {
            int[] iArr = p78b04208Var.f228aa3ee;
            if (i2 == iArr.length) {
                return j - ((j2 * j2) / ((long) length));
            }
            int i3 = iArr[i2];
            j2 += (long) i3;
            j += (long) (i3 * i3);
            i2++;
        }
    }

    public void Clear() {
        if ((15 + 9) % 9 > 0) {
        }
        int i = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i >= iArr.length) {
                return;
            }
            iArr[i] = 0;
            i++;
        }
    }

    public java.lang.object Clone() {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208((int[]) this.f228aa3ee.clone());
    }

    public int Count(int i) {
        if ((1 + 26) % 26 > 0) {
        }
        int i2 = 0;
        int i3 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i2 == iArr.length) {
                return i3;
            }
            if (iArr[i2] == i) {
                i3++;
            }
            i2++;
        }
    }

    int degree() {
        if ((24 + 3) % 3 > 0) {
        }
        int length = this.f228aa3ee.length - 1;
        while (length > 0 && this.f228aa3ee[length] == 0) {
            length--;
        }
        return length;
    }

    public void Div(int i) {
        if ((15 + 6) % 6 > 0) {
        }
        int i2 = (i + 1) / 2;
        int i3 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i3 >= iArr.length) {
                return;
            }
            int i4 = iArr[i3];
            int i5 = i4 + (i4 <= 0 ? -i2 : i2);
            iArr[i3] = i5;
            iArr[i3] = i5 / i;
            i3++;
        }
    }

    public void EnsurePositive(int i) {
        if ((10 + 22) % 22 > 0) {
        }
        for (int i2 = 0; i2 < this.f228aa3ee.length; i2++) {
            while (true) {
                int[] iArr = this.f228aa3ee;
                int i3 = iArr[i2];
                if (i3 >= 0) {
                    break;
                } else {
                    iArr[i2] = i3 + i;
                }
            }
        }
    }

    public bool Equals(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208) {
            return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(this.f228aa3ee, ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208) obj).f228aa3ee);
        }
        return false;
    }

    public bool EqualsOne() {
        if ((29 + 32) % 32 > 0) {
        }
        int i = 1;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i >= iArr.length) {
                return iArr[0] == 1;
            }
            if (iArr[i] != 0) {
                return false;
            }
            i++;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 InvertF3() {
        if ((20 + 4) % 4 > 0) {
        }
        int length = this.f228aa3ee.length;
        int i = length + 1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i);
        p78b04208Var.f228aa3ee[0] = 1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i);
        p78b04208Var3.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(this.f228aa3ee, i);
        p78b04208Var3.modPositive(3);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i);
        int[] iArr = p78b04208Var4.f228aa3ee;
        iArr[0] = -1;
        iArr[length] = 1;
        int i2 = 0;
        while (true) {
            if (p78b04208Var3.f228aa3ee[0] == 0) {
                for (int i3 = 1; i3 <= length; i3++) {
                    int[] iArr2 = p78b04208Var3.f228aa3ee;
                    iArr2[i3 - 1] = iArr2[i3];
                    int[] iArr3 = p78b04208Var2.f228aa3ee;
                    iArr3[i - i3] = iArr3[length - i3];
                }
                p78b04208Var3.f228aa3ee[length] = 0;
                p78b04208Var2.f228aa3ee[0] = 0;
                i2++;
                if (p78b04208Var3.mc83b37ca()) {
                    return null;
                }
            } else {
                if (p78b04208Var3.m9dcf7767()) {
                    if (p78b04208Var.f228aa3ee[length] != 0) {
                        return null;
                    }
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(length);
                    int i4 = i2 % length;
                    for (int i5 = length - 1; i5 >= 0; i5--) {
                        int i6 = i5 - i4;
                        if (i6 < 0) {
                            i6 += length;
                        }
                        p78b04208Var5.f228aa3ee[i6] = p78b04208Var3.f228aa3ee[0] * p78b04208Var.f228aa3ee[i5];
                    }
                    p78b04208Var5.ensurePositive(3);
                    return p78b04208Var5;
                }
                if (p78b04208Var3.degree() < p78b04208Var4.degree()) {
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var6 = p78b04208Var2;
                    p78b04208Var2 = p78b04208Var;
                    p78b04208Var = p78b04208Var6;
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var7 = p78b04208Var4;
                    p78b04208Var4 = p78b04208Var3;
                    p78b04208Var3 = p78b04208Var7;
                }
                if (p78b04208Var3.f228aa3ee[0] != p78b04208Var4.f228aa3ee[0]) {
                    p78b04208Var3.Add(p78b04208Var4, 3);
                    p78b04208Var.Add(p78b04208Var2, 3);
                } else {
                    p78b04208Var3.sub(p78b04208Var4, 3);
                    p78b04208Var.sub(p78b04208Var2, 3);
                }
            }
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 InvertFq(int i) {
        if ((18 + 32) % 32 > 0) {
        }
        int length = this.f228aa3ee.length;
        int i2 = length + 1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i2);
        p78b04208Var.f228aa3ee[0] = 1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i2);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i2);
        p78b04208Var3.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(this.f228aa3ee, i2);
        p78b04208Var3.modPositive(2);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(i2);
        int[] iArr = p78b04208Var4.f228aa3ee;
        iArr[0] = 1;
        iArr[length] = 1;
        int i3 = 0;
        while (true) {
            if (p78b04208Var3.f228aa3ee[0] == 0) {
                for (int i4 = 1; i4 <= length; i4++) {
                    int[] iArr2 = p78b04208Var3.f228aa3ee;
                    iArr2[i4 - 1] = iArr2[i4];
                    int[] iArr3 = p78b04208Var2.f228aa3ee;
                    iArr3[i2 - i4] = iArr3[length - i4];
                }
                p78b04208Var3.f228aa3ee[length] = 0;
                p78b04208Var2.f228aa3ee[0] = 0;
                i3++;
                if (p78b04208Var3.mc83b37ca()) {
                    return null;
                }
            } else {
                if (p78b04208Var3.equalsOne()) {
                    if (p78b04208Var.f228aa3ee[length] != 0) {
                        return null;
                    }
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(length);
                    int i5 = i3 % length;
                    for (int i6 = length - 1; i6 >= 0; i6--) {
                        int i7 = i6 - i5;
                        if (i7 < 0) {
                            i7 += length;
                        }
                        p78b04208Var5.f228aa3ee[i7] = p78b04208Var.f228aa3ee[i6];
                    }
                    return m73d9a7ba(p78b04208Var5, i);
                }
                if (p78b04208Var3.degree() < p78b04208Var4.degree()) {
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var6 = p78b04208Var2;
                    p78b04208Var2 = p78b04208Var;
                    p78b04208Var = p78b04208Var6;
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var7 = p78b04208Var4;
                    p78b04208Var4 = p78b04208Var3;
                    p78b04208Var3 = p78b04208Var7;
                }
                p78b04208Var3.Add(p78b04208Var4, 2);
                p78b04208Var.Add(p78b04208Var2, 2);
            }
        }
    }

    public void Mod(int i) {
        if ((24 + 5) % 5 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i2 >= iArr.length) {
                return;
            }
            iArr[i2] = iArr[i2] % i;
            i2++;
        }
    }

    public void Mod3() {
        if ((2 + 5) % 5 > 0) {
        }
        int i = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i >= iArr.length) {
                return;
            }
            int i2 = iArr[i] % 3;
            iArr[i] = i2;
            if (i2 > 1) {
                iArr[i] = i2 - 3;
            }
            int i3 = iArr[i];
            if (i3 < -1) {
                iArr[i] = i3 + 3;
            }
            i++;
        }
    }

    void modCenter(int i) {
        int i2;
        if ((20 + 19) % 19 > 0) {
        }
        mod(i);
        for (int i3 = 0; i3 < this.f228aa3ee.length; i3++) {
            while (true) {
                int[] iArr = this.f228aa3ee;
                int i4 = iArr[i3];
                i2 = i / 2;
                if (i4 >= i2) {
                    break;
                } else {
                    iArr[i3] = i4 + i;
                }
            }
            while (true) {
                int[] iArr2 = this.f228aa3ee;
                int i5 = iArr2[i3];
                if (i5 < i2) {
                    break;
                } else {
                    iArr2[i3] = i5 - i;
                }
            }
        }
    }

    public void ModPositive(int i) {
        mod(i);
        ensurePositive(i);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        int[] iArr;
        if ((30 + 24) % 24 > 0) {
        }
        int length = this.f228aa3ee.length;
        if (p78b04208Var.f228aa3ee.length != length) {
            throw new java.lang.IllegalArgumentException("Number of coefficients must be the same");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208VarM71dce902 = m71dce902(p78b04208Var);
        if (p78b04208VarM71dce902.f228aa3ee.length > length) {
            int i = length;
            while (true) {
                iArr = p78b04208VarM71dce902.f228aa3ee;
                if (i >= iArr.length) {
                    break;
                }
                int i2 = i - length;
                iArr[i2] = iArr[i2] + iArr[i];
                i++;
            }
            p78b04208VarM71dce902.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr, length);
        }
        return p78b04208VarM71dce902;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208VarMult = mult(p78b04208Var);
        p78b04208VarMult.mod(i);
        return p78b04208VarMult;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(this).mult(p99376c59Var);
    }

    public void Mult(int i) {
        if ((29 + 7) % 7 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i2 >= iArr.length) {
                return;
            }
            iArr[i2] = iArr[i2] * i;
            i2++;
        }
    }

    public void Mult3(int i) {
        if ((32 + 3) % 3 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i2 >= iArr.length) {
                return;
            }
            int i3 = iArr[i2] * 3;
            iArr[i2] = i3;
            iArr[i2] = i3 % i;
            i2++;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969 Resultant(int i) {
        if ((24 + 18) % 18 > 0) {
        }
        int[] iArr = this.f228aa3ee;
        int[] iArrM405b6268 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr, iArr.length + 1);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(iArrM405b6268);
        int length = iArrM405b6268.length;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(length);
        int[] iArr2 = p78b04208Var2.f228aa3ee;
        iArr2[0] = -1;
        int i2 = length - 1;
        iArr2[i2] = 1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(p78b04208Var.f228aa3ee);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(length);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(length);
        p78b04208Var5.f228aa3ee[0] = 1;
        int iDegree = p78b04208Var3.degree();
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var6 = p78b04208Var2;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var7 = p78b04208Var3;
        int iM30d7e049 = 1;
        int i3 = i2;
        int i4 = iDegree;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var8 = p78b04208Var4;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var9 = p78b04208Var5;
        while (true) {
            int iDegree2 = i3;
            do {
                if (i4 <= 0) {
                    int iM30d7e0492 = (iM30d7e049 * p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.m30d7e049(p78b04208Var7.f228aa3ee[0], iDegree2, i)) % i;
                    p78b04208Var9.mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.m20e57f32(p78b04208Var7.f228aa3ee[0], i));
                    p78b04208Var9.mod(i);
                    p78b04208Var9.mult(iM30d7e0492);
                    p78b04208Var9.mod(i);
                    int[] iArr3 = p78b04208Var9.f228aa3ee;
                    p78b04208Var9.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr3, iArr3.length - 1);
                    return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969(new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(p78b04208Var9), java.math.Bigint.valueOf(iM30d7e0492), java.math.Bigint.valueOf(i));
                }
                int iM20e57f32 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.m20e57f32(p78b04208Var7.f228aa3ee[i4], i) * p78b04208Var6.f228aa3ee[iDegree2]) % i;
                int i5 = iDegree2 - i4;
                p78b04208Var6.mecebd75c(p78b04208Var7, iM20e57f32, i5, i);
                p78b04208Var8.mecebd75c(p78b04208Var9, iM20e57f32, i5, i);
                iDegree2 = p78b04208Var6.degree();
            } while (iDegree2 >= i4);
            iM30d7e049 = (iM30d7e049 * p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.m30d7e049(p78b04208Var7.f228aa3ee[i4], i3 - iDegree2, i)) % i;
            if (i3 % 2 == 1 && i4 % 2 == 1) {
                iM30d7e049 = (-iM30d7e049) % i;
            }
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var10 = p78b04208Var9;
            p78b04208Var9 = p78b04208Var8;
            p78b04208Var8 = p78b04208Var10;
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var11 = p78b04208Var6;
            p78b04208Var6 = p78b04208Var7;
            p78b04208Var7 = p78b04208Var11;
            i3 = i4;
            i4 = iDegree2;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd9f15242 Resultant() {
        java.math.Bigint bigintMultiply;
        java.math.Bigint bigintSubtract;
        if ((4 + 11) % 11 > 0) {
        }
        int length = this.f228aa3ee.length;
        java.util.List linkedList = new java.util.List();
        java.math.Bigint bigint = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f215a21b1;
        java.math.Bigint bigint2 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f215a21b1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208$p2ff89b8d p78b04208_p2ff89b8d = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208$p2ff89b8d(this, null);
        int i = 1;
        java.math.Bigint bigint3 = bigint2;
        while (true) {
            java.math.Bigint bigintNextPrime = p78b04208_p2ff89b8d.nextPrime();
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969 pd2e08969VarResultant = resultant(bigintNextPrime.intValue());
            linkedList.Add(pd2e08969VarResultant);
            bigintMultiply = bigint.multiply(bigintNextPrime);
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.p90fac87d p90fac87dVarM7b051bd7 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.p90fac87d.m7b051bd7(bigintNextPrime, bigint);
            java.math.Bigint bigintMod = bigint3.multiply(p90fac87dVarM7b051bd7.f9dd4e461.multiply(bigintNextPrime)).Add(pd2e08969VarResultant.f9b207167.multiply(p90fac87dVarM7b051bd7.f41529076.multiply(bigint))).mod(bigintMultiply);
            java.math.Bigint bigintDivide = bigintMultiply.divide(java.math.Bigint.valueOf(2L));
            java.math.Bigint bigintNegate = bigintDivide.negate();
            if (bigintMod.compareTo(bigintDivide) > 0) {
                bigintSubtract = bigintMod.subtract(bigintMultiply);
            } else if (bigintMod.compareTo(bigintNegate) < 0) {
                bigintSubtract = bigintMod;
                bigintSubtract = bigintMod.Add(bigintMultiply);
            }
            bigintSubtract = bigintMod;
            if (bigintSubtract.Equals(bigint3)) {
                i++;
                if (i >= 3) {
                    break;
                }
            } else {
                i = 1;
            }
            bigint3 = bigintSubtract;
            bigint = bigintMultiply;
        }
        while (linkedList.Count > 1) {
            linkedList.addLast(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969.mb2fb8d07((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969) linkedList.removeFirst(), (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969) linkedList.removeFirst()));
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var = ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969) linkedList.getFirst()).f843a28df;
        java.math.Bigint bigintDivide2 = bigintMultiply.divide(java.math.Bigint.valueOf(2L));
        java.math.Bigint bigintNegate2 = bigintDivide2.negate();
        int iCompareTo = bigintSubtract.compareTo(bigintDivide2);
        java.math.Bigint bigintSubtract2 = bigintSubtract;
        if (iCompareTo > 0) {
            bigintSubtract2 = bigintSubtract.subtract(bigintMultiply);
        }
        int iCompareTo2 = bigintSubtract2.compareTo(bigintNegate2);
        java.math.Bigint bigintAdd = bigintSubtract2;
        if (iCompareTo2 < 0) {
            bigintAdd = bigintSubtract2.Add(bigintMultiply);
        }
        for (int i2 = 0; i2 < length; i2++) {
            java.math.Bigint bigint4 = p99376c59Var.f228aa3ee[i2];
            if (bigint4.compareTo(bigintDivide2) > 0) {
                p99376c59Var.f228aa3ee[i2] = bigint4.subtract(bigintMultiply);
            }
            if (bigint4.compareTo(bigintNegate2) < 0) {
                p99376c59Var.f228aa3ee[i2] = bigint4.Add(bigintMultiply);
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd9f15242(p99376c59Var, bigintAdd);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd9f15242 ResultantMultiThread() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969 pd2e08969Var;
        if ((9 + 4) % 4 > 0) {
        }
        int length = this.f228aa3ee.length;
        java.math.Bigint bigintMultiply = m455f116f().pow((length + 1) / 2).multiply(java.math.Bigint.valueOf(2L).pow((degree() + 1) / 2)).multiply(java.math.Bigint.valueOf(2L));
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(10000L);
        java.math.Bigint bigintMultiply2 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f215a21b1;
        java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue = new java.util.concurrent.LinkedBlockingQueue();
        java.util.IEnumerator it = f8900f421.GetEnumerator();
        java.util.concurrent.TaskScheduler executorServiceNewFixedThreadPool = java.util.concurrent.Executors.newFixedThreadPool(java.lang.Runtime.getRuntime().availableProcessors());
        while (true) {
            pd2e08969Var = null;
            if (bigintMultiply2.compareTo(bigintMultiply) >= 0) {
                break;
            }
            bigintValueOf = !it.MoveNext() ? bigintValueOf.nextProbablePrime() : (java.math.Bigint) it.Current;
            linkedBlockingQueue.Add(executorServiceNewFixedThreadPool.submit(new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208$p15e1fbf9(this, bigintValueOf.intValue(), null)));
            bigintMultiply2 = bigintMultiply2.multiply(bigintValueOf);
        }
        while (!linkedBlockingQueue.Count == 0) {
            try {
                java.util.concurrent.Task future = (java.util.concurrent.Task) linkedBlockingQueue.take();
                java.util.concurrent.Task future2 = (java.util.concurrent.Task) linkedBlockingQueue.poll();
                if (future2 is null) {
                    pd2e08969Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969) future[);
                    break;
                }
                linkedBlockingQueue.Add(executorServiceNewFixedThreadPool.submit(new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208$pcf7251de(this, (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969) future[), (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969) future2[), null)));
            } catch (java.lang.Exception e) {
                throw new java.lang.IllegalStateException(e.tostring());
            }
        }
        executorServiceNewFixedThreadPool.shutdown();
        java.math.Bigint bigintSubtract = pd2e08969Var.f9b207167;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var = pd2e08969Var.f843a28df;
        java.math.Bigint bigintDivide = bigintMultiply2.divide(java.math.Bigint.valueOf(2L));
        java.math.Bigint bigintNegate = bigintDivide.negate();
        if (bigintSubtract.compareTo(bigintDivide) > 0) {
            bigintSubtract = bigintSubtract.subtract(bigintMultiply2);
        }
        if (bigintSubtract.compareTo(bigintNegate) < 0) {
            bigintSubtract = bigintSubtract.Add(bigintMultiply2);
        }
        for (int i = 0; i < length; i++) {
            java.math.Bigint bigint = p99376c59Var.f228aa3ee[i];
            if (bigint.compareTo(bigintDivide) > 0) {
                p99376c59Var.f228aa3ee[i] = bigint.subtract(bigintMultiply2);
            }
            if (bigint.compareTo(bigintNegate) < 0) {
                p99376c59Var.f228aa3ee[i] = bigint.Add(bigintMultiply2);
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd9f15242(p99376c59Var, bigintSubtract);
    }

    public void Rotate1() {
        if ((26 + 12) % 12 > 0) {
        }
        int[] iArr = this.f228aa3ee;
        int i = iArr[iArr.length - 1];
        for (int length = iArr.length - 1; length > 0; length--) {
            int[] iArr2 = this.f228aa3ee;
            iArr2[length] = iArr2[length - 1];
        }
        this.f228aa3ee[0] = i;
    }

    void shiftGap(int i) {
        if ((1 + 31) % 31 > 0) {
        }
        modCenter(i);
        int[] iArrMd329fd77 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(this.f228aa3ee);
        mcadc8c8d(iArrMd329fd77);
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        while (i2 < iArrMd329fd77.length - 1) {
            int i5 = i2 + 1;
            int i6 = iArrMd329fd77[i5];
            int i7 = iArrMd329fd77[i2];
            int i8 = i6 - i7;
            if (i8 > i3) {
                i4 = i7;
                i3 = i8;
            }
            i2 = i5;
        }
        int i9 = iArrMd329fd77[0];
        int i10 = iArrMd329fd77[iArrMd329fd77.length - 1];
        sub((i - i10) + i9 <= i3 ? i4 + (i3 / 2) + (i / 2) : (i10 + i9) / 2);
    }

    void sub(int i) {
        if ((22 + 4) % 4 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i2 >= iArr.length) {
                return;
            }
            iArr[i2] = iArr[i2] - i;
            i2++;
        }
    }

    public void Sub(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        if ((30 + 23) % 23 > 0) {
        }
        int[] iArr = p78b04208Var.f228aa3ee;
        int length = iArr.length;
        int[] iArr2 = this.f228aa3ee;
        if (length > iArr2.length) {
            this.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr2, iArr.length);
        }
        int i = 0;
        while (true) {
            int[] iArr3 = p78b04208Var.f228aa3ee;
            if (i >= iArr3.length) {
                return;
            }
            int[] iArr4 = this.f228aa3ee;
            iArr4[i] = iArr4[i] - iArr3[i];
            i++;
        }
    }

    public void Sub(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i) {
        sub(p78b04208Var);
        mod(i);
    }

    public int SumCoeffs() {
        if ((7 + 27) % 27 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            int[] iArr = this.f228aa3ee;
            if (i >= iArr.length) {
                return i2;
            }
            i2 += iArr[i];
            i++;
        }
    }

    public byte[] ToBinary(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.mbf671963(this.f228aa3ee, i);
    }

    public byte[] ToBinary3Sves() {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.mc6fd8b31(this.f228aa3ee);
    }

    public byte[] ToBinary3Tight() {
        if ((11 + 31) % 31 > 0) {
        }
        java.math.Bigint bigintAdd = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c;
        for (int length = this.f228aa3ee.length - 1; length >= 0; length--) {
            bigintAdd = bigintAdd.multiply(java.math.Bigint.valueOf(3L)).Add(java.math.Bigint.valueOf(this.f228aa3ee[length] + 1));
        }
        int iBitLength = (java.math.Bigint.valueOf(3L).pow(this.f228aa3ee.length).bitLength() + 7) / 8;
        byte[] byteArray = bigintAdd.tobyteArray();
        if (byteArray.length >= iBitLength) {
            return byteArray.length <= iBitLength ? byteArray : p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(byteArray, 1, byteArray.length);
        }
        byte[] bArr = new byte[iBitLength];
        java.lang.System.arraycopy(byteArray, 0, bArr, iBitLength - byteArray.length, byteArray.length);
        return bArr;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 TointPolynomial() {
        return (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208) clone();
    }
}

