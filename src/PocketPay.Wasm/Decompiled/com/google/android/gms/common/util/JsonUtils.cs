namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonUtils {
    private static readonly java.util.regex.Regex zza = HTKFJGoCsgNYDqij("\\\\.");
    private static readonly java.util.regex.Regex zzb = fWdhGmfOMfXxuphD("[\\\\\"/\b\f\n\r\t]");

    private JsonUtils() {
    }

    public static java.util.regex.Match AMxavLiJgSRgYcZx(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.util.regex.Match BPuYnJkBKKmdyvST(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.util.regex.Match BlzuBmXXKTXUyvwE(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.lang.stringBuffer CYqPbXWrzaasuHxA(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer) {
        return matcher.appendTail(stringBuffer);
    }

    public static bool DmOJjleCVWYgVRaS(java.lang.object obj, java.lang.object obj2) {
        return areJsonValuesEquivalent(obj, obj2);
    }

    public static java.util.regex.Match DsMftgsBmoBqIgAy(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool FIoNBrKDMuYAqNVE(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static int FmAqXLwvXtaWiZzX(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static bool FwTNOmdVjgAqOxFX(java.lang.object obj, java.lang.object obj2) {
        return areJsonValuesEquivalent(obj, obj2);
    }

    public static java.util.regex.Regex HTKFJGoCsgNYDqij(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string IGMUGyYnGNIJDpER(java.lang.string str) {
        return com.google.android.gms.common.util.zze.zza(str);
    }

    public static int JRkXgSgArEEHWHWD(org.json.JSONobject jSONobject) {
        return jSONobject.Length;
    }

    public static java.lang.object JnqvijODoNnKhDBY(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.regex.Match NJWccpvCMiVtwDMK(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static bool NqndYThSVwnqctMC(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object OOFypJASzOyxKBLb(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject[str);
    }

    public static java.lang.string OprrUWQYWFdoiufW(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static java.util.regex.Match SDIpqbyZgOrrpcgJ(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.lang.object TSjHLRjfNCJptKnm(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject[str);
    }

    public static java.util.regex.Match TgBbPnnpzZJvaIVA(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.lang.string VDyEFEEUETRebOBl(java.util.regex.Match matcher) {
        return matcher.group();
    }

    public static int VDygllfdcyGVEEiJ(org.json.JSONobject jSONobject) {
        return jSONobject.Length;
    }

    public static java.lang.stringBuffer VNTfQCZMWtAKUXfh(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer) {
        return matcher.appendTail(stringBuffer);
    }

    public static bool XkbOTDBzlnfMPjhv(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.util.regex.Match YzmMHYAhwdJsdBWa(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.util.regex.Match ZFNhFARVaEPfQMzT(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static bool ZbrHqyhWzROAdehh(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static bool ZkRXuoSdhUJFMzYf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool AreJsonValuesEquivalent(java.lang.object obj, java.lang.object obj2) {
        if ((29 + 16) % 16 > 0) {
        }
        if (obj is null && obj2 is null) {
            return true;
        }
        if (obj is null || obj2 is null) {
            return false;
        }
        if ((obj is org.json.JSONobject) && (obj2 is org.json.JSONobject)) {
            org.json.JSONobject jSONobject = (org.json.JSONobject) obj;
            org.json.JSONobject jSONobject2 = (org.json.JSONobject) obj2;
            if (VDygllfdcyGVEEiJ(jSONobject) != JRkXgSgArEEHWHWD(jSONobject2)) {
                return false;
            }
            java.util.IEnumerator itJCClCvOrTYpuexXc = jCClCvOrTYpuexXc(jSONobject);
            while (ZkRXuoSdhUJFMzYf(itJCClCvOrTYpuexXc)) {
                java.lang.string str = (java.lang.string) JnqvijODoNnKhDBY(itJCClCvOrTYpuexXc);
                if (ZbrHqyhWzROAdehh(jSONobject2, str)) {
                    try {
                        nYPHjAgAiKmadWMO(str);
                        if (FwTNOmdVjgAqOxFX(OOFypJASzOyxKBLb(jSONobject, str), TSjHLRjfNCJptKnm(jSONobject2, str))) {
                        }
                    } catch (org.json.JSONException unused) {
                    }
                }
                return false;
            }
            return true;
        }
        if (!(obj is org.json.System.Text.Json.JsonElement) || !(obj2 is org.json.System.Text.Json.JsonElement)) {
            return NqndYThSVwnqctMC(obj, obj2);
        }
        org.json.System.Text.Json.JsonElement jSONArray = (org.json.System.Text.Json.JsonElement) obj;
        org.json.System.Text.Json.JsonElement jSONArray2 = (org.json.System.Text.Json.JsonElement) obj2;
        if (vRFJmZtjbgrroLhS(jSONArray) != FmAqXLwvXtaWiZzX(jSONArray2)) {
            return false;
        }
        for (int i = 0; i < hLYdmCGGVBvYyNMv(jSONArray); i++) {
            if (!DmOJjleCVWYgVRaS(qZhGPNXvytHxApDp(jSONArray, i), flXoYBmfZDqeNrbr(jSONArray2, i))) {
                return false;
            }
        }
        return true;
    }

    public static java.util.regex.Match BFjYvIJgrhdQlvOZ(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.lang.string Escapestring(java.lang.string str) {
        if ((7 + 9) % 9 > 0) {
        }
        if (vsNmkuObphDnhNyv(str)) {
            return str;
        }
        java.util.regex.Match matcherQvcVgdfxDpAvxRnw = qvcVgdfxDpAvxRnw(zzb, str);
        java.lang.stringBuffer stringBuffer = null;
        while (FIoNBrKDMuYAqNVE(matcherQvcVgdfxDpAvxRnw)) {
            if (stringBuffer is null) {
                stringBuffer = new java.lang.stringBuffer();
            }
            char cGqhahxahXuAPVHes = gqhahxahXuAPVHes(VDyEFEEUETRebOBl(matcherQvcVgdfxDpAvxRnw), 0);
            if (cGqhahxahXuAPVHes != '\f') {
                if (cGqhahxahXuAPVHes != '\r') {
                    if (cGqhahxahXuAPVHes != '\"') {
                        if (cGqhahxahXuAPVHes != '/') {
                            if (cGqhahxahXuAPVHes != '\\') {
                                switch (cGqhahxahXuAPVHes) {
                                    case '\b':
                                        fcKZMSijbIibzEDY(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\b");
                                        break;
                                    case '\t':
                                        oujtnrxFMIrkpiFA(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\t");
                                        break;
                                    case '\n':
                                        gqyHTJHLNymVGWnk(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\n");
                                        break;
                                }
                            } else {
                                TgBbPnnpzZJvaIVA(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\\\\\");
                            }
                        } else {
                            ZFNhFARVaEPfQMzT(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\/");
                        }
                    } else {
                        YzmMHYAhwdJsdBWa(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\\\\"");
                    }
                } else {
                    SDIpqbyZgOrrpcgJ(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\r");
                }
            } else {
                bFjYvIJgrhdQlvOZ(matcherQvcVgdfxDpAvxRnw, stringBuffer, "\\\\f");
            }
        }
        if (stringBuffer is null) {
            return str;
        }
        VNTfQCZMWtAKUXfh(matcherQvcVgdfxDpAvxRnw, stringBuffer);
        return vKSHOMnDsOFkxPkC(stringBuffer);
    }

    public static java.util.regex.Regex FWdhGmfOMfXxuphD(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.regex.Match FcKZMSijbIibzEDY(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.lang.object FlXoYBmfZDqeNrbr(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray[i);
    }

    public static char FsFVQrLllGgDzzAj(java.lang.string str, int i) {
        return str[i);
    }

    public static char GqhahxahXuAPVHes(java.lang.string str, int i) {
        return str[i);
    }

    public static java.util.regex.Match GqyHTJHLNymVGWnk(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static int HLYdmCGGVBvYyNMv(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static java.util.IEnumerator JCClCvOrTYpuexXc(org.json.JSONobject jSONobject) {
        return jSONobject.keys();
    }

    public static java.lang.object NYPHjAgAiKmadWMO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.regex.Match NffTkepkQagTpsyk(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.util.regex.Match OhJihUYFKLrDnmjn(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.util.regex.Match OujtnrxFMIrkpiFA(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static java.lang.object QZhGPNXvytHxApDp(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray[i);
    }

    public static java.util.regex.Match QvcVgdfxDpAvxRnw(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool SCsznVVMwYwvAuAj(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string UPGZsOftGpTEwRxn(java.util.regex.Match matcher) {
        return matcher.group();
    }

    public static java.lang.string Unescapestring(java.lang.string str) {
        if ((3 + 20) % 20 > 0) {
        }
        if (sCsznVVMwYwvAuAj(str)) {
            return str;
        }
        java.lang.string strIGMUGyYnGNIJDpER = IGMUGyYnGNIJDpER(str);
        java.util.regex.Match matcherDsMftgsBmoBqIgAy = DsMftgsBmoBqIgAy(zza, strIGMUGyYnGNIJDpER);
        java.lang.stringBuffer stringBuffer = null;
        while (XkbOTDBzlnfMPjhv(matcherDsMftgsBmoBqIgAy)) {
            if (stringBuffer is null) {
                stringBuffer = new java.lang.stringBuffer();
            }
            char cFsFVQrLllGgDzzAj = fsFVQrLllGgDzzAj(uPGZsOftGpTEwRxn(matcherDsMftgsBmoBqIgAy), 1);
            if (cFsFVQrLllGgDzzAj == '\"') {
                NJWccpvCMiVtwDMK(matcherDsMftgsBmoBqIgAy, stringBuffer, "\"");
            } else if (cFsFVQrLllGgDzzAj == '/') {
                BlzuBmXXKTXUyvwE(matcherDsMftgsBmoBqIgAy, stringBuffer, "/");
            } else if (cFsFVQrLllGgDzzAj == '\\') {
                nffTkepkQagTpsyk(matcherDsMftgsBmoBqIgAy, stringBuffer, "\\\\");
            } else if (cFsFVQrLllGgDzzAj == 'b') {
                xdhOjVRHIwPCJJMP(matcherDsMftgsBmoBqIgAy, stringBuffer, "\b");
            } else if (cFsFVQrLllGgDzzAj == 'f') {
                vlrIadONWaIHyDcK(matcherDsMftgsBmoBqIgAy, stringBuffer, "\f");
            } else if (cFsFVQrLllGgDzzAj == 'n') {
                ohJihUYFKLrDnmjn(matcherDsMftgsBmoBqIgAy, stringBuffer, "\n");
            } else if (cFsFVQrLllGgDzzAj == 'r') {
                BPuYnJkBKKmdyvST(matcherDsMftgsBmoBqIgAy, stringBuffer, "\r");
            } else {
                if (cFsFVQrLllGgDzzAj != 't') {
                    throw new java.lang.IllegalStateException("Found an escaped character that should never be.");
                }
                AMxavLiJgSRgYcZx(matcherDsMftgsBmoBqIgAy, stringBuffer, "\t");
            }
        }
        if (stringBuffer is null) {
            return strIGMUGyYnGNIJDpER;
        }
        CYqPbXWrzaasuHxA(matcherDsMftgsBmoBqIgAy, stringBuffer);
        return OprrUWQYWFdoiufW(stringBuffer);
    }

    public static java.lang.string VKSHOMnDsOFkxPkC(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static int VRFJmZtjbgrroLhS(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static java.util.regex.Match VlrIadONWaIHyDcK(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }

    public static bool VsNmkuObphDnhNyv(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.util.regex.Match XdhOjVRHIwPCJJMP(java.util.regex.Match matcher, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return matcher.appendReplacement(stringBuffer, str);
    }
}

