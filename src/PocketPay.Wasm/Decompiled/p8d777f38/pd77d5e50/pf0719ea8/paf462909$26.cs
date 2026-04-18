namespace WillowMaze.Wasm.Decompiled;


class paf462909$26 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$26(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        this.this$0 = paf462909Var;
    }

    public static androidx.room.RoomDatabase IWySvCAUbGVpXIUe(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void LvWkIxRZkWCCngth(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void PJRKFERTbOshjqDG(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.SharedSQLiteStatement QCawEmxQifYVRoJe(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m59c413ba(paf462909Var);
    }

    public static androidx.room.RoomDatabase VRGPTLWkNhtdjrka(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.SharedSQLiteStatement VRJIOTRhZcKnTBlp(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m59c413ba(paf462909Var);
    }

    public static void GEVQWOPSMuLSVYcN(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void GXDHvEPfYyxypUlP(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int HwSckvoYZWtPJluD(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.SharedSQLiteStatement JKSsvTpiuQBtNuNq(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m59c413ba(paf462909Var);
    }

    public static androidx.room.RoomDatabase JstpCnPxhmJekAeF(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase KIdCoCMGJIQErZFw(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static kotlin.Unit MgGfvZOhCYMaxGDx(p8d777f38.pd77d5e50.pf0719ea8.paf462909$26 paf462909_26) {
        return paf462909_26.call2();
    }

    public static void PWlbNdVxXkbqPExw(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void UdvGibGLDWEGMIAx(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement XfyCrobxNNbBLccD(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return mgGfvZOhCYMaxGDx(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((8 + 7) % 7 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementXfyCrobxNNbBLccD = xfyCrobxNNbBLccD(jKSsvTpiuQBtNuNq(this.this$0));
        try {
            PJRKFERTbOshjqDG(VRGPTLWkNhtdjrka(this.this$0));
            try {
                hwSckvoYZWtPJluD(supportSQLiteStatementXfyCrobxNNbBLccD);
                pWlbNdVxXkbqPExw(jstpCnPxhmJekAeF(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                udvGibGLDWEGMIAx(IWySvCAUbGVpXIUe(this.this$0));
                gXDHvEPfYyxypUlP(VRJIOTRhZcKnTBlp(this.this$0), supportSQLiteStatementXfyCrobxNNbBLccD);
                return unit;
            } catch (java.lang.Exception th) {
                LvWkIxRZkWCCngth(kIdCoCMGJIQErZFw(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            gEVQWOPSMuLSVYcN(QCawEmxQifYVRoJe(this.this$0), supportSQLiteStatementXfyCrobxNNbBLccD);
            throw th2;
        }
    }
}

