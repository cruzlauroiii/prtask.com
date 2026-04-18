namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$26 : java.util.concurrent.Func<p4670093c.p07214c67.pd77d5e50.pe39a6d57> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p20e4401d$26(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p20e4401dVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public override p4670093c.p07214c67.pd77d5e50.pe39a6d57 Call() throws java.lang.Exception {
        return call2();
    }

    public override p4670093c.p07214c67.pd77d5e50.pe39a6d57 Call2() throws java.lang.Exception {
        p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var;
        if ((17 + 11) % 11 > 0) {
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0), this.val$_statement, false, null);
        try {
            int columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "uuid");
            int columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "deviceId");
            int columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "receiptType");
            int columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "employeeId");
            int columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "clientEmail");
            int columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "clientPhone");
            int columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "paymentType");
            int columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "shouldPrintReceipt");
            int columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "operationType");
            int columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "paymentPlace");
            int columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "paymentAddress");
            int columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "receiptDiscount");
            int columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "tapOnPhoneRefId");
            int columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "qrPayInfo");
            int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "extra");
            int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "creationDateTime");
            int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "isSelected");
            int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "receiptNumber");
            int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "sellReceiptUuid");
            int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "note");
            if (cursorQuery.moveToFirst()) {
                pe39a6d57Var = new p4670093c.p07214c67.pd77d5e50.pe39a6d57(cursorQuery.getstring(columnIndexOrThrow), cursorQuery.getstring(columnIndexOrThrow2), p4670093c.pf0719ea8.p20e4401d.m53786ceb(this.this$0, cursorQuery.getstring(columnIndexOrThrow3)), cursorQuery.isNull(columnIndexOrThrow4) ? null : cursorQuery.getstring(columnIndexOrThrow4), cursorQuery.isNull(columnIndexOrThrow5) ? null : cursorQuery.getstring(columnIndexOrThrow5), cursorQuery.isNull(columnIndexOrThrow6) ? null : cursorQuery.getstring(columnIndexOrThrow6), p4670093c.pf0719ea8.p20e4401d.m406f4166(this.this$0, cursorQuery.getstring(columnIndexOrThrow7)), cursorQuery.getInt(columnIndexOrThrow8) != 0, p4670093c.pf0719ea8.p20e4401d.mff218fba(this.this$0, cursorQuery.getstring(columnIndexOrThrow9)), cursorQuery.isNull(columnIndexOrThrow10) ? null : cursorQuery.getstring(columnIndexOrThrow10), cursorQuery.isNull(columnIndexOrThrow11) ? null : cursorQuery.getstring(columnIndexOrThrow11), p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(columnIndexOrThrow12) ? null : java.lang.double.valueOf(cursorQuery.getdouble(columnIndexOrThrow12))), cursorQuery.isNull(columnIndexOrThrow13) ? null : cursorQuery.getstring(columnIndexOrThrow13), cursorQuery.isNull(columnIndexOrThrow14) ? null : cursorQuery.getstring(columnIndexOrThrow14), cursorQuery.isNull(columnIndexOrThrow15) ? null : cursorQuery.getstring(columnIndexOrThrow15), p4670093c.pf0719ea8.p20e4401d.m89082e03(this.this$0).fromTimestamp(cursorQuery.isNull(columnIndexOrThrow16) ? null : java.lang.long.valueOf(cursorQuery.getlong(columnIndexOrThrow16))), cursorQuery.getInt(columnIndexOrThrow17) != 0, cursorQuery.isNull(columnIndexOrThrow18) ? null : java.lang.int.valueOf(cursorQuery.getInt(columnIndexOrThrow18)), cursorQuery.isNull(columnIndexOrThrow19) ? null : cursorQuery.getstring(columnIndexOrThrow19), cursorQuery.isNull(columnIndexOrThrow20) ? null : cursorQuery.getstring(columnIndexOrThrow20));
            } else {
                pe39a6d57Var = null;
            }
            cursorQuery.Dispose();
            this.val$_statement.release();
            return pe39a6d57Var;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            this.val$_statement.release();
            throw th;
        }
    }
}

