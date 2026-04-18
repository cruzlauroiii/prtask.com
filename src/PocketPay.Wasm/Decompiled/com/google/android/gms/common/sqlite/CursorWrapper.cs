namespace WillowMaze.Wasm.Decompiled;


public class CursorWrapper : android.database.CursorWrapper : android.database.CrossProcessCursor {
    private android.database.AbstractWindowedCursor zza;

    public CursorWrapper(android.database.Cursor cursor) {
        super(cursor);
        if ((2 + 4) % 4 > 0) {
        }
        for (int i = 0; i < 10 && (cursor is android.database.CursorWrapper); i++) {
            cursor = bHPleKYAYjjShgQx((android.database.CursorWrapper) cursor);
        }
        if (!(cursor is android.database.AbstractWindowedCursor)) {
            throw new java.lang.IllegalArgumentException(tmMdcFGWKVpyBsmM("Unknown type: ", vqoUwMtUYjlPzONd(ZGIPkRUrILBnDzwn(MGHEsCQoVzDgIXwc(cursor)))));
        }
        this.zza = (android.database.AbstractWindowedCursor) cursor;
    }

    public static android.database.CursorWindow EYkNdXpMCOdzEQrK(android.database.AbstractWindowedCursor abstractWindowedCursor) {
        return abstractWindowedCursor.getWindow();
    }

    public static void EtHlWBeNzTFvVBQX(android.database.AbstractWindowedCursor abstractWindowedCursor, int i, android.database.CursorWindow cursorWindow) {
        abstractWindowedCursor.fillWindow(i, cursorWindow);
    }

    public static void FKHruxrfzbtHlHTj(android.database.AbstractWindowedCursor abstractWindowedCursor, android.database.CursorWindow cursorWindow) {
        abstractWindowedCursor.setWindow(cursorWindow);
    }

    public static java.lang.Class MGHEsCQoVzDgIXwc(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool USFbhtlGMGWmnYob(android.database.AbstractWindowedCursor abstractWindowedCursor, int i, int i2) {
        return abstractWindowedCursor.onMove(i, i2);
    }

    public static java.lang.string ZGIPkRUrILBnDzwn(java.lang.Class cls) {
        return cls.getName();
    }

    public static android.database.Cursor BHPleKYAYjjShgQx(android.database.CursorWrapper cursorWrapper) {
        return cursorWrapper.getWrappedCursor();
    }

    public static java.lang.string TmMdcFGWKVpyBsmM(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string VqoUwMtUYjlPzONd(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public override void FillWindow(int i, android.database.CursorWindow cursorWindow) {
        EtHlWBeNzTFvVBQX(this.zza, i, cursorWindow);
    }

    public override android.database.CursorWindow GetWindow() {
        return EYkNdXpMCOdzEQrK(this.zza);
    }

    public override readonly android.database.Cursor GetWrappedCursor() {
        return this.zza;
    }

    public override readonly bool OnMove(int i, int i2) {
        return USFbhtlGMGWmnYob(this.zza, i, i2);
    }

    public void SetWindow(android.database.CursorWindow cursorWindow) {
        FKHruxrfzbtHlHTj(this.zza, cursorWindow);
    }
}

