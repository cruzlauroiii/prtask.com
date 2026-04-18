import {
  registerClient,
  unregisterClient,
  handleWsMessage,
} from "./websocket/handler";
import type { UserClaims, Env } from "./websocket/types";

const ALLOWED_ORIGINS = ["https://prtask.com", "https://0.0.0.1"];
const ALLOWED_REDIRECTS = ["https://cruzlauroiii.github.io/wolfstruckingco.com"];
const LOCALHOST_RE = /^https:\/\/127\.0\.0\.1(:\d+)?$/;
const SESSION_TTL = 2592000;
const SESSION_REPO = "prtask-sessions";

function IsAllowedOrigin(Origin: string | null): boolean {
  if (!Origin) return true;
  return ALLOWED_ORIGINS.includes(Origin) || LOCALHOST_RE.test(Origin);
}

function CorsHeaders(Req: Request): Record<string, string> {
  const Origin = Req.headers.get("Origin") ?? "";
  const Allowed =
    ALLOWED_ORIGINS.includes(Origin) || LOCALHOST_RE.test(Origin)
      ? Origin
      : ALLOWED_ORIGINS[0];
  return {
    "Content-Type": "application/json",
    "Access-Control-Allow-Origin": Allowed,
    "Access-Control-Allow-Methods": "GET, POST, OPTIONS",
    "Access-Control-Allow-Headers": "Content-Type, Cookie",
    "Access-Control-Allow-Credentials": "true",
    "Access-Control-Max-Age": "86400",
  };
}

function GetSessionId(Req: Request): string | null {
  const Cookie = Req.headers.get("Cookie") ?? "";
  const Match = Cookie.match(/session=([^;]+)/);
  return Match ? Match[1] : null;
}

async function GitHubApiGet(
  Pat: string, Owner: string, Repo: string, Path: string,
): Promise<Response> {
  return fetch(`https://api.github.com/repos/${Owner}/${Repo}/contents/${Path}`, {
    headers: {
      Authorization: `Bearer ${Pat}`,
      Accept: "application/vnd.github.v3+json",
      "User-Agent": "PrTask",
    },
  });
}

async function GitHubApiPut(
  Pat: string, Owner: string, Repo: string, Path: string,
  Content: string, Message: string, Sha?: string,
): Promise<Response> {
  const Body: Record<string, string> = {
    message: Message,
    content: btoa(unescape(encodeURIComponent(Content))),
  };
  if (Sha) Body.sha = Sha;
  return fetch(`https://api.github.com/repos/${Owner}/${Repo}/contents/${Path}`, {
    method: "PUT",
    headers: {
      Authorization: `Bearer ${Pat}`,
      Accept: "application/vnd.github.v3+json",
      "User-Agent": "PrTask",
      "Content-Type": "application/json",
    },
    body: JSON.stringify(Body),
  });
}

async function GitHubApiDelete(
  Pat: string, Owner: string, Repo: string, Path: string, Sha: string, Message: string,
): Promise<Response> {
  return fetch(`https://api.github.com/repos/${Owner}/${Repo}/contents/${Path}`, {
    method: "DELETE",
    headers: {
      Authorization: `Bearer ${Pat}`,
      Accept: "application/vnd.github.v3+json",
      "User-Agent": "PrTask",
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ message: Message, sha: Sha }),
  });
}

interface SessionData {
  Email: string;
  SessionId: string;
  Providers: Record<string, { AccessToken: string }>;
}

async function ReadSession(
  Env: Env, Email: string,
): Promise<{ Data: SessionData; Sha: string } | null> {
  const Path = `sessions/${encodeURIComponent(Email)}.json`;
  const Res = await GitHubApiGet(Env.GITHUB_PAT, Env.GITHUB_REPO_OWNER, SESSION_REPO, Path);
  if (!Res.ok) return null;
  const Json = (await Res.json()) as { content: string; sha: string };
  const Decoded = decodeURIComponent(escape(atob(Json.content.replace(/\n/g, ""))));
  return { Data: JSON.parse(Decoded) as SessionData, Sha: Json.sha };
}

