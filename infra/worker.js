export default {
  async fetch(request, env) {
    const url = new URL(request.url);
    if (url.pathname.startsWith("/api/")) {
      return handleApi(request, env, url);
    }
    return new Response("Not Found", { status: 404 });
  }
};

async function handleApi(request, env, url) {
  const path = url.pathname;
  const headers = { "Content-Type": "application/json", "Access-Control-Allow-Origin": "https://prtask.com" };

  if (path === "/api/tasks" && request.method === "GET") {
    const results = await env.DB.prepare("SELECT * FROM tasks WHERE status = 'Open' ORDER BY created_at DESC").all();
    return new Response(JSON.stringify(results.results), { headers });
  }

  if (path === "/api/tasks" && request.method === "POST") {
    const session = await getSession(request, env);
    if (!session) {
      return new Response("Unauthorized", { status: 401 });
    }
    const body = await request.json();
    const id = crypto.randomUUID();
    await env.DB.prepare("INSERT INTO tasks (id, client_id, title, description, repo_url, complexity, bounty_amount_cents, status, created_at) VALUES (?, ?, ?, ?, ?, ?, ?, 'Open', datetime('now'))").bind(id, session.userId, body.title, body.description, body.repoUrl || "", body.complexity || "Medium", body.bountyAmountCents || 10000).run();
    return new Response(JSON.stringify({ id: id }), { status: 201, headers });
  }

  if (path.match(/^\/api\/tasks\/[^/]+$/) && request.method === "PUT") {
    const session = await getSession(request, env);
    if (!session) {
      return new Response("Unauthorized", { status: 401 });
    }
    const taskId = path.split("/").pop();
    const body = await request.json();
    await env.DB.prepare("UPDATE tasks SET title = ?, description = ?, complexity = ?, bounty_amount_cents = ? WHERE id = ?").bind(body.title, body.description, body.complexity || "Medium", body.bountyAmountCents || 10000, taskId).run();
    return new Response(JSON.stringify({ ok: true }), { headers });
  }

  if (path.match(/^\/api\/tasks\/[^/]+$/) && request.method === "DELETE") {
    const session = await getSession(request, env);
    if (!session) {
      return new Response("Unauthorized", { status: 401 });
    }
    const taskId = path.split("/").pop();
    await env.DB.prepare("DELETE FROM tasks WHERE id = ?").bind(taskId).run();
    return new Response(JSON.stringify({ ok: true }), { headers });
  }

  if (path.match(/^\/api\/tasks\/[^/]+$/) && request.method === "GET") {
    const taskId = path.split("/").pop();
    const result = await env.DB.prepare("SELECT * FROM tasks WHERE id = ?").bind(taskId).first();
    if (!result) {
      return new Response(JSON.stringify({ error: "not_found" }), { status: 404, headers });
    }
    return new Response(JSON.stringify(result), { headers });
  }

  if (path.match(/^\/api\/tasks\/[^/]+\/prs$/) && request.method === "GET") {
    const taskId = path.split("/")[3];
    const results = await env.DB.prepare("SELECT * FROM pull_requests WHERE task_id = ? ORDER BY created_at DESC").bind(taskId).all();
    return new Response(JSON.stringify(results.results), { headers });
  }

  if (path === "/api/leaderboard" && request.method === "GET") {
    const count = url.searchParams.get("Count") || "100";
    const results = await env.DB.prepare("SELECT * FROM leaderboard ORDER BY total_xp DESC LIMIT ?").bind(parseInt(count)).all();
    return new Response(JSON.stringify(results.results), { headers });
  }

  if (path === "/api/auth/me" && request.method === "GET") {
    const session = await getSession(request, env);
    if (!session) {
      return new Response("Unauthorized", { status: 401 });
    }
    return new Response(JSON.stringify(session), { headers });
  }

  if (path === "/api/auth/google" && request.method === "GET") {
    return handleGoogleAuth(request, env, url);
  }

  if (path === "/api/auth/callback/google" && request.method === "GET") {
    return handleGoogleCallback(request, env, url);
  }

  if (path === "/api/auth/github" && request.method === "GET") {
    return handleGitHubAuth(request, env, url);
  }

  if (path === "/api/auth/callback/github" && request.method === "GET") {
    return handleGitHubCallback(request, env, url);
  }

  if (path === "/api/auth/azure" && request.method === "GET") {
    return handleAzureAuth(request, env, url);
  }

  if (path === "/api/auth/callback/azure" && request.method === "GET") {
    return handleAzureCallback(request, env, url);
  }

  if (path === "/api/auth/okta" && request.method === "GET") {
    return handleOktaAuth(request, env, url);
  }

  if (path === "/api/auth/callback/okta" && request.method === "GET") {
    return handleOktaCallback(request, env, url);
  }

  if (path === "/api/auth/logout" && request.method === "POST") {
    return handleLogout(request, env);
  }

  if (path === "/api/payments/webhook" && request.method === "POST") {
    return new Response(JSON.stringify({ received: true }), { headers });
  }

  return new Response(JSON.stringify({ error: "not_found" }), { status: 404, headers });
}

