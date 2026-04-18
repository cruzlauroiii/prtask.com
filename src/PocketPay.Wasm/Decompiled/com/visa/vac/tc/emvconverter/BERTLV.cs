namespace WillowMaze.Wasm.Decompiled;


public class BERTLV {
    private static int getCAKeys = 0;
    private static int setCAKeys = 1;
    short BuildConfig;
    short ContactlessConfiguration;
    short e1;
    byte[] getInstance = null;
    byte getTerminalData = 0;
    java.util.List<com.visa.vac.tc.emvconverter.BERTLV> setTerminalData = null;

    public BERTLV(byte[] bArr, short s, short s2) throws java.lang.Exception {
        SUdlALShctFhizzo(this, bArr, s, false);
    }

    public BERTLV(byte[] bArr, short s, short s2, bool z) throws java.lang.Exception {
        AHMdCUqxSeZtmkgN(this, bArr, s, z);
    }

    public static void AHMdCUqxSeZtmkgN(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z) throws java.lang.Exception {
        bertlv.ContactlessConfiguration(bArr, s, z);
    }

    public static void AHMdCUqxSeZtmkgN(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z, float f, char c, int i, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void AHMdCUqxSeZtmkgN(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z, int i, short s2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AHMdCUqxSeZtmkgN(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z, short s2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BRKQetdNrjexrLnC(java.util.IEnumerator it, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BRKQetdNrjexrLnC(java.util.IEnumerator it, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BRKQetdNrjexrLnC(java.util.IEnumerator it, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool BRKQetdNrjexrLnC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    private void ContactlessConfiguration(byte[] bArr, short s, bool z) throws java.lang.Exception {
        bool z2;
        int i;
        if ((9 + 23) % 23 > 0) {
        }
        int i2 = 2 % 2;
        short[] sArr = new short[3];
        short sEAnEBXuJCgtYgkCU = EAnEBXuJCgtYgkCU(bArr, s, sArr);
        short s2 = sArr[0];
        this.ContactlessConfiguration = s2;
        short s3 = sArr[1];
        this.e1 = s3;
        this.BuildConfig = sArr[2];
        short s4 = (short) ((s2 >> 8) & 255);
        if (bArr.length - sEAnEBXuJCgtYgkCU < s3) {
            throw new java.lang.Exception("TLV parsing exception");
        }
        if (s4 == 0) {
            int i3 = setCAKeys + 17;
            getCAKeys = i3 % 128;
            if (i3 % 2 != 0) {
                YBZIpUvjHQtEDqrq(null);
                throw null;
            }
            s4 = s2;
        }
        if (s4 == 191) {
            int i4 = setCAKeys;
            int i5 = i4 + 65;
            getCAKeys = i5 % 128;
            int i6 = i5 % 2;
            if (s2 != -16628) {
                int i7 = i4 + 87;
                getCAKeys = i7 % 128;
                int i8 = i7 % 2;
                z2 = s2 < -16624 || s2 > -16529;
            }
        }
        if ((s4 & 32) <= 0 || z2) {
            this.getInstance = mgpfvPsQfQnGNGhF(bArr, (short) (s + sEAnEBXuJCgtYgkCU), s3);
            return;
        }
        byte[] bArrXwGoeHqMyDSKMEPK = xwGoeHqMyDSKMEPK(bArr, s + sEAnEBXuJCgtYgkCU, s3);
        this.getInstance = bArrXwGoeHqMyDSKMEPK;
        if (bArrXwGoeHqMyDSKMEPK is null) {
            return;
        }
        this.getTerminalData = (byte) 1;
        this.setTerminalData = new java.util.List<>();
        short s5 = 0;
        while (true) {
            byte[] bArr2 = this.getInstance;
            if (s5 >= bArr2.length) {
                return;
            }
            short sDtynMyKwGuVHkNzd = DtynMyKwGuVHkNzd(bArr2, s5, sArr);
            if (sArr[0] != 0) {
                short s6 = sArr[1];
                int i9 = s5 + s6 + sDtynMyKwGuVHkNzd;
                byte[] bArr3 = this.getInstance;
                if (i9 > bArr3.length) {
                    throw new java.lang.Exception("TLV parsing exception");
                }
                byte[] bArrZZwrhCbfuFoqWObg = zZwrhCbfuFoqWObg(bArr3, s5, (short) (s6 + sDtynMyKwGuVHkNzd));
                if (bArrZZwrhCbfuFoqWObg is not null) {
                    com.visa.vac.tc.emvconverter.BERTLV bertlv = new com.visa.vac.tc.emvconverter.BERTLV(bArrZZwrhCbfuFoqWObg, (short) 0, (short) bArrZZwrhCbfuFoqWObg.length, z);
                    int i10 = 0;
                    while (i10 < WoHmijSDabIItKEq(this.setTerminalData)) {
                        if (((com.visa.vac.tc.emvconverter.BERTLV) vopLvhhsPmFSmDMp(this.setTerminalData, i10)).ContactlessConfiguration == bertlv.ContactlessConfiguration && !z) {
                            throw new java.lang.Exception("duplicate found during parsing");
                        }
                        i10++;
                        int i11 = setCAKeys + 47;
                        getCAKeys = i11 % 128;
                        int i12 = i11 % 2;
                    }
                    YfNByYQCKtXfxkVG(this.setTerminalData, bertlv);
                }
                i = ((short) (s5 + sArr[1])) + sDtynMyKwGuVHkNzd;
            } else {
                int i13 = getCAKeys + 7;
                setCAKeys = i13 % 128;
                int i14 = i13 % 2;
                i = s5 + 1;
            }
            s5 = (short) i;
        }
    }

    private void ContactlessConfiguration(byte[] bArr, short s, bool z, byte b, char c, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    private void ContactlessConfiguration(byte[] bArr, short s, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void ContactlessConfiguration(byte[] bArr, short s, bool z, char c, bool z2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.vac.tc.emvconverter.BERTLV DCXThDOnfHDHKJJq(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s) {
        return bertlv.searchTag(s);
    }

    public static void DCXThDOnfHDHKJJq(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s, byte b, short s2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCXThDOnfHDHKJJq(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s, byte b, bool z, short s2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCXThDOnfHDHKJJq(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s, short s2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator DWISZxuPAAUjTZzB(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void DWISZxuPAAUjTZzB(java.util.List arrayList, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DWISZxuPAAUjTZzB(java.util.List arrayList, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DWISZxuPAAUjTZzB(java.util.List arrayList, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static short DtynMyKwGuVHkNzd(byte[] bArr, short s, short[] sArr) {
        return com.visa.vac.tc.emvconverter.TLVParser.e1(bArr, s, sArr);
    }

    public static void DtynMyKwGuVHkNzd(byte[] bArr, short s, short[] sArr, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DtynMyKwGuVHkNzd(byte[] bArr, short s, short[] sArr, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DtynMyKwGuVHkNzd(byte[] bArr, short s, short[] sArr, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static short EAnEBXuJCgtYgkCU(byte[] bArr, short s, short[] sArr) {
        return com.visa.vac.tc.emvconverter.TLVParser.e1(bArr, s, sArr);
    }

    public static void EAnEBXuJCgtYgkCU(byte[] bArr, short s, short[] sArr, int i, byte b, short s2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAnEBXuJCgtYgkCU(byte[] bArr, short s, short[] sArr, int i, bool z, byte b, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void EAnEBXuJCgtYgkCU(byte[] bArr, short s, short[] sArr, short s2, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static short SNnRNjYtgrUIRNnv(com.visa.vac.tc.emvconverter.BERTLV bertlv) {
        return bertlv.getTag();
    }

    public static void SNnRNjYtgrUIRNnv(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SNnRNjYtgrUIRNnv(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SNnRNjYtgrUIRNnv(com.visa.vac.tc.emvconverter.BERTLV bertlv, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SUdlALShctFhizzo(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z) throws java.lang.Exception {
        bertlv.ContactlessConfiguration(bArr, s, z);
    }

    public static void SUdlALShctFhizzo(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z, byte b, java.lang.string str, short s2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SUdlALShctFhizzo(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z, byte b, bool z2, short s2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SUdlALShctFhizzo(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte[] bArr, short s, bool z, bool z2, short s2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WoHmijSDabIItKEq(java.util.AbstractICollection abstractICollection) {
        return abstractICollection.Count;
    }

    public static void WoHmijSDabIItKEq(java.util.AbstractICollection abstractICollection, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WoHmijSDabIItKEq(java.util.AbstractICollection abstractICollection, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WoHmijSDabIItKEq(java.util.AbstractICollection abstractICollection, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XxtSimSeFbhkfFEb(java.util.AbstractList abstractList, int i) {
        return abstractList[i);
    }

    public static void XxtSimSeFbhkfFEb(java.util.AbstractList abstractList, int i, char c, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XxtSimSeFbhkfFEb(java.util.AbstractList abstractList, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XxtSimSeFbhkfFEb(java.util.AbstractList abstractList, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YBZIpUvjHQtEDqrq(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void YBZIpUvjHQtEDqrq(java.lang.object obj, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBZIpUvjHQtEDqrq(java.lang.object obj, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBZIpUvjHQtEDqrq(java.lang.object obj, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YfNByYQCKtXfxkVG(java.util.AbstractICollection abstractICollection, java.lang.object obj, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YfNByYQCKtXfxkVG(java.util.AbstractICollection abstractICollection, java.lang.object obj, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YfNByYQCKtXfxkVG(java.util.AbstractICollection abstractICollection, java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YfNByYQCKtXfxkVG(java.util.AbstractICollection abstractICollection, java.lang.object obj) {
        return abstractICollection.Add(obj);
    }

    public static short YubSMKebmshhFJjU(com.visa.vac.tc.emvconverter.BERTLV bertlv) {
        return bertlv.getTag();
    }

    public static void YubSMKebmshhFJjU(com.visa.vac.tc.emvconverter.BERTLV bertlv, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YubSMKebmshhFJjU(com.visa.vac.tc.emvconverter.BERTLV bertlv, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YubSMKebmshhFJjU(com.visa.vac.tc.emvconverter.BERTLV bertlv, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZvpeREBQaKWWFEbu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZvpeREBQaKWWFEbu(java.util.IEnumerator it, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZvpeREBQaKWWFEbu(java.util.IEnumerator it, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvpeREBQaKWWFEbu(java.util.IEnumerator it, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DpeIASCFyvyrVenY(java.util.AbstractList abstractList, int i) {
        return abstractList[i);
    }

    public static void DpeIASCFyvyrVenY(java.util.AbstractList abstractList, int i, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DpeIASCFyvyrVenY(java.util.AbstractList abstractList, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DpeIASCFyvyrVenY(java.util.AbstractList abstractList, int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FyzVMhaHpWnXoGkd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FyzVMhaHpWnXoGkd(java.util.IEnumerator it, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FyzVMhaHpWnXoGkd(java.util.IEnumerator it, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FyzVMhaHpWnXoGkd(java.util.IEnumerator it, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MgpfvPsQfQnGNGhF(byte[] bArr, int i, int i2, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MgpfvPsQfQnGNGhF(byte[] bArr, int i, int i2, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MgpfvPsQfQnGNGhF(byte[] bArr, int i, int i2, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] MgpfvPsQfQnGNGhF(byte[] bArr, int i, int i2) {
        return com.visa.vac.tc.emvconverter.Utils.trimbyteArray(bArr, i, i2);
    }

    public static com.visa.vac.tc.emvconverter.BERTLV PXpSVezibzLCpWjC(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s) {
        return bertlv.searchTag(s);
    }

    public static void PXpSVezibzLCpWjC(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s, float f, int i, java.lang.string str, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void PXpSVezibzLCpWjC(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s, float f, int i, short s2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PXpSVezibzLCpWjC(com.visa.vac.tc.emvconverter.BERTLV bertlv, short s, short s2, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RYTCsJlrVkvMxivI(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void RYTCsJlrVkvMxivI(java.lang.object obj, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RYTCsJlrVkvMxivI(java.lang.object obj, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RYTCsJlrVkvMxivI(java.lang.object obj, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator StGhwwRQArrLcqYa(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void StGhwwRQArrLcqYa(java.util.List arrayList, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void StGhwwRQArrLcqYa(java.util.List arrayList, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void StGhwwRQArrLcqYa(java.util.List arrayList, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ULBoEhceMzRfhXrJ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void ULBoEhceMzRfhXrJ(java.lang.object obj, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ULBoEhceMzRfhXrJ(java.lang.object obj, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ULBoEhceMzRfhXrJ(java.lang.object obj, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VopLvhhsPmFSmDMp(java.util.AbstractList abstractList, int i) {
        return abstractList[i);
    }

    public static void VopLvhhsPmFSmDMp(java.util.AbstractList abstractList, int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VopLvhhsPmFSmDMp(java.util.AbstractList abstractList, int i, bool z, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VopLvhhsPmFSmDMp(java.util.AbstractList abstractList, int i, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XwGoeHqMyDSKMEPK(byte[] bArr, int i, int i2, float f, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwGoeHqMyDSKMEPK(byte[] bArr, int i, int i2, float f, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwGoeHqMyDSKMEPK(byte[] bArr, int i, int i2, int i3, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] XwGoeHqMyDSKMEPK(byte[] bArr, int i, int i2) {
        return com.visa.vac.tc.emvconverter.Utils.trimbyteArray(bArr, i, i2);
    }

    public static int ZSheFGltNrtJJbgk(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void ZSheFGltNrtJJbgk(java.lang.object obj, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZSheFGltNrtJJbgk(java.lang.object obj, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZSheFGltNrtJJbgk(java.lang.object obj, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZZwrhCbfuFoqWObg(byte[] bArr, int i, int i2, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZZwrhCbfuFoqWObg(byte[] bArr, int i, int i2, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZZwrhCbfuFoqWObg(byte[] bArr, int i, int i2, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ZZwrhCbfuFoqWObg(byte[] bArr, int i, int i2) {
        return com.visa.vac.tc.emvconverter.Utils.trimbyteArray(bArr, i, i2);
    }

    public static int ZwZCXDTXhCFCPttN(java.util.AbstractICollection abstractICollection) {
        return abstractICollection.Count;
    }

    public static void ZwZCXDTXhCFCPttN(java.util.AbstractICollection abstractICollection, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZwZCXDTXhCFCPttN(java.util.AbstractICollection abstractICollection, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZwZCXDTXhCFCPttN(java.util.AbstractICollection abstractICollection, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    readonly bool BuildConfig(short s) {
        if ((17 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = setCAKeys + 39;
        int i3 = i2 % 128;
        getCAKeys = i3;
        if (i2 % 2 != 0) {
            throw null;
        }
        if (this.setTerminalData is not null) {
            int i4 = i3 + 83;
            setCAKeys = i4 % 128;
            int i5 = i4 % 2;
            for (int i6 = 0; i6 < zwZCXDTXhCFCPttN(this.setTerminalData); i6++) {
                int i7 = setCAKeys + 75;
                getCAKeys = i7 % 128;
                if (i7 % 2 != 0) {
                    SNnRNjYtgrUIRNnv((com.visa.vac.tc.emvconverter.BERTLV) dpeIASCFyvyrVenY(this.setTerminalData, i6));
                    throw null;
                }
                if (YubSMKebmshhFJjU((com.visa.vac.tc.emvconverter.BERTLV) XxtSimSeFbhkfFEb(this.setTerminalData, i6)) == s) {
                    return true;
                }
            }
        }
        return false;
    }

    public short GetLen() {
        if ((31 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = setCAKeys;
        int i3 = i2 + 47;
        getCAKeys = i3 % 128;
        int i4 = i3 % 2;
        short s = this.e1;
        int i5 = i2 + 91;
        getCAKeys = i5 % 128;
        if (i5 % 2 == 0) {
            return s;
        }
        uLBoEhceMzRfhXrJ(null);
        throw null;
    }

    public java.util.List<com.visa.vac.tc.emvconverter.BERTLV> GetMoreTLVs() {
        if ((1 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = setCAKeys + 59;
        int i3 = i2 % 128;
        getCAKeys = i3;
        int i4 = i2 % 2;
        java.util.List<com.visa.vac.tc.emvconverter.BERTLV> arrayList = this.setTerminalData;
        int i5 = i3 + 59;
        setCAKeys = i5 % 128;
        int i6 = i5 % 2;
        return arrayList;
    }

    public short GetTag() {
        if ((20 + 20) % 20 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys;
        int i3 = i2 + 105;
        setCAKeys = i3 % 128;
        int i4 = i3 % 2;
        short s = this.ContactlessConfiguration;
        int i5 = i2 + 63;
        setCAKeys = i5 % 128;
        if (i5 % 2 != 0) {
            return s;
        }
        zSheFGltNrtJJbgk(null);
        throw null;
    }

    public byte[] GetValue() {
        if ((3 + 25) % 25 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys;
        int i3 = i2 + 71;
        setCAKeys = i3 % 128;
        int i4 = i3 % 2;
        byte[] bArr = this.getInstance;
        if (bArr is null) {
            return null;
        }
        int i5 = i2 + 85;
        setCAKeys = i5 % 128;
        int i6 = i5 % 2;
        return bArr;
    }

    public com.visa.vac.tc.emvconverter.BERTLV SearchTag(short s) {
        if ((3 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = setCAKeys;
        int i3 = i2 + 53;
        getCAKeys = i3 % 128;
        if (i3 % 2 != 0) {
            throw null;
        }
        if (this.ContactlessConfiguration == s) {
            return this;
        }
        if (this.getTerminalData == 1) {
            int i4 = i2 + 65;
            getCAKeys = i4 % 128;
            if (i4 % 2 != 0) {
                stGhwwRQArrLcqYa(this.setTerminalData);
                rYTCsJlrVkvMxivI(null);
                throw null;
            }
            java.util.IEnumerator itDWISZxuPAAUjTZzB = DWISZxuPAAUjTZzB(this.setTerminalData);
            while (BRKQetdNrjexrLnC(itDWISZxuPAAUjTZzB)) {
                int i5 = getCAKeys + 5;
                setCAKeys = i5 % 128;
                if (i5 % 2 != 0) {
                    com.visa.vac.tc.emvconverter.BERTLV bertlv = (com.visa.vac.tc.emvconverter.BERTLV) ZvpeREBQaKWWFEbu(itDWISZxuPAAUjTZzB);
                    if (DCXThDOnfHDHKJJq(bertlv, s) is not null) {
                        return bertlv;
                    }
                } else {
                    com.visa.vac.tc.emvconverter.BERTLV bertlv2 = (com.visa.vac.tc.emvconverter.BERTLV) fyzVMhaHpWnXoGkd(itDWISZxuPAAUjTZzB);
                    int i6 = 35 / 0;
                    if (pXpSVezibzLCpWjC(bertlv2, s) is not null) {
                        return bertlv2;
                    }
                }
            }
        }
        return null;
    }
}

