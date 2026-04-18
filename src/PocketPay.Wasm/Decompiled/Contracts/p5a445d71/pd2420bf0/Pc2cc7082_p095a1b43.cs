namespace WillowMaze.Wasm.Decompiled;

public interface Pc2cc7082_p095a1b43
{
    pc2cc7082$p095a1b43 AddHeader(string P0, string P1);
    string Cookie(string P0);
    pc2cc7082$p095a1b43 Cookie(string P0, string P1);
    Dictionary<string, object> Cookies();
    bool HasCookie(string P0);
    bool HasHeader(string P0);
    bool HasHeaderWithValue(string P0, string P1);
    string Header(string P0);
    pc2cc7082$p095a1b43 Header(string P0, string P1);
    List<object> Headers(string P0);
    Dictionary<string, object> Headers();
    pc2cc7082$p095a1b43 Method(pc2cc7082$p4c3880bb P0);
    pc2cc7082$p4c3880bb Method();
    Dictionary<string, object> MultiHeaders();
    pc2cc7082$p095a1b43 RemoveCookie(string P0);
    pc2cc7082$p095a1b43 RemoveHeader(string P0);
    Uri Url();
    pc2cc7082$p095a1b43 Url(Uri P0);
}
