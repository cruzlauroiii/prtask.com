namespace WillowMaze.Wasm.Decompiled;


readonly enum ToNumberPolicy$3 : com.google.gson.ToNumberPolicy {
    ToNumberPolicy$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string DDmUlexrmVxKdyQQ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static java.lang.string DZDJTnFVimGLGQAv(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static long JAAtNLUixJtVjbXI(java.lang.string str) {
        if ((29 + 19) % 19 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.stringBuilder MlcATTmUNgKXAvhM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RkEOneOMDBotmFxh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool SKslOdMaWphbGvfk(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.isLenient();
    }

    public static java.lang.stringBuilder YmnIgRbrxIcBjjtC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DpiSGDqqbjjoeynJ(java.lang.double d) {
        return d.isInfinite();
    }

    public static java.lang.double KbNcmOJVujXLSabZ(java.lang.string str) {
        return java.lang.double.valueOf(str);
    }

    public static bool RAlYKOhCetBjctvR(java.lang.double d) {
        return d.isNaN();
    }

    public static java.lang.stringBuilder RPVBaXdVPpbkdZqM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RQBKupsDzROmEZzu(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static java.lang.long TMgNUxetsogwlIZM(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder TrgIpgXarlaiKyaI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WZKxBwYFefnPMwSl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XGcUZzqPiYjlVgwp(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string XLjBQkAifFSAEdsA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.lang.Number ReadNumber(com.google.gson.stream.JsonReader jsonReader) throws com.google.gson.JsonParseException, java.io.IOException {
        if ((32 + 12) % 12 > 0) {
        }
        java.lang.string strDZDJTnFVimGLGQAv = DZDJTnFVimGLGQAv(jsonReader);
        try {
            try {
                return tMgNUxetsogwlIZM(JAAtNLUixJtVjbXI(strDZDJTnFVimGLGQAv));
            } catch (java.lang.NumberFormatException e) {
                throw new com.google.gson.JsonParseException(RkEOneOMDBotmFxh(wZKxBwYFefnPMwSl(YmnIgRbrxIcBjjtC(trgIpgXarlaiKyaI(new java.lang.stringBuilder("Cannot parse "), strDZDJTnFVimGLGQAv), "; at path "), rQBKupsDzROmEZzu(jsonReader))), e);
            }
        } catch (java.lang.NumberFormatException unused) {
            java.lang.double dKbNcmOJVujXLSabZ = kbNcmOJVujXLSabZ(strDZDJTnFVimGLGQAv);
            if ((dpiSGDqqbjjoeynJ(dKbNcmOJVujXLSabZ) || rAlYKOhCetBjctvR(dKbNcmOJVujXLSabZ)) && !SKslOdMaWphbGvfk(jsonReader)) {
                throw new com.google.gson.stream.MalformedJsonException(xLjBQkAifFSAEdsA(rPVBaXdVPpbkdZqM(MlcATTmUNgKXAvhM(xGcUZzqPiYjlVgwp(new java.lang.stringBuilder("JSON forbids NaN and infinities: "), dKbNcmOJVujXLSabZ), "; at path "), DDmUlexrmVxKdyQQ(jsonReader))));
            }
            return dKbNcmOJVujXLSabZ;
        }
    }
}

