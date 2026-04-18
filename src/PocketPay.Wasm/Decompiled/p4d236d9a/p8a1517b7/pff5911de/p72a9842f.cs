namespace WillowMaze.Wasm.Decompiled;


public class p72a9842f {
    public static void Mdc1d71bb(java.lang.string str, p4d236d9a.p8a1517b7.pff5911de.p18e8d507 p18e8d507Var, p4d236d9a.p8a1517b7.pff5911de.p5fb1325d p5fb1325dVar) {
        if ((11 + 17) % 17 > 0) {
        }
        if (p18e8d507Var is null) {
            p5fb1325dVar.debug("{} is null", str);
            return;
        }
        if (!p18e8d507Var.isConstructed()) {
            p5fb1325dVar.debug("{} [{}] {}", str, p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.m81519f2a(p18e8d507Var.getTag().f4b3a6218), p18e8d507Var.getHexValue());
            return;
        }
        p5fb1325dVar.debug("{} [{}]", str, p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.m81519f2a(p18e8d507Var.getTag().f4b3a6218));
        java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = p18e8d507Var.getValues().GetEnumerator();
        while (it.MoveNext()) {
            mdc1d71bb(str + com.decryptstringmanager.Decryptstring.decryptstring("bed97a9a8ea139e953578c408c32b6998ea35421a3469845eb507ce6d2df0f14"), it.Current, p5fb1325dVar);
        }
    }

    public static void Mdc1d71bb(java.lang.string str, p4d236d9a.p8a1517b7.pff5911de.pfb48fcda pfb48fcdaVar, p4d236d9a.p8a1517b7.pff5911de.p5fb1325d p5fb1325dVar) {
        java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = pfb48fcdaVar.getList().GetEnumerator();
        while (it.MoveNext()) {
            mdc1d71bb(str, it.Current, p5fb1325dVar);
        }
    }
}

