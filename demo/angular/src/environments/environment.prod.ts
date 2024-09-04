import { Environment } from "@abp/ng.core";

const baseUrl = "http://localhost:4200";

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: "DemoApp",
    logoUrl: "",
  },
  oAuthConfig: {
    issuer: "https://localhost:44305",
    redirectUri: baseUrl,
    clientId: "DemoApp",
    responseType: "code",
    scope: "offline_access DemoApp",
    requireHttps: true,
  },
  apis: {
    default: {
      url: "https://localhost:44305",
      rootNamespace: "DemoApp",
    },
  },
} as Environment;
