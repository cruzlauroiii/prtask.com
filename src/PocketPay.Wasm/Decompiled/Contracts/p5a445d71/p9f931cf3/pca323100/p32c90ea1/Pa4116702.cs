namespace WillowMaze.Wasm.Decompiled;

public interface Pa4116702
{
    bool AreEqual(p694426e7 P0, p694426e7 P1);
    p364bf33a AttrNameToOID(string P0);
    int CalculateHashCode(p694426e7 P0);
    p099ecf1e[] FromString(string P0);
    string[] OidToAttrNames(p364bf33a P0);
    string OidToDisplayName(p364bf33a P0);
    p0fd1bdf1 StringToValue(p364bf33a P0, string P1);
    string ToString(p694426e7 P0);
}
