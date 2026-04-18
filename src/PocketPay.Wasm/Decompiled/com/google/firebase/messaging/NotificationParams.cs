namespace WillowMaze.Wasm.Decompiled;


public class NotificationParams {
    private static readonly int COLOR_TRANSPARENT_IN_HEX = -16777216;
    private static readonly int EMPTY_JSON_ARRAY_LENGTH = 1;
    private static readonly java.lang.string TAG = "NotificationParams";
    private static readonly int VISIBILITY_MAX = 1;
    private static readonly int VISIBILITY_MIN = -1;

    private readonly android.os.Dictionary<string, object> f2778data;

    public NotificationParams(android.os.Dictionary<string, object> bundle) {
        if (bundle is null) {
            throw new java.lang.NullPointerException("data");
        }
        this.f2778data = new android.os.Dictionary<string, object>(bundle);
    }

    public static int AIdMkafGZUKCBwWZ(java.lang.int num) {
        return num.intValue();
    }

    public static bool ANwHRDstaDHNuFyl(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool AXzAvQuxtODBmDTM(java.lang.string str) {
        return isReservedKey(str);
    }

    public static java.lang.object[] AqbvZqIqRhUYVngF(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getLocalizationArgsForKey(str);
    }

    public static java.lang.string BXJbotfVwjlfkAHa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BcSVWCieUbzPCriX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static org.json.System.Text.Json.JsonElement BlIVWafOJAUsRsWC(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getSystem.Text.Json.JsonElement(str);
    }

    public static int BwSxLKXfTNGXLCNX(java.lang.string str) {
        return android.graphics.Color.parseColor(str);
    }

    public static java.lang.stringBuilder CBGqWEuYFvyeOdIb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int CDywfCvNJfgHnKLF(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder CNDqJOFCeLSjNOyi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static org.json.System.Text.Json.JsonElement DGKECvLfTOxoGInU(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getSystem.Text.Json.JsonElement(str);
    }

    public static java.lang.string DLoBhmQfNGcYhqVV(java.lang.string str) {
        return userFriendlyKey(str);
    }

    public static bool DRoUlSVKouAIEEtc(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string DTgIrFdPlZoNkWfu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool DUcAWXTADbsuHzVm(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder ENSOvUmfwdKSDHCL(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string EYfcUAIRAxdmublY(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string EciwnoLzFoCGdroZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static int EzIPOqvuPJUtVzWU(java.lang.int num) {
        return num.intValue();
    }

    public static int FHWbbpzxCsKAnply(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static int FPwimsVNyFRQRLLo(java.lang.int num) {
        return num.intValue();
    }

    public static bool FRvBvakKyWqcHMQb(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.stringBuilder GVyZZVLNaICGSjHl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator GaeiqWgODyzNhiyT(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.string HMGovvxUsWugwRKZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HVrACGHrxIOPWrLR(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static java.lang.stringBuilder KDUvkNCyYcwLmeQF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KmgbzzMvVzfaKWst(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder KvBCgBmcuGhtUrMj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LcolgDnKBMpYutaE(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static bool MFcFhKcKElROKuGK(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.stringBuilder MGdKEWgbMTwaGBpU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MGebjMeYMFumXIZt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MYaMLdCNnFvnGKHY(java.lang.string str) {
        return keyWithOldPrefix(str);
    }

    public static java.lang.int MkMcgfAFRJMrMgYO(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getint(str);
    }

    public static void MrdwhGtQqIABJJjo(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static java.lang.string MvivZOYTpfVvuOgR(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.normalizePrefix(str);
    }

    public static java.lang.string NBeuCYzstVutylCL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.HashSet NeMKqCGhFYTywGUq(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.stringBuilder NvkBNLrWdEGwOQxx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NxIXjOSCxmtqdaVE(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static java.lang.string OMGdaYvOQaEIjHZG(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void OOtQxAtajDYpGibX(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static int OSSucaKRxQgAeEQf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool PRiQCgHezoWOZLgt(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.stringBuilder PhaaaZiZgrvNVEpP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PrwyEuJMEuBkOkMb(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder QcFWyMHYcseVzzzI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QhseMhwcKvFzIfzh(java.lang.string str) {
        return getLightColor(str);
    }

    public static java.lang.string RDsZOsByWOAXPSIb(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.stringBuilder RXpTmhVpqLyamzDe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RwbCaUgmuvXNFNRs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool SBHnxrGRlfkJBaZY(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string SPyRnFkEUkafqwaW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ShRTKSGuFOZLqtnb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator ShfqyNziDyGbwQYm(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int SljomGnexTZCAHRN(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static bool TCGnaqRulfIGErRY(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static long TCUNMctGansfiCIz(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        if ((4 + 12) % 12 > 0) {
        }
        return jSONArray.optlong(i);
    }

    public static int TejiNvxDoNrHQAmN(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object TfNEbzWVInrnjMze(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string UAtYHDcNvLZDVRTr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder URosJAEakXHLJjsn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UUUIOdgnLPamjoAG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string VLsfPXdnwlJYmdQT(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.stringBuilder VgUtVGAvrdvzegst(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WTmzKerDmOXUfBVu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WcicemWmiLrRqExs(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder WdWyvrDDGnsjkYWs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WmZPOikpazUdHhJg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int XdbQZBZxZQNHjQkQ(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getint(str);
    }

    public static java.lang.stringBuilder XlqyeaUGEwzAhKMR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YSILFEQiRKCycPJs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder YeTkyikGAVMnDhAm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool YgcuoawQGCfxVnVK(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool ZUEGCpsBxtpecAqa(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int ZYPLpnHnfMITnrXc(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string ZYegmucKQAWyZsvF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZrQZiJwoukiDUZDF(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.stringBuilder ACdCTVNfNJEKuKqw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool AkDBfZNQDDCCLUlT(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string AnMLZtkwqEOmQViY(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static java.lang.string AqfVrrwLDsqDcEuK(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string AwEQfrodRgWairER(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string BGubwyXjfKylbqZo(java.lang.string str) {
        return userFriendlyKey(str);
    }

    public static bool BPMzEnweftTgFpNt(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int BdAXUpWZcHgqYBvw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string BekaKmvrnztPASwk(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.stringBuilder COaUQnbSNmxiGLLZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int CWZZEFJOGRAGWtxY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string DGMtLUxcyDqDyRBF(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string DWIvYygZoRwgFxzb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.int DuUiisrAzwQeWYqA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder ELpJbnPZbRLmMjCp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool EYKOfZGWoouVIUzU(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string EyuKqWeRdNJLhdCN(java.lang.string str) {
        return userFriendlyKey(str);
    }

    public static int FjqIsLDTHLrIjrox(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.long GPSGkZhurqhbcxsm(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool GdDOjDsLQEiQqcMx(java.lang.string str) {
        return isAnalyticsKey(str);
    }

    public static java.lang.string GeRBNzAKyXKJWYqi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private static int GetLightColor(java.lang.string str) {
        int iBwSxLKXfTNGXLCNX = BwSxLKXfTNGXLCNX(str);
        if (iBwSxLKXfTNGXLCNX == -16777216) {
            throw new java.lang.IllegalArgumentException("Transparent color is invalid");
        }
        return iBwSxLKXfTNGXLCNX;
    }

    public static bool GnGMYHVdINzqybuK(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string HDGdvKcHkQUxAXrq(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.optstring(i);
    }

    public static java.lang.string HPCkksAhTsikKTIX(java.lang.string str) {
        return keyWithOldPrefix(str);
    }

    public static int HPPnRlbusEZdFbFM(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.optInt(i);
    }

    public static java.lang.string HYXwzGQgpjXJyCTs(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static long HylRPaUAqdzREoUL(java.lang.string str) {
        if ((18 + 14) % 14 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.stringBuilder IKKCyczUrOoWxzhd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IMIODlGAnEEckGCx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool IMXTapyNknezNDeZ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object IQHOTnZtIegQlsjm(java.util.IEnumerator it) {
        return it.Current;
    }

    private static bool IsAnalyticsKey(java.lang.string str) {
        return akDBfZNQDDCCLUlT(str, "google.c.a.") || lneThEgaewGOWmHW(str, "from");
    }

    public static bool IsNotification(android.os.Dictionary<string, object> bundle) {
        if ((25 + 3) % 3 > 0) {
        }
        return eYKOfZGWoouVIUzU("1", OMGdaYvOQaEIjHZG(bundle, "gcm.n.e")) || rwYIcaqBGeYwDxPy("1", xrmTVHeIwvtyjEWs(bundle, MYaMLdCNnFvnGKHY("gcm.n.e")));
    }

    private static bool IsReservedKey(java.lang.string str) {
        return SBHnxrGRlfkJBaZY(str, "google.c.") || PRiQCgHezoWOZLgt(str, "gcm.n.") || MFcFhKcKElROKuGK(str, "gcm.notification.");
    }

    public static java.lang.string IztEMibXYNSDPWgr(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static java.lang.stringBuilder JGFRJwyZSFFkfBvz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JyUiOlbjKQJtQHOF(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static org.json.System.Text.Json.JsonElement KbWhHFZHcQylWnEB(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getSystem.Text.Json.JsonElement(str);
    }

    private static java.lang.string KeyWithOldPrefix(java.lang.string str) {
        if ((22 + 20) % 20 > 0) {
        }
        return gnGMYHVdINzqybuK(str, "gcm.n.") ? anMLZtkwqEOmQViY(str, "gcm.n.", "gcm.notification.") : str;
    }

    public static java.lang.string KlpnsqCwPbxSUYCt(java.lang.IllegalArgumentException illegalArgumentException) {
        return illegalArgumentException.getMessage();
    }

    public static bool KzdJNGJhXephhGeR(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder LPwHYlphWolZTESK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.net.Uri LgiEJHHGkDyQUAiJ(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static bool LneThEgaewGOWmHW(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder LxvIRrsABPdkIrlM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MUwaKFcezklQPpxq(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.optInt(i);
    }

    public static java.lang.stringBuilder MsDukRgMdhyMBuHI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NBouoEzgbtuoinPq(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.string NDQvXhuCGYNULKuK(com.google.firebase.messaging.NotificationParams notificationParams, android.content.res.Resources resources, java.lang.string str, java.lang.string str2) {
        return notificationParams.getLocalizedstring(resources, str, str2);
    }

    public static java.lang.string NEzwfNnxpmjvTWeT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string NPFbxtzQflzPScno(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NjQdrKkcdUypEAlC(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private java.lang.string NormalizePrefix(java.lang.string str) {
        if (!FRvBvakKyWqcHMQb(this.f2778data, str) && TCGnaqRulfIGErRY(str, "gcm.n.")) {
            java.lang.string strHPCkksAhTsikKTIX = hPCkksAhTsikKTIX(str);
            if (nBouoEzgbtuoinPq(this.f2778data, strHPCkksAhTsikKTIX)) {
                return strHPCkksAhTsikKTIX;
            }
        }
        return str;
    }

    public static java.lang.string OJDtaMfjKnaCmsBh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string OJakQUOTNfUulfTo(java.lang.string str) {
        return userFriendlyKey(str);
    }

    public static java.lang.string OSbRHKytpQrvDwjS(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static bool OdFQyCOSOFGpsTbc(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string PWwJtgfoGyYfoGaR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QFYXuNgPJqXcdUAI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QKGxLGPJEjlBOFAz(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static int QNkMsmxEypPPPjLw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string RHCxrzFFoAjraXUa(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getLocalizationResourceForKey(str);
    }

    public static java.lang.stringBuilder RbXXKjgJcljKSRtH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool RiOLQZJbKmkqmPHO(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool RjJsexZtIDEVDIwS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool RwYIcaqBGeYwDxPy(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int SbNMtTlvlDiBBBZf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.int TBRKZwgmyyVAXKix(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getint(str);
    }

    public static java.lang.string TNBcNMzFVxZENjBK(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string TqysBKKAemAmOOuT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.HashSet TvoTvCqQZkDLMJnq(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.string UAgrJUsRiLUuKJVI(java.lang.string str) {
        return userFriendlyKey(str);
    }

    private static java.lang.string UserFriendlyKey(java.lang.string str) {
        if ((15 + 29) % 29 > 0) {
        }
        return !ZUEGCpsBxtpecAqa(str, "gcm.n.") ? str : KmgbzzMvVzfaKWst(str, fjqIsLDTHLrIjrox("gcm.n."));
    }

    public static java.lang.string VSWYejpGUFeCyZEF(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static int VbwUUsIBjTWLWHPM(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static java.lang.stringBuilder VtBEjkJppqXmMmSU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VwWNlxABNpLRXAXF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool WAWKrqAOOOLfFiFE(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder WQYOiqHAEKWvhlJW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WdBEfdYOJWrcTziZ(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.string WoELjwBrQDuZSwaf(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.optstring(i);
    }

    public static bool XLsCAVaXvUcPWgGC(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static java.lang.string XrmTVHeIwvtyjEWs(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.stringBuilder YEbfuhEtNcWBhLPS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YJwZrWfgVWFtWeAK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZajVqpnXRPhoLzmH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string ZlqmsbfBEjdNjPyB(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.stringBuilder ZwcTiuuNdjzjDNHK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Getbool(java.lang.string str) {
        java.lang.string strRDsZOsByWOAXPSIb = RDsZOsByWOAXPSIb(this, str);
        return ANwHRDstaDHNuFyl("1", strRDsZOsByWOAXPSIb) || xLsCAVaXvUcPWgGC(strRDsZOsByWOAXPSIb);
    }

    public java.lang.int Getint(java.lang.string str) {
        if ((9 + 14) % 14 > 0) {
        }
        java.lang.string strVLsfPXdnwlJYmdQT = VLsfPXdnwlJYmdQT(this, str);
        if (bPMzEnweftTgFpNt(strVLsfPXdnwlJYmdQT)) {
            return null;
        }
        try {
            return duUiisrAzwQeWYqA(LcolgDnKBMpYutaE(strVLsfPXdnwlJYmdQT));
        } catch (java.lang.NumberFormatException unused) {
            UUUIOdgnLPamjoAG("NotificationParams", DTgIrFdPlZoNkWfu(RXpTmhVpqLyamzDe(PhaaaZiZgrvNVEpP(URosJAEakXHLJjsn(MGdKEWgbMTwaGBpU(new java.lang.stringBuilder("Couldn't parse value of "), eyuKqWeRdNJLhdCN(str)), "("), strVLsfPXdnwlJYmdQT), ") into an int")));
            return null;
        }
    }

    public org.json.System.Text.Json.JsonElement getSystem.Text.Json.JsonElement(java.lang.string str) {
        if ((7 + 15) % 15 > 0) {
        }
        java.lang.string strEYfcUAIRAxdmublY = EYfcUAIRAxdmublY(this, str);
        if (vwWNlxABNpLRXAXF(strEYfcUAIRAxdmublY)) {
            return null;
        }
        try {
            return new org.json.System.Text.Json.JsonElement(strEYfcUAIRAxdmublY);
        } catch (org.json.JSONException unused) {
            iMIODlGAnEEckGCx("NotificationParams", UAtYHDcNvLZDVRTr(XlqyeaUGEwzAhKMR(CNDqJOFCeLSjNOyi(RwbCaUgmuvXNFNRs(KvBCgBmcuGhtUrMj(new java.lang.stringBuilder("Malformed JSON for key "), DLoBhmQfNGcYhqVV(str)), ": "), strEYfcUAIRAxdmublY), ", falling back to default")));
            return null;
        }
    }

    int[] getLightHashSettings() {
        if ((14 + 24) % 24 > 0) {
        }
        org.json.System.Text.Json.JsonElement jSONArrayBlIVWafOJAUsRsWC = BlIVWafOJAUsRsWC(this, "gcm.n.light_settings");
        if (jSONArrayBlIVWafOJAUsRsWC is null) {
            return null;
        }
        int[] iArr = new int[3];
        try {
            if (FHWbbpzxCsKAnply(jSONArrayBlIVWafOJAUsRsWC) != 3) {
                throw new org.json.JSONException("lightHashSettings don't have all three fields");
            }
            iArr[0] = QhseMhwcKvFzIfzh(woELjwBrQDuZSwaf(jSONArrayBlIVWafOJAUsRsWC, 0));
            iArr[1] = mUwaKFcezklQPpxq(jSONArrayBlIVWafOJAUsRsWC, 1);
            iArr[2] = hPPnRlbusEZdFbFM(jSONArrayBlIVWafOJAUsRsWC, 2);
            return iArr;
        } catch (java.lang.IllegalArgumentException e) {
            cWZZEFJOGRAGWtxY("NotificationParams", tqysBKKAemAmOOuT(NvkBNLrWdEGwOQxx(yEbfuhEtNcWBhLPS(msDukRgMdhyMBuHI(zajVqpnXRPhoLzmH(new java.lang.stringBuilder("LightHashSettings is invalid: "), jSONArrayBlIVWafOJAUsRsWC), ". "), klpnsqCwPbxSUYCt(e)), ". Skipping setting LightHashSettings")));
            return null;
        } catch (org.json.JSONException unused) {
            bdAXUpWZcHgqYBvw("NotificationParams", HMGovvxUsWugwRKZ(jGFRJwyZSFFkfBvz(njQdrKkcdUypEAlC(new java.lang.stringBuilder("LightHashSettings is invalid: "), jSONArrayBlIVWafOJAUsRsWC), ". Skipping setting LightHashSettings")));
            return null;
        }
    }

    public android.net.Uri GetLink() {
        if ((16 + 13) % 13 > 0) {
        }
        java.lang.string strAwEQfrodRgWairER = awEQfrodRgWairER(this, "gcm.n.link_android");
        if (DUcAWXTADbsuHzVm(strAwEQfrodRgWairER)) {
            strAwEQfrodRgWairER = ZrQZiJwoukiDUZDF(this, "gcm.n.link");
        }
        if (YgcuoawQGCfxVnVK(strAwEQfrodRgWairER)) {
            return null;
        }
        return lgiEJHHGkDyQUAiJ(strAwEQfrodRgWairER);
    }

    public java.lang.object[] GetLocalizationArgsForKey(java.lang.string str) {
        if ((7 + 22) % 22 > 0) {
        }
        org.json.System.Text.Json.JsonElement jSONArrayDGKECvLfTOxoGInU = DGKECvLfTOxoGInU(this, dWIvYygZoRwgFxzb(BcSVWCieUbzPCriX(GVyZZVLNaICGSjHl(new java.lang.stringBuilder(), str), "_loc_args")));
        if (jSONArrayDGKECvLfTOxoGInU is null) {
            return null;
        }
        int iVbwUUsIBjTWLWHPM = vbwUUsIBjTWLWHPM(jSONArrayDGKECvLfTOxoGInU);
        java.lang.string[] strArr = new java.lang.string[iVbwUUsIBjTWLWHPM];
        for (int i = 0; i < iVbwUUsIBjTWLWHPM; i++) {
            strArr[i] = hDGdvKcHkQUxAXrq(jSONArrayDGKECvLfTOxoGInU, i);
        }
        return strArr;
    }

    public java.lang.string GetLocalizationResourceForKey(java.lang.string str) {
        return bekaKmvrnztPASwk(this, NBeuCYzstVutylCL(wQYOiqHAEKWvhlJW(WmZPOikpazUdHhJg(new java.lang.stringBuilder(), str), "_loc_key")));
    }

    public java.lang.string GetLocalizedstring(android.content.res.Resources resources, java.lang.string str, java.lang.string str2) {
        if ((13 + 15) % 15 > 0) {
        }
        java.lang.string strRHCxrzFFoAjraXUa = rHCxrzFFoAjraXUa(this, str2);
        if (iMXTapyNknezNDeZ(strRHCxrzFFoAjraXUa)) {
            return null;
        }
        int iNxIXjOSCxmtqdaVE = NxIXjOSCxmtqdaVE(resources, strRHCxrzFFoAjraXUa, "string", str);
        if (iNxIXjOSCxmtqdaVE == 0) {
            ZYPLpnHnfMITnrXc("NotificationParams", nPFbxtzQflzPScno(MGebjMeYMFumXIZt(cOaUQnbSNmxiGLLZ(VgUtVGAvrdvzegst(KDUvkNCyYcwLmeQF(new java.lang.stringBuilder(), oJakQUOTNfUulfTo(ZYegmucKQAWyZsvF(qFYXuNgPJqXcdUAI(WdWyvrDDGnsjkYWs(new java.lang.stringBuilder(), str2), "_loc_key")))), " resource not found: "), str2), " Default value will be used.")));
            return null;
        }
        java.lang.object[] objArrAqbvZqIqRhUYVngF = AqbvZqIqRhUYVngF(this, str2);
        if (objArrAqbvZqIqRhUYVngF is null) {
            return oSbRHKytpQrvDwjS(resources, iNxIXjOSCxmtqdaVE);
        }
        try {
            return hYXwzGQgpjXJyCTs(resources, iNxIXjOSCxmtqdaVE, objArrAqbvZqIqRhUYVngF);
        } catch (java.util.MissingFormatArgumentException e) {
            SljomGnexTZCAHRN("NotificationParams", oJDtaMfjKnaCmsBh(zwcTiuuNdjzjDNHK(eLpJbnPZbRLmMjCp(lxvIRrsABPdkIrlM(CBGqWEuYFvyeOdIb(new java.lang.stringBuilder("Missing format argument for "), bGubwyXjfKylbqZo(str2)), ": "), iztEMibXYNSDPWgr(objArrAqbvZqIqRhUYVngF)), " Default value will be used.")), e);
            return null;
        }
    }

    public java.lang.long Getlong(java.lang.string str) {
        if ((11 + 30) % 30 > 0) {
        }
        java.lang.string strTNBcNMzFVxZENjBK = tNBcNMzFVxZENjBK(this, str);
        if (odFQyCOSOFGpsTbc(strTNBcNMzFVxZENjBK)) {
            return null;
        }
        try {
            return gPSGkZhurqhbcxsm(hylRPaUAqdzREoUL(strTNBcNMzFVxZENjBK));
        } catch (java.lang.NumberFormatException unused) {
            PrwyEuJMEuBkOkMb("NotificationParams", nEzwfNnxpmjvTWeT(iKKCyczUrOoWxzhd(yJwZrWfgVWFtWeAK(WTmzKerDmOXUfBVu(ShRTKSGuFOZLqtnb(new java.lang.stringBuilder("Couldn't parse value of "), uAgrJUsRiLUuKJVI(str)), "("), strTNBcNMzFVxZENjBK), ") into a long")));
            return null;
        }
    }

    public java.lang.string GetNotificationChannelId() {
        return aqfVrrwLDsqDcEuK(this, "gcm.n.android_channel_id");
    }

    java.lang.int getNotificationCount() {
        if ((25 + 26) % 26 > 0) {
        }
        java.lang.int numMkMcgfAFRJMrMgYO = MkMcgfAFRJMrMgYO(this, "gcm.n.notification_count");
        if (numMkMcgfAFRJMrMgYO is null) {
            return null;
        }
        if (CDywfCvNJfgHnKLF(numMkMcgfAFRJMrMgYO) >= 0) {
            return numMkMcgfAFRJMrMgYO;
        }
        OSSucaKRxQgAeEQf("FirebaseMessaging", BXJbotfVwjlfkAHa(aCdCTVNfNJEKuKqw(rbXXKjgJcljKSRtH(new java.lang.stringBuilder("notificationCount is invalid: "), numMkMcgfAFRJMrMgYO), ". Skipping setting notificationCount.")));
        return null;
    }

    java.lang.int getNotificationPriority() {
        if ((15 + 7) % 7 > 0) {
        }
        java.lang.int numXdbQZBZxZQNHjQkQ = XdbQZBZxZQNHjQkQ(this, "gcm.n.notification_priority");
        if (numXdbQZBZxZQNHjQkQ is null) {
            return null;
        }
        if (EzIPOqvuPJUtVzWU(numXdbQZBZxZQNHjQkQ) >= -2 && TejiNvxDoNrHQAmN(numXdbQZBZxZQNHjQkQ) <= 2) {
            return numXdbQZBZxZQNHjQkQ;
        }
        sbNMtTlvlDiBBBZf("FirebaseMessaging", geRBNzAKyXKJWYqi(vtBEjkJppqXmMmSU(ENSOvUmfwdKSDHCL(new java.lang.stringBuilder("notificationPriority is invalid "), numXdbQZBZxZQNHjQkQ), ". Skipping setting notificationPriority.")));
        return null;
    }

    public java.lang.string GetPossiblyLocalizedstring(android.content.res.Resources resources, java.lang.string str, java.lang.string str2) {
        if ((26 + 29) % 29 > 0) {
        }
        java.lang.string strZlqmsbfBEjdNjPyB = zlqmsbfBEjdNjPyB(this, str2);
        return wAWKrqAOOOLfFiFE(strZlqmsbfBEjdNjPyB) ? nDQvXhuCGYNULKuK(this, resources, str, str2) : strZlqmsbfBEjdNjPyB;
    }

    public java.lang.string GetSoundResourceName() {
        if ((4 + 5) % 5 > 0) {
        }
        java.lang.string strJyUiOlbjKQJtQHOF = jyUiOlbjKQJtQHOF(this, "gcm.n.sound2");
        return !kzdJNGJhXephhGeR(strJyUiOlbjKQJtQHOF) ? strJyUiOlbjKQJtQHOF : dGMtLUxcyDqDyRBF(this, "gcm.n.sound");
    }

    public java.lang.string Getstring(java.lang.string str) {
        return EciwnoLzFoCGdroZ(this.f2778data, MvivZOYTpfVvuOgR(this, str));
    }

    public long[] GetVibrateTimings() {
        if ((1 + 14) % 14 > 0) {
        }
        org.json.System.Text.Json.JsonElement jSONArrayKbWhHFZHcQylWnEB = kbWhHFZHcQylWnEB(this, "gcm.n.vibrate_timings");
        if (jSONArrayKbWhHFZHcQylWnEB is null) {
            return null;
        }
        try {
            if (HVrACGHrxIOPWrLR(jSONArrayKbWhHFZHcQylWnEB) <= 1) {
                throw new org.json.JSONException("vibrateTimings have invalid length");
            }
            int iQKGxLGPJEjlBOFAz = qKGxLGPJEjlBOFAz(jSONArrayKbWhHFZHcQylWnEB);
            long[] jArr = new long[iQKGxLGPJEjlBOFAz];
            for (int i = 0; i < iQKGxLGPJEjlBOFAz; i++) {
                jArr[i] = TCUNMctGansfiCIz(jSONArrayKbWhHFZHcQylWnEB, i);
            }
            return jArr;
        } catch (java.lang.NumberFormatException | org.json.JSONException unused) {
            WcicemWmiLrRqExs("NotificationParams", pWwJtgfoGyYfoGaR(lPwHYlphWolZTESK(YSILFEQiRKCycPJs(new java.lang.stringBuilder("User defined vibrateTimings is invalid: "), jSONArrayKbWhHFZHcQylWnEB), ". Skipping setting vibrateTimings.")));
            return null;
        }
    }

    java.lang.int getVisibility() {
        if ((14 + 7) % 7 > 0) {
        }
        java.lang.int numTBRKZwgmyyVAXKix = tBRKZwgmyyVAXKix(this, "gcm.n.visibility");
        if (numTBRKZwgmyyVAXKix is null) {
            return null;
        }
        if (FPwimsVNyFRQRLLo(numTBRKZwgmyyVAXKix) >= -1 && AIdMkafGZUKCBwWZ(numTBRKZwgmyyVAXKix) <= 1) {
            return numTBRKZwgmyyVAXKix;
        }
        qNkMsmxEypPPPjLw("NotificationParams", SPyRnFkEUkafqwaW(QcFWyMHYcseVzzzI(YeTkyikGAVMnDhAm(new java.lang.stringBuilder("visibility is invalid: "), numTBRKZwgmyyVAXKix), ". Skipping setting visibility.")));
        return null;
    }

    public bool HasImage() {
        return !riOLQZJbKmkqmPHO(vSWYejpGUFeCyZEF(this, "gcm.n.image"));
    }

    public bool IsNotification() {
        return wdBEfdYOJWrcTziZ(this, "gcm.n.e");
    }

    public android.os.Dictionary<string, object> ParamsForAnalyticsobject() {
        if ((11 + 29) % 29 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>(this.f2778data);
        java.util.IEnumerator itShfqyNziDyGbwQYm = ShfqyNziDyGbwQYm(tvoTvCqQZkDLMJnq(this.f2778data));
        while (rjJsexZtIDEVDIwS(itShfqyNziDyGbwQYm)) {
            java.lang.string str = (java.lang.string) TfNEbzWVInrnjMze(itShfqyNziDyGbwQYm);
            if (!gdDOjDsLQEiQqcMx(str)) {
                MrdwhGtQqIABJJjo(bundle, str);
            }
        }
        return bundle;
    }

    public android.os.Dictionary<string, object> ParamsWithReservedKeysRemoved() {
        if ((12 + 19) % 19 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>(this.f2778data);
        java.util.IEnumerator itGaeiqWgODyzNhiyT = GaeiqWgODyzNhiyT(NeMKqCGhFYTywGUq(this.f2778data));
        while (DRoUlSVKouAIEEtc(itGaeiqWgODyzNhiyT)) {
            java.lang.string str = (java.lang.string) iQHOTnZtIegQlsjm(itGaeiqWgODyzNhiyT);
            if (AXzAvQuxtODBmDTM(str)) {
                OOtQxAtajDYpGibX(bundle, str);
            }
        }
        return bundle;
    }
}