async function handleGoogleAuth(request, env, url) {
  const auto = url.searchParams.get("auto") === "true";
  const platform = url.searchParams.get("platform") || "";
  const verifier = generateCodeVerifier();
  const challenge = await generateCodeChallenge(verifier);
  const state = crypto.randomUUID();
  await env.SESSIONS.put("pkce_" + state, verifier, { expirationTtl: 600 });
  if (platform === "android") {
    await env.SESSIONS.put("platform_" + state, "android", { expirationTtl: 600 });
  }
  const redirectUri = "https://prtask.com/api/auth/callback/google";
  const params = new URLSearchParams({
    client_id: env.GOOGLE_CLIENT_ID,
    redirect_uri: redirectUri,
    response_type: "code",
    scope: "openid email profile",
    code_challenge: challenge,
    code_challenge_method: "S256",
    state: state
  });
  if (auto) {
    params.set("prompt", "none");
  }
  return Response.redirect("https://accounts.google.com/o/oauth2/v2/auth?" + params.toString(), 302);
}

async function handleGoogleCallback(request, env, url) {
  const error = url.searchParams.get("error");
  if (error) {
    return Response.redirect("https://prtask.com/login?auto_failed=true", 302);
  }
  const code = url.searchParams.get("code");
  const state = url.searchParams.get("state");
  if (!code || !state) {
    return Response.redirect("https://prtask.com/login?error=no_code", 302);
  }
  const verifier = await env.SESSIONS.get("pkce_" + state);
  if (!verifier) {
    return Response.redirect("https://prtask.com/login?error=pkce_missing", 302);
  }
  await env.SESSIONS.delete("pkce_" + state);
  const tokenBody = new URLSearchParams({
    grant_type: "authorization_code",
    code: code,
    redirect_uri: "https://prtask.com/api/auth/callback/google",
    client_id: env.GOOGLE_CLIENT_ID,
    client_secret: env.GOOGLE_CLIENT_SECRET,
    code_verifier: verifier
  });
  const tokenResponse = await fetch("https://oauth2.googleapis.com/token", {
    method: "POST",
    headers: { "Content-Type": "application/x-www-form-urlencoded" },
    body: tokenBody.toString()
  });
  if (!tokenResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=token_failed", 302);
  }
  const tokens = await tokenResponse.json();
  const accessToken = tokens.access_token;
  if (!accessToken) {
    return Response.redirect("https://prtask.com/login?error=no_access_token", 302);
  }
  const userResponse = await fetch("https://www.googleapis.com/oauth2/v3/userinfo", {
    headers: { Authorization: "Bearer " + accessToken }
  });
  if (!userResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=profile_failed", 302);
  }
  const userInfo = await userResponse.json();
  const sessionId = crypto.randomUUID();
  const sessionData = {
    userId: userInfo.sub,
    username: userInfo.name || userInfo.email,
    email: userInfo.email,
    avatarUrl: userInfo.picture,
    provider: "Google"
  };
  await env.SESSIONS.put(sessionId, JSON.stringify(sessionData), { expirationTtl: 2592000 });
  return finishAuth(sessionId, sessionData, state, env);
}

async function handleGitHubAuth(request, env, url) {
  const platform = url.searchParams.get("platform") || "";
  const state = crypto.randomUUID();
  if (platform === "android") {
    await env.SESSIONS.put("platform_" + state, "android", { expirationTtl: 600 });
  }
  const redirectUri = "https://prtask.com/api/auth/callback/github";
  const params = new URLSearchParams({
    client_id: env.GITHUB_CLIENT_ID,
    redirect_uri: redirectUri,
    scope: "read:user user:email",
    state: state
  });
  return Response.redirect("https://github.com/login/oauth/authorize?" + params.toString(), 302);
}

