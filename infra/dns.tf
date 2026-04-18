data "cloudflare_zone" "prtask" {
  zone_id = var.cloudflare_zone_id
}

resource "cloudflare_record" "root" {
  zone_id = var.cloudflare_zone_id
  name    = "@"
  content = cloudflare_pages_project.prtask.subdomain
  type    = "CNAME"
  proxied = true
}

resource "cloudflare_record" "www" {
  zone_id = var.cloudflare_zone_id
  name    = "www"
  content = cloudflare_pages_project.prtask.subdomain
  type    = "CNAME"
  proxied = true
}

resource "cloudflare_record" "yandex_verification" {
  zone_id = var.cloudflare_zone_id
  name    = "@"
  content = "yandex-verification: f7c6ece28393ab0c"
  type    = "TXT"
}
