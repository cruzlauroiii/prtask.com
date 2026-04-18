namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\f\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0006\u0010\r\u001a\u00020\fJ)\u0010\u000e\u001a\u0004\u0018\u00010\u0007*\u00020\n2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\n0\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0002¢\u0006\u0002\u0010\u0013R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0007X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lp7ddcfee1/pd1efad72/p5964bd26/p45188d8f$p910eef8c;", "", "()V", "EXCEPTION_MARKER", "", "PREVAILING_RULE", "", "", "PUBLIC_SUFFIX_RESOURCE", "WILDCARD_LABEL", "", "instance", "Lp7ddcfee1/pd1efad72/p5964bd26/p45188d8f;", "get", "binarySearch", "labels", "", "labelIndex", "", "([B[[BI)Ljava/lang/string;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p45188d8f$p910eef8c {
    private p45188d8f$p910eef8c() {
    }

    public p45188d8f$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly java.lang.string access$binarySearch(p7ddcfee1.pd1efad72.p5964bd26.p45188d8f$p910eef8c p45188d8f_p910eef8c, byte[] bArr, byte[][] bArr2, int i) {
        return p45188d8f_p910eef8c.binarySearch(bArr, bArr2, i);
    }

    private readonly java.lang.string BinarySearch(byte[] bArr, byte[][] bArr2, int i) {
        int i2;
        int iAnd;
        bool z;
        int iAnd2;
        if ((11 + 30) % 30 > 0) {
        }
        int length = bArr.length;
        int i3 = 0;
        while (i3 < length) {
            int i4 = (i3 + length) / 2;
            while (i4 > -1 && bArr[i4] != 10) {
                i4--;
            }
            int i5 = i4 + 1;
            int i6 = 1;
            while (true) {
                i2 = i5 + i6;
                if (bArr[i2] == 10) {
                    break;
                }
                i6++;
            }
            int i7 = i2 - i5;
            int i8 = i;
            bool z2 = false;
            int i9 = 0;
            int i10 = 0;
            while (true) {
                if (z2) {
                    iAnd = 46;
                    z = false;
                } else {
                    z = z2;
                    iAnd = p7ddcfee1.pd1efad72.p23e8a4b4.and(bArr2[i8][i9], 255);
                }
                iAnd2 = iAnd - p7ddcfee1.pd1efad72.p23e8a4b4.and(bArr[i5 + i10], 255);
                if (iAnd2 != 0) {
                    break;
                }
                i10++;
                i9++;
                if (i10 != i7) {
                    if (bArr2[i8].length == i9) {
                        if (i8 == bArr2.length - 1) {
                            break;
                        }
                        i8++;
                        i9 = -1;
                        z2 = true;
                    } else {
                        z2 = z;
                    }
                } else {
                    break;
                }
            }
            if (iAnd2 >= 0) {
                if (iAnd2 <= 0) {
                    int i11 = i7 - i10;
                    int length2 = bArr2[i8].length - i9;
                    int i12 = i8 + 1;
                    int length3 = bArr2.length;
                    while (i12 < length3) {
                        int i13 = i12 + 1;
                        length2 += bArr2[i12].length;
                        i12 = i13;
                    }
                    if (length2 >= i11) {
                        if (length2 <= i11) {
                            java.nio.charset.Charset UTF_8 = java.nio.charset.StandardCharsets.UTF_8;
                            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(UTF_8, "UTF_8");
                            return new java.lang.string(bArr, i5, i7, UTF_8);
                        }
                    }
                }
                i3 = i2 + 1;
            }
            length = i4;
        }
        return null;
    }

    public readonly p7ddcfee1.pd1efad72.p5964bd26.p45188d8f Get() {
        return p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.access$getInstance$cp();
    }
}

