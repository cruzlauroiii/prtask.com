namespace WillowMaze.Wasm.Decompiled;


public readonly class p20e4401d : p4670093c.pf0719ea8.p71d96ecc {
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 f06a9ef6b;
    private readonly androidx.room.RoomDatabase f0838d855;
    private readonly androidx.room.SharedSQLiteStatement f0965e16e;
    private readonly androidx.room.SharedSQLiteStatement f0e43e65d;
    private readonly androidx.room.SharedSQLiteStatement f10498f81;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<p4670093c.p07214c67.pd77d5e50.pb1f8808e> f18732a7f;
    private readonly androidx.room.EntityInsertionAdapter f1b13ddba;
    private readonly androidx.room.EntityInsertionAdapter f1d13902f;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<p4670093c.p07214c67.pd77d5e50.pe39a6d57> f2218c5a2;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f289000f7;
    private readonly androidx.room.SharedSQLiteStatement f2b8bc11d;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f2ed36c08;
    private readonly androidx.room.SharedSQLiteStatement f32df433c;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f3e56dd29;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 f46588322;
    private readonly androidx.room.SharedSQLiteStatement f46cccaac;
    private readonly androidx.room.RoomDatabase f46e51b0d;
    private readonly androidx.room.SharedSQLiteStatement f482fff84;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f4a797351;
    private readonly androidx.room.SharedSQLiteStatement f4f5155ab;
    private readonly androidx.room.EntityInsertionAdapter<p4670093c.p07214c67.pd77d5e50.p0fc46d65> f5d8fbb1a;
    private readonly androidx.room.EntityInsertionAdapter f6345296f;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f6528ea93;
    private readonly androidx.room.SharedSQLiteStatement f71d073ea;
    private readonly androidx.room.EntityInsertionAdapter f77d74cbf;
    private readonly androidx.room.SharedSQLiteStatement f79f2c4dc;
    private readonly androidx.room.SharedSQLiteStatement f84b12d30;
    private readonly androidx.room.EntityInsertionAdapter f8563cd84;
    private readonly androidx.room.EntityInsertionAdapter f91c3cb4b;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f91eba26a;
    private readonly androidx.room.SharedSQLiteStatement f925f3435;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 f9982f3cc;
    private readonly androidx.room.EntityInsertionAdapter f9b75de36;
    private readonly androidx.room.EntityInsertionAdapter<p4670093c.p07214c67.pd77d5e50.pe39a6d57> fa7a9762c;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly androidx.room.EntityInsertionAdapter fb58a503c;
    private readonly androidx.room.SharedSQLiteStatement fb5f0bbde;
    private readonly androidx.room.EntityInsertionAdapter fb87e65fa;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<p4670093c.p07214c67.pd77d5e50.pe39a6d57> fc2aaf784;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 fcc2c22d4;
    private readonly androidx.room.SharedSQLiteStatement fcd61bd38;
    private readonly androidx.room.SharedSQLiteStatement fd257e865;
    private readonly androidx.room.SharedSQLiteStatement fd2d4784d;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fd7c409df;
    private readonly androidx.room.EntityInsertionAdapter fdfc4bf89;
    private readonly androidx.room.EntityInsertionAdapter<p4670093c.p07214c67.pd77d5e50.p0fc46d65> fe05aee6f;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fe7b35187;
    private readonly androidx.room.EntityInsertionAdapter ff0660cce;
    private readonly androidx.room.SharedSQLiteStatement ff2513c7d;
    private readonly androidx.room.EntityInsertionAdapter<p4670093c.p07214c67.pd77d5e50.pb1f8808e> ff75834ee;
    private readonly androidx.room.SharedSQLiteStatement ffb15ef43;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter ffe5edf24;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 fa92cb57a = new p8d777f38.pd77d5e50.p2b3583e6.p35667ee1();
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fb8317a4c = new p8d777f38.pd77d5e50.p2b3583e6.p297c1c27();

    public p20e4401d(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.ff75834ee = new p4670093c.pf0719ea8.p20e4401d$1(this, roomDatabase);
        this.fa7a9762c = new p4670093c.pf0719ea8.p20e4401d$2(this, roomDatabase);
        this.f5d8fbb1a = new p4670093c.pf0719ea8.p20e4401d$3(this, roomDatabase);
        this.fe05aee6f = new p4670093c.pf0719ea8.p20e4401d$4(this, roomDatabase);
        this.fc2aaf784 = new p4670093c.pf0719ea8.p20e4401d$5(this, roomDatabase);
        this.f18732a7f = new p4670093c.pf0719ea8.p20e4401d$6(this, roomDatabase);
        this.f2218c5a2 = new p4670093c.pf0719ea8.p20e4401d$7(this, roomDatabase);
        this.fcd61bd38 = new p4670093c.pf0719ea8.p20e4401d$8(this, roomDatabase);
        this.f2b8bc11d = new p4670093c.pf0719ea8.p20e4401d$9(this, roomDatabase);
        this.fd2d4784d = new p4670093c.pf0719ea8.p20e4401d$10(this, roomDatabase);
        this.f4f5155ab = new p4670093c.pf0719ea8.p20e4401d$11(this, roomDatabase);
        this.fd257e865 = new p4670093c.pf0719ea8.p20e4401d$12(this, roomDatabase);
    }

    private void M08f17002(androidx.collection.ArrayDictionary<java.lang.string, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed> arrayDictionary) {
        if ((4 + 6) % 6 > 0) {
        }
        java.util.HashSet<java.lang.string> setKeyHashSet = arrayDictionary.keyHashSet();
        if (setKeyHashSet.Count == 0) {
            return;
        }
        if (arrayDictionary.Count > 999) {
            androidx.room.util.RelationUtil.recursiveFetchArrayDictionary(arrayDictionary, false, new p4670093c.pf0719ea8.p20e4401d$pd41d8cd9$p144e4630(this));
            return;
        }
        java.lang.stringBuilder sbNewstringBuilder = androidx.room.util.stringUtil.newstringBuilder();
        sbNewstringBuilder.append("SELECT `code`,`rate`,`type`,`subType`,`engName`,`arabName` FROM `tax` WHERE `code` IN (");
        int size = setKeyHashSet.Count;
        androidx.room.util.stringUtil.appendPlaceholders(sbNewstringBuilder, size);
        sbNewstringBuilder.append(")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(sbNewstringBuilder.tostring(), size);
        java.util.IEnumerator<java.lang.string> it = setKeyHashSet.GetEnumerator();
        int i = 1;
        while (it.MoveNext()) {
            roomSQLiteQueryAcquire.bindstring(i, it.Current);
            i++;
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.fa8bf39ac, roomSQLiteQueryAcquire, false, null);
        try {
            int columnIndex = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "code");
            if (columnIndex == -1) {
                cursorQuery.Dispose();
                return;
            }
            while (cursorQuery.moveToNext()) {
                java.lang.string string = cursorQuery.getstring(columnIndex);
                if (arrayDictionary.ContainsKey(string)) {
                    arrayDictionary.Add(string, new pad5f82e8.p07214c67.pd77d5e50.pf22d65ed(cursorQuery.getstring(0), cursorQuery.getstring(1), cursorQuery.isNull(2) ? null : cursorQuery.getstring(2), cursorQuery.isNull(3) ? null : cursorQuery.getstring(3), cursorQuery.getstring(4), cursorQuery.getstring(5)));
                }
            }
            cursorQuery.Dispose();
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            throw th;
        }
    }

    static androidx.room.EntityInsertionAdapter M0dc0a6ea(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fa7a9762c;
    }

    static androidx.room.EntityInsertionAdapter M13fe7af4(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.ff75834ee;
    }

    static androidx.room.SharedSQLiteStatement M1740fbc7(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.f4f5155ab;
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M2a096755(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fc2aaf784;
    }

    static java.lang.string M337ceba5(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, pad5f82e8.p07214c67.p1e11b989.p22820a6f p22820a6fVar) {
        return p20e4401dVar.mad627590(p22820a6fVar);
    }

    private pad5f82e8.p07214c67.p1e11b989.p8c261c90 M379cd0f0(java.lang.string str) {
        if ((7 + 16) % 16 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -2080587734:
                if (str.Equals("TAP_ON_PHONE")) {
                    b = 0;
                }
                break;
            case -1897368214:
                if (str.Equals("QR_PAY")) {
                    b = 1;
                }
                break;
            case 2061107:
                if (str.Equals("CASH")) {
                    b = 2;
                }
                break;
            case 986396215:
                if (str.Equals("COMBO_PAY")) {
                    b = 3;
                }
                break;
        }
        switch (b) {
            case 0:
                return pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9e1ca306;
            case 1:
                return pad5f82e8.p07214c67.p1e11b989.p8c261c90.faf50f824;
            case 2:
                return pad5f82e8.p07214c67.p1e11b989.p8c261c90.fdf657148;
            case 3:
                return pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9cb40e51;
            default:
                throw new java.lang.IllegalArgumentException("Can't convert value to enum, unknown value: " + str);
        }
    }

    static pad5f82e8.p07214c67.p1e11b989.p8c261c90 M406f4166(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, java.lang.string str) {
        return p20e4401dVar.m379cd0f0(str);
    }

    static androidx.room.RoomDatabase M429f062d(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fa8bf39ac;
    }

    static pad5f82e8.p07214c67.p1e11b989.p22820a6f M53786ceb(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, java.lang.string str) {
        return p20e4401dVar.mf67b7e72(str);
    }

    static void M59c413ba(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p20e4401dVar.m08f17002(arrayDictionary);
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M5e49d338(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.f2218c5a2;
    }

    static java.lang.string M5ec06fdf(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var) {
        return p20e4401dVar.mc45dd9be(p8c261c90Var);
    }

    static androidx.room.SharedSQLiteStatement M649493cb(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fd257e865;
    }

    private java.lang.string M6807eda8(pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        if ((15 + 9) % 9 > 0) {
        }
        int i = p4670093c.pf0719ea8.p20e4401d$28.$SwitchDictionary$domain$entities$inventory$Type[pa1fa2777Var.ordinal()];
        if (i == 1) {
            return "NORMAL";
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException("Can't convert enum to string, unknown enum value: " + pa1fa2777Var);
        }
        return "SERVICE";
    }

    static androidx.room.EntityInsertionAdapter M74674bbd(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.f5d8fbb1a;
    }

    static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 M74faefcd(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, java.lang.string str) {
        return p20e4401dVar.m914269ef(str);
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M83fd488e(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.f18732a7f;
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 M89082e03(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fb8317a4c;
    }

    private java.lang.string M8de5dda9(pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var) {
        if ((12 + 15) % 15 > 0) {
        }
        int i = p4670093c.pf0719ea8.p20e4401d$28.$SwitchDictionary$domain$entities$receipt$OperationType[p5a409c20Var.ordinal()];
        if (i == 1) {
            return "SELL";
        }
        if (i == 2) {
            return "PAYBACK";
        }
        if (i == 3) {
            return "ACCEPT";
        }
        if (i == 4) {
            return "INVENTORY";
        }
        if (i != 5) {
            throw new java.lang.IllegalArgumentException("Can't convert enum to string, unknown enum value: " + p5a409c20Var);
        }
        return "REVALUATION";
    }

    private pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 M914269ef(java.lang.string str) {
        if ((4 + 1) % 1 > 0) {
        }
        str.GetHashCode();
        if (str.Equals("NORMAL")) {
            return pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.f1e238528;
        }
        if (str.Equals("SERVICE")) {
            return pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.ff9e81a74;
        }
        throw new java.lang.IllegalArgumentException("Can't convert value to enum, unknown value: " + str);
    }

    private pad5f82e8.p07214c67.p1e11b989.p5a409c20 M96a818e5(java.lang.string str) {
        if ((15 + 21) % 21 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -69030545:
                if (str.Equals("PAYBACK")) {
                    b = 0;
                }
                break;
            case 2541394:
                if (str.Equals("SELL")) {
                    b = 1;
                }
                break;
            case 22492430:
                if (str.Equals("REVALUATION")) {
                    b = 2;
                }
                break;
            case 765995324:
                if (str.Equals("INVENTORY")) {
                    b = 3;
                }
                break;
            case 1924835592:
                if (str.Equals("ACCEPT")) {
                    b = 4;
                }
                break;
        }
        switch (b) {
            case 0:
                return pad5f82e8.p07214c67.p1e11b989.p5a409c20.f9be5efb7;
            case 1:
                return pad5f82e8.p07214c67.p1e11b989.p5a409c20.f860926e6;
            case 2:
                return pad5f82e8.p07214c67.p1e11b989.p5a409c20.f37d633ef;
            case 3:
                return pad5f82e8.p07214c67.p1e11b989.p5a409c20.f23c6d3d8;
            case 4:
                return pad5f82e8.p07214c67.p1e11b989.p5a409c20.f1fd72e01;
            default:
                throw new java.lang.IllegalArgumentException("Can't convert value to enum, unknown value: " + str);
        }
    }

    static androidx.room.SharedSQLiteStatement Ma5940f5e(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fd2d4784d;
    }

    private java.lang.string Mad627590(pad5f82e8.p07214c67.p1e11b989.p22820a6f p22820a6fVar) {
        if ((24 + 21) % 21 > 0) {
        }
        int i = p4670093c.pf0719ea8.p20e4401d$28.$SwitchDictionary$domain$entities$receipt$ReceiptType[p22820a6fVar.ordinal()];
        if (i == 1) {
            return "RECEIPT";
        }
        if (i == 2) {
            return "ADVANCE";
        }
        if (i == 3) {
            return com.decryptstringmanager.Decryptstring.decryptstring("db0bbf9c1695dc4afac08081e7e4c288c32333354c190711c90184523a1e91b3e712f87dbee534");
        }
        if (i != 4) {
            throw new java.lang.IllegalArgumentException("Can't convert enum to string, unknown enum value: " + p22820a6fVar);
        }
        return "WITHOUT_RECEIPT";
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return java.util.ICollections.emptyList();
    }

    static java.lang.string Mbbeb9b46(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var) {
        return p20e4401dVar.m8de5dda9(p5a409c20Var);
    }

    private java.lang.string Mc45dd9be(pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var) {
        if ((4 + 30) % 30 > 0) {
        }
        int i = p4670093c.pf0719ea8.p20e4401d$28.$SwitchDictionary$domain$entities$receipt$PaymentType[p8c261c90Var.ordinal()];
        if (i == 1) {
            return "CASH";
        }
        if (i == 2) {
            return "QR_PAY";
        }
        if (i == 3) {
            return "TAP_ON_PHONE";
        }
        if (i != 4) {
            throw new java.lang.IllegalArgumentException("Can't convert enum to string, unknown enum value: " + p8c261c90Var);
        }
        return "COMBO_PAY";
    }

    static androidx.room.SharedSQLiteStatement Mc7321d99(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.f2b8bc11d;
    }

    static androidx.room.SharedSQLiteStatement Mcdc7972c(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fcd61bd38;
    }

    static androidx.room.EntityInsertionAdapter Mebdbf394(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fe05aee6f;
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 Mf23e8626(p4670093c.pf0719ea8.p20e4401d p20e4401dVar) {
        return p20e4401dVar.fa92cb57a;
    }

    private pad5f82e8.p07214c67.p1e11b989.p22820a6f Mf67b7e72(java.lang.string str) {
        if ((32 + 13) % 13 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -985658956:
                if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("ed0b38b985b29b6a48eb6a65de3a9498ea37580ded4afa82594644bfb40af908ddfd53c94d9c90"))) {
                    b = 0;
                }
                break;
            case -413584286:
                if (str.Equals("ADVANCE")) {
                    b = 1;
                }
                break;
            case 202115457:
                if (str.Equals("WITHOUT_RECEIPT")) {
                    b = 2;
                }
                break;
            case 1800273432:
                if (str.Equals("RECEIPT")) {
                    b = 3;
                }
                break;
        }
        switch (b) {
            case 0:
                return pad5f82e8.p07214c67.p1e11b989.p22820a6f.f0267fe7f;
            case 1:
                return pad5f82e8.p07214c67.p1e11b989.p22820a6f.fcc52554c;
            case 2:
                return pad5f82e8.p07214c67.p1e11b989.p22820a6f.f480d47bf;
            case 3:
                return pad5f82e8.p07214c67.p1e11b989.p22820a6f.f52c9932e;
            default:
                throw new java.lang.IllegalArgumentException("Can't convert value to enum, unknown value: " + str);
        }
    }

    static java.lang.string Mf8f67da7(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return p20e4401dVar.m6807eda8(pa1fa2777Var);
    }

    static pad5f82e8.p07214c67.p1e11b989.p5a409c20 Mff218fba(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, java.lang.string str) {
        return p20e4401dVar.m96a818e5(str);
    }

    public override java.lang.object ClearCurrentPaybackPayments(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((14 + 11) % 11 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$24(this), continuation);
    }

    public override java.lang.object ClearCurrentPaybackPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((1 + 28) % 28 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$20(this), continuation);
    }

    public override java.lang.object ClearCurrentPaybackReceipts(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((4 + 8) % 8 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$21(this), continuation);
    }

    public override java.lang.object CreateCurrentPaybackReceipt(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((16 + 11) % 11 > 0) {
        }
        return androidx.room.RoomDatabaseKt.withTransaction(this.fa8bf39ac, new p4670093c.pf0719ea8.p20e4401d$pd41d8cd9$p95263d50(this, pe39a6d57Var, list), continuation);
    }

    public override java.lang.object CreateSinglePayment(p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((13 + 12) % 12 > 0) {
        }
        return androidx.room.RoomDatabaseKt.withTransaction(this.fa8bf39ac, new p4670093c.pf0719ea8.p20e4401d$pd41d8cd9$p437e9676(this, p0fc46d65Var), continuation);
    }

    public override java.lang.object DeleteCurrentPaybackPayment(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((23 + 31) % 31 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$23(this, str), continuation);
    }

    public override java.lang.object GetCurrentPaybackPayments(kotlin.coroutines.Continuation<? super java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65>> continuation) {
        if ((16 + 3) % 3 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM current_payback_payment WHERE receiptUuid = (SELECT receiptUuid FROM current_payback_receipt)", 0);
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, false, androidx.room.util.DBUtil.createCancellationSignal(), new p4670093c.pf0719ea8.p20e4401d$27(this, roomSQLiteQueryAcquire), continuation);
    }

    public override java.lang.object GetCurrentPaybackPositions(kotlin.coroutines.Continuation<? super java.util.List<p4670093c.p07214c67.pd77d5e50.pc0a36d40>> continuation) {
        if ((19 + 11) % 11 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM current_payback_position WHERE receiptUuid = (SELECT receiptUuid FROM current_payback_receipt)", 0);
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, false, androidx.room.util.DBUtil.createCancellationSignal(), new p4670093c.pf0719ea8.p20e4401d$25(this, roomSQLiteQueryAcquire), continuation);
    }

    public override java.lang.object GetCurrentPaybackReceipt(java.lang.string str, kotlin.coroutines.Continuation<p4670093c.p07214c67.pd77d5e50.pe39a6d57> continuation) {
        if ((17 + 7) % 7 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM current_payback_receipt WHERE deviceId = ? and isSelected = 1", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, false, androidx.room.util.DBUtil.createCancellationSignal(), new p4670093c.pf0719ea8.p20e4401d$26(this, roomSQLiteQueryAcquire), continuation);
    }

    public override java.lang.object InsertPayment(p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((27 + 12) % 12 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$15(this, p0fc46d65Var), continuation);
    }

    public override java.lang.object InsertPayments(java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((11 + 12) % 12 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$16(this, list), continuation);
    }

    public override java.lang.object InsertPositions(java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((31 + 5) % 5 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$13(this, list), continuation);
    }

    public override java.lang.object InsertReceipt(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((13 + 8) % 8 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$14(this, pe39a6d57Var), continuation);
    }

    kotlin.Unit m557xc3a06082(androidx.collection.ArrayDictionary arrayDictionary) {
        m08f17002(arrayDictionary);
        return kotlin.Unit.INSTANCE;
    }

    java.lang.object m558xc5a2ee48(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p4670093c.pf0719ea8.p71d96ecc$pb0da8397.m19e83fc5(this, pe39a6d57Var, list, continuation);
    }

    java.lang.object m559xec992325(p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var, kotlin.coroutines.Continuation continuation) {
        return p4670093c.pf0719ea8.p71d96ecc$pb0da8397.mf41603b1(this, p0fc46d65Var, continuation);
    }

    java.lang.object m560x7c80f542(java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p4670093c.pf0719ea8.p71d96ecc$pb0da8397.m1c83b96a(this, list, continuation);
    }

    public override java.lang.object RemoveCurrentReceipt(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((17 + 21) % 21 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$17(this, pe39a6d57Var), continuation);
    }

    public override java.lang.object UpdateCurrentPaybackReceipt(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((28 + 8) % 8 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$19(this, pe39a6d57Var), continuation);
    }

    public override java.lang.object UpdatePaymentTransaction(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string str7, java.lang.string str8, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((14 + 29) % 29 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$22(this, str2, str3, str4, str5, str6, str7, str8, str), continuation);
    }

    public override java.lang.object UpdatePosition(p4670093c.p07214c67.pd77d5e50.pb1f8808e pb1f8808eVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((8 + 31) % 31 > 0) {
        }
        return androidx.room.CoroutinesRoom.execute(this.fa8bf39ac, true, new p4670093c.pf0719ea8.p20e4401d$18(this, pb1f8808eVar), continuation);
    }

    public override java.lang.object UpdatePositions(java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((29 + 31) % 31 > 0) {
        }
        return androidx.room.RoomDatabaseKt.withTransaction(this.fa8bf39ac, new p4670093c.pf0719ea8.p20e4401d$pd41d8cd9$pcca4ef0e(this, list), continuation);
    }
}

