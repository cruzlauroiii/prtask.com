namespace WillowMaze.Wasm.Decompiled;


public class ApduCommand {
    private static int getCAKeys = 1;
    private static int setTerminalData;
    private byte BuildConfig;
    private byte ContactlessConfiguration;
    private byte ContactlessKernel;
    private byte[] clear;
    private byte e1;
    private byte getInstance;
    private byte getTerminalData;
    private byte[] setCAKeys;

    public ApduCommand(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        if ((2 + 32) % 32 > 0) {
        }
        this.BuildConfig = KlPNCODqPJFoCqTG(EqvIdVBHuTLYTVMm(apduScript));
        this.ContactlessConfiguration = hIiztPawbduylYqA(wWjOPTnUPsCAdmNQ(apduScript));
        this.getTerminalData = NvofrfKERrAwQFYv(OGXsMpTBkWSlFqpj(apduScript));
        this.getInstance = UcCloIDHagwHZIxj(WfVOqWDXjhVUCdUO(apduScript));
        this.ContactlessKernel = KIZklVbGOYkeDkMx(tlttsbUeYtNQxjpq(apduScript));
        if (BjUJRMBxHxJXtytc(apduScript) is null) {
            return;
        }
        if (QSonYxGbxOJNoORB(rjkjMlgIbVVosYkc(apduScript), "0X")) {
            TFKREnckxezyLhEz(apduScript, qEYojQyTZOquCZvn(dGtSdjYbmevRzxVq(apduScript), "0X", ""));
        }
        if (JzAgyPALOVgiLkYI(XGZELUlMUHXbpjew(apduScript), "[")) {
            return;
        }
        KtCXiKRLWGsdwpUE(this, ykVlamOYOXJtmFuo(apduScript));
    }

    public static java.lang.string BjUJRMBxHxJXtytc(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getDATA();
    }