async function WriteSession(
  Env: Env, Email: string, Data: SessionData, Sha?: string,
): Promise<void> {
  const Path = `sessions/${encodeURIComponent(Email)}.json`;
  const Content = JSON.stringify(Data, null, 2);
  const Message = Sha ? `Update session: ${Email}` : `Create session: ${Email}`;
  await GitHubApiPut(Env.GITHUB_PAT, Env.GITHUB_REPO_OWNER, SESSION_REPO, Path, Content, Message, Sha);
}

async function DeleteSession(
  Env: Env, Email: string,
): Promise<void> {
  const Path = `sessions/${encodeURIComponent(Email)}.json`;
  const Res = await GitHubApiGet(Env.GITHUB_PAT, Env.GITHUB_REPO_OWNER, SESSION_REPO, Path);
  if (!Res.ok) return;
  const Json = (await Res.json()) as { sha: string };
  await GitHubApiDelete(Env.GITHUB_PAT, Env.GITHUB_REPO_OWNER, SESSION_REPO, Path, Json.sha, `Delete session: ${Email}`);
}

async function FindSessionBySessionId(
  Env: Env, SessionId: string,
): Promise<{ Data: SessionData; Sha: string } | null> {
  const Res = await fetch(
    `https://api.github.com/repos/${Env.GITHUB_REPO_OWNER}/${SESSION_REPO}/contents/sessions`,
    {
      headers: {
        Authorization: `Bearer ${Env.GITHUB_PAT}`,
        Accept: "application/vnd.github.v3+json",
        "User-Agent": "PrTask",
      },
    },
  );
  if (!Res.ok) return null;
  const Files = (await Res.json()) as { name: string }[];
  for (const File of Files) {
    const Email = decodeURIComponent(File.name.replace(/\.json$/, ""));
    const Session = await ReadSession(Env, Email);
    if (Session && Session.Data.SessionId === SessionId) return Session;
  }
  return null;
}

function DecodeJwtPayload(Token: string): Record<string, unknown> {
  const Parts = Token.split(".");
  if (Parts.length !== 3) throw new Error("Invalid JWT");
  const Payload = Parts[1].replace(/-/g, "+").replace(/_/g, "/");
  return JSON.parse(decodeURIComponent(escape(atob(Payload))));
}

const OAuthConfigs: Record<string, {
  AuthorizeUrl: string;
  TokenUrl: string;
  UserInfoUrl: string;
  Scope: string;
  ClientIdKey: keyof Env;
  ClientSecretKey: keyof Env;
  CallbackPath: string;
}> = {
  google: {
    AuthorizeUrl: "https://accounts.google.com/o/oauth2/v2/auth",
    TokenUrl: "https://oauth2.googleapis.com/token",
    UserInfoUrl: "https://www.googleapis.com/oauth2/v3/userinfo",
    Scope: "openid email profile",
    ClientIdKey: "GOOGLE_CLIENT_ID",
    ClientSecretKey: "GOOGLE_CLIENT_SECRET",
    CallbackPath: "/Api/Auth/Callback/Google",
  },
  github: {
    AuthorizeUrl: "https://github.com/login/oauth/authorize",
    TokenUrl: "https://github.com/login/oauth/access_token",
    UserInfoUrl: "https://api.github.com/user",
    Scope: "read:user user:email",
    ClientIdKey: "GITHUB_CLIENT_ID",
    ClientSecretKey: "GITHUB_CLIENT_SECRET",
    CallbackPath: "/Api/Auth/Callback",
  },
  azure: {
    AuthorizeUrl: "https://login.microsoftonline.com/common/oauth2/v2.0/authorize",
    TokenUrl: "https://login.microsoftonline.com/common/oauth2/v2.0/token",
    UserInfoUrl: "https://graph.microsoft.com/oidc/userinfo",
    Scope: "openid email profile",
    ClientIdKey: "AZURE_CLIENT_ID",
    ClientSecretKey: "AZURE_CLIENT_SECRET",
    CallbackPath: "/Api/Auth/Callback/Azure",
  },
  okta: {
    AuthorizeUrl: "",
    TokenUrl: "",
    UserInfoUrl: "",
    Scope: "openid email profile",
    ClientIdKey: "OKTA_CLIENT_ID",
    ClientSecretKey: "OKTA_CLIENT_SECRET",
    CallbackPath: "/Api/Auth/Callback/Okta",
  },
};

