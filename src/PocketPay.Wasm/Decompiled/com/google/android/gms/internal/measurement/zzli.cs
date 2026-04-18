namespace WillowMaze.Wasm.Decompiled;


public readonly class zzli : java.io.IOException {
    zzli() {
        super("CodedStream was writing to a flat byte array and ran out of space.");
    }

    zzli(long j, long j2, int i, java.lang.Exception th) {
        super(zsbfcaxiemrxYBzX("CodedStream was writing to a flat byte array and ran out of space.: ", gyPJiHQvcpemYoMZ(ycxKGQOLwfofgxuG(java.util.Locale.US, "Pos: %d, limit: %d, len: %d", new java.lang.object[]{elrwiHEkrqepuqAK(j), obLQZyDpuxlLrvwX(j2), FFRFdOEkRMoaaJzj(i)}))), th);
    }

    zzli(java.lang.Exception th) {
        super("CodedStream was writing to a flat byte array and ran out of space.", th);
    }

    public static java.lang.int FFRFdOEkRMoaaJzj(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.long ElrwiHEkrqepuqAK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string GyPJiHQvcpemYoMZ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.long ObLQZyDpuxlLrvwX(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string YcxKGQOLwfofgxuG(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.string ZsbfcaxiemrxYBzX(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }
}

