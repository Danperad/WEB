const path = require("path");

module.exports = {
  devServer: {
    proxy: {
      '/vyatsu': {
        target: 'https://new.vyatsu.ru/',
        changeOrigin: true,
        pathRewrite: {
          '^/vyatsu': ''
        }
      },
      '^/api': {
        target: 'http://localhost:8888/',
        changeOrigin: true,
        pathRewrite: {
          '^/api': ''
        }
      }
    },
  },
  configureWebpack: {
    resolve: {
      symlinks: false,
      alias: {
        vue: path.resolve(`./node_modules/vue`),
      },
    },
  },
};
