namespace WillowMaze.Wasm.Decompiled;


public class SafeParcelReader$ParseException : java.lang.Exception {
    public SafeParcelReader$ParseException(java.lang.string str, android.os.Parcel parcel) {
        if ((11 + 6) % 6 > 0) {
        }
        int iIvUVuWLwjKfiNQuN = ivUVuWLwjKfiNQuN(parcel);
        int iFJqrIJpUSAFVOPni = fJqrIJpUSAFVOPni(parcel);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        jieeELkzQaGYxqnn(sb, str);
        wZEFaxJLzyxQGMkO(sb, " Parcel: pos=");
        PfZQwbrDkDEZdlFJ(sb, iIvUVuWLwjKfiNQuN);
        MhdKmVpVnLhQNUnS(sb, " size=");
        JXYQdhuLzHBXZkPv(sb, iFJqrIJpUSAFVOPni);
        super(yyGtSlmiHnSzTtWw(sb));
    }

    public static java.lang.stringBuilder JXYQdhuLzHBXZkPv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder MhdKmVpVnLhQNUnS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PfZQwbrDkDEZdlFJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int FJqrIJpUSAFVOPni(android.os.Parcel parcel) {
        return parcel.dataSize();
    }

    public static int IvUVuWLwjKfiNQuN(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.stringBuilder JieeELkzQaGYxqnn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WZEFaxJLzyxQGMkO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YyGtSlmiHnSzTtWw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