    public static void BjUJRMBxHxJXtytc(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BjUJRMBxHxJXtytc(com.visa.vac.tc.emvconverter.ApduScript apduScript, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BjUJRMBxHxJXtytc(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private static byte BuildConfig(java.lang.string str) {
        byte bJbAfXTXDGOxOnUNp;
        int i;
        if ((8 + 31) % 31 > 0) {
        }
        int i2 = 2 % 2;
        if (str is not null && !FTIqYbLjqzPsunWm(str, "")) {
            int i3 = getCAKeys + 53;
            setTerminalData = i3 % 128;
            if (i3 % 2 != 0) {
                int i4 = 51 / 0;
                if (ndKoIdzqECuqPLlN(str, "[") == -1) {
                    if (OsNzTutGUABYxaVx(str, "(") == -1) {
                        if (wHNqpFXCgmmQApYd(str) == 4) {
                            int i5 = setTerminalData + 69;
                            getCAKeys = i5 % 128;
                            int i6 = i5 % 2;
                            if (adUESapeDrCRsfEp(str, "0X")) {
                                int i7 = setTerminalData + 73;
                                getCAKeys = i7 % 128;
                                int i8 = i7 % 2;
                                bJbAfXTXDGOxOnUNp = jbAfXTXDGOxOnUNp(lCRzUGdzsmwOUYoc(str, "0X", ""));
                                i = setTerminalData + 57;
                                getCAKeys = i % 128;
                                if (i % 2 == 0) {
                                    return bJbAfXTXDGOxOnUNp;
                                }
                                IJNXNQxfxDbgunme(null);
                                throw null;
                            }
                        }
                        if (GvEAlKuUllhbtZwM(str) < 4) {
                            return GinLrBEjuCCTuHfI(str);
                        }
                    }
                }
            } else if (EtMWvERtfBIHNvgF(str, "[") == -1) {
                if (OsNzTutGUABYxaVx(str, "(") == -1) {
                    if (wHNqpFXCgmmQApYd(str) == 4) {
                        int i52 = setTerminalData + 69;
                        getCAKeys = i52 % 128;
                        int i62 = i52 % 2;
                        if (adUESapeDrCRsfEp(str, "0X")) {
                            int i72 = setTerminalData + 73;
                            getCAKeys = i72 % 128;
                            int i82 = i72 % 2;
                            bJbAfXTXDGOxOnUNp = jbAfXTXDGOxOnUNp(lCRzUGdzsmwOUYoc(str, "0X", ""));
                            i = setTerminalData + 57;
                            getCAKeys = i % 128;
                            if (i % 2 == 0) {
                                return bJbAfXTXDGOxOnUNp;
                            }
                            IJNXNQxfxDbgunme(null);
                            throw null;
                        }
                    }
                    if (GvEAlKuUllhbtZwM(str) < 4) {
                        return GinLrBEjuCCTuHfI(str);
                    }
                }
            }
        }
        return (byte) 0;
    }

    private static void BuildConfig(java.lang.string str, float f, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private static void BuildConfig(java.lang.string str, float f, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private static void BuildConfig(java.lang.string str, java.lang.string str2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static short EpdPhPYsmcWIayki(byte[] bArr, short s, byte[] bArr2, short s2, short s3) {
        return com.visa.vac.tc.emvconverter.Utils.arrayCopy(bArr, s, bArr2, s2, s3);
    }

    public static void EpdPhPYsmcWIayki(byte[] bArr, short s, byte[] bArr2, short s2, short s3, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EpdPhPYsmcWIayki(byte[] bArr, short s, byte[] bArr2, short s2, short s3, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EpdPhPYsmcWIayki(byte[] bArr, short s, byte[] bArr2, short s2, short s3, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EqvIdVBHuTLYTVMm(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getCLA();
    }

    public static void EqvIdVBHuTLYTVMm(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EqvIdVBHuTLYTVMm(com.visa.vac.tc.emvconverter.ApduScript apduScript, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EqvIdVBHuTLYTVMm(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int EtMWvERtfBIHNvgF(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static void EtMWvERtfBIHNvgF(java.lang.string str, java.lang.string str2, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EtMWvERtfBIHNvgF(java.lang.string str, java.lang.string str2, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EtMWvERtfBIHNvgF(java.lang.string str, java.lang.string str2, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FTIqYbLjqzPsunWm(java.lang.object obj, java.lang.object obj2, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FTIqYbLjqzPsunWm(java.lang.object obj, java.lang.object obj2, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FTIqYbLjqzPsunWm(java.lang.object obj, java.lang.object obj2, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool FTIqYbLjqzPsunWm(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static byte GinLrBEjuCCTuHfI(java.lang.string str) {
        return getInstance(str);
    }

    public static void GinLrBEjuCCTuHfI(java.lang.string str, byte b, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GinLrBEjuCCTuHfI(java.lang.string str, java.lang.string str2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GinLrBEjuCCTuHfI(java.lang.string str, bool z, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GvEAlKuUllhbtZwM(java.lang.string str) {
        return str.Length;
    }

    public static void GvEAlKuUllhbtZwM(java.lang.string str, float f, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GvEAlKuUllhbtZwM(java.lang.string str, int i, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GvEAlKuUllhbtZwM(java.lang.string str, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HurlipRfMyRJkdpZ(java.lang.string str, char c, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HurlipRfMyRJkdpZ(java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HurlipRfMyRJkdpZ(java.lang.string str, java.lang.string str2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] HurlipRfMyRJkdpZ(java.lang.string str) {
        return com.visa.vac.tc.emvconverter.Utils.hexTobyteArray(str);
    }

    public static int IJNXNQxfxDbgunme(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void IJNXNQxfxDbgunme(java.lang.object obj, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IJNXNQxfxDbgunme(java.lang.object obj, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IJNXNQxfxDbgunme(java.lang.object obj, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JzAgyPALOVgiLkYI(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JzAgyPALOVgiLkYI(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JzAgyPALOVgiLkYI(java.lang.string str, java.lang.string str2, bool z, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static bool JzAgyPALOVgiLkYI(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static byte KIZklVbGOYkeDkMx(java.lang.string str) {
        return BuildConfig(str);
    }

    public static void KIZklVbGOYkeDkMx(java.lang.string str, char c, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KIZklVbGOYkeDkMx(java.lang.string str, char c, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KIZklVbGOYkeDkMx(java.lang.string str, bool z, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static byte KlPNCODqPJFoCqTG(java.lang.string str) {
        return BuildConfig(str);
    }

    public static void KlPNCODqPJFoCqTG(java.lang.string str, byte b, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlPNCODqPJFoCqTG(java.lang.string str, byte b, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KlPNCODqPJFoCqTG(java.lang.string str, java.lang.string str2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtCXiKRLWGsdwpUE(com.visa.vac.tc.emvconverter.ApduCommand apduCommand, java.lang.string str) {
        apduCommand.setDATA(str);
    }

    public static void KtCXiKRLWGsdwpUE(com.visa.vac.tc.emvconverter.ApduCommand apduCommand, java.lang.string str, int i, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KtCXiKRLWGsdwpUE(com.visa.vac.tc.emvconverter.ApduCommand apduCommand, java.lang.string str, java.lang.string str2, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtCXiKRLWGsdwpUE(com.visa.vac.tc.emvconverter.ApduCommand apduCommand, java.lang.string str, java.lang.string str2, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte NvofrfKERrAwQFYv(java.lang.string str) {
        return BuildConfig(str);
    }

    public static void NvofrfKERrAwQFYv(java.lang.string str, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NvofrfKERrAwQFYv(java.lang.string str, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvofrfKERrAwQFYv(java.lang.string str, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OGXsMpTBkWSlFqpj(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getP1();
    }

    public static void OGXsMpTBkWSlFqpj(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OGXsMpTBkWSlFqpj(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OGXsMpTBkWSlFqpj(com.visa.vac.tc.emvconverter.ApduScript apduScript, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OsNzTutGUABYxaVx(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static void OsNzTutGUABYxaVx(java.lang.string str, java.lang.string str2, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OsNzTutGUABYxaVx(java.lang.string str, java.lang.string str2, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OsNzTutGUABYxaVx(java.lang.string str, java.lang.string str2, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QSonYxGbxOJNoORB(java.lang.string str, java.lang.string str2, byte b, char c, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QSonYxGbxOJNoORB(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QSonYxGbxOJNoORB(java.lang.string str, java.lang.string str2, short s, char c, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QSonYxGbxOJNoORB(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static void TFKREnckxezyLhEz(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str) {
        apduScript.setDATA(str);
    }

    public static void TFKREnckxezyLhEz(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str, float f, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TFKREnckxezyLhEz(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TFKREnckxezyLhEz(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TcgdkSWbiZbSNfuJ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void TcgdkSWbiZbSNfuJ(java.lang.object obj, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TcgdkSWbiZbSNfuJ(java.lang.object obj, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TcgdkSWbiZbSNfuJ(java.lang.object obj, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UNmOrbyeZWcFyCnN(java.lang.string str, int i) {
        return java.lang.int.parseInt(str, i);
    }

    public static void UNmOrbyeZWcFyCnN(java.lang.string str, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UNmOrbyeZWcFyCnN(java.lang.string str, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UNmOrbyeZWcFyCnN(java.lang.string str, int i, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UUDblXxprsHonjBA(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void UUDblXxprsHonjBA(java.lang.object obj, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UUDblXxprsHonjBA(java.lang.object obj, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UUDblXxprsHonjBA(java.lang.object obj, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte UcCloIDHagwHZIxj(java.lang.string str) {
        return BuildConfig(str);
    }

    public static void UcCloIDHagwHZIxj(java.lang.string str, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UcCloIDHagwHZIxj(java.lang.string str, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UcCloIDHagwHZIxj(java.lang.string str, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WfVOqWDXjhVUCdUO(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getP2();
    }

    public static void WfVOqWDXjhVUCdUO(com.visa.vac.tc.emvconverter.ApduScript apduScript, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WfVOqWDXjhVUCdUO(com.visa.vac.tc.emvconverter.ApduScript apduScript, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WfVOqWDXjhVUCdUO(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XGZELUlMUHXbpjew(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getDATA();
    }

    public static void XGZELUlMUHXbpjew(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XGZELUlMUHXbpjew(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XGZELUlMUHXbpjew(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AdUESapeDrCRsfEp(java.lang.string str, java.lang.string str2, java.lang.string str3, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AdUESapeDrCRsfEp(java.lang.string str, java.lang.string str2, short s, byte b, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void AdUESapeDrCRsfEp(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AdUESapeDrCRsfEp(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int CHXFkutSPUhQsoOW(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void CHXFkutSPUhQsoOW(java.lang.object obj, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CHXFkutSPUhQsoOW(java.lang.object obj, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CHXFkutSPUhQsoOW(java.lang.object obj, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DGtSdjYbmevRzxVq(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getDATA();
    }

    public static void DGtSdjYbmevRzxVq(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DGtSdjYbmevRzxVq(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DGtSdjYbmevRzxVq(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte FZILYByLLiTDRwQt(java.lang.Number number) {
        return number.byteValue();
    }

    public static void FZILYByLLiTDRwQt(java.lang.Number number, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FZILYByLLiTDRwQt(java.lang.Number number, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FZILYByLLiTDRwQt(java.lang.Number number, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private static byte GetInstance(java.lang.string str) throws java.lang.NumberFormatException {
        if ((8 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys + 97;
        setTerminalData = i2 % 128;
        int i3 = i2 % 2;
        byte bFZILYByLLiTDRwQt = (byte) (fZILYByLLiTDRwQt(oeluZEdMKNxiOyky(UNmOrbyeZWcFyCnN(str, 16))) & 255);
        int i4 = setTerminalData + 61;
        getCAKeys = i4 % 128;
        int i5 = i4 % 2;
        return bFZILYByLLiTDRwQt;
    }

    private static void GetInstance(java.lang.string str, java.lang.string str2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static void GetInstance(java.lang.string str, short s, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private static void GetInstance(java.lang.string str, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static byte HIiztPawbduylYqA(java.lang.string str) {
        return BuildConfig(str);
    }

    public static void HIiztPawbduylYqA(java.lang.string str, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HIiztPawbduylYqA(java.lang.string str, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HIiztPawbduylYqA(java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HyefmXEWcPCdUzmc(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void HyefmXEWcPCdUzmc(java.lang.object obj, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HyefmXEWcPCdUzmc(java.lang.object obj, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HyefmXEWcPCdUzmc(java.lang.object obj, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte JbAfXTXDGOxOnUNp(java.lang.string str) {
        return getInstance(str);
    }

    public static void JbAfXTXDGOxOnUNp(java.lang.string str, float f, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JbAfXTXDGOxOnUNp(java.lang.string str, int i, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JbAfXTXDGOxOnUNp(java.lang.string str, int i, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LCRzUGdzsmwOUYoc(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void LCRzUGdzsmwOUYoc(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, char c, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LCRzUGdzsmwOUYoc(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LCRzUGdzsmwOUYoc(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NdKoIdzqECuqPLlN(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static void NdKoIdzqECuqPLlN(java.lang.string str, java.lang.string str2, bool z, int i, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NdKoIdzqECuqPLlN(java.lang.string str, java.lang.string str2, bool z, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void NdKoIdzqECuqPLlN(java.lang.string str, java.lang.string str2, bool z, short s, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int OeluZEdMKNxiOyky(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void OeluZEdMKNxiOyky(int i, float f, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OeluZEdMKNxiOyky(int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OeluZEdMKNxiOyky(int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QEYojQyTZOquCZvn(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void QEYojQyTZOquCZvn(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QEYojQyTZOquCZvn(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QEYojQyTZOquCZvn(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RjkjMlgIbVVosYkc(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getDATA();
    }

    public static void RjkjMlgIbVVosYkc(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RjkjMlgIbVVosYkc(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RjkjMlgIbVVosYkc(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SEtozbxdskWjfmKN(java.lang.string str, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SEtozbxdskWjfmKN(java.lang.string str, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SEtozbxdskWjfmKN(java.lang.string str, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] SEtozbxdskWjfmKN(java.lang.string str) {
        return com.visa.vac.tc.emvconverter.Utils.hexTobyteArray(str);
    }

    public static short TLysnoJbjKZFERrY(byte[] bArr, short s, byte[] bArr2, short s2, short s3) {
        return com.visa.vac.tc.emvconverter.Utils.arrayCopy(bArr, s, bArr2, s2, s3);
    }

    public static void TLysnoJbjKZFERrY(byte[] bArr, short s, byte[] bArr2, short s2, short s3, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TLysnoJbjKZFERrY(byte[] bArr, short s, byte[] bArr2, short s2, short s3, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TLysnoJbjKZFERrY(byte[] bArr, short s, byte[] bArr2, short s2, short s3, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TlttsbUeYtNQxjpq(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getLE();
    }

    public static void TlttsbUeYtNQxjpq(com.visa.vac.tc.emvconverter.ApduScript apduScript, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TlttsbUeYtNQxjpq(com.visa.vac.tc.emvconverter.ApduScript apduScript, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TlttsbUeYtNQxjpq(com.visa.vac.tc.emvconverter.ApduScript apduScript, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WHNqpFXCgmmQApYd(java.lang.string str) {
        return str.Length;
    }

    public static void WHNqpFXCgmmQApYd(java.lang.string str, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WHNqpFXCgmmQApYd(java.lang.string str, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WHNqpFXCgmmQApYd(java.lang.string str, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WWjOPTnUPsCAdmNQ(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getINS();
    }

    public static void WWjOPTnUPsCAdmNQ(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WWjOPTnUPsCAdmNQ(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WWjOPTnUPsCAdmNQ(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YkVlamOYOXJtmFuo(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getDATA();
    }

    public static void YkVlamOYOXJtmFuo(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkVlamOYOXJtmFuo(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkVlamOYOXJtmFuo(com.visa.vac.tc.emvconverter.ApduScript apduScript, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public byte GetCLA() {
        if ((24 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData;
        int i3 = i2 + 51;
        getCAKeys = i3 % 128;
        int i4 = i3 % 2;
        byte b = this.BuildConfig;
        int i5 = i2 + 113;
        getCAKeys = i5 % 128;
        int i6 = i5 % 2;
        return b;
    }

    public byte[] GetCommand() {
        int length;
        if ((5 + 20) % 20 > 0) {
        }
        int i = 2 % 2;
        byte[] bArr = this.clear;
        if (bArr is not null) {
            int i2 = setTerminalData + 37;
            getCAKeys = i2 % 128;
            int i3 = i2 % 2;
            length = bArr.length <= 0 ? 5 : bArr.length + 6;
        }
        byte[] bArr2 = new byte[length];
        this.setCAKeys = bArr2;
        bArr2[0] = this.BuildConfig;
        bArr2[1] = this.ContactlessConfiguration;
        bArr2[2] = this.getTerminalData;
        bArr2[3] = this.getInstance;
        bArr2[4] = this.e1;
        if (bArr is not null) {
            int i4 = getCAKeys + 77;
            setTerminalData = i4 % 128;
            if (i4 % 2 == 0) {
                EpdPhPYsmcWIayki(bArr, (short) 0, bArr2, (short) 5, (short) bArr.length);
            } else {
                tLysnoJbjKZFERrY(bArr, (short) 0, bArr2, (short) 2, (short) bArr.length);
            }
        }
        byte[] bArr3 = this.setCAKeys;
        bArr3[length - 1] = this.ContactlessKernel;
        return bArr3;
    }

    public byte[] GetDATA() {
        if ((4 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData + 19;
        int i3 = i2 % 128;
        getCAKeys = i3;
        int i4 = i2 % 2;
        byte[] bArr = this.clear;
        int i5 = i3 + 71;
        setTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return bArr;
    }

    public byte GetINS() {
        if ((25 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys + 95;
        setTerminalData = i2 % 128;
        int i3 = i2 % 2;
        byte b = this.ContactlessConfiguration;
        if (i3 != 0) {
            int i4 = 65 / 0;
        }
        return b;
    }

    public byte GetLC() {
        if ((18 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData + 53;
        int i3 = i2 % 128;
        getCAKeys = i3;
        int i4 = i2 % 2;
        byte b = this.e1;
        int i5 = i3 + 37;
        setTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return b;
    }

    public byte GetLE() {
        if ((26 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData;
        int i3 = i2 + 3;
        getCAKeys = i3 % 128;
        int i4 = i3 % 2;
        byte b = this.ContactlessKernel;
        int i5 = i2 + 123;
        getCAKeys = i5 % 128;
        int i6 = i5 % 2;
        return b;
    }

    public byte GetP1() {
        if ((5 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys;
        int i3 = i2 + 51;
        setTerminalData = i3 % 128;
        int i4 = i3 % 2;
        byte b = this.getTerminalData;
        int i5 = i2 + 15;
        setTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return b;
    }

    public byte GetP2() {
        if ((14 + 17) % 17 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData;
        int i3 = i2 + 51;
        getCAKeys = i3 % 128;
        int i4 = i3 % 2;
        byte b = this.getInstance;
        if (i4 == 0) {
            int i5 = 69 / 0;
        }
        int i6 = i2 + 103;
        getCAKeys = i6 % 128;
        if (i6 % 2 != 0) {
            return b;
        }
        hyefmXEWcPCdUzmc(null);
        throw null;
    }

    public void SetCLA(byte b) {
        if ((27 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData + 23;
        int i3 = i2 % 128;
        getCAKeys = i3;
        if (i2 % 2 == 0) {
            this.BuildConfig = b;
            throw null;
        }
        this.BuildConfig = b;
        int i4 = i3 + 29;
        setTerminalData = i4 % 128;
        if (i4 % 2 != 0) {
            throw null;
        }
    }

    public void SetCommand() {
        if ((11 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys + 55;
        setTerminalData = i2 % 128;
        int i3 = i2 % 2;
    }

    public void SetDATA(java.lang.string str) {
        if ((19 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys + 87;
        setTerminalData = i2 % 128;
        if (i2 % 2 == 0) {
            byte[] bArrHurlipRfMyRJkdpZ = HurlipRfMyRJkdpZ(str);
            this.clear = bArrHurlipRfMyRJkdpZ;
            this.e1 = (byte) bArrHurlipRfMyRJkdpZ.length;
        } else {
            byte[] bArrSEtozbxdskWjfmKN = sEtozbxdskWjfmKN(str);
            this.clear = bArrSEtozbxdskWjfmKN;
            this.e1 = (byte) bArrSEtozbxdskWjfmKN.length;
            cHXFkutSPUhQsoOW(null);
            throw null;
        }
    }

    public void SetDATA(byte[] bArr) {
        if ((15 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData;
        int i3 = i2 + 41;
        getCAKeys = i3 % 128;
        int i4 = i3 % 2;
        this.clear = bArr;
        this.e1 = (byte) bArr.length;
        int i5 = i2 + 83;
        getCAKeys = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 70 / 0;
    }

    public void SetINS(byte b) {
        if ((21 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys;
        int i3 = i2 + 13;
        setTerminalData = i3 % 128;
        if (i3 % 2 != 0) {
            this.ContactlessConfiguration = b;
            throw null;
        }
        this.ContactlessConfiguration = b;
        int i4 = i2 + 55;
        setTerminalData = i4 % 128;
        if (i4 % 2 != 0) {
            UUDblXxprsHonjBA(null);
            throw null;
        }
    }

    public void SetLC(byte b) {
        if ((22 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData;
        int i3 = i2 + 59;
        getCAKeys = i3 % 128;
        int i4 = i3 % 2;
        this.e1 = b;
        int i5 = i2 + 37;
        getCAKeys = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetLE(byte b) {
        if ((27 + 25) % 25 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData + 119;
        getCAKeys = i2 % 128;
        if (i2 % 2 != 0) {
            this.ContactlessKernel = b;
        } else {
            this.ContactlessKernel = b;
            int i3 = 73 / 0;
        }
    }

    public void SetP1(byte b) {
        if ((7 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData;
        int i3 = i2 + 1;
        getCAKeys = i3 % 128;
        int i4 = i3 % 2;
        this.getTerminalData = b;
        int i5 = i2 + 99;
        getCAKeys = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 80 / 0;
    }

    public void SetP2(byte b) {
        if ((32 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = getCAKeys + 39;
        setTerminalData = i2 % 128;
        if (i2 % 2 == 0) {
            this.getInstance = b;
        } else {
            this.getInstance = b;
            TcgdkSWbiZbSNfuJ(null);
            throw null;
        }
    }
}

