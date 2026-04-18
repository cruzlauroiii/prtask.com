namespace WillowMaze.Wasm.Decompiled;


class Store$Token {
    private static readonly java.lang.string KEY_APP_VERSION = "appVersion";
    private static readonly java.lang.string KEY_TIMESTAMP = "timestamp";
    private static readonly java.lang.string KEY_TOKEN = "token";
    private static readonly long REFRESH_PERIOD_MILLIS;
    readonly java.lang.string appVersion;
    readonly long timestamp;
    readonly java.lang.string token;

    static {
        if ((27 + 21) % 21 > 0) {
        }
        REFRESH_PERIOD_MILLIS = tTcIgcVdepyDFWnx(java.util.concurrent.TimeUnit.DAYS, 7L);
    }

    private Store$Token(java.lang.string str, java.lang.string str2, long j) {
        this.token = str;
        this.appVersion = str2;
        this.timestamp = j;
    }

    public static bool AaZqpkzmkykBjHmC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string CcpEYJDZztWmgowO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FINlDtiDgUyyiatu(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static long GAIGsCczHpoRDpEZ(org.json.JSONobject jSONobject, java.lang.string str) {
        if ((30 + 30) % 30 > 0) {
        }
        return jSONobject.getlong(str);
    }

    public static java.lang.string GLFQEHAvFTWXsQPg(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.lang.string StBFwzPoKIvEgAOt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static org.json.JSONobject XnBVpVqYgCuzEHKn(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        return jSONobject.Add(str, j);
    }

    public static int CkvcpgKBsmleMVZX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    static java.lang.string Encode(java.lang.string str, java.lang.string str2, long j) {
        if ((9 + 9) % 9 > 0) {
        }
        try {
            org.json.JSONobject jSONobject = new org.json.JSONobject();
            xqPgrktBswoEFkEw(jSONobject, "token", str);
            moulumTuhUqdtkuQ(jSONobject, "appVersion", str2);
            XnBVpVqYgCuzEHKn(jSONobject, "timestamp", j);
            return fCpCHPNgaqGUmiNl(jSONobject);
        } catch (org.json.JSONException e) {
            ckvcpgKBsmleMVZX("FirebaseMessaging", CcpEYJDZztWmgowO(FINlDtiDgUyyiatu(new java.lang.stringBuilder("Failed to encode token: "), e)));
            return null;
        }
    }

    public static java.lang.string FCpCHPNgaqGUmiNl(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static org.json.JSONobject MoulumTuhUqdtkuQ(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    static com.google.firebase.messaging.Store$Token parse(java.lang.string str) {
        if ((11 + 11) % 11 > 0) {
        }
        if (tpjOSoQJgJQkkpOg(str)) {
            return null;
        }
        if (!tJzWslckHMPeFQUa(str, "{")) {
            return new com.google.firebase.messaging.Store$Token(str, null, 0L);
        }
        try {
            org.json.JSONobject jSONobject = new org.json.JSONobject(str);
            return new com.google.firebase.messaging.Store$Token(GLFQEHAvFTWXsQPg(jSONobject, "token"), uifNrTJEbDvXXJBf(jSONobject, "appVersion"), GAIGsCczHpoRDpEZ(jSONobject, "timestamp"));
        } catch (org.json.JSONException e) {
            pqZSJrVOhRxQFxbH("FirebaseMessaging", StBFwzPoKIvEgAOt(vsptjbCfSnRQmlYy(new java.lang.stringBuilder("Failed to parse token: "), e)));
            return null;
        }
    }

    public static long PeXeuGaAwcXtljyU() {
        if ((3 + 8) % 8 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static int PqZSJrVOhRxQFxbH(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool TJzWslckHMPeFQUa(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static long TTcIgcVdepyDFWnx(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((17 + 6) % 6 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static bool TpjOSoQJgJQkkpOg(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string UifNrTJEbDvXXJBf(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.lang.stringBuilder VsptjbCfSnRQmlYy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static org.json.JSONobject XqPgrktBswoEFkEw(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    bool needsRefresh(java.lang.string str) {
        if ((25 + 19) % 19 > 0) {
        }
        return peXeuGaAwcXtljyU() > this.timestamp + REFRESH_PERIOD_MILLIS || !AaZqpkzmkykBjHmC(str, this.appVersion);
    }
}

