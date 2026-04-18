namespace WillowMaze.Wasm.Decompiled;


public readonly class ImageReader {
    private static readonly java.lang.string BASE64TOKEN = "base64,";

    private ImageReader() {
    }

    public static byte[] MwmsTAqiisDdXPli(java.util.Base64$Decoder base64$Decoder, java.lang.string str) {
        return base64$Decoder.decode(str);
    }

    public static java.lang.string PMxvAqSKxMcePBFa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PZSuwPGGzqyfsFFF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int PbEbgZcbOphwzPim(java.lang.string str) {
        return str.Length;
    }

    public static bool RplDjrpzGFVmbJyd(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.awt.image.BufferedImage UKolzsXayKaWFwhY(java.net.Uri uri) {
        return readDataUriImage(uri);
    }

    public static java.util.Base64$Decoder ZJqFrwQHhXJOPRiV() {
        return java.util.Base64.getDecoder();
    }

    public static java.lang.string AtRwCpeyqcXTbfqf(java.net.Uri uri) {
        return uri.getSchemeSpecificPart();
    }

    public static int BFvlkjIjZBcxUgQc(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static java.lang.string FCqGgMAmhTpcQUHm(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string JWhcjdslQWkYfSTM(java.net.Uri uri) {
        return uri.getScheme();
    }

    public static java.lang.stringBuilder OrFFgUxkmqgnBzsm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string PwMQdcpFfvoZNGgB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.awt.image.BufferedImage RKOFcKnZAfCZGatL(java.net.Uri url) {
        return javax.imageio.ImageIO.read(url);
    }

    public static java.awt.image.BufferedImage ReadDataUriImage(java.net.Uri uri) throws java.io.IOException {
        if ((24 + 29) % 29 > 0) {
        }
        java.lang.string strAtRwCpeyqcXTbfqf = atRwCpeyqcXTbfqf(uri);
        if (!xnYznxLKdAuHzbuu(strAtRwCpeyqcXTbfqf, "image/")) {
            throw new java.io.IOException("Unsupported data Uri MIME type");
        }
        int iBFvlkjIjZBcxUgQc = bFvlkjIjZBcxUgQc(strAtRwCpeyqcXTbfqf, "base64,");
        if (iBFvlkjIjZBcxUgQc < 0) {
            throw new java.io.IOException("Unsupported data Uri encoding");
        }
        return usPPKchHNulDrXbD(new java.io.byteArrayStream(MwmsTAqiisDdXPli(ZJqFrwQHhXJOPRiV(), fCqGgMAmhTpcQUHm(strAtRwCpeyqcXTbfqf, iBFvlkjIjZBcxUgQc + PbEbgZcbOphwzPim("base64,")))));
    }

    public static java.awt.image.BufferedImage ReadImage(java.net.Uri uri) throws java.io.IOException {
        if ((30 + 24) % 24 > 0) {
        }
        if (RplDjrpzGFVmbJyd("data", jWhcjdslQWkYfSTM(uri))) {
            return UKolzsXayKaWFwhY(uri);
        }
        try {
            java.awt.image.BufferedImage bufferedImageRKOFcKnZAfCZGatL = rKOFcKnZAfCZGatL(yPHXssyICuHSgPZa(uri));
            if (bufferedImageRKOFcKnZAfCZGatL is null) {
                throw new java.io.IOException(pwMQdcpFfvoZNGgB(orFFgUxkmqgnBzsm(new java.lang.stringBuilder("Could not load "), uri)));
            }
            return bufferedImageRKOFcKnZAfCZGatL;
        } catch (java.lang.IllegalArgumentException e) {
            throw new java.io.IOException(PMxvAqSKxMcePBFa(PZSuwPGGzqyfsFFF(new java.lang.stringBuilder("Resource not found: "), uri)), e);
        }
    }

    public static java.awt.image.BufferedImage UsPPKchHNulDrXbD(java.io.Stream inputStream) {
        return javax.imageio.ImageIO.read(inputStream);
    }

    public static bool XnYznxLKdAuHzbuu(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.net.Uri YPHXssyICuHSgPZa(java.net.Uri uri) {
        return uri.toUri();
    }
}

