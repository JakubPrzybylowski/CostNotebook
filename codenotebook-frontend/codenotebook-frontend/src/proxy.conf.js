const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
    ],
    target: "http://localhost:39698",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
