const PROXY_CONFIG = [
  {
    context: '/v1',
    target: "https://localhost:8080",
    secure: false,
    changeOrigin: false,
    pathRewrite: {
      "^/": ""
    }
  }
];
module.exports = PROXY_CONFIG;
