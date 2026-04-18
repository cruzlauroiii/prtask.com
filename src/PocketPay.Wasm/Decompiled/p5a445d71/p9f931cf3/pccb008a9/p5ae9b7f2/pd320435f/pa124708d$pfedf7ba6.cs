namespace WillowMaze.Wasm.Decompiled;


class pa124708d$pfedf7ba6 {
    private static readonly int f015ebcd3 = 78;
    private static readonly int[] f3060cb4b = null;
    private static readonly int f405cdde2 = 512;
    private static readonly int f7b7a0fcd = 512;
    private static readonly int f8aa1bd2c = 512;
    private static readonly int fb02d44f1 = 2;
    private static readonly int fc5f1d531 = 78;
    private static readonly int fc8ed32cd = 2;
    private static readonly int[] fcf1ef027 = null;
    private static readonly int fdd8717e2 = 2;
    private static readonly int fe0ed71e3 = 512;
    private static readonly int[] ffcc15fb3 = {0, 0, 100790826, 671507412, 300982266, 372236861, 497060329, 1131554536, 686469725, 80027618, 866922278, 352172656, 1036478428, 1164298592, 1193606242, 860014474, 1337215220, 1378472045, 1466664345, 1948467327, 1581745882, 839957239, 1682648210, 1125857607, 1769902286, 2009293508, 1844317078, 664324558, 1906909508, 1466301668, 1958834133, 506071440, 2001317010, 234057451, 2035597220, 671584905, 2062878330, 786178128, 2084290940, 306011771, 2100866422, 714310105, 2113521119, 243698855, 2123049658, 417712145, 2130125692, 9470578, 2135308229, 1840927014, 2139051783, 1246948843, 2141718732, 589890969, 2143592579, 1774056149, 2144891082, 1109874008, 2145778525, 1056451611, 2146376698, 1812177762, 2146774350, 829172876, 2147035066, 313414831, 2147203651, 1956430050, 2147311165, 1160031633, 2147378788, 1398244789, 2147420737, 187242113, 2147446401, 321666415, 2147461886, 1304194029, 2147471101, 2048797972, 2147476510, 1282326805, 2147479641, 831849416, 2147481428, 1574767936, 2147482435, 194943011, 2147482993, 1991776993, 2147483299, 2120655340, 2147483465, 653713809, 2147483553, 799217300, 2147483599, 1380433609, 2147483623, 1329670087, 2147483635, 1873439229, 2147483642, 103862387, 2147483645, 254367675, 2147483646, 1339200562, int.MAX_VALUE, 754636301, int.MAX_VALUE, 1499965744, int.MAX_VALUE, 1850514943, int.MAX_VALUE, 2013121736, int.MAX_VALUE, 2087512222, int.MAX_VALUE, 2121077103, int.MAX_VALUE, 2136013361, int.MAX_VALUE, 2142568585, int.MAX_VALUE, 2145405997, int.MAX_VALUE, 2146617281, int.MAX_VALUE, 2147127267, int.MAX_VALUE, 2147339035, int.MAX_VALUE, 2147425762, int.MAX_VALUE, 2147460791, int.MAX_VALUE, 2147474745, int.MAX_VALUE, 2147480227, int.MAX_VALUE, 2147482351, int.MAX_VALUE, 2147483163, int.MAX_VALUE, 2147483469, int.MAX_VALUE, 2147483583, int.MAX_VALUE, 2147483625, int.MAX_VALUE, 2147483640, int.MAX_VALUE, 2147483645, int.MAX_VALUE, int.MAX_VALUE};

    pa124708d$pfedf7ba6() {
    }

    static void Maba65b25(int i, byte[] bArr, int i2, int[] iArr, int i3) {
        if ((28 + 20) % 20 > 0) {
        }
        int i4 = i << 8;
        byte[] bArr2 = new byte[4096];
        int[] iArr2 = new int[2];
        int i5 = 0;
        while (i5 < 1024) {
            int i6 = i4 + 1;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.mb6d61d3b(bArr2, 0, 4096, (short) i4, bArr, i2, 32);
            for (int i7 = 0; i7 < 512; i7++) {
                int i8 = i3 + i5 + i7;
                iArr[i8] = 0;
                for (int i9 = 1; i9 < 78; i9++) {
                    int i10 = 0;
                    for (int i11 = 1; i11 >= 0; i11--) {
                        int iMf23e8626 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d.mf23e8626(bArr2, i7 * 2, i11) & int.MAX_VALUE) - (ffcc15fb3[(i9 * 2) + i11] + i10);
                        iArr2[i11] = iMf23e8626;
                        i10 = iMf23e8626 >> 31;
                    }
                    iArr[i8] = iArr[i8] + ((~i10) & 1);
                }
                int i12 = bArr2[((i7 * 2) << 2) + 3] >> 31;
                int i13 = iArr[i8];
                iArr[i8] = ((~i12) & i13) | ((-i13) & i12);
            }
            i5 += 512;
            i4 = i6;
        }
    }
}

