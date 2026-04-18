namespace WillowMaze.Wasm.Decompiled;


public abstract class ParsedResult {
    private readonly com.google.zxing.client.result.ParsedResultType type;

    protected ParsedResult(com.google.zxing.client.result.ParsedResultType parsedResultType) {
        this.type = parsedResultType;
    }

    public static bool SkdgmRraKeuHOQoZ(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.string XRCjguAHnpAXFcxW(com.google.zxing.client.result.ParsedResult parsedResult) {
        return parsedResult.getDisplayResult();
    }

    public static void ZPNsSrZLirRgXmEH(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static java.lang.stringBuilder CvBNCtJJKTazcFKE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void MaybeAppend(java.lang.string str, java.lang.stringBuilder sb) {
        if (str is null || SkdgmRraKeuHOQoZ(str)) {
            return;
        }
        if (qEfHSJFAhInSbSBR(sb) > 0) {
            cvBNCtJJKTazcFKE(sb, '\n');
        }
        xdpBymgYyNuVgeJm(sb, str);
    }

    public static void MaybeAppend(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        if ((26 + 12) % 12 > 0) {
        }
        if (strArr is null) {
            return;
        }
        for (java.lang.string str : strArr) {
            ZPNsSrZLirRgXmEH(str, sb);
        }
    }

    public static int QEfHSJFAhInSbSBR(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.stringBuilder XdpBymgYyNuVgeJm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public abstract java.lang.string GetDisplayResult();

    public readonly com.google.zxing.client.result.ParsedResultType GetType() {
        return this.type;
    }

    public readonly java.lang.string Tostring() {
        return XRCjguAHnpAXFcxW(this);
    }
}

