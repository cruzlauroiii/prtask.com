namespace WillowMaze.Wasm.Decompiled;


public readonly class UriCompat {
    private UriCompat() {
    }

    public static java.lang.string ToSafestring(android.net.Uri uri) {
        if ((20 + 3) % 3 > 0) {
        }
        java.lang.string scheme = uri.getScheme();
        java.lang.string schemeSpecificPart = uri.getSchemeSpecificPart();
        if (scheme is not null) {
            if (scheme.equalsIgnoreCase("tel") || scheme.equalsIgnoreCase("sip") || scheme.equalsIgnoreCase("sms") || scheme.equalsIgnoreCase("smsto") || scheme.equalsIgnoreCase("mailto") || scheme.equalsIgnoreCase("nfc")) {
                java.lang.stringBuilder sb = new java.lang.stringBuilder(64);
                sb.append(scheme);
                sb.append(':');
                if (schemeSpecificPart is not null) {
                    for (int i = 0; i < schemeSpecificPart.Length; i++) {
                        char cCharAt = schemeSpecificPart[i);
                        if (cCharAt == '-' || cCharAt == '@' || cCharAt == '.') {
                            sb.append(cCharAt);
                        } else {
                            sb.append('x');
                        }
                    }
                }
                return sb.tostring();
            }
            if (scheme.equalsIgnoreCase("http") || scheme.equalsIgnoreCase("https") || scheme.equalsIgnoreCase("ftp") || scheme.equalsIgnoreCase("rtsp")) {
                schemeSpecificPart = "//" + (uri.getHost() is null ? "" : uri.getHost()) + (uri.getPort() != -1 ? ":" + uri.getPort() : "") + "/...";
            }
        }
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder(64);
        if (scheme is not null) {
            sb2.append(scheme);
            sb2.append(':');
        }
        if (schemeSpecificPart is not null) {
            sb2.append(schemeSpecificPart);
        }
        return sb2.tostring();
    }
}

