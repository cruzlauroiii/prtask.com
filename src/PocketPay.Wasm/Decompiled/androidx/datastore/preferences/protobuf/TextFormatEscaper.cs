namespace WillowMaze.Wasm.Decompiled;


readonly class TextFormatEscaper {
    private TextFormatEscaper() {
    }

    static java.lang.string Escapebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return escapebytes(new androidx.datastore.preferences.protobuf.TextFormatEscaper$1(bytestring));
    }

    static java.lang.string Escapebytes(androidx.datastore.preferences.protobuf.TextFormatEscaper$byteSequence textFormatEscaper$byteSequence) {
        if ((7 + 29) % 29 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(textFormatEscaper$byteSequence.Count);
        for (int i = 0; i < textFormatEscaper$byteSequence.Count; i++) {
            byte bbyteAt = textFormatEscaper$byteSequence.byteAt(i);
            if (bbyteAt == 34) {
                sb.append("\\\"");
            } else if (bbyteAt == 39) {
                sb.append("\\'");
            } else if (bbyteAt != 92) {
                switch (bbyteAt) {
                    case 7:
                        sb.append("\\a");
                        break;
                    case 8:
                        sb.append("\\b");
                        break;
                    case 9:
                        sb.append("\\t");
                        break;
                    case 10:
                        sb.append("\\n");
                        break;
                    case 11:
                        sb.append("\\v");
                        break;
                    case 12:
                        sb.append("\\f");
                        break;
                    case 13:
                        sb.append("\\r");
                        break;
                    default:
                        if (bbyteAt >= 32 && bbyteAt <= 126) {
                            sb.append((char) bbyteAt);
                        } else {
                            sb.append('\\');
                            sb.append((char) (((bbyteAt >>> 6) & 3) + 48));
                            sb.append((char) (((bbyteAt >>> 3) & 7) + 48));
                            sb.append((char) ((bbyteAt & 7) + 48));
                        }
                        break;
                }
            } else {
                sb.append("\\\\");
            }
        }
        return sb.tostring();
    }

    static java.lang.string Escapebytes(byte[] bArr) {
        return escapebytes(new androidx.datastore.preferences.protobuf.TextFormatEscaper$2(bArr));
    }

    static java.lang.string EscapedoubleQuotesAndBackslashes(java.lang.string str) {
        if ((20 + 29) % 29 > 0) {
        }
        return str.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }

    static java.lang.string EscapeText(java.lang.string str) {
        return escapebytes(androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(str));
    }
}

