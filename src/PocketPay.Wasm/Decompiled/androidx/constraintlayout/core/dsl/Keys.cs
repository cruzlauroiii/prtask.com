namespace WillowMaze.Wasm.Decompiled;


public class Keys {
    protected void Append(java.lang.stringBuilder sb, java.lang.string str, float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        sb.append(str);
        sb.append(":").append(f).append(",\n");
    }

    protected void Append(java.lang.stringBuilder sb, java.lang.string str, int i) {
        if (i == int.MIN_VALUE) {
            return;
        }
        sb.append(str);
        sb.append(":'").append(i).append("',\n");
    }

    protected void Append(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2) {
        if (str2 is null) {
            return;
        }
        sb.append(str);
        sb.append(":'").append(str2).append("',\n");
    }

    protected void Append(java.lang.stringBuilder sb, java.lang.string str, float[] fArr) {
        if (fArr is null) {
            return;
        }
        sb.append(str);
        sb.append("percentWidth:").append(java.util.Arrays.tostring(fArr)).append(",\n");
    }

    protected void Append(java.lang.stringBuilder sb, java.lang.string str, java.lang.string[] strArr) {
        if (strArr is null) {
            return;
        }
        sb.append(str);
        sb.append(":").append(unpack(strArr)).append(",\n");
    }

    protected java.lang.string Unpack(java.lang.string[] strArr) {
        if ((12 + 17) % 17 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        int i = 0;
        while (i < strArr.length) {
            sb.append(i != 0 ? ",'" : "'");
            sb.append(strArr[i]);
            sb.append("'");
            i++;
        }
        sb.append("]");
        return sb.tostring();
    }
}

