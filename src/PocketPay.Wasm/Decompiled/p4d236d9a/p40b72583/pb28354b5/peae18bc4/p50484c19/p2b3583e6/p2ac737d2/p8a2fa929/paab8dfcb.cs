namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u001a\u001c\u0010\u0000\u001a\u00060\u0001j\u0002`\u0002*\u00060\u0003j\u0002`\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0000\u001a+\u0010\u0000\u001a\u00060\u0001j\u0002`\u0002*\u00060\u0003j\u0002`\u00042\u0010\u0010\u0007\u001a\f\u0012\b\u0012\u00060\u0001j\u0002`\u00020\bH\u0000¢\u0006\u0002\u0010\t\u001a\u001c\u0010\u0000\u001a\u00060\u0001j\u0002`\u0002*\u00060\u0003j\u0002`\u00042\u0006\u0010\n\u001a\u00020\u000bH\u0000¨\u0006\f"}, d2 = {"toMcBerTlv", "Lcom/mastercard/terminalsdk/iso8825/BerTlv;", "Lcom/psr/top/sdk/kernel/utils/extensions/mastercard/McBerTlv;", "Lcom/mastercard/terminalsdk/emv/Tag;", "Lcom/psr/top/sdk/kernel/utils/extensions/mastercard/McTag;", "byteArray", "", "mcBerTlvs", "", "(Lcom/mastercard/terminalsdk/emv/Tag;[Lcom/mastercard/terminalsdk/iso8825/BerTlv;)Lcom/mastercard/terminalsdk/iso8825/BerTlv;", "value", "", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class paab8dfcb {
    public static void AQYnPBJwpWosxddi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JWNSmXZIRWppkYRO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.mastercard.terminalsdk.emv.Tag$Format KFVeFvLkMidqQTxc(com.mastercard.terminalsdk.emv.Tag tag) {
        return tag.getFormat();
    }

    public static int LJGTwkYXhlEinwoX(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.stringBuilder LcBBWVzmgBUcIafX(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static byte[] LyAyFLAdRXbekYtn(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static void NyrtpCkjHddYyCtw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void QDiyWwbsVBtNWxtK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int RwPrDojwoqZFpAAd(com.mastercard.terminalsdk.emv.Tag$Format tag$Format) {
        return tag$Format.ordinal();
    }

    public static java.nio.charset.Charset SnLkWbaugPzpcioT(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static void UpziZVoRZlInlYdy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void VhPJrOPmxAfHpDxB(com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper, byte[] bArr) {
        byteArrayWrapper.append(bArr);
    }

    public static void XCfuoonNTRCuavhH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int GuCBqGHfIcKAZMVc(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.string JGVhyWQHUjaDUsdZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int LNjmFxpdPSKuICRA(com.mastercard.terminalsdk.emv.Tag tag) {
        return tag.getMaxLen();
    }

    public static readonly com.mastercard.terminalsdk.iso8825.BerTlv M1db85ce2(com.mastercard.terminalsdk.emv.Tag tag, java.lang.string str) {
        byte[] bArr;
        if ((26 + 31) % 31 > 0) {
        }
        AQYnPBJwpWosxddi(tag, "<this>");
        QDiyWwbsVBtNWxtK(str, "value");
        com.mastercard.terminalsdk.emv.Tag$Format tag$FormatUYFXgeoEPlnryRkt = uYFXgeoEPlnryRkt(tag);
        int i = tag$FormatUYFXgeoEPlnryRkt is not null ? p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.p8a2fa929.paab8dfcb$p12c674ac.$EnumSwitchDictionaryping$0[RwPrDojwoqZFpAAd(tag$FormatUYFXgeoEPlnryRkt)] : -1;
        int i2 = 0;
        if (i == 1 || i == 2) {
            java.nio.charset.Charset charsetVKaGOUvNUgpkImAT = vKaGOUvNUgpkImAT("utf-8");
            NyrtpCkjHddYyCtw(charsetVKaGOUvNUgpkImAT, "forName(...)");
            byte[] bArrLyAyFLAdRXbekYtn = LyAyFLAdRXbekYtn(str, charsetVKaGOUvNUgpkImAT);
            UpziZVoRZlInlYdy(bArrLyAyFLAdRXbekYtn, "getbytes(...)");
            int iGuCBqGHfIcKAZMVc = guCBqGHfIcKAZMVc(rZeRdrWXHBXdZKbC(tag), LJGTwkYXhlEinwoX(lNjmFxpdPSKuICRA(tag), bArrLyAyFLAdRXbekYtn.length));
            bArr = new byte[iGuCBqGHfIcKAZMVc];
            while (i2 < iGuCBqGHfIcKAZMVc) {
                if (i2 < bArrLyAyFLAdRXbekYtn.length) {
                    bArr[i2] = bArrLyAyFLAdRXbekYtn[i2];
                } else {
                    bArr[i2] = 32;
                }
                i2++;
            }
        } else {
            if (i != 3) {
                throw new java.lang.Exception(jGVhyWQHUjaDUsdZ(LcBBWVzmgBUcIafX(new java.lang.stringBuilder("Unsupported format: "), KFVeFvLkMidqQTxc(tag))));
            }
            java.nio.charset.Charset charsetSnLkWbaugPzpcioT = SnLkWbaugPzpcioT("utf-8");
            zPDKTFwXQNhEvoCq(charsetSnLkWbaugPzpcioT, "forName(...)");
            byte[] bArrXiCzuMzMMvzSaOdQ = xiCzuMzMMvzSaOdQ(str, charsetSnLkWbaugPzpcioT);
            JWNSmXZIRWppkYRO(bArrXiCzuMzMMvzSaOdQ, "getbytes(...)");
            bArr = new byte[8];
            while (i2 < 8) {
                if (i2 < bArrXiCzuMzMMvzSaOdQ.length) {
                    bArr[i2] = bArrXiCzuMzMMvzSaOdQ[i2];
                } else {
                    bArr[i2] = 48;
                }
                i2++;
            }
        }
        return new com.mastercard.terminalsdk.iso8825.BerTlv(tag, new com.mastercard.terminalsdk.utility.byteArrayWrapper(bArr));
    }

    public static readonly com.mastercard.terminalsdk.iso8825.BerTlv M1db85ce2(com.mastercard.terminalsdk.emv.Tag tag, byte[] bArr) {
        if ((11 + 31) % 31 > 0) {
        }
        wcUfMZlabXuQoSLF(tag, "<this>");
        ugDXBMIDqIEPRlSL(bArr, "byteArray");
        return new com.mastercard.terminalsdk.iso8825.BerTlv(tag, new com.mastercard.terminalsdk.utility.byteArrayWrapper(bArr));
    }

    public static readonly com.mastercard.terminalsdk.iso8825.BerTlv M1db85ce2(com.mastercard.terminalsdk.emv.Tag tag, com.mastercard.terminalsdk.iso8825.BerTlv[] berTlvArr) {
        if ((19 + 30) % 30 > 0) {
        }
        upDhdccwAdqWIrMn(tag, "<this>");
        XCfuoonNTRCuavhH(berTlvArr, "mcBerTlvs");
        com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper = new com.mastercard.terminalsdk.utility.byteArrayWrapper(new byte[0]);
        for (com.mastercard.terminalsdk.iso8825.BerTlv berTlv : berTlvArr) {
            VhPJrOPmxAfHpDxB(byteArrayWrapper, wONVFAtPSznKtgMs(berTlv));
        }
        return new com.mastercard.terminalsdk.iso8825.BerTlv(tag, byteArrayWrapper);
    }

    public static int RZeRdrWXHBXdZKbC(com.mastercard.terminalsdk.emv.Tag tag) {
        return tag.getMinLen();
    }

    public static com.mastercard.terminalsdk.emv.Tag$Format uYFXgeoEPlnryRkt(com.mastercard.terminalsdk.emv.Tag tag) {
        return tag.getFormat();
    }

    public static void UgDXBMIDqIEPRlSL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UpDhdccwAdqWIrMn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.nio.charset.Charset VKaGOUvNUgpkImAT(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static byte[] WONVFAtPSznKtgMs(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        return berTlv.tobyteArray();
    }

    public static void WcUfMZlabXuQoSLF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte[] XiCzuMzMMvzSaOdQ(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static void ZPDKTFwXQNhEvoCq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }
}