async function handleGitHubCallback(request, env, url) {
  const error = url.searchParams.get("error");
  if (error) {
    return Response.redirect("https://prtask.com/login?error=github_denied", 302);
  }
  const code = url.searchParams.get("code");
  const state = url.searchParams.get("state");
  if (!code || !state) {
    return Response.redirect("https://prtask.com/login?error=no_code", 302);
  }
  const tokenResponse = await fetch("https://github.com/login/oauth/access_token", {
    method: "POST",
    headers: { "Content-Type": "application/json", "Accept": "application/json" },
    body: JSON.stringify({
      client_id: env.GITHUB_CLIENT_ID,
      client_secret: env.GITHUB_CLIENT_SECRET,
      code: code,
      redirect_uri: "https://prtask.com/api/auth/callback/github"
    })
  });
  if (!tokenResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=token_failed", 302);
  }
  const tokens = await tokenResponse.json();
  const accessToken = tokens.access_token;
  if (!accessToken) {
    return Response.redirect("https://prtask.com/login?error=no_access_token", 302);
  }
  const userResponse = await fetch("https://api.github.com/user", {
    headers: { Authorization: "Bearer " + accessToken, "User-Agent": "PrTask" }
  });
  if (!userResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=profile_failed", 302);
  }
  const userInfo = await userResponse.json();
  const sessionId = crypto.randomUUID();
  const sessionData = {
    userId: "github_" + userInfo.id,
    username: userInfo.login,
    email: userInfo.email || "",
    avatarUrl: userInfo.avatar_url,
    provider: "GitHub"
  };
  await env.SESSIONS.put(sessionId, JSON.stringify(sessionData), { expirationTtl: 2592000 });
  return finishAuth(sessionId, sessionData, state, env);
}

async function handleAzureAuth(request, env, url) {
  const platform = url.searchParams.get("platform") || "";
  const verifier = generateCodeVerifier();
  const challenge = await generateCodeChallenge(verifier);
  const state = crypto.randomUUID();
  await env.SESSIONS.put("pkce_" + state, verifier, { expirationTtl: 600 });
  if (platform === "android") {
    await env.SESSIONS.put("platform_" + state, "android", { expirationTtl: 600 });
  }
  const redirectUri = "https://prtask.com/api/auth/callback/azure";
  const params = new URLSearchParams({
    client_id: env.AZURE_CLIENT_ID,
    redirect_uri: redirectUri,
    response_type: "code",
    scope: "openid email profile",
    code_challenge: challenge,
    code_challenge_method: "S256",
    state: state
  });
  return Response.redirect("https://login.microsoftonline.com/common/oauth2/v2.0/authorize?" + params.toString(), 302);
}

async function handleAzureCallback(request, env, url) {
  const error = url.searchParams.get("error");
  if (error) {
    return Response.redirect("https://prtask.com/login?error=azure_denied", 302);
  }
  const code = url.searchParams.get("code");
  const state = url.searchParams.get("state");
  if (!code || !state) {
    return Response.redirect("https://prtask.com/login?error=no_code", 302);
  }
  const verifier = await env.SESSIONS.get("pkce_" + state);
  if (!verifier) {
    return Response.redirect("https://prtask.com/login?error=pkce_missing", 302);
  }
  await env.SESSIONS.delete("pkce_" + state);
  const tokenBody = new URLSearchParams({
    grant_type: "authorization_code",
    code: code,
    redirect_uri: "https://prtask.com/api/auth/callback/azure",
    client_id: env.AZURE_CLIENT_ID,
    client_secret: env.AZURE_CLIENT_SECRET,
    code_verifier: verifier
  });
  const tokenResponse = await fetch("https://login.microsoftonline.com/common/oauth2/v2.0/token", {
    method: "POST",
    headers: { "Content-Type": "application/x-www-form-urlencoded" },
    body: tokenBody.toString()
  });
  if (!tokenResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=token_failed", 302);
  }
  const tokens = await tokenResponse.json();
  const accessToken = tokens.access_token;
  if (!accessToken) {
    return Response.redirect("https://prtask.com/login?error=no_access_token", 302);
  }
  const userResponse = await fetch("https://graph.microsoft.com/v1.0/me", {
    headers: { Authorization: "Bearer " + accessToken }
  });
  if (!userResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=profile_failed", 302);
  }
  const userInfo = await userResponse.json();
  const sessionId = crypto.randomUUID();
  const sessionData = {
    userId: "azure_" + userInfo.id,
    username: userInfo.displayName || userInfo.mail,
    email: userInfo.mail || userInfo.userPrincipalName || "",
    avatarUrl: "",
    provider: "Azure"
  };
  await env.SESSIONS.put(sessionId, JSON.stringify(sessionData), { expirationTtl: 2592000 });
  return finishAuth(sessionId, sessionData, state, env);
}

async function handleOktaAuth(request, env, url) {
  const platform = url.searchParams.get("platform") || "";
  const verifier = generateCodeVerifier();
  const challenge = await generateCodeChallenge(verifier);
  const state = crypto.randomUUID();
  await env.SESSIONS.put("pkce_" + state, verifier, { expirationTtl: 600 });
  if (platform === "android") {
    await env.SESSIONS.put("platform_" + state, "android", { expirationTtl: 600 });
  }
  const redirectUri = "https://prtask.com/api/auth/callback/okta";
  const params = new URLSearchParams({
    client_id: env.OKTA_CLIENT_ID,
    redirect_uri: redirectUri,
    response_type: "code",
    scope: "openid email profile",
    code_challenge: challenge,
    code_challenge_method: "S256",
    state: state
  });
  return Response.redirect(env.OKTA_DOMAIN + "/oauth2/default/v1/authorize?" + params.toString(), 302);
}

