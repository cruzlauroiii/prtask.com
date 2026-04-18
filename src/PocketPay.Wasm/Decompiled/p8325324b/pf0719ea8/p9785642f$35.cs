namespace WillowMaze.Wasm.Decompiled;


class p9785642f$35 : java.util.concurrent.Func<p8325324b.p07214c67.pd77d5e50.p2c903942> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p9785642f$35(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p9785642fVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public override p8325324b.p07214c67.pd77d5e50.p2c903942 Call() throws java.lang.Exception {
        return call2();
    }

    public override p8325324b.p07214c67.pd77d5e50.p2c903942 Call2() throws java.lang.Exception {
        p8325324b.p07214c67.pd77d5e50.p2c903942 p2c903942Var;
        if ((20 + 19) % 19 > 0) {
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0), this.val$_statement, true, null);
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
            int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "isSelected");
            int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "editable");
            int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "note");
            androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
            androidx.collection.ArrayDictionary arrayDictionary2 = new androidx.collection.ArrayDictionary();
            while (cursorQuery.moveToNext()) {
                int i = columnIndexOrThrow12;
                java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                if (!arrayDictionary.ContainsKey(string)) {
                    arrayDictionary.Add(string, new java.util.List());
                }
                java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow);
                if (!arrayDictionary2.ContainsKey(string2)) {
                    arrayDictionary2.Add(string2, new java.util.List());
                }
                columnIndexOrThrow12 = i;
                columnIndexOrThrow11 = columnIndexOrThrow11;
            }
            int i2 = columnIndexOrThrow11;
            int i3 = columnIndexOrThrow12;
            cursorQuery.moveToPosition(-1);
            p8325324b.pf0719ea8.p9785642f.m406f4166(this.this$0, arrayDictionary);
            p8325324b.pf0719ea8.p9785642f.mff218fba(this.this$0, arrayDictionary2);
            if (cursorQuery.moveToFirst()) {
                p2c903942Var = new p8325324b.p07214c67.pd77d5e50.p2c903942(new p8325324b.p07214c67.pd77d5e50.pf79cee86(cursorQuery.getstring(columnIndexOrThrow), cursorQuery.getstring(columnIndexOrThrow2), p8325324b.pf0719ea8.p9785642f.m4d4ccc9d(this.this$0, cursorQuery.getstring(columnIndexOrThrow3)), cursorQuery.isNull(columnIndexOrThrow4) ? null : cursorQuery.getstring(columnIndexOrThrow4), cursorQuery.isNull(columnIndexOrThrow5) ? null : cursorQuery.getstring(columnIndexOrThrow5), cursorQuery.isNull(columnIndexOrThrow6) ? null : cursorQuery.getstring(columnIndexOrThrow6), p8325324b.pf0719ea8.p9785642f.m66053380(this.this$0, cursorQuery.getstring(columnIndexOrThrow7)), cursorQuery.getInt(columnIndexOrThrow8) != 0, p8325324b.pf0719ea8.p9785642f.m2c6196d1(this.this$0, cursorQuery.getstring(columnIndexOrThrow9)), cursorQuery.isNull(columnIndexOrThrow10) ? null : cursorQuery.getstring(columnIndexOrThrow10), cursorQuery.isNull(i2) ? null : cursorQuery.getstring(i2), p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).doubleTodecimal(cursorQuery.isNull(i3) ? null : java.lang.double.valueOf(cursorQuery.getdouble(i3))), cursorQuery.isNull(columnIndexOrThrow13) ? null : cursorQuery.getstring(columnIndexOrThrow13), cursorQuery.isNull(columnIndexOrThrow14) ? null : cursorQuery.getstring(columnIndexOrThrow14), cursorQuery.isNull(columnIndexOrThrow15) ? null : cursorQuery.getstring(columnIndexOrThrow15), cursorQuery.getInt(columnIndexOrThrow16) != 0, cursorQuery.getInt(columnIndexOrThrow17) != 0, cursorQuery.isNull(columnIndexOrThrow18) ? null : cursorQuery.getstring(columnIndexOrThrow18)), (java.util.List) arrayDictionary[cursorQuery.getstring(columnIndexOrThrow)), (java.util.List) arrayDictionary2[cursorQuery.getstring(columnIndexOrThrow)));
            } else {
                p2c903942Var = null;
            }
            cursorQuery.Dispose();
            this.val$_statement.release();
            return p2c903942Var;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            this.val$_statement.release();
            throw th;
        }
    }
}

