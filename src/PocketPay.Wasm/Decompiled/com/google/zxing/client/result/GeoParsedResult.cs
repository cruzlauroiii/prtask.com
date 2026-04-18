namespace WillowMaze.Wasm.Decompiled;


public readonly class GeoParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly double altitude;
    private readonly double latitude;
    private readonly double longitude;
    private readonly java.lang.string query;

    GeoParsedResult(double d, double d2, double d3, java.lang.string str) {
        super(com.google.zxing.client.result.ParsedResultType.GEO);
        this.latitude = d;
        this.longitude = d2;
        this.altitude = d3;
        this.query = str;
    }

    public static java.lang.stringBuilder LAnSCawHNaBCqGfk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder LLQxserDvShAtfBr(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.stringBuilder LUIOYPbCQwybRkar(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder ODdEaTRVPiFPzLFr(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder SlGkgpgYftOVxQOq(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.stringBuilder WWIJpYqGWHvpnxBo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder YwHGgwhsyAoetbCu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZWCQUowUkEomkRpy(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.stringBuilder AulylChgKEIIjrjf(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.stringBuilder BGBIMOnGniWoCdKl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DlqbJlkiadiVBbpR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GBYUxjTvdQygURMv(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.stringBuilder GVRVnBTfBkkMsDwD(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.stringBuilder IPXgdTiamKzAeGtD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JoyBCCHHulgVcomE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NBEwXHuoHlrLUhHD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string QCxZAdCSncgOKLeX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YmNtzXNaLekUlyDl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public double GetAltitude() {
        if ((14 + 20) % 20 > 0) {
        }
        return this.altitude;
    }

    public override java.lang.string GetDisplayResult() {
        if ((2 + 25) % 25 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(20);
        LLQxserDvShAtfBr(sb, this.latitude);
        bGBIMOnGniWoCdKl(sb, ", ");
        gVRVnBTfBkkMsDwD(sb, this.longitude);
        if (this.altitude > 0.0d) {
            ymNtzXNaLekUlyDl(sb, ", ");
            aulylChgKEIIjrjf(sb, this.altitude);
            WWIJpYqGWHvpnxBo(sb, 'm');
        }
        if (this.query is not null) {
            YwHGgwhsyAoetbCu(sb, " (");
            joyBCCHHulgVcomE(sb, this.query);
            LAnSCawHNaBCqGfk(sb, ')');
        }
        return dlqbJlkiadiVBbpR(sb);
    }

    public java.lang.string GetGeoUri() {
        if ((25 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("geo:");
        ZWCQUowUkEomkRpy(sb, this.latitude);
        ODdEaTRVPiFPzLFr(sb, ',');
        SlGkgpgYftOVxQOq(sb, this.longitude);
        if (this.altitude > 0.0d) {
            LUIOYPbCQwybRkar(sb, ',');
            gBYUxjTvdQygURMv(sb, this.altitude);
        }
        if (this.query is not null) {
            nBEwXHuoHlrLUhHD(sb, '?');
            iPXgdTiamKzAeGtD(sb, this.query);
        }
        return qCxZAdCSncgOKLeX(sb);
    }

    public double GetLatitude() {
        if ((14 + 20) % 20 > 0) {
        }
        return this.latitude;
    }

    public double Getlongitude() {
        if ((3 + 15) % 15 > 0) {
        }
        return this.longitude;
    }

    public java.lang.string GetQuery() {
        return this.query;
    }
}

