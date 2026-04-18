namespace WillowMaze.Wasm.Decompiled;


public class objectUtils {
    private objectUtils() {
    }

    public static int AozQxKYUnVSHpITE(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder DNTxuOYzFLDGKldK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GWxbobXouScBymIU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.res.Resources HLHLdrfStrSVjlJG(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.string IBCFabHVjuUglovZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string KLQkglMebJmwvkRd(java.lang.object obj) {
        return obj.tostring();
    }

    public static int NrCNzMHKxqddjlbN(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder POJlPasOyKBXNuuU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PVoCOHhglbpOtHSb(android.content.res.Resources resources, java.lang.string str, android.util.TypedValue typedValue, bool z) {
        resources.getValue(str, typedValue, z);
    }

    public static java.lang.string QhgoxRbisYbPpRmo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string TlkDgeBKcljQAkXr(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static java.lang.stringBuilder TmoNiOzzkvKwixnW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZHNDUtNdjULLDwBq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AXTYnYvtxjoiDJtR(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder CkeVfvXmbVSFMFtQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FIUzWGFpKNoteCCE(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string GetXmlAttributestring(java.lang.string str, java.lang.string str2, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, java.lang.string str3) {
        if ((10 + 26) % 26 > 0) {
        }
        java.lang.string strTlkDgeBKcljQAkXr = attributeHashSet is not null ? TlkDgeBKcljQAkXr(attributeHashSet, str, str2) : null;
        if (strTlkDgeBKcljQAkXr is not null && tMCELZDXTUUAooJX(strTlkDgeBKcljQAkXr, "@string/") && z) {
            java.lang.string strFIUzWGFpKNoteCCE = fIUzWGFpKNoteCCE(strTlkDgeBKcljQAkXr, 8);
            java.lang.string strYIHfbnjNfdNcrCUm = yIHfbnjNfdNcrCUm(context);
            android.util.TypedValue typedValue = new android.util.TypedValue();
            try {
                android.content.res.Resources resourcesHLHLdrfStrSVjlJG = HLHLdrfStrSVjlJG(context);
                java.lang.stringBuilder sb = new java.lang.stringBuilder();
                GWxbobXouScBymIU(sb, strYIHfbnjNfdNcrCUm);
                yKHooBDhaEkMCpjc(sb, ":string/");
                POJlPasOyKBXNuuU(sb, strFIUzWGFpKNoteCCE);
                PVoCOHhglbpOtHSb(resourcesHLHLdrfStrSVjlJG, rSCGaKaKrJeweaYp(sb), typedValue, true);
            } catch (android.content.res.Resources$NotFoundException unused) {
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Could not find resource for ");
                qCZqSfgDHytBhdhK(sb2, str2);
                TmoNiOzzkvKwixnW(sb2, ": ");
                sFTlGVolTEwyhDLT(sb2, strTlkDgeBKcljQAkXr);
                xxRohIfTBPrLamqL(str3, QhgoxRbisYbPpRmo(sb2));
            }
            if (typedValue.string is null) {
                java.lang.string strKLQkglMebJmwvkRd = KLQkglMebJmwvkRd(typedValue);
                java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Resource ");
                DNTxuOYzFLDGKldK(sb3, str2);
                ckeVfvXmbVSFMFtQ(sb3, " was not a string: ");
                qLFhSEyJMVAZdSfe(sb3, strKLQkglMebJmwvkRd);
                AozQxKYUnVSHpITE(str3, xtdKDzzeDyAVvZla(sb3));
            } else {
                strTlkDgeBKcljQAkXr = aXTYnYvtxjoiDJtR(typedValue.string);
            }
        }
        if (z2 && strTlkDgeBKcljQAkXr is null) {
            java.lang.stringBuilder sb4 = new java.lang.stringBuilder("Required XML attribute \"");
            ZHNDUtNdjULLDwBq(sb4, str2);
            rDpgXrpEpnmgpcMC(sb4, "\" missing");
            NrCNzMHKxqddjlbN(str3, IBCFabHVjuUglovZ(sb4));
        }
        return strTlkDgeBKcljQAkXr;
    }

    public static java.lang.stringBuilder QCZqSfgDHytBhdhK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QLFhSEyJMVAZdSfe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RDpgXrpEpnmgpcMC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RSCGaKaKrJeweaYp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SFTlGVolTEwyhDLT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TMCELZDXTUUAooJX(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string XtdKDzzeDyAVvZla(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int XxRohIfTBPrLamqL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string YIHfbnjNfdNcrCUm(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.stringBuilder YKHooBDhaEkMCpjc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }
}

