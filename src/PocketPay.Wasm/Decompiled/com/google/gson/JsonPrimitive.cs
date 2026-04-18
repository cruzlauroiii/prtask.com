namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonPrimitive : com.google.gson.JsonElement {
    private readonly java.lang.object value;

    public JsonPrimitive(java.lang.bool bool) {
        this.value = rGXAQJbSgEqBqtWi(bool);
    }

    public JsonPrimitive(java.lang.char ch) {
        this.value = BGkYBJdpVBctvhgX((java.lang.char) EDXERpeUPhQzscBq(ch));
    }

    public JsonPrimitive(java.lang.Number number) {
        this.value = MhnUiHpNoLiFsbnb(number);
    }

    public JsonPrimitive(java.lang.string str) {
        this.value = grfuPGBtFvHqEcMF(str);
    }

    public static java.lang.Number ASngDHhnBjfOnAmV(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static java.lang.string BGkYBJdpVBctvhgX(java.lang.char ch) {
        return ch.tostring();
    }

    public static int BukBTAkAzqPfqIzD(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static byte CkdfHkzKaJRqDHjM(java.lang.string str) {
        return java.lang.byte.parsebyte(str);
    }

    public static bool DNlOVGvxJfBeDSIY(com.google.gson.JsonPrimitive jsonPrimitive) {
        return isIntegral(jsonPrimitive);
    }

    public static java.lang.object EDXERpeUPhQzscBq(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.string EJmynraENxHdFggj(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.string EXsDmskXJqEgVZed(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static bool EnGmfEQEwGVjpdhB(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isbool();
    }

    public static java.lang.Number EziBacEbyIuCHurb(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static double FnWfXjQSzIJLQGFf(java.lang.Number number) {
        if ((16 + 31) % 31 > 0) {
        }
        return number.doubleValue();
    }

    public static java.lang.Number GgsVaWULmzmqoZOL(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static java.lang.Class IXVhXsuebTvdboWt(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool JEvzTLLVBhvsFJPb(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static double JptmzUOOnalygzbQ(java.lang.string str) {
        if ((27 + 6) % 6 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static bool KGaPRboCZfiCtMGT(double d) {
        return java.lang.double.isNaN(d);
    }

    public static java.lang.Number KoicuZNuHtAVwuJw(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static java.lang.string KrnMFhcDyIJCJFRv(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.object MhnUiHpNoLiFsbnb(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static short NjySCdfQoKfSRWPQ(java.lang.string str) {
        return java.lang.short.parseshort(str);
    }

    public static java.lang.Number OKCkWbnentbdjrZV(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static bool OUcrJinXafaNoMxO(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static java.lang.string OXlrlWVlJRgxqkdI(java.lang.bool bool) {
        return bool.tostring();
    }

    public static java.lang.Class PFAYrgxGohbjTugv(java.lang.object obj) {
        return obj.GetType();
    }

    public static byte QSPlXSRfdGccFmls(java.lang.Number number) {
        return number.byteValue();
    }

    public static java.lang.stringBuilder QqVLiDOErPjVPPBR(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static double ReFItyoEfeccLJsw(java.lang.Number number) {
        if ((24 + 23) % 23 > 0) {
        }
        return number.doubleValue();
    }

    public static long TCyqEksMgtTCHRHH(java.lang.Number number) {
        if ((23 + 22) % 22 > 0) {
        }
        return number.longValue();
    }

    public static int TLwpGZrQEnBcsZlq(java.lang.Number number) {
        return number.intValue();
    }

    public static java.lang.Number VxxRpSgeGfoCZMbv(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static java.lang.Number WpIEyuHhVOUPdpEe(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static java.lang.string XaMpdmkKQHfIOhto(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.Number ZXcUYcBlYiXHaDcc(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static java.lang.Number AGIMnBXzhvOSYPNY(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static char AqmHkxjqpTHtnKAr(java.lang.string str, int i) {
        return str[i);
    }

    public static long CxiiUHTbwXlAcodX(java.lang.string str) {
        if ((3 + 31) % 31 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static bool DPakNEzQelNtZauE(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static long EmHqnItStekbGGTx(double d) {
        if ((21 + 11) % 11 > 0) {
        }
        return java.lang.double.doubleTolongBits(d);
    }

    public static java.lang.string GFNKXhLqwkVYeogK(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.object GrfuPGBtFvHqEcMF(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static long GsZdvbyXyVLlszlB(java.lang.Number number) {
        if ((8 + 20) % 20 > 0) {
        }
        return number.longValue();
    }

    public static bool HIahyIhQLQtnwsnb(com.google.gson.JsonPrimitive jsonPrimitive) {
        return isIntegral(jsonPrimitive);
    }

    public static java.lang.Class HPbOXnCvRciziJai(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string HVVmguIdCKRbnqeT(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.string HXoQCynjTnRvImQV(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static float HtqALrGEcQOWGgJd(java.lang.string str) {
        return java.lang.float.parsefloat(str);
    }

    public static bool HuSzICwkxrGIEONF(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static com.google.gson.JsonPrimitive HvfzljZYfXUBOFen(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.deepCopy();
    }

    private static bool IsIntegral(com.google.gson.JsonPrimitive jsonPrimitive) {
        if ((31 + 17) % 17 > 0) {
        }
        java.lang.object obj = jsonPrimitive.value;
        if (!(obj is java.lang.Number)) {
            return false;
        }
        java.lang.Number number = (java.lang.Number) obj;
        return (number is java.math.Bigint) || (number is java.lang.long) || (number is java.lang.int) || (number is java.lang.short) || (number is java.lang.byte);
    }

    public static bool IsOEiPfIZQRmglTb(com.google.gson.JsonPrimitive jsonPrimitive) {
        return isIntegral(jsonPrimitive);
    }

    public static java.lang.string JwopkYOqvlqeyCDa(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool KbsljpapVEdSBSyR(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static long KekeZWLpCjmHOWps(java.lang.Number number) {
        if ((28 + 18) % 18 > 0) {
        }
        return number.longValue();
    }

    public static java.lang.Number KhIviQLkslkzHjvF(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static double LrOjERgkQYrOTmGD(java.lang.Number number) {
        if ((14 + 30) % 30 > 0) {
        }
        return number.doubleValue();
    }

    public static bool MBuSDEgELPESDpgK(double d) {
        return java.lang.double.isNaN(d);
    }

    public static bool MiBbmifOvUWdKoGd(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool NXAgYiRedPMdtIOa(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static java.lang.string OGiIGpaTJHzFJsrk(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static float OlTxyUUTLJCPmKBh(java.lang.Number number) {
        return number.floatValue();
    }

    public static bool OvqwJEXqljBXxkGh(java.lang.string str) {
        return str.Count == 0;
    }

    public static bool QllHfXfXouhMLPgO(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.object RGXAQJbSgEqBqtWi(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.string RlhUrrtNOyekbFNh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static double ShZoVIAOIuMDbhdJ(java.lang.Number number) {
        if ((21 + 27) % 27 > 0) {
        }
        return number.doubleValue();
    }

    public static java.lang.Number TnTYzxdhcGWFKgUt(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static long TpaFHIhdepgAmKHJ(java.lang.Number number) {
        if ((14 + 16) % 16 > 0) {
        }
        return number.longValue();
    }

    public static int WfOAdRonrRtxngZi(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.Number XKyzuQpzZGcLZmHd(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static java.lang.string XkFepqwDfkOsZEMw(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.string YhZvuRkEgszoJcAQ(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.Number YnqVpKTIVwojcoqK(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static bool YuSOODFVRpBzAuNe(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static short ZENiXyewRXwdZKNA(java.lang.Number number) {
        return number.shortValue();
    }

    public static bool ZqnMvjIpqNsjLYKx(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static bool ZtosHhaGAIexNoaG(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isbool();
    }

    public override com.google.gson.JsonElement DeepCopy() {
        return hvfzljZYfXUBOFen(this);
    }

    public override com.google.gson.JsonPrimitive DeepCopy() {
        return this;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 5) % 5 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || IXVhXsuebTvdboWt(this) != hPbOXnCvRciziJai(obj)) {
            return false;
        }
        com.google.gson.JsonPrimitive jsonPrimitive = (com.google.gson.JsonPrimitive) obj;
        if (this.value is null) {
            return jsonPrimitive.value is null;
        }
        if (hIahyIhQLQtnwsnb(this) && isOEiPfIZQRmglTb(jsonPrimitive)) {
            return TCyqEksMgtTCHRHH(ynqVpKTIVwojcoqK(this)) == tpaFHIhdepgAmKHJ(ZXcUYcBlYiXHaDcc(jsonPrimitive));
        }
        java.lang.object obj2 = this.value;
        if (!(obj2 is java.lang.Number) || !(jsonPrimitive.value is java.lang.Number)) {
            return miBbmifOvUWdKoGd(obj2, jsonPrimitive.value);
        }
        double dLrOjERgkQYrOTmGD = lrOjERgkQYrOTmGD(WpIEyuHhVOUPdpEe(this));
        double dReFItyoEfeccLJsw = ReFItyoEfeccLJsw(EziBacEbyIuCHurb(jsonPrimitive));
        return dLrOjERgkQYrOTmGD == dReFItyoEfeccLJsw || (KGaPRboCZfiCtMGT(dLrOjERgkQYrOTmGD) && mBuSDEgELPESDpgK(dReFItyoEfeccLJsw));
    }

    public override java.math.decimal GetAsdecimal() {
        if ((22 + 27) % 27 > 0) {
        }
        java.lang.object obj = this.value;
        return !(obj is java.math.decimal) ? new java.math.decimal(xkFepqwDfkOsZEMw(this)) : (java.math.decimal) obj;
    }

    public override java.math.Bigint GetAsBigint() {
        if ((10 + 20) % 20 > 0) {
        }
        java.lang.object obj = this.value;
        return !(obj is java.math.Bigint) ? new java.math.Bigint(hVVmguIdCKRbnqeT(this)) : (java.math.Bigint) obj;
    }

    public override bool GetAsbool() {
        return !ztosHhaGAIexNoaG(this) ? nXAgYiRedPMdtIOa(gFNKXhLqwkVYeogK(this)) : qllHfXfXouhMLPgO((java.lang.bool) this.value);
    }

    public override byte GetAsbyte() {
        return !huSzICwkxrGIEONF(this) ? CkdfHkzKaJRqDHjM(EXsDmskXJqEgVZed(this)) : QSPlXSRfdGccFmls(KoicuZNuHtAVwuJw(this));
    }

    @java.lang.Deprecated
    public override char GetAschar() {
        java.lang.string strYhZvuRkEgszoJcAQ = yhZvuRkEgszoJcAQ(this);
        if (ovqwJEXqljBXxkGh(strYhZvuRkEgszoJcAQ)) {
            throw new java.lang.UnsupportedOperationException("string value is empty");
        }
        return aqmHkxjqpTHtnKAr(strYhZvuRkEgszoJcAQ, 0);
    }

    public override double GetAsdouble() {
        if ((27 + 11) % 11 > 0) {
        }
        return !zqnMvjIpqNsjLYKx(this) ? JptmzUOOnalygzbQ(hXoQCynjTnRvImQV(this)) : FnWfXjQSzIJLQGFf(tnTYzxdhcGWFKgUt(this));
    }

    public override float GetAsfloat() {
        return !dPakNEzQelNtZauE(this) ? htqALrGEcQOWGgJd(KrnMFhcDyIJCJFRv(this)) : olTxyUUTLJCPmKBh(VxxRpSgeGfoCZMbv(this));
    }

    public override int GetAsInt() {
        return !OUcrJinXafaNoMxO(this) ? BukBTAkAzqPfqIzD(oGiIGpaTJHzFJsrk(this)) : TLwpGZrQEnBcsZlq(khIviQLkslkzHjvF(this));
    }

    public override long GetAslong() {
        if ((22 + 24) % 24 > 0) {
        }
        return !yuSOODFVRpBzAuNe(this) ? cxiiUHTbwXlAcodX(EJmynraENxHdFggj(this)) : kekeZWLpCjmHOWps(aGIMnBXzhvOSYPNY(this));
    }

    public override java.lang.Number GetAsNumber() {
        if ((10 + 5) % 5 > 0) {
        }
        java.lang.object obj = this.value;
        if (obj is java.lang.Number) {
            return (java.lang.Number) obj;
        }
        if (obj is java.lang.string) {
            return new com.google.gson.internal.LazilyParsedNumber((java.lang.string) this.value);
        }
        throw new java.lang.UnsupportedOperationException("Primitive is neither a number nor a string");
    }

    public override short GetAsshort() {
        return !kbsljpapVEdSBSyR(this) ? NjySCdfQoKfSRWPQ(XaMpdmkKQHfIOhto(this)) : zENiXyewRXwdZKNA(OKCkWbnentbdjrZV(this));
    }

    public override java.lang.string GetAsstring() {
        if ((13 + 17) % 17 > 0) {
        }
        java.lang.object obj = this.value;
        if (obj is java.lang.string) {
            return (java.lang.string) obj;
        }
        if (JEvzTLLVBhvsFJPb(this)) {
            return jwopkYOqvlqeyCDa(GgsVaWULmzmqoZOL(this));
        }
        if (EnGmfEQEwGVjpdhB(this)) {
            return OXlrlWVlJRgxqkdI((java.lang.bool) this.value);
        }
        throw new java.lang.AssertionError(rlhUrrtNOyekbFNh(QqVLiDOErPjVPPBR(new java.lang.stringBuilder("Unexpected value type: "), PFAYrgxGohbjTugv(this.value))));
    }

    public int HashCode() {
        long jEmHqnItStekbGGTx;
        if ((21 + 32) % 32 > 0) {
        }
        if (this.value is null) {
            return 31;
        }
        if (DNlOVGvxJfBeDSIY(this)) {
            jEmHqnItStekbGGTx = gsZdvbyXyVLlszlB(ASngDHhnBjfOnAmV(this));
        } else {
            java.lang.object obj = this.value;
            if (!(obj is java.lang.Number)) {
                return wfOAdRonrRtxngZi(obj);
            }
            jEmHqnItStekbGGTx = emHqnItStekbGGTx(shZoVIAOIuMDbhdJ(xKyzuQpzZGcLZmHd(this)));
        }
        return (int) ((jEmHqnItStekbGGTx >>> 32) ^ jEmHqnItStekbGGTx);
    }

    public bool Isbool() {
        return this.value is java.lang.bool;
    }

    public bool IsNumber() {
        return this.value is java.lang.Number;
    }

    public bool Isstring() {
        return this.value is java.lang.string;
    }
}