async function GeneratePkce(): Promise<{ Verifier: string; Challenge: string }> {
  const Bytes = crypto.getRandomValues(new Uint8Array(32));
  const Verifier = btoa(String.fromCharCode(...Bytes))
    .replace(/\+/g, "-").replace(/\//g, "_").replace(/=+$/, "");
  const Hash = await crypto.subtle.digest("SHA-256", new TextEncoder().encode(Verifier));
  const Challenge = btoa(String.fromCharCode(...new Uint8Array(Hash)))
    .replace(/\+/g, "-").replace(/\//g, "_").replace(/=+$/, "");
  return { Verifier, Challenge };
}

async function HandleOAuthStart(
  Req: Request, Env: Env, Url: URL, Provider: string,
): Promise<Response> {
  const Config = { ...OAuthConfigs[Provider] };
  if (Provider === "okta") {
    const Domain = Env.OKTA_DOMAIN;
    Config.AuthorizeUrl = `${Domain}/oauth2/default/v1/authorize`;
    Config.TokenUrl = `${Domain}/oauth2/default/v1/token`;
    Config.UserInfoUrl = `${Domain}/oauth2/default/v1/userinfo`;
  }

  const ClientId = Env[Config.ClientIdKey] as string;
  const RedirectUri = `https://prtask.com${Config.CallbackPath}`;
  const { Verifier, Challenge } = await GeneratePkce();
  const Platform = Url.searchParams.get("platform") ?? "";
  const ExternalRedirect = Url.searchParams.get("redirect") ?? "";
  const State = btoa(JSON.stringify({ Verifier, Platform, Redirect: ExternalRedirect }));

  let AuthUrl: string;
  if (Provider === "github") {
    AuthUrl = `${Config.AuthorizeUrl}?client_id=${ClientId}`
      + `&redirect_uri=${encodeURIComponent(RedirectUri)}`
      + `&scope=${encodeURIComponent(Config.Scope)}`
      + `&state=${encodeURIComponent(State)}`;
  } else {
    AuthUrl = `${Config.AuthorizeUrl}?client_id=${ClientId}`
      + `&redirect_uri=${encodeURIComponent(RedirectUri)}`
      + `&response_type=code`
      + `&scope=${encodeURIComponent(Config.Scope)}`
      + `&code_challenge=${Challenge}`
      + `&code_challenge_method=S256`
      + `&state=${encodeURIComponent(State)}`;
  }

  return Response.redirect(AuthUrl, 302);
}

async function HandleOAuthCallback(
  Req: Request, Env: Env, Url: URL, Provider: string,
): Promise<Response> {
  const Code = Url.searchParams.get("code");
  const ErrorParam = Url.searchParams.get("error");
  const StateParam = Url.searchParams.get("state") ?? "";

  if (ErrorParam) return Response.redirect("https://prtask.com/en/Login?error=auth_failed", 302);
  if (!Code) return Response.redirect("https://prtask.com/en/Login?error=no_code", 302);

  let Verifier = "";
  let Platform = "";
  let ExternalRedirect = "";
  try {
    const Parsed = JSON.parse(atob(StateParam));
    Verifier = Parsed.Verifier ?? "";
    Platform = Parsed.Platform ?? "";
    ExternalRedirect = Parsed.Redirect ?? "";
  } catch { /* ignore */ }

  const Config = { ...OAuthConfigs[Provider] };
  if (Provider === "okta") {
    const Domain = Env.OKTA_DOMAIN;
    Config.TokenUrl = `${Domain}/oauth2/default/v1/token`;
  }

  const RedirectUri = `https://prtask.com${Config.CallbackPath}`;
  const TokenRes = await fetch(Config.TokenUrl, {
    method: "POST",
    headers: { "Content-Type": "application/x-www-form-urlencoded" },
    body: new URLSearchParams({
      grant_type: "authorization_code",
      code: Code,
      redirect_uri: RedirectUri,
      client_id: Env[Config.ClientIdKey] as string,
      client_secret: Env[Config.ClientSecretKey] as string,
      code_verifier: Verifier,
    }),
  });

  const TokenData = (await TokenRes.json()) as { access_token?: string; id_token?: string };
  if (!TokenData.access_token) {
    return Response.redirect("https://prtask.com/en/Login?error=auth_failed", 302);
  }

  const IdPayload = TokenData.id_token ? DecodeJwtPayload(TokenData.id_token) : null;
  const Email = (IdPayload?.email as string) ?? "";
  if (!Email) {
    return Response.redirect("https://prtask.com/en/Login?error=no_email", 302);
  }

  const ProviderName = Provider.charAt(0).toUpperCase() + Provider.slice(1);
  const Existing = await ReadSession(Env, Email);
  const SessionId = Existing?.Data.SessionId ?? crypto.randomUUID();
  const SessionData: SessionData = Existing?.Data ?? {
    Email,
    SessionId,
    Providers: {},
  };
  SessionData.Providers[ProviderName] = { AccessToken: TokenData.access_token };

  await WriteSession(Env, Email, SessionData, Existing?.Sha);

  if (Platform === "android") {
    return Response.redirect(
      `com.prtask.app://auth?session=${encodeURIComponent(SessionId)}&email=${encodeURIComponent(Email)}`, 302,
    );
  }

  if (ExternalRedirect && ALLOWED_REDIRECTS.some((R) => ExternalRedirect.startsWith(R))) {
    const Sep = ExternalRedirect.includes("?") ? "&" : "?";
    return new Response(null, {
      status: 302,
      headers: {
        Location: `${ExternalRedirect}${Sep}session=${encodeURIComponent(SessionId)}&email=${encodeURIComponent(Email)}`,
        "Set-Cookie": `session=${SessionId}; Path=/; Domain=.prtask.com; HttpOnly; Secure; SameSite=None; Max-Age=${SESSION_TTL}`,
      },
    });
  }

  return new Response(null, {
    status: 302,
    headers: {
      Location: "https://prtask.com/en/Dashboard",
      "Set-Cookie": `session=${SessionId}; Path=/; Domain=.prtask.com; HttpOnly; Secure; SameSite=None; Max-Age=${SESSION_TTL}`,
    },
  });
}

async function HandleGitHubCallback(
  Req: Request, Env: Env, Url: URL,
): Promise<Response> {
  const Code = Url.searchParams.get("code");
  const StateParam = Url.searchParams.get("state") ?? "";

  if (!Code) return Response.redirect("https://prtask.com/en/Login?error=no_code", 302);

  let Platform = "";
  let ExternalRedirect = "";
  try {
    const Parsed = JSON.parse(atob(StateParam));
    Platform = Parsed.Platform ?? "";
    ExternalRedirect = Parsed.Redirect ?? "";
  } catch { /* ignore */ }

  const Config = OAuthConfigs.github;
  const TokenRes = await fetch(Config.TokenUrl, {
    method: "POST",
    headers: { "Content-Type": "application/json", Accept: "application/json" },
    body: JSON.stringify({
      client_id: Env[Config.ClientIdKey],
      client_secret: Env[Config.ClientSecretKey],
      code: Code,
    }),
  });

  const TokenData = (await TokenRes.json()) as { access_token?: string };
  if (!TokenData.access_token) {
    return Response.redirect("https://prtask.com/en/Login?error=auth_failed", 302);
  }

  const UserRes = await fetch("https://api.github.com/user", {
    headers: { Authorization: `Bearer ${TokenData.access_token}`, "User-Agent": "PrTask" },
  });
  const User = (await UserRes.json()) as { email?: string; login: string };

  let Email = User.email ?? "";
  if (!Email) {
    const EmailsRes = await fetch("https://api.github.com/user/emails", {
      headers: { Authorization: `Bearer ${TokenData.access_token}`, "User-Agent": "PrTask" },
    });
    const Emails = (await EmailsRes.json()) as { email: string; primary: boolean }[];
    const Primary = Emails.find((E) => E.primary);
    Email = Primary?.email ?? Emails[0]?.email ?? "";
  }

  if (!Email) {
    return Response.redirect("https://prtask.com/en/Login?error=no_email", 302);
  }

  const Existing = await ReadSession(Env, Email);
  const SessionId = Existing?.Data.SessionId ?? crypto.randomUUID();
  const SessionData: SessionData = Existing?.Data ?? {
    Email,
    SessionId,
    Providers: {},
  };
  SessionData.Providers.GitHub = { AccessToken: TokenData.access_token };

  await WriteSession(Env, Email, SessionData, Existing?.Sha);

  if (Platform === "android") {
    return Response.redirect(
      `com.prtask.app://auth?session=${encodeURIComponent(SessionId)}&email=${encodeURIComponent(Email)}`, 302,
    );
  }

  if (ExternalRedirect && ALLOWED_REDIRECTS.some((R) => ExternalRedirect.startsWith(R))) {
    const Sep = ExternalRedirect.includes("?") ? "&" : "?";
    return new Response(null, {
      status: 302,
      headers: {
        Location: `${ExternalRedirect}${Sep}session=${encodeURIComponent(SessionId)}&email=${encodeURIComponent(Email)}`,
        "Set-Cookie": `session=${SessionId}; Path=/; Domain=.prtask.com; HttpOnly; Secure; SameSite=None; Max-Age=${SESSION_TTL}`,
      },
    });
  }

  return new Response(null, {
    status: 302,
    headers: {
      Location: "https://prtask.com/en/Dashboard",
      "Set-Cookie": `session=${SessionId}; Path=/; Domain=.prtask.com; HttpOnly; Secure; SameSite=None; Max-Age=${SESSION_TTL}`,
    },
  });
}

async function HandleLogout(Req: Request, Env: Env): Promise<Response> {
  const SessionId = GetSessionId(Req);
  if (SessionId) {
    const Session = await FindSessionBySessionId(Env, SessionId);
    if (Session) {
      await DeleteSession(Env, Session.Data.Email);
    }
  }

  return new Response(null, {
    status: 302,
    headers: {
      Location: "https://prtask.com/en/",
      "Set-Cookie": "session=; Path=/; Domain=.prtask.com; HttpOnly; Secure; SameSite=None; Max-Age=0",
    },
  });
}

async function HandleWebSocket(Req: Request, Env: Env): Promise<Response> {
  if (!IsAllowedOrigin(Req.headers.get("Origin"))) {
    return new Response("Forbidden", { status: 403 });
  }

  const Upgrade = Req.headers.get("Upgrade");
  if (!Upgrade || Upgrade.toLowerCase() !== "websocket") {
    return new Response("Expected WebSocket upgrade", { status: 426 });
  }

  let User: UserClaims | null = null;
  const SessionId = GetSessionId(Req);
  if (SessionId) {
    const Session = await FindSessionBySessionId(Env, SessionId);
    if (Session) {
      User = {
        userId: Session.Data.Email,
        username: Session.Data.Email,
        email: Session.Data.Email,
        avatarUrl: "",
        role: "Developer",
        provider: Object.keys(Session.Data.Providers)[0] ?? "",
      };
    }
  }

  const Pair = new WebSocketPair();
  const [Client, Server] = Object.values(Pair);

  Server.accept();
  registerClient(Server, User);

  if (User) {
    Server.send(JSON.stringify({ type: "session", data: User }));
  }

  Server.addEventListener("message", async (Evt) => {
    const Raw = typeof Evt.data === "string"
      ? Evt.data
      : new TextDecoder().decode(Evt.data as ArrayBuffer);
    await handleWsMessage(Server, Raw, Env);
  });

  Server.addEventListener("close", () => {
    unregisterClient(Server);
  });

  Server.addEventListener("error", () => {
    unregisterClient(Server);
  });

  return new Response(null, {
    status: 101,
    webSocket: Client,
    headers: { "Sec-WebSocket-Protocol": "prtask-db" },
  });
}

export default {
  async fetch(Req: Request, Env: Env): Promise<Response> {
    const Url = new URL(Req.url);
    const Path = Url.pathname;
    const Cors = CorsHeaders(Req);

    if (Req.method === "OPTIONS") {
      return new Response(null, { status: 204, headers: Cors });
    }

    if (Path === "/Api/Wss" || Path === "/Api/Ws") {
      return HandleWebSocket(Req, Env);
    }

    if (Path === "/Api/Auth/Google") return HandleOAuthStart(Req, Env, Url, "google");
    if (Path === "/Api/Auth/GitHub") return HandleOAuthStart(Req, Env, Url, "github");
    if (Path === "/Api/Auth/Azure") return HandleOAuthStart(Req, Env, Url, "azure");
    if (Path === "/Api/Auth/Okta") return HandleOAuthStart(Req, Env, Url, "okta");

    if (Path === "/Api/Auth/Callback/Google") return HandleOAuthCallback(Req, Env, Url, "google");
    if (Path === "/Api/Auth/Callback") return HandleGitHubCallback(Req, Env, Url);
    if (Path === "/Api/Auth/Callback/Azure") return HandleOAuthCallback(Req, Env, Url, "azure");
    if (Path === "/Api/Auth/Callback/Okta") return HandleOAuthCallback(Req, Env, Url, "okta");

    if (Path === "/Api/Auth/Logout") return HandleLogout(Req, Env);

    return HandleStaticProxy(Req, Env, Url);
  },
};

const GITHUB_PAGES_ORIGIN = "https://cruzlauroiii.github.io";

async function HandleStaticProxy(
  Req: Request, Env: Env, Url: URL,
): Promise<Response> {
  const UpstreamPath = `/prtask.com${Url.pathname}${Url.search}`;
  const UpstreamUrl = `${GITHUB_PAGES_ORIGIN}${UpstreamPath}`;

  const UpstreamRes = await fetch(UpstreamUrl, {
    headers: {
      "User-Agent": "PrTask-Proxy",
      Accept: Req.headers.get("Accept") ?? "*/*",
      "Accept-Encoding": Req.headers.get("Accept-Encoding") ?? "",
    },
    redirect: "follow",
  });

  const ResponseHeaders = new Headers(UpstreamRes.headers);
  ResponseHeaders.set("Cache-Control", "public, max-age=86400, s-maxage=2592000");
  ResponseHeaders.delete("x-served-by");
  ResponseHeaders.delete("x-cache");
  ResponseHeaders.delete("x-cache-hits");
  ResponseHeaders.delete("x-timer");
  ResponseHeaders.delete("x-fastly-request-id");
  ResponseHeaders.delete("x-github-request-id");
  ResponseHeaders.delete("via");

  return new Response(UpstreamRes.body, {
    status: UpstreamRes.status,
    headers: ResponseHeaders,
  });
}
