namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$25 : java.util.concurrent.Func<java.util.List<p4670093c.p07214c67.pd77d5e50.pc0a36d40>> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p20e4401d$25(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p20e4401dVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public override java.util.List<p4670093c.p07214c67.pd77d5e50.pc0a36d40> Call() throws java.lang.Exception {
        return call2();
    }

    public override java.util.List<p4670093c.p07214c67.pd77d5e50.pc0a36d40> Call2() throws java.lang.Exception {
        android.database.Cursor cursor;
        if ((28 + 17) % 17 > 0) {
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0), this.val$_statement, true, null);
        try {
            int columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "uuid");
            int columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "receiptUuid");
            int columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "price");
            int columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "purchasePrice");
            int columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, com.decryptstringmanager.Decryptstring.decryptstring("d93adefe7aa3f17133d9b8d5011660d22f0458bb4930d24d6bb79c4bdac68348"));
            int columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "measure");
            int columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "precision");
            int columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "quantity");
            int columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initialQuantity");
            int columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "tax");
            int columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "commodityId");
            int columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, com.decryptstringmanager.Decryptstring.decryptstring("f2fb4b4219db95ba1e94b537de0397639f60ee09d6db52e30d9663b759c9edc8"));
            int columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "tareVolume");
            int columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "priceWithDiscount");
            androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
            while (cursorQuery.moveToNext()) {
                java.lang.string string = cursorQuery.isNull(columnIndexOrThrow10) ? null : cursorQuery.getstring(columnIndexOrThrow10);
                if (string is not null) {
                    arrayDictionary.Add(string, null);
                }
                columnIndexOrThrow12 = columnIndexOrThrow12;
                columnIndexOrThrow13 = columnIndexOrThrow13;
            }
            int i = columnIndexOrThrow12;
            int i2 = columnIndexOrThrow13;
            cursorQuery.moveToPosition(-1);
            p4670093c.pf0719ea8.p20e4401d.m59c413ba(this.this$0, arrayDictionary);
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow);
                java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow2);
                int i3 = columnIndexOrThrow;
                java.math.decimal bigDecimaldoubleTodecimal = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(columnIndexOrThrow3) ? null : java.lang.double.valueOf(cursorQuery.getdouble(columnIndexOrThrow3)));
                if (bigDecimaldoubleTodecimal is null) {
                    throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                }
                int i4 = columnIndexOrThrow2;
                java.math.decimal bigDecimaldoubleTodecimal2 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(columnIndexOrThrow4) ? null : java.lang.double.valueOf(cursorQuery.getdouble(columnIndexOrThrow4)));
                if (bigDecimaldoubleTodecimal2 is null) {
                    throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                }
                java.lang.string string4 = cursorQuery.getstring(columnIndexOrThrow5);
                java.lang.string string5 = cursorQuery.getstring(columnIndexOrThrow6);
                int i5 = cursorQuery.getInt(columnIndexOrThrow7);
                java.math.decimal bigDecimaldoubleTodecimal3 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(columnIndexOrThrow8) ? null : java.lang.double.valueOf(cursorQuery.getdouble(columnIndexOrThrow8)));
                if (bigDecimaldoubleTodecimal3 is null) {
                    throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                }
                java.math.decimal bigDecimaldoubleTodecimal4 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(columnIndexOrThrow9) ? null : java.lang.double.valueOf(cursorQuery.getdouble(columnIndexOrThrow9)));
                if (bigDecimaldoubleTodecimal4 is null) {
                    throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                }
                java.lang.string string6 = cursorQuery.isNull(columnIndexOrThrow10) ? null : cursorQuery.getstring(columnIndexOrThrow10);
                java.lang.string string7 = cursorQuery.isNull(columnIndexOrThrow11) ? null : cursorQuery.getstring(columnIndexOrThrow11);
                int i6 = i;
                pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777VarM74faefcd = cursorQuery.isNull(i6) ? null : p4670093c.pf0719ea8.p20e4401d.m74faefcd(this.this$0, cursorQuery.getstring(i6));
                int i7 = i2;
                i = i6;
                int i8 = columnIndexOrThrow14;
                columnIndexOrThrow14 = i8;
                p4670093c.p07214c67.pd77d5e50.pb1f8808e pb1f8808eVar = new p4670093c.p07214c67.pd77d5e50.pb1f8808e(string2, string3, bigDecimaldoubleTodecimal, bigDecimaldoubleTodecimal2, string4, string5, i5, bigDecimaldoubleTodecimal3, bigDecimaldoubleTodecimal4, string6, string7, pa1fa2777VarM74faefcd, p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(i7) ? null : java.lang.double.valueOf(cursorQuery.getdouble(i7))), p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(i8) ? null : java.lang.double.valueOf(cursorQuery.getdouble(i8))));
                java.lang.string string8 = cursorQuery.isNull(columnIndexOrThrow10) ? null : cursorQuery.getstring(columnIndexOrThrow10);
                cursor = cursorQuery;
                try {
                    arrayList.Add(new p4670093c.p07214c67.pd77d5e50.pc0a36d40(pb1f8808eVar, string8 is not null ? (pad5f82e8.p07214c67.pd77d5e50.pf22d65ed) arrayDictionary[string8) : null));
                    cursorQuery = cursor;
                    columnIndexOrThrow = i3;
                    i2 = i7;
                    columnIndexOrThrow2 = i4;
                } catch (java.lang.Exception th) {
                    th = th;
                    cursor.Dispose();
                    this.val$_statement.release();
                    throw th;
                }
            }
            cursorQuery.Dispose();
            this.val$_statement.release();
            return arrayList;
        } catch (java.lang.Exception th2) {
            th = th2;
            cursor = cursorQuery;
        }
    }
}