async function handleOktaCallback(request, env, url) {
  const error = url.searchParams.get("error");
  if (error) {
    return Response.redirect("https://prtask.com/login?error=okta_denied", 302);
  }
  const code = url.searchParams.get("code");
  const state = url.searchParams.get("state");
  if (!code || !state) {
    return Response.redirect("https://prtask.com/login?error=no_code", 302);
  }
  const verifier = await env.SESSIONS.get("pkce_" + state);
  if (!verifier) {
    return Response.redirect("https://prtask.com/login?error=pkce_missing", 302);
  }
  await env.SESSIONS.delete("pkce_" + state);
  const tokenBody = new URLSearchParams({
    grant_type: "authorization_code",
    code: code,
    redirect_uri: "https://prtask.com/api/auth/callback/okta",
    client_id: env.OKTA_CLIENT_ID,
    client_secret: env.OKTA_CLIENT_SECRET,
    code_verifier: verifier
  });
  const tokenResponse = await fetch(env.OKTA_DOMAIN + "/oauth2/default/v1/token", {
    method: "POST",
    headers: { "Content-Type": "application/x-www-form-urlencoded" },
    body: tokenBody.toString()
  });
  if (!tokenResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=token_failed", 302);
  }
  const tokens = await tokenResponse.json();
  const accessToken = tokens.access_token;
  if (!accessToken) {
    return Response.redirect("https://prtask.com/login?error=no_access_token", 302);
  }
  const userResponse = await fetch(env.OKTA_DOMAIN + "/oauth2/default/v1/userinfo", {
    headers: { Authorization: "Bearer " + accessToken }
  });
  if (!userResponse.ok) {
    return Response.redirect("https://prtask.com/login?error=profile_failed", 302);
  }
  const userInfo = await userResponse.json();
  const sessionId = crypto.randomUUID();
  const sessionData = {
    userId: "okta_" + userInfo.sub,
    username: userInfo.name || userInfo.email,
    email: userInfo.email || "",
    avatarUrl: "",
    provider: "Okta"
  };
  await env.SESSIONS.put(sessionId, JSON.stringify(sessionData), { expirationTtl: 2592000 });
  return finishAuth(sessionId, sessionData, state, env);
}

async function finishAuth(sessionId, sessionData, state, env) {
  const platform = await env.SESSIONS.get("platform_" + state);
  if (platform) {
    await env.SESSIONS.delete("platform_" + state);
  }
  if (platform === "android") {
    const mobileParams = new URLSearchParams({
      session: sessionId,
      username: sessionData.username || ""
    });
    return Response.redirect("com.prtask.app://auth?" + mobileParams.toString(), 302);
  }
  const cookieHeaders = new Headers();
  cookieHeaders.set("Location", "https://prtask.com/dashboard");
  cookieHeaders.set("Set-Cookie", "session=" + sessionId + "; Path=/; HttpOnly; Secure; SameSite=Lax; Max-Age=2592000");
  return new Response(null, { status: 302, headers: cookieHeaders });
}

async function handleLogout(request, env) {
  const session = getSessionId(request);
  if (session) {
    await env.SESSIONS.delete(session);
  }
  const headers = new Headers();
  headers.set("Set-Cookie", "session=; Path=/; HttpOnly; Secure; SameSite=Lax; Max-Age=0");
  headers.set("Content-Type", "application/json");
  return new Response(JSON.stringify({ ok: true }), { headers });
}

function generateCodeVerifier() {
  const bytes = new Uint8Array(32);
  crypto.getRandomValues(bytes);
  return base64UrlEncode(bytes);
}

async function generateCodeChallenge(verifier) {
  const encoder = new TextEncoder();
  const data = encoder.encode(verifier);
  const hash = await crypto.subtle.digest("SHA-256", data);
  return base64UrlEncode(new Uint8Array(hash));
}

function base64UrlEncode(bytes) {
  let binary = "";
  for (const byte of bytes) {
    binary += String.fromCharCode(byte);
  }
  return btoa(binary).replace(/\+/g, "-").replace(/\//g, "_").replace(/=+$/, "");
}

async function getSession(request, env) {
  const sessionId = getSessionId(request);
  if (!sessionId) return null;
  const session = await env.SESSIONS.get(sessionId);
  return session ? JSON.parse(session) : null;
}

function getSessionId(request) {
  const cookie = request.headers.get("Cookie") || "";
  const match = cookie.match(/session=([^;]+)/);
  return match ? match[1] : null;
}
