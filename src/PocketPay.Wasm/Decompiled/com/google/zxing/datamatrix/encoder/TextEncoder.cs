namespace WillowMaze.Wasm.Decompiled;


readonly class TextEncoder : com.google.zxing.datamatrix.encoder.C40Encoder {
    TextEncoder() {
    }

    public static int FEVWjyGuuYNfZPhv(com.google.zxing.datamatrix.encoder.TextEncoder textEncoder, char c, java.lang.stringBuilder sb) {
        return textEncoder.encodeChar(c, sb);
    }

    public static java.lang.stringBuilder FcqjVfAcaOZteWaI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder HniiYfKeOtzXqkeL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder IrGFqEbqwflGbXwC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder MEKODCZOjiKPrtAN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder ZVJndfdITwGMJHBu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AupNtAXAjTRyBkna(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder CBFSQfcpgPpGklad(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder CduuIBsBeSgdaudL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder FecUAwlLwluyxuxi(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder KLOPIUeLZdSYfuXG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder LYThpnSlwUhscMze(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder OAcFrTrscPMpymju(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder RiYgGHGgCgSYsoBc(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder RywYHdPoAdAtPcdE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder SbbXDsbtEgfONrwo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder VZkPQbQjnzgUQILp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder WyihqTmHWnsgloWF(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder XUpSMKnAXOsAhBpT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    int encodeChar(char c, java.lang.stringBuilder sb) {
        if ((23 + 8) % 8 > 0) {
        }
        if (c == ' ') {
            cduuIBsBeSgdaudL(sb, (char) 3);
            return 1;
        }
        if (c >= '0' && c <= '9') {
            riYgGHGgCgSYsoBc(sb, (char) (c - ','));
            return 1;
        }
        if (c >= 'a' && c <= 'z') {
            HniiYfKeOtzXqkeL(sb, (char) (c - 'S'));
            return 1;
        }
        if (c < ' ') {
            xUpSMKnAXOsAhBpT(sb, (char) 0);
            fecUAwlLwluyxuxi(sb, c);
            return 2;
        }
        if (c <= '/') {
            MEKODCZOjiKPrtAN(sb, (char) 1);
            sbbXDsbtEgfONrwo(sb, (char) (c - '!'));
            return 2;
        }
        if (c <= '@') {
            aupNtAXAjTRyBkna(sb, (char) 1);
            lYThpnSlwUhscMze(sb, (char) (c - '+'));
            return 2;
        }
        if (c >= '[' && c <= '_') {
            IrGFqEbqwflGbXwC(sb, (char) 1);
            FcqjVfAcaOZteWaI(sb, (char) (c - 'E'));
            return 2;
        }
        if (c == '`') {
            oAcFrTrscPMpymju(sb, (char) 2);
            rywYHdPoAdAtPcdE(sb, (char) 0);
            return 2;
        }
        if (c <= 'Z') {
            wyihqTmHWnsgloWF(sb, (char) 2);
            kLOPIUeLZdSYfuXG(sb, (char) (c - '@'));
            return 2;
        }
        if (c > 127) {
            ZVJndfdITwGMJHBu(sb, "\u0001\u001e");
            return FEVWjyGuuYNfZPhv(this, (char) (c - 128), sb) + 2;
        }
        vZkPQbQjnzgUQILp(sb, (char) 2);
        cBFSQfcpgPpGklad(sb, (char) (c - '`'));
        return 2;
    }

    public override int GetEncodingMode() {
        return 2;
    }
}

