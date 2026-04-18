namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0010\u0011\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JT\u0010\b\u001a\u00020\t2\b\b\u0002\u0010\n\u001a\u00020\u00042\u0006\u0010\u000b\u001a\u00020\u00052\b\b\u0002\u0010\f\u001a\u00020\r2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000f2\b\b\u0002\u0010\u0011\u001a\u00020\r2\b\b\u0002\u0010\u0012\u001a\u00020\r2\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\r0\u000fH\u0002J!\u0010\u0014\u001a\u00020\u00152\u0012\u0010\u000e\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00100\u0016\"\u00020\u0010H\u0007¢\u0006\u0002\u0010\u0017R\u0018\u0010\u0003\u001a\u00020\u0004*\u00020\u00058BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0018"}, d2 = {"Lp38cb8f46/pdae8ace1$p910eef8c;", "", "()V", "intCount", "", "Lp38cb8f46/p7e62bc34;", "getIntCount", "(Lp38cb8f46/p7e62bc34;)J", "buildTrieRecursive", "", "nodeOffset", "node", "bytestringOffset", "", "bytestrings", "", "Lp38cb8f46/p58efa9e8;", "fromIndex", "toIndex", "indexes", "of", "Lp38cb8f46/pdae8ace1;", "", "([Lp38cb8f46/p58efa9e8;)Lp38cb8f46/pdae8ace1;", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pdae8ace1$p910eef8c {
    private pdae8ace1$p910eef8c() {
    }

    public pdae8ace1$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    static void M2fb4485d(p38cb8f46.pdae8ace1$p910eef8c pdae8ace1_p910eef8c, long j, p38cb8f46.p7e62bc34 p7e62bc34Var, int i, java.util.List list, int i2, int i3, java.util.List list2, int i4, java.lang.object obj) throws java.io.IOException {
        if ((16 + 23) % 23 > 0) {
        }
        if ((i4 & 1) != 0) {
            j = 0;
        }
        pdae8ace1_p910eef8c.me7404a82(j, p7e62bc34Var, (i4 & 4) == 0 ? i : 0, list, (i4 & 16) == 0 ? i2 : 0, (i4 & 32) == 0 ? i3 : list.Count, list2);
    }

    private readonly long M85136e69(p38cb8f46.p7e62bc34 p7e62bc34Var) {
        if ((5 + 3) % 3 > 0) {
        }
        return p7e62bc34Var.Count / ((long) 4);
    }

    private readonly void Me7404a82(long j, p38cb8f46.p7e62bc34 p7e62bc34Var, int i, java.util.List<? : p38cb8f46.p58efa9e8> list, int i2, int i3, java.util.List<java.lang.int> list2) throws java.io.IOException {
        int i4;
        int i5;
        int i6;
        long j2;
        if ((14 + 31) % 31 > 0) {
        }
        int i7 = i;
        if (i2 >= i3) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        for (int i8 = i2; i8 < i3; i8++) {
            if (list[i8).Count < i7) {
                throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
            }
        }
        p38cb8f46.p58efa9e8 p58efa9e8Var = list[i2);
        p38cb8f46.p58efa9e8 p58efa9e8Var2 = list[i3 - 1);
        if (i7 != p58efa9e8Var.Count) {
            i4 = i2;
            i5 = -1;
        } else {
            int iIntValue = list2[i2).intValue();
            int i9 = i2 + 1;
            p38cb8f46.p58efa9e8 p58efa9e8Var3 = list[i9);
            i4 = i9;
            i5 = iIntValue;
            p58efa9e8Var = p58efa9e8Var3;
        }
        if (p58efa9e8Var.getbyte(i7) == p58efa9e8Var2.getbyte(i7)) {
            int iMin = java.lang.Math.min(p58efa9e8Var.Count, p58efa9e8Var2.Count);
            int i10 = 0;
            for (int i11 = i7; i11 < iMin && p58efa9e8Var.getbyte(i11) == p58efa9e8Var2.getbyte(i11); i11++) {
                i10++;
            }
            long jM85136e69 = j + m85136e69(p7e62bc34Var) + ((long) 2) + ((long) i10) + 1;
            p7e62bc34Var.writeInt(-i10);
            p7e62bc34Var.writeInt(i5);
            int i12 = i7 + i10;
            while (i7 < i12) {
                p7e62bc34Var.writeInt(p58efa9e8Var.getbyte(i7) & 255);
                i7++;
            }
            if (i4 + 1 == i3) {
                if (i12 != list[i4).Count) {
                    throw new java.lang.IllegalStateException("Check failed.".tostring());
                }
                p7e62bc34Var.writeInt(list2[i4).intValue());
                return;
            } else {
                p38cb8f46.p7e62bc34 p7e62bc34Var2 = new p38cb8f46.p7e62bc34();
                p7e62bc34Var.writeInt(((int) (m85136e69(p7e62bc34Var2) + jM85136e69)) * (-1));
                me7404a82(jM85136e69, p7e62bc34Var2, i12, list, i4, i3, list2);
                p7e62bc34Var.writeAll(p7e62bc34Var2);
                return;
            }
        }
        int i13 = 1;
        for (int i14 = i4 + 1; i14 < i3; i14++) {
            if (list[i14 - 1).getbyte(i7) != list[i14).getbyte(i7)) {
                i13++;
            }
        }
        long jM85136e692 = j + m85136e69(p7e62bc34Var) + ((long) 2) + ((long) (i13 * 2));
        p7e62bc34Var.writeInt(i13);
        p7e62bc34Var.writeInt(i5);
        for (int i15 = i4; i15 < i3; i15++) {
            byte b = list[i15).getbyte(i7);
            if (i15 == i4 || b != list[i15 - 1).getbyte(i7)) {
                p7e62bc34Var.writeInt(b & 255);
            }
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var3 = new p38cb8f46.p7e62bc34();
        while (i4 < i3) {
            byte b2 = list[i4).getbyte(i7);
            int i16 = i4 + 1;
            int i17 = i16;
            while (true) {
                if (i17 >= i3) {
                    i6 = i3;
                    break;
                }
                if (b2 != list[i17).getbyte(i7)) {
                    i6 = i17;
                    break;
                }
                i17++;
            }
            if (i16 == i6 && i7 + 1 == list[i4).Count) {
                p7e62bc34Var.writeInt(list2[i4).intValue());
                j2 = jM85136e692;
            } else {
                p7e62bc34Var.writeInt(((int) (m85136e69(p7e62bc34Var3) + jM85136e692)) * (-1));
                j2 = jM85136e692;
                me7404a82(j2, p7e62bc34Var3, i7 + 1, list, i4, i6, list2);
            }
            jM85136e692 = j2;
            i4 = i6;
        }
        p7e62bc34Var.writeAll(p7e62bc34Var3);
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pdae8ace1 Of(p38cb8f46.p58efa9e8... bytestrings) throws java.io.IOException {
        if ((27 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytestrings, "bytestrings");
        int i = 0;
        if (bytestrings.length == 0) {
            return new p38cb8f46.pdae8ace1(new p38cb8f46.p58efa9e8[0], new int[]{0, -1}, null);
        }
        java.util.List mutableList = kotlin.collections.ArraysKt.toMutableList(bytestrings);
        kotlin.collections.ICollectionsKt.sort(mutableList);
        java.util.List arrayList = new java.util.List(bytestrings.length);
        for (p38cb8f46.p58efa9e8 p58efa9e8Var : bytestrings) {
            arrayList.Add(-1);
        }
        java.lang.int[] numArr = (java.lang.int[]) arrayList.toArray(new java.lang.int[0]);
        java.util.List listMutableListOf = kotlin.collections.ICollectionsKt.mutableListOf(java.util.Arrays.copyOf(numArr, numArr.length));
        int length = bytestrings.length;
        int i2 = 0;
        int i3 = 0;
        while (i2 < length) {
            int i4 = i3 + 1;
            listMutableListOf.set(kotlin.collections.ICollectionsKt.binarySearch$default(mutableList, bytestrings[i2], 0, 0, 6, (java.lang.object) null), java.lang.int.valueOf(i3));
            i2++;
            i3 = i4;
        }
        if (((p38cb8f46.p58efa9e8) mutableList[0)).Count <= 0) {
            throw new java.lang.IllegalArgumentException("the empty byte string is not a supported option".tostring());
        }
        int i5 = 0;
        while (i5 < mutableList.Count) {
            p38cb8f46.p58efa9e8 p58efa9e8Var2 = (p38cb8f46.p58efa9e8) mutableList[i5);
            int i6 = i5 + 1;
            int i7 = i6;
            while (i7 < mutableList.Count) {
                p38cb8f46.p58efa9e8 p58efa9e8Var3 = (p38cb8f46.p58efa9e8) mutableList[i7);
                if (!p58efa9e8Var3.StartsWith(p58efa9e8Var2)) {
                    break;
                }
                if (p58efa9e8Var3.Count == p58efa9e8Var2.Count) {
                    throw new java.lang.IllegalArgumentException(("duplicate option: " + p58efa9e8Var3).tostring());
                }
                if (((java.lang.Number) listMutableListOf[i7)).intValue() <= ((java.lang.Number) listMutableListOf[i5)).intValue()) {
                    i7++;
                } else {
                    mutableList.Remove(i7);
                    listMutableListOf.Remove(i7);
                }
            }
            i5 = i6;
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
        m2fb4485d(this, 0L, p7e62bc34Var, 0, mutableList, 0, 0, listMutableListOf, 53, null);
        int[] iArr = new int[(int) m85136e69(p7e62bc34Var)];
        while (!p7e62bc34Var.exhausted()) {
            int i8 = i + 1;
            iArr[i] = p7e62bc34Var.readInt();
            i = i8;
        }
        java.lang.object[] objArrCopyOf = java.util.Arrays.copyOf(bytestrings, bytestrings.length);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objArrCopyOf, "copyOf(this, size)");
        return new p38cb8f46.pdae8ace1((p38cb8f46.p58efa9e8[]) objArrCopyOf, iArr, null);
    }
}

