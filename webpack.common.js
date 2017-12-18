const path = require('path');
const cleanWebpackPlugin = require('clean-webpack-plugin');
const htmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
    entry:{
        main:'./src/main.js'
    },
    plugin:[
        new cleanWebpackPlugin(['dist']),
        new htmlWebpackPlugin({
            title:'RRRSWQL'
        })
    ],
    output:{
        filename:'[name].bundle.js',
        path : path.resolve(__dirname,'dist')
    }
};