'use strict';

var path = require('path');
var WebpackNotifierPlugin = require('webpack-notifier');
var BrowserSyncPlugin = require('browser-sync-webpack-plugin');

module.exports = {
    entry: ['./app/src/main.js', './app/src/main.scss'],
    output: {
        path: path.resolve(__dirname, './build'),
        filename: 'bundle.js'
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader'
                }
            },
            {
                test: /\.tpl.html/,
                use: 'raw-loader'
            },
            {
                test: /\.(scss)$/,
                use: [
                    {
                        loader: 'style-loader',
                    }, 
                    {
                        loader: 'css-loader',
                    }, 
                    {
                        loader: 'postcss-loader',
                        options: {
                            plugins: function () {
                                return [
                                    require('precss'),
                                    require('autoprefixer')
                                ];
                            }
                        }
                    }, {
                        loader: 'sass-loader'
                    }]
            }
        ]
    },
    devtool: 'inline-source-map',
    plugins: [new WebpackNotifierPlugin(), new BrowserSyncPlugin()]
};
